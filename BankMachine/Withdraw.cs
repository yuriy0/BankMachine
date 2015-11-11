using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace BankMachine
{
    public partial class Withdraw : Form
    {
        public Person user; 

        public Withdraw()
        {
            InitializeComponent();
            this.keyPad1.outputTextBox = this.txt_total;
            this.keyPad1.AllowDot = false;
            this.keyPad1.CancelText = "CL";
        }

        private int _Total; 
        public int Total
        {
            get
            {
                return _Total; 
            }
            set
            {
                _Total = value;
                this.txt_total.Text = _Total.ToString();
            }
        }

        public void initWith(Person p)
        {
            user = p;
            this.init();
        }

        public void init()
        {
            this.lstb_accounts.Items.Clear();
            foreach (Account a in user.Accounts)
            {
                this.lstb_accounts.Items.Add(a.Type.ToString());
            }
            if (lstb_accounts.SelectedIndex == -1)
            {
                this.btn_confirm.Enabled = false;
            }
            this.Show();
        }

        private void addToTotal(int delta)
        {
        }

        private void btn_add200_Click(object sender, EventArgs e)
        { Total += 200; }

        private void btn_add100_Click(object sender, EventArgs e)
        { Total += 100; }

        private void btn_add50_Click(object sender, EventArgs e)
        { Total += 50; }

        private void btn_add20_Click(object sender, EventArgs e)
        { Total += 20; }

        private void btn_backHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.mainMenu.init();
        }


        private void btn_toggleNumpad_Click(object sender, EventArgs e)
        {
            if (this.panel_bottom.Visible)
            {
                trans_showKeypad();
            } else 
            {
                trans_hideKeypad();
            }
        }

        private void trans_showKeypad()
        {
            this.panel_bottom.Visible = false;
            this.keyPad1.Visible = true;
            this.btn_toggleNumpad.Text = "Return...";
        }

        private void trans_hideKeypad()
        {
            this.panel_bottom.Visible = true;
            this.keyPad1.Visible = false;
            this.btn_toggleNumpad.Text = "Other...";
        }

        private void keyPad1_Submit(object sender, bool isOk)
        {
            if (isOk)
            {
                trans_hideKeypad();
            } else 
            {
                Total = 0; 
            }
        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {
            if (this.txt_total.Text == "") { this.txt_total.Text = "0";  }
            _Total = Int32.Parse(this.txt_total.Text);
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (_Total > 0 && lstb_accounts.SelectedIndex != -1)
            {
                this.Hide();
                Program.withdrawConfirm.initWith(user, _Total, lstb_accounts.SelectedIndex);
            }
        }

        private void lstb_accounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstb_accounts.SelectedIndex != -1)
            {
                this.btn_confirm.Enabled = true;
            }
        }

    }
}
