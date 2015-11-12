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
    public partial class Transfer : Form
    {
        public static int amount;
        public Person person = null;

        public Transfer()
        {
            InitializeComponent();
        }

        public void initWith(Person p)
        {
            person = p;
            init();
        }

        public void init ()
        {
            this.keypad_transfer.Visible = false;
            this.Show();
            this.keypad_transfer.outputTextBox = this.txt_amount;
            this.keypad_transfer.CancelText = "CL";
            this.keypad_transfer.AllowDot = true;
            this.txt_amount.Text = "Press to enter amount";

            lst_transferFrom.Items.Clear();
            lst_transferTo.Items.Clear();

            foreach (Account a in person.Accounts)
            {
                lst_transferFrom.Items.Add(a.Type);
                lst_transferTo.Items.Add(a.Type);
            }
            checkForSubmit();
        }

        private void trans_enterAmount()
        {
            this.pnl_accounts.Visible = false;
            this.keypad_transfer.Visible = true;
            this.txt_amount.Text = "0";
            //checkForSubmit();
        }

        private void trans_pickAccnts()
        {
            this.pnl_accounts.Visible = true;
            this.keypad_transfer.Visible = false;
        }


        private void button3_Click(object sender, EventArgs e)
        {
           
            /*btn_confirm.Hide();
            label2.Hide();
            label1.Show(); label3.Show(); label4.Show();
            txt_amount.Show();*/
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float r = 0;
            if (float.TryParse(txt_amount.Text,out r)) 
            {
                this.Hide();
                Program.transferConfirm.initWith(this.person, r, lst_transferFrom.SelectedIndex, lst_transferTo.SelectedIndex);
            }

        }


        private void lst_transferTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_transferTo.SelectedIndex != -1 &&
                lst_transferTo.SelectedIndex == lst_transferFrom.SelectedIndex)
            {
                lst_transferFrom.SelectedIndex = -1;
            }
            checkForSubmit();
        }


        // Check if the submit button should be enabled
        private void checkForSubmit()
        {
            decimal r = 0;

            if (lst_transferFrom.SelectedIndex != -1 &&
                lst_transferTo.SelectedIndex != -1 && 
                decimal.TryParse(txt_amount.Text,out r) && 
                r>0)
            { btn_confirm.Enabled = true; }
            else { btn_confirm.Enabled = false; }
        }

        private void lst_transferFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_transferFrom.SelectedIndex != -1 && 
                lst_transferFrom.SelectedIndex == lst_transferTo.SelectedIndex)
            {
                lst_transferTo.SelectedIndex = -1;
            }

            checkForSubmit();
        }

        private void txt_amount_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.pnl_accounts.Visible) { trans_enterAmount(); }
        }

        private void keypad_transfer_Submit(object sender, bool isOk)
        {
            if (isOk)
            {
                trans_pickAccnts();
                checkForSubmit();
            } else
            {
                this.txt_amount.Text = "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.mainMenu.init();
        }
    }
}
