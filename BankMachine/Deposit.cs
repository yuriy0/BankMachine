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
        private List<String> cheque= new List<string>() ;
        
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
            
            this.Show();
            listBox1.Items.Add("Chequing");
            listBox1.Items.Add("Savings");
            MessageBox.Show("This is a simulation of depositing a cheque and cash");
            cheque.Add("Emaad Fazal &120" );
            cheque.Add("Emaad Fazal &150");
            cheque.Add("Emaad Fazal &150");
           
            



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
            listBox1.Show();
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
            listBox1.Show();
            button1.Show();
            button2.Show();
            checkBox1.Show();
            listBox2.Show();

            label2.Hide();
            label3.Hide();
            button3.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Hide();
            listBox1.Hide();
            button1.Hide();
            button2.Hide();
            checkBox1.Hide();


            label2.Show();
            label3.Show();
            button3.Show();
            pictureBox1.Show();
        
    }
}
            pictureBox2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

 for (int i = 0; i < cheque.Count; i++ )
            {
                String temp = cheque[i].Split('&')[1];
                listBox2.Items.Add(temp);
            }
for (int i = 0; i < cheque.Count; i++)
            {
                person.Accounts[0].deposit((float)(listBox2.Items., "today"); ;
            }
        }

