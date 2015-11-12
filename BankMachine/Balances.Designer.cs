namespace BankMachine
{
    partial class Balances
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node10");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node11");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node5", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            this.tview_balances = new System.Windows.Forms.TreeView();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_backHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tview_balances
            // 
            this.tview_balances.BackColor = System.Drawing.SystemColors.Menu;
            this.tview_balances.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tview_balances.Font = new System.Drawing.Font("DejaVu Sans Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tview_balances.Location = new System.Drawing.Point(12, 115);
            this.tview_balances.Name = "tview_balances";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node1";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Node2";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Node3";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Node4";
            treeNode5.Name = "Node0";
            treeNode5.Text = "Node0";
            treeNode6.Name = "Node6";
            treeNode6.Text = "Node6";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Node7";
            treeNode8.Name = "Node8";
            treeNode8.Text = "Node8";
            treeNode9.Name = "Node9";
            treeNode9.Text = "Node9";
            treeNode10.Name = "Node10";
            treeNode10.Text = "Node10";
            treeNode11.Name = "Node11";
            treeNode11.Text = "Node11";
            treeNode12.Name = "Node5";
            treeNode12.Text = "Node5";
            this.tview_balances.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode12});
            this.tview_balances.Size = new System.Drawing.Size(560, 350);
            this.tview_balances.TabIndex = 0;
            this.tview_balances.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(2, 37);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(581, 55);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Account balances";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_print
            // 
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(307, 471);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(235, 68);
            this.btn_print.TabIndex = 7;
            this.btn_print.Text = "Print current view";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_backHome
            // 
            this.btn_backHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backHome.Location = new System.Drawing.Point(-1, 517);
            this.btn_backHome.Name = "btn_backHome";
            this.btn_backHome.Size = new System.Drawing.Size(112, 45);
            this.btn_backHome.TabIndex = 15;
            this.btn_backHome.Text = "Back to home";
            this.btn_backHome.UseVisualStyleBackColor = true;
            this.btn_backHome.Click += new System.EventHandler(this.btn_backHome_Click);
            // 
            // Balances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.btn_backHome);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.tview_balances);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Balances";
            this.ShowIcon = false;
            this.Text = "Bank Machine";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tview_balances;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_backHome;
    }
}