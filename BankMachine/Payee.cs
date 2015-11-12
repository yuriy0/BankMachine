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
    public partial class Payee : Form
    {

        public Person person = null;
        
        
        public Payee()
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
            this.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_backHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.mainMenu.init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Hide();
            list.Hide();
            btn_backHome.Hide();
            button1.Hide();


            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            textBox1.Show();
            button4.Show();
            button3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Show();
            list.Show();
            btn_backHome.Show();
            button1.Show();


            label2.Hide();
            label4.Hide();
            label5.Hide();
            textBox1.Hide();
            button4.Hide();
            button3.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            label7.Text = textBox1.Text;
            
            
            label6.Show();
            label8.Show();
            listBox1.Show();
            
            
            button5.Hide();
            label5.Hide();
            textBox1.Hide();
        }
    }
}
