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
    public partial class MainMenu : Form
    {
        public Person user; 

        public MainMenu()
        {
            InitializeComponent();
        }

        public void initWith (Person p) {
            if (p != null)
            {
                user = p;
                this.lbl_welcome.Text = String.Format("Welcome {0}", p.Name);
                this.Show();
            }
            else
            {
                throw new Exception("Got to main menu without actually logging in...");
            }
        }

        public void init()
        {
            this.Show();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.user = null;
            this.Hide();
            Program.mainScreen.init();
        }

        private void btn_withdrawls_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.withdrawMenu.initWith(user);
        }

        private void btn_balances_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.balances.initWith(user);
        }

        private void btn_transfer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.transfers.initWith(user);
        }
    }
}
