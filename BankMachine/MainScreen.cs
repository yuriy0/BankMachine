using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankMachine; 

namespace BankMachine
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
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
                this.Hide();
                Program.mainMenu.Show();
                //this.Visible = false;
                //this.Enabled = false; 
                //Program.mainMenu.Visible = true;
            }
        }

        private void main_accnt_num_MouseClick(object sender, MouseEventArgs e)
        {

            if (this.main_landing.Visible)
            {
                // Position the account number box in the middle and show the number pad
                this.main_accnt_num.Location = new System.Drawing.Point(208, 204);
                this.main_landing.Visible = false;
                this.main_enter_accnt.Visible = true;
            }
            else
            {
                // Position the account number box in the at the bottom and
                // show the default landing screen
                this.main_accnt_num.Location = new System.Drawing.Point(208, 456);
                this.main_landing.Visible = true;
                this.main_enter_accnt.Visible = false;
            }
        }
    }
}
