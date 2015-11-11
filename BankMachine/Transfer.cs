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
           
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           


            




        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            




           
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
           



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
           

         
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            btn_confirm.Hide();
            label2.Hide();
            label1.Show(); label3.Show(); label4.Show();
            txt_amount.Show();
            
            
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
