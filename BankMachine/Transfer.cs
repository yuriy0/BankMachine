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
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            /*if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = true;
            }*/
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            /*if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox4.Checked = false;
                checkBox3.Checked = true;
            }



            else
            {
                checkBox1.Enabled = true;
            }*/




        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            /*if (checkBox3.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = true;
                checkBox4.Checked = false;

            }*/




           
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            /*if (checkBox4.Checked)
            {
                checkBox1.Checked = true;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }*/



        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            txt_amount.Text = txt_amount.Text + "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txt_amount.Text = txt_amount.Text + "2";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txt_amount.Text = txt_amount.Text + "3";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txt_amount.Text = txt_amount.Text + "4";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txt_amount.Text = txt_amount.Text + "5";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txt_amount.Text = txt_amount.Text + "6";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txt_amount.Text = txt_amount.Text + "7";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txt_amount.Text = txt_amount.Text + "8";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txt_amount.Text = txt_amount.Text + "9";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* if (checkBox1.Checked || checkBox2.Checked)
            {


                if (checkBox1.Checked)
                {
                    person.Accounts[0].transferTo(amount, person.Accounts[1], "TODAY");
                    Console.WriteLine( person.Accounts[0].Amount);
                }
                else if (checkBox2.Checked)
                {
                    person.Accounts[1].transferTo(amount, person.Accounts[0], "TODAY");


                }



                amount = Int32.Parse(txt_amount.Text.Trim().ToLower());
                //button3.Show();
                btn_confirm.Show();
                label2.Show();
                /*button10.Hide(); button11.Hide(); button12.Hide(); button13.Hide(); button14.Hide(); button15.Hide(); button16.Hide(); button17.Hide(); button18.Hide();
                label1.Hide(); label3.Hide(); label4.Hide();
                txt_amount.Hide();
                checkBox1.Hide(); checkBox2.Hide(); checkBox3.Hide(); checkBox4.Hide();
                button1.Hide(); button2.Hide();

            } **/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //button3.Hide();
            btn_confirm.Hide();
            label2.Hide();
           /* button10.Show(); button11.Show(); button12.Show(); button13.Show(); button14.Show(); button15.Show(); button16.Show(); button17.Show(); button18.Show(); */
            label1.Show(); label3.Show(); label4.Show();
            txt_amount.Show();
            //checkBox1.Show(); checkBox2.Show(); checkBox3.Show(); checkBox4.Show();
            //button1.Show(); button2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
