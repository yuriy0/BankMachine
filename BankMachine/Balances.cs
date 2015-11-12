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
    public partial class Balances : Form
    {
        public Person user;

        public Balances()
        {
            InitializeComponent();
        }

        public void initWith (Person p)
        {
            user = p;
            init();
        }

        public void init()
        {
            this.Show();
            var N = this.tview_balances.Nodes;
            N.Clear();
            foreach (Account a in user.Accounts)
            {
                TreeNode[] children = new TreeNode[a.History.Count];
                for (int i = 0; i < a.History.Count; i++)
                    { children[i] = new TreeNode(a.History[i].ToString()); }
                N.Add(new TreeNode(String.Format("{0,-15} ${1,-10}", a.Type, a.Amount.ToString("0.00")), children));
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btn_backHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.mainMenu.init();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            // 

            string strOut = String.Format("User: {0}\nAccount #{1}", user.Name, user.AccountNumber);
            TreeNode node = this.tview_balances.TopNode;
            do
            {
                strOut += "\n" + string.Join("", Enumerable.Repeat("  ", node.Level)) + node.Text;
            } while ((node = node.NextVisibleNode) != null);

            MessageBox.Show("This is a simulation of printing a paper receipt. The receipt is:\n\n"+strOut);

        }
    }
}
