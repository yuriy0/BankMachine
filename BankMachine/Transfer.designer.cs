namespace BankMachine
{
    partial class Transfer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_transferFrom = new System.Windows.Forms.ListBox();
            this.lst_transferTo = new System.Windows.Forms.ListBox();
            this.keypad_transfer = new BankMachine.KeyPad();
            this.pnl_accounts = new System.Windows.Forms.Panel();
            this.pnl_accounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter an amount to transfer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Transfer from account:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Transfer to account:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 511);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "Back to home";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(209, 79);
            this.txt_amount.Margin = new System.Windows.Forms.Padding(2);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(135, 20);
            this.txt_amount.TabIndex = 19;
            this.txt_amount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(387, 211);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(2);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(96, 57);
            this.btn_confirm.TabIndex = 21;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lst_transferFrom
            // 
            this.lst_transferFrom.FormattingEnabled = true;
            this.lst_transferFrom.Location = new System.Drawing.Point(28, 87);
            this.lst_transferFrom.Name = "lst_transferFrom";
            this.lst_transferFrom.Size = new System.Drawing.Size(120, 95);
            this.lst_transferFrom.TabIndex = 24;
            // 
            // lst_transferTo
            // 
            this.lst_transferTo.FormattingEnabled = true;
            this.lst_transferTo.Location = new System.Drawing.Point(367, 87);
            this.lst_transferTo.Name = "lst_transferTo";
            this.lst_transferTo.Size = new System.Drawing.Size(120, 95);
            this.lst_transferTo.TabIndex = 25;
            // 
            // keypad_transfer
            // 
            this.keypad_transfer.AllowDot = false;
            this.keypad_transfer.CancelText = "X";
            this.keypad_transfer.Location = new System.Drawing.Point(175, 42);
            this.keypad_transfer.Name = "keypad_transfer";
            this.keypad_transfer.Size = new System.Drawing.Size(169, 286);
            this.keypad_transfer.TabIndex = 23;
            // 
            // pnl_accounts
            // 
            this.pnl_accounts.Controls.Add(this.keypad_transfer);
            this.pnl_accounts.Controls.Add(this.lst_transferTo);
            this.pnl_accounts.Controls.Add(this.btn_confirm);
            this.pnl_accounts.Controls.Add(this.label4);
            this.pnl_accounts.Controls.Add(this.label3);
            this.pnl_accounts.Controls.Add(this.lst_transferFrom);
            this.pnl_accounts.Location = new System.Drawing.Point(22, 145);
            this.pnl_accounts.Name = "pnl_accounts";
            this.pnl_accounts.Size = new System.Drawing.Size(534, 348);
            this.pnl_accounts.TabIndex = 26;
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_accounts);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Transfer";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.pnl_accounts.ResumeLayout(false);
            this.pnl_accounts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label label2;
        private KeyPad keypad_transfer;
        private System.Windows.Forms.ListBox lst_transferFrom;
        private System.Windows.Forms.ListBox lst_transferTo;
        private System.Windows.Forms.Panel pnl_accounts;
    }
}