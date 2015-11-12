namespace BankMachine
{
    partial class Deposit
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
            this.lst_accountsTo = new System.Windows.Forms.ListBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.chk_receipt = new System.Windows.Forms.CheckBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pic_cash = new System.Windows.Forms.PictureBox();
            this.pic_cheque = new System.Windows.Forms.PictureBox();
            this.lbl_dir = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pnl_inputObjs = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_depositTo = new System.Windows.Forms.Label();
            this.pnl_confirmDeposit = new System.Windows.Forms.Panel();
            this.lst_input = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cheque)).BeginInit();
            this.pnl_inputObjs.SuspendLayout();
            this.pnl_confirmDeposit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_accountsTo
            // 
            this.lst_accountsTo.BackColor = System.Drawing.SystemColors.Control;
            this.lst_accountsTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_accountsTo.FormattingEnabled = true;
            this.lst_accountsTo.ItemHeight = 25;
            this.lst_accountsTo.Location = new System.Drawing.Point(25, 296);
            this.lst_accountsTo.Margin = new System.Windows.Forms.Padding(2);
            this.lst_accountsTo.MultiColumn = true;
            this.lst_accountsTo.Name = "lst_accountsTo";
            this.lst_accountsTo.Size = new System.Drawing.Size(190, 104);
            this.lst_accountsTo.TabIndex = 1;
            this.lst_accountsTo.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(228, 389);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(299, 47);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel and return cheques/cash";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.Location = new System.Drawing.Point(335, 286);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(2);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(192, 52);
            this.btn_confirm.TabIndex = 3;
            this.btn_confirm.Text = "Confirm deposit";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // chk_receipt
            // 
            this.chk_receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_receipt.Location = new System.Drawing.Point(351, 342);
            this.chk_receipt.Margin = new System.Windows.Forms.Padding(2);
            this.chk_receipt.Name = "chk_receipt";
            this.chk_receipt.Size = new System.Drawing.Size(170, 33);
            this.chk_receipt.TabIndex = 4;
            this.chk_receipt.Text = "Print receipt";
            this.chk_receipt.UseVisualStyleBackColor = true;
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(11, 22);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(562, 66);
            this.lbl_title.TabIndex = 5;
            this.lbl_title.Text = "Insert cheques or cash into the slot";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_cash
            // 
            this.pic_cash.BackgroundImage = global::BankMachine.Properties.Resources.bill;
            this.pic_cash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_cash.Location = new System.Drawing.Point(124, 114);
            this.pic_cash.Margin = new System.Windows.Forms.Padding(2);
            this.pic_cash.Name = "pic_cash";
            this.pic_cash.Size = new System.Drawing.Size(252, 138);
            this.pic_cash.TabIndex = 6;
            this.pic_cash.TabStop = false;
            this.pic_cash.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pic_cheque
            // 
            this.pic_cheque.BackgroundImage = global::BankMachine.Properties.Resources.cheque;
            this.pic_cheque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_cheque.Location = new System.Drawing.Point(124, 281);
            this.pic_cheque.Margin = new System.Windows.Forms.Padding(2);
            this.pic_cheque.Name = "pic_cheque";
            this.pic_cheque.Size = new System.Drawing.Size(252, 138);
            this.pic_cheque.TabIndex = 7;
            this.pic_cheque.TabStop = false;
            this.pic_cheque.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lbl_dir
            // 
            this.lbl_dir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dir.Location = new System.Drawing.Point(5, 19);
            this.lbl_dir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dir.Name = "lbl_dir";
            this.lbl_dir.Size = new System.Drawing.Size(489, 125);
            this.lbl_dir.TabIndex = 8;
            this.lbl_dir.Text = "Insert cash and cheques face up into the slot as show below. Insert all cash and " +
    "cheques to be desposited at once.";
            this.lbl_dir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 521);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 40);
            this.button3.TabIndex = 10;
            this.button3.Text = "Back to home";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnl_inputObjs
            // 
            this.pnl_inputObjs.Controls.Add(this.panel1);
            this.pnl_inputObjs.Controls.Add(this.pic_cash);
            this.pnl_inputObjs.Controls.Add(this.panel2);
            this.pnl_inputObjs.Controls.Add(this.lbl_dir);
            this.pnl_inputObjs.Controls.Add(this.pic_cheque);
            this.pnl_inputObjs.Location = new System.Drawing.Point(32, 81);
            this.pnl_inputObjs.Name = "pnl_inputObjs";
            this.pnl_inputObjs.Size = new System.Drawing.Size(496, 466);
            this.pnl_inputObjs.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(361, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(33, 159);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(361, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(33, 159);
            this.panel2.TabIndex = 10;
            // 
            // lbl_depositTo
            // 
            this.lbl_depositTo.AutoSize = true;
            this.lbl_depositTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_depositTo.Location = new System.Drawing.Point(14, 260);
            this.lbl_depositTo.Name = "lbl_depositTo";
            this.lbl_depositTo.Size = new System.Drawing.Size(217, 29);
            this.lbl_depositTo.TabIndex = 13;
            this.lbl_depositTo.Text = "Deposit to account:";
            // 
            // pnl_confirmDeposit
            // 
            this.pnl_confirmDeposit.Controls.Add(this.lst_input);
            this.pnl_confirmDeposit.Controls.Add(this.lbl_depositTo);
            this.pnl_confirmDeposit.Controls.Add(this.btn_cancel);
            this.pnl_confirmDeposit.Controls.Add(this.chk_receipt);
            this.pnl_confirmDeposit.Controls.Add(this.lst_accountsTo);
            this.pnl_confirmDeposit.Controls.Add(this.btn_confirm);
            this.pnl_confirmDeposit.Location = new System.Drawing.Point(16, 91);
            this.pnl_confirmDeposit.Name = "pnl_confirmDeposit";
            this.pnl_confirmDeposit.Size = new System.Drawing.Size(543, 459);
            this.pnl_confirmDeposit.TabIndex = 14;
            this.pnl_confirmDeposit.Visible = false;
            // 
            // lst_input
            // 
            this.lst_input.BackColor = System.Drawing.SystemColors.Control;
            this.lst_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_input.ColumnWidth = 150;
            this.lst_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_input.FormattingEnabled = true;
            this.lst_input.ItemHeight = 25;
            this.lst_input.Location = new System.Drawing.Point(25, 21);
            this.lst_input.Margin = new System.Windows.Forms.Padding(2);
            this.lst_input.MultiColumn = true;
            this.lst_input.Name = "lst_input";
            this.lst_input.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lst_input.Size = new System.Drawing.Size(485, 225);
            this.lst_input.TabIndex = 11;
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pnl_confirmDeposit);
            this.Controls.Add(this.pnl_inputObjs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Deposit";
            this.ShowIcon = false;
            this.Text = "Bank Machine";
            this.Load += new System.EventHandler(this.Deposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_cash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cheque)).EndInit();
            this.pnl_inputObjs.ResumeLayout(false);
            this.pnl_confirmDeposit.ResumeLayout(false);
            this.pnl_confirmDeposit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_accountsTo;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.CheckBox chk_receipt;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pic_cash;
        private System.Windows.Forms.PictureBox pic_cheque;
        private System.Windows.Forms.Label lbl_dir;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbl_depositTo;
        private System.Windows.Forms.Panel pnl_inputObjs;
        private System.Windows.Forms.Panel pnl_confirmDeposit;
        private System.Windows.Forms.ListBox lst_input;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}