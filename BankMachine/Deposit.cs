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
    public partial class Deposit : Form
    {


        public Person person = null;
        private List<DepositObject> cheques = new List<DepositObject>();

        public Deposit()
        {
            InitializeComponent();
        }

        public void initWith(Person p)
        {
            person = p;
            init();
        }

        public void init()
        {
            lst_accountsTo.Items.Clear();
            foreach (Account a in person.Accounts)
            {
                lst_accountsTo.Items.Add(a.Type.ToString());
            }

            trans_inputCheques();
            this.Show();

            cheques.Clear();
            while (cheques.Count == 0)
            {
                cheques = simulateChequeInput();

                lbl_dir.ForeColor = Color.Red;
                lbl_dir.Text = "Error - cheques or cash not recognized, please try again or speak to a teller.";
            }
            trans_confirmDeposit();
        }

        private void trans_g(bool b)
        {
            pnl_inputObjs.Visible = b;
            pnl_confirmDeposit.Visible = !b;
            btn_backHome.Visible = b; 
        }

        private void trans_inputCheques()
        {
            trans_g(true);
            lbl_title.Text = "Insert cheques or cash into the slot";
            lbl_title.TextAlign = ContentAlignment.MiddleCenter;
            lbl_dir.Text = "Insert cash and cheques face up into the slot as show below. Insert all cash and cheques to be desposited at once.";
            lbl_dir.ForeColor = Color.Black;
            lst_input.Items.Clear();
            checkConfirmEnabled();
            //cheques = simulateChequeInput();
        }

        private void trans_confirmDeposit()
        {
            trans_g(false);
            lbl_title.Text = "You are about to deposit:";
            lbl_title.TextAlign = ContentAlignment.MiddleLeft;
            lst_input.Items.Clear();
            foreach (DepositObject o in cheques)
            {
                lst_input.Items.Add(o.ToString());
            }
            checkConfirmEnabled();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkConfirmEnabled();
        }

        private void checkConfirmEnabled()
        {
            if (lst_accountsTo.SelectedIndex == -1)
            {
                btn_confirm.Enabled = false;
            }
            else
            {
                btn_confirm.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.mainMenu.init();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //label1.Show();
            /*lst_accountsTo.Show();
            button1.Show();
            btn_confirm.Show();
            chk_receipt.Show();


            lbl_title.Hide();
            lbl_dir.Hide();
            button3.Hide();
            pic_cash.Hide();
            pic_cheque.Hide();*/
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //label1.Show();
            /*lst_accountsTo.Show();
            button1.Show();
            btn_confirm.Show();
            chk_receipt.Show();
            lst_input.Show();

            lbl_title.Hide();
            lbl_dir.Hide();
            button3.Hide();
            pic_cash.Hide();
            pic_cheque.Hide();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.mainMenu.init();
        }

        public List<DepositObject> simulateChequeInput()
        {
            List<DepositObject> o = new List<DepositObject>();

            //MessageBox.Show("x","caption",MessageBoxButtons.)
            string userInput = "";
            float[] validCashVals = { 5, 10, 20, 50, 100 };
            const string title = "Simulation of inputing cheques and cash";
            const string prompt =
@"This is a simulation of inputing cheques and cash. 
 Press OK to enter more values. Press Cancel
 to proceed with already inputted values.
 Invalid values are ignored. 
Enter cheques in the format 'CHEQUE;dollar value;name' 
   eg: CHEQUE;250.50;bob
Enter cash in the format 'CASH;dollar value' 
   eg: CASH;50. 
   The amount must be 5,10,20,50,or 100.";
            DialogResult r;
            MessageBox.Show(prompt, title);

            while ((r = Util.InputBox(title, "Input a cheque or cash value", ref userInput)) == DialogResult.OK)
            {
                try
                {
                    string[] parts = userInput.Split(';');
                    switch (parts[0])
                    {
                        case "CASH":
                            float val = float.Parse(parts[1]);
                            if (!validCashVals.Contains(val))
                            { continue; }
                            o.Add(new DepositObject(val, "Cash", null));
                            break;

                        case "CHEQUE":
                            o.Add(new DepositObject(float.Parse(parts[1]), "Cheque", parts[2]));
                            break;

                        default: continue;
                    }
                }
                catch (IndexOutOfRangeException) { }
                catch (FormatException) { }
            }

            return o;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (lst_accountsTo.SelectedIndex != -1)
            {
                person.depositMany(cheques, lst_accountsTo.SelectedIndex);
                if (this.chk_receipt.Checked)
                {
                    MessageBox.Show(person.LastReceipt, "Simulation of printing receipt");
                }
                this.Hide();
                Program.mainMenu.init();
            }
        }

        private void Deposit_Load(object sender, EventArgs e)
        {

        }
    }
}


