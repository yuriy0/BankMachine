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
        private List<String> cheque = new List<string>();

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



            foreach (Account a in person.Accounts)
            {
                lst_accountsTo.Items.Add(a.Type.ToString());
            }
            //MessageBox.Show("This is a simulation of depositing a cheque and cash");
            //cheque.Add("Emaad Fazal &120");
            //cheque.Add("Emaad Fazal &150");
            //cheque.Add("Emaad Fazal &150");

            this.Show();
            MessageBox.Show(simulateChequeInput().Count.ToString());



        }






        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.mainMenu.init();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Show();
            lst_accountsTo.Show();
            button1.Show();
            button2.Show();
            checkBox1.Show();


            label2.Hide();
            label3.Hide();
            button3.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label1.Show();
            lst_accountsTo.Show();
            button1.Show();
            button2.Show();
            checkBox1.Show();
            lst_input.Show();

            label2.Hide();
            label3.Hide();
            button3.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Hide();
            lst_accountsTo.Hide();
            button1.Hide();
            button2.Hide();
            checkBox1.Hide();


            label2.Show();
            label3.Show();
            button3.Show();
            pictureBox1.Show();

            pictureBox2.Show();

        }

         //public interface HasValue

        public class DepositObject
        {
            public float value;
            public string type;
            public string meta; 
            public DepositObject(float v, string t, string m)
            {
                value = v; type = t; meta = m; 
            }
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
                            o.Add(new DepositObject(float.Parse(parts[1]), "Cash", null));
                            break;

                        case "CHEQUE":
                            float val = float.Parse(parts[1]);
                            if (!validCashVals.Contains(val))
                            { continue; }

                            //o.Add(new DepositObject(, "Cheque", parts[2]));
                            break;

                        default: continue;
                    }
                }
                catch (IndexOutOfRangeException) { }
                catch (FormatException) { }
            }

            return o;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

 for (int i = 0; i < cheque.Count; i++ )
            {
                String temp = cheque[i].Split('&')[1];
                lst_input.Items.Add(temp);
            }

for (int i = 0; i < cheque.Count; i++)
            {
                //person.Accounts[0].deposit((float)(listBox2.Items., "today"); ;
            }
        }
    }
}


