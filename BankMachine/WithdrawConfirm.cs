﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankMachine
{
    public partial class WithdrawConfirm : Form
    {

        public Person user;
        public int withdrawlAmount = 0;
        public int accountFrom = 0;
        private int n20 = 0, n50 = 0;
        private bool isErr; 

        public WithdrawConfirm()
        {
            InitializeComponent();
        }

        public void initWith (Person p, int amount, int accntFrom)
        {
            user = p;
            withdrawlAmount = amount;
            accountFrom = accntFrom;

            try 
            {
                bool evenBills = Util.countBills(withdrawlAmount, ref n20, ref n50);
                if (!evenBills)
                { throw new Exception("the machine can only dispense $20 and $50 bills");  }

                p.withdrawFrom(amount,accntFrom);
                this.lbl_msg.Text = String.Format("You are about to withdraw ${0}.00 from your {1} account.",
                                            withdrawlAmount,
                                            user.Accounts[accntFrom].Type);
                isErr = false; 
            } catch (Exception e) 
            {
                this.lbl_msg.Text = String.Format("You are unable to withdraw ${0}.00 from your {1} account because {2}.",
                                            withdrawlAmount,
                                            user.Accounts[accntFrom].Type,
                                            e.Message);

                isErr = true; 
            }

            this.btn_confirm.Enabled = !isErr;
            this.chk_receipt.Enabled = !isErr;
            this.lbl_err.Visible = isErr;

            this.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();

            // undo the withdrawl
            if (!isErr)
            {
                user.Accounts[accountFrom].Amount += withdrawlAmount;
                user.Accounts[accountFrom].History.RemoveAt(user.Accounts[accountFrom].History.Count - 1);
            }

            Program.withdrawMenu.init();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (this.chk_receipt.Checked)
            {
                MessageBox.Show(user.LastReceipt, "Simulation of printing receipt");
            }
            this.Hide();
            Program.mainMenu.init();
        }
    }
}
