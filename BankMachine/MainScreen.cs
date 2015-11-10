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
        public String pinAttempt; 

        public MainScreen()
        {
            InitializeComponent();
            this.mainScreen_keypad.AllowDot = false; 
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
                var r = Util.InputBox("Simulating swiping/inserting card", "Enter a card/account number", ref pOut);
                
                trans_loggedIn();
            }
        }

        private void trans_loggedIn()
        {
            this.Hide();
            Program.mainMenu.Show();
        }

        private void trans_enterAccntNum()
        {
            // Position the account number box in the middle and show the number pad
            this.main_accnt_num.Location = new System.Drawing.Point(208, 185);
            this.main_landing.Visible = false;
            this.main_enter_accnt.Visible = true;
            this.pinAttempt = "";
            this.whosTryingToLogIn = null;
        }

        private void trans_mainSplash()
        {
            this.main_accnt_num.Location = new System.Drawing.Point(208, 456);
            this.main_landing.Visible = true;
            this.main_enter_accnt.Visible = false;
            this.pinAttempt = "";
            this.mainLabel.Text = "Enter your account:";
            if (whosTryingToLogIn != null)
            {
                main_accnt_num.Text = "";
            }
            this.whosTryingToLogIn = null;
        }

        private void main_accnt_num_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.main_landing.Visible) { trans_enterAccntNum(); }
        }

        private void delFromEnd (ref String s)
        {
            if (s.Length != 0) { s = s.Remove(s.Length - 1); }
        }

        private void accn_num_keypad_CharEntered(object sender, char digit)
        {
            if (digit == ((char)8))
            {

                string v = this.main_accnt_num.Text;
                delFromEnd(ref v);
                this.main_accnt_num.Text = v;

                if (whosTryingToLogIn != null)
                {
                    delFromEnd(ref (this.pinAttempt));
                } 
            } else
            {
                if (whosTryingToLogIn != null) {
                    this.main_accnt_num.Text += "*";
                    this.pinAttempt += digit; 
                }
                else
                {
                    this.main_accnt_num.Text += digit;
                }
            }
        }
        

        private bool tryLookupAccntNum (string str)
        {
            int i;
            // Try to parse input number
            if (!Int32.TryParse(main_accnt_num.Text, out i))
            {
                return false;
            }
            // Try to find that person
            whosTryingToLogIn = Program.db.lookupAccntNum(i);
            return (whosTryingToLogIn != null);
        }

        private void mainScreen_keypad_Submit(object sender, bool isOk)
        {
            if (isOk) // If OK was pressed 
            {
                if (whosTryingToLogIn == null) // Login not yet in progress
                {
                    if (tryLookupAccntNum(main_accnt_num.Text))
                    {
                        this.mainLabel.Text = "Enter your PIN:";
                        this.main_accnt_num.Text = "";
                    }
                    else 
                    {
                        this.mainLabel.Text = "Invalid account number";
                        return;
                    } 
                } else // Login in progress
                {
                    int left = Person.MaxPinAttempts - whosTryingToLogIn.NumPinAttempts;

                    if (left<=0)
                    {
                        this.mainLabel.Text = "Your PIN has been blocked due to too many incorrect guesses";
                        return;
                    }

                    bool loginSucceed = whosTryingToLogIn.guessPIN(pinAttempt);
                    if (loginSucceed) // Login succeeded
                    {
                        trans_loggedIn(); 
                    }
                    else
                    {
                        this.mainLabel.Text = string.Format("PIN incorrect. {0} attempt(s) left.", left-1);
                    }

                }
            } else
            {
                trans_mainSplash();
            }
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void welcomeLabel(object sender, EventArgs e)
        {

        }

    }
}
