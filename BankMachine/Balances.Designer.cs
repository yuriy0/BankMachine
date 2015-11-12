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
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode37,
            treeNode38,
            treeNode39,
            treeNode40});
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Node10");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Node11");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Node5", new System.Windows.Forms.TreeNode[] {
            treeNode42,
            treeNode43,
            treeNode44,
            treeNode45,
            treeNode46,
            treeNode47});
            this.tview_balances = new System.Windows.Forms.TreeView();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_backHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tview_balances
            // 
            this.tview_balances.Font = new System.Drawing.Font("DejaVu Sans Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tview_balances.Location = new System.Drawing.Point(51, 115);
            this.tview_balances.Name = "tview_balances";
            treeNode37.Name = "Node1";
            treeNode37.Text = "Node1";
            treeNode38.Name = "Node2";
            treeNode38.Text = "Node2";
            treeNode39.Name = "Node3";
            treeNode39.Text = "Node3";
            treeNode40.Name = "Node4";
            treeNode40.Text = "Node4";
            treeNode41.Name = "Node0";
            treeNode41.Text = "Node0";
            treeNode42.Name = "Node6";
            treeNode42.Text = "Node6";
            treeNode43.Name = "Node7";
            treeNode43.Text = "Node7";
            treeNode44.Name = "Node8";
            treeNode44.Text = "Node8";
            treeNode45.Name = "Node9";
            treeNode45.Text = "Node9";
            treeNode46.Name = "Node10";
            treeNode46.Text = "Node10";
            treeNode47.Name = "Node11";
            treeNode47.Text = "Node11";
            treeNode48.Name = "Node5";
            treeNode48.Text = "Node5";
            this.tview_balances.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode41,
            treeNode48});
            this.tview_balances.Size = new System.Drawing.Size(491, 350);
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