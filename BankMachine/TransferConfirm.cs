using System;
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
    public partial class TransferConfirm : Form
    {

        public Person user;
        public float transferAmount = 0;
        public int accountFrom = 0;
        public int accountTo = 0;
        private bool isErr; 

        public TransferConfirm()
        {
            InitializeComponent();
        }

        public void initWith (Person p, float amount, int accntFrom, int accntTo)
        {
            user = p;
            transferAmount = amount;
            accountFrom = accntFrom;
            accountTo = accntTo;

            try 
            {
                p.transferBetween(amount, accntFrom, accntTo, "today");

                this.lbl_msg.Text = String.Format("You are about to transfer ${0}.00 from your {1} account to your {2} account.",
                                            transferAmount,
                                            user.Accounts[accntFrom].Type,
                                            user.Accounts[accntTo].Type);

                isErr = false;

            } catch (Exception e) 
            {
                this.lbl_msg.Text = String.Format("You are unable to transfer ${0}.00 from your {1} account to your {2} account because {3}.",
                                            transferAmount,
                                            user.Accounts[accntFrom].Type,
                                            user.Accounts[accntTo].Type,
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

            //Undo the transaciton
            if (!isErr)
            {
                user.Accounts[accountTo].Amount -= transferAmount;
                user.Accounts[accountFrom].Amount += transferAmount;
                user.Accounts[accountTo].History.RemoveAt(user.Accounts[accountTo].History.Count - 1);
                user.Accounts[accountFrom].History.RemoveAt(user.Accounts[accountFrom].History.Count - 1);
            }

            Program.transfers.init();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (this.chk_receipt.Checked)
            {
                MessageBox.Show(user.LastReceipt);
            }
            this.Hide();
            Program.mainMenu.init();
        }
    }
}
