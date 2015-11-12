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
    public partial class MainScreen : Form
    {

        public Person whosTryingToLogIn;

        public MainScreen()
        {
            InitializeComponent();
            this.mainScreen_keypad.AllowDot = false;
            this.mainScreen_keypad.outputTextBox = this.main_accnt_num;
            this.mainScreen_keypad.TextMode = true;
        }

        public void init()
        {
            this.Show();
            this.trans_mainSplash();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // 
        }

        private void MainScreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 's') // s for swipe 
            {
                string pOut = "";
                var r = Util.InputBox("Simulating the swiping/inserting of a card card.", "Enter a card/account number", ref pOut);

                if (try_login(pOut)) 
                {
                    MessageBox.Show("Swiping/inserting successful. Please proceed.");
                    trans_enterPin();
                }
                else
                {
                    // MessageBox.Show(String.Format("Swiping/inserting card '{0}' failed. Please try again.", pOut));
                    trans_mainSplash();
                    this.main_errorLabel.Text = "Card reading failed. Please try again.";
                    this.main_errorLabel.Visible = true;
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.S) // Handles this key press globally in the form
            {
                MainScreen_KeyPress(null, new KeyPressEventArgs('s'));
                return true;    // indicate that you handled this keystroke
            }
            else { return base.ProcessCmdKey(ref msg, keyData); }
        }

        private void try_enter_pin(String guess)
        {

            int left = Person.MaxPinAttempts - whosTryingToLogIn.NumPinAttempts;

            if (left <= 0)
            {
                this.mainLabel.Text = "Your PIN has been blocked due to too many incorrect guesses";
                return;
            }

            bool loginSucceed = whosTryingToLogIn.guessPIN(guess);
            if (loginSucceed) // Login succeeded
            {
                trans_loggedIn();
            }
            else
            {
                this.mainLabel.Text = string.Format("PIN incorrect. {0} attempt(s) left.", left - 1);
            }

        }

        private bool try_login(String acct)
        {
            bool r = try_lookup_accnt_num(acct);
            if (r)
            {
                this.mainLabel.Text = "Enter your PIN:";
                this.main_accnt_num.Text = "";
                this.main_accnt_num.PasswordChar = '*';
            }
            else
            {
                this.mainLabel.Text = "Invalid account number";
            }
            return r;
        }

        private void trans_loggedIn()
        {
            this.Hide();
            Program.mainMenu.initWith(whosTryingToLogIn);
        }

        private void trans_enterAccntNum()
        {
            // Position the account number box in the middle and show the number pad
            this.main_accnt_num.Location = new System.Drawing.Point(191, 185);
            this.main_landing.Visible = false;
            this.main_enter_accnt.Visible = true;
            this.main_errorLabel.Visible = false;
            //this.pinAttempt = "";
            this.whosTryingToLogIn = null;
        }

        private void trans_enterPin()
        {
            // Position the account number box in the middle and show the number pad
            this.main_accnt_num.Location = new System.Drawing.Point(191, 185);
            this.main_landing.Visible = false;
            this.main_enter_accnt.Visible = true;
            this.main_errorLabel.Visible = false;
            this.main_accnt_num.PasswordChar = '*';
        }

        private void trans_mainSplash()
        {
            this.main_accnt_num.Location = new System.Drawing.Point(191, 456);
            this.main_landing.Visible = true;
            this.main_enter_accnt.Visible = false;
            //this.main_errorLabel.Visible = false;
            //this.pinAttempt = "";
            this.mainLabel.Text = "Enter your account:";
            if (whosTryingToLogIn != null)
            {
                main_accnt_num.Text = "";
                this.main_accnt_num.PasswordChar = (char)0;
            } 
            this.whosTryingToLogIn = null;
        }

        private void main_accnt_num_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.main_landing.Visible) { trans_enterAccntNum(); }
        }

        private void accn_num_keypad_CharEntered(object sender, char digit)
        {
        }
        

        private bool try_lookup_accnt_num (string str)
        {
            // Try to find that person
            whosTryingToLogIn = Program.db.lookupAccntNum(str);
            return (whosTryingToLogIn != null);
        }

        private void mainScreen_keypad_Submit(object sender, bool isOk)
        {
            if (isOk) // If OK was pressed 
            {
                if (whosTryingToLogIn == null) // Login not yet in progress
                {
                    try_login(main_accnt_num.Text);
                } else // Login in progress
                {
                    try_enter_pin(main_accnt_num.Text);
                }
            } else
            {
                trans_mainSplash(); // Cancel was pressed, go back to splash screen
            }
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void welcomeLabel(object sender, EventArgs e)
        {

        }

        private void main_accnt_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            MainScreen_KeyPress(sender, e);
        }

        private void main_errorLabel_Click(object sender, EventArgs e)
        {

        }

    }
}
