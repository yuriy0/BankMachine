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
            this.lst_transferFrom = new System.Windows.Forms.ListBox();
            this.lst_transferTo = new System.Windows.Forms.ListBox();
            this.pnl_accounts = new System.Windows.Forms.Panel();
            this.keypad_transfer = new BankMachine.KeyPad();
            this.pnl_accounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter an amount to transfer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Transfer from account:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 24);
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
            this.txt_amount.BackColor = System.Drawing.SystemColors.Window;
            this.txt_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(141, 92);
            this.txt_amount.Margin = new System.Windows.Forms.Padding(2);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.ReadOnly = true;
            this.txt_amount.Size = new System.Drawing.Size(276, 38);
            this.txt_amount.TabIndex = 19;
            this.txt_amount.Text = "Press to enter amount";
            this.txt_amount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_amount_MouseClick);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Enabled = false;
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.Location = new System.Drawing.Point(387, 263);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(2);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(96, 57);
            this.btn_confirm.TabIndex = 21;
            this.btn_confirm.Text = "Continue";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.button4_Click);
            // 
            // lst_transferFrom
            // 
            this.lst_transferFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_transferFrom.FormattingEnabled = true;
            this.lst_transferFrom.ItemHeight = 33;
            this.lst_transferFrom.Location = new System.Drawing.Point(12, 69);
            this.lst_transferFrom.Name = "lst_transferFrom";
            this.lst_transferFrom.Size = new System.Drawing.Size(198, 136);
            this.lst_transferFrom.TabIndex = 24;
            this.lst_transferFrom.SelectedIndexChanged += new System.EventHandler(this.lst_transferFrom_SelectedIndexChanged);
            // 
            // lst_transferTo
            // 
            this.lst_transferTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_transferTo.FormattingEnabled = true;
            this.lst_transferTo.ItemHeight = 33;
            this.lst_transferTo.Location = new System.Drawing.Point(315, 69);
            this.lst_transferTo.Name = "lst_transferTo";
            this.lst_transferTo.Size = new System.Drawing.Size(198, 136);
            this.lst_transferTo.TabIndex = 25;
            this.lst_transferTo.SelectedIndexChanged += new System.EventHandler(this.lst_transferTo_SelectedIndexChanged);
            // 
            // pnl_accounts
            // 
            this.pnl_accounts.Controls.Add(this.lst_transferTo);
            this.pnl_accounts.Controls.Add(this.btn_confirm);
            this.pnl_accounts.Controls.Add(this.label4);
            this.pnl_accounts.Controls.Add(this.label3);
            this.pnl_accounts.Controls.Add(this.lst_transferFrom);
            this.pnl_accounts.Location = new System.Drawing.Point(24, 149);
            this.pnl_accounts.Name = "pnl_accounts";
            this.pnl_accounts.Size = new System.Drawing.Size(534, 348);
            this.pnl_accounts.TabIndex = 26;
            // 
            // keypad_transfer
            // 
            this.keypad_transfer.AllowDot = false;
            this.keypad_transfer.CancelText = "X";
            this.keypad_transfer.Location = new System.Drawing.Point(192, 158);
            this.keypad_transfer.Name = "keypad_transfer";
            this.keypad_transfer.Size = new System.Drawing.Size(169, 286);
            this.keypad_transfer.TabIndex = 23;
            this.keypad_transfer.TextMode = false;
            this.keypad_transfer.Submit += new BankMachine.KeyPad.SubmitEventHandler(this.keypad_transfer_Submit);
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.keypad_transfer);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_accounts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Transfer";
            this.ShowIcon = false;
            this.Text = "Bank Machine";
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
        private KeyPad keypad_transfer;
        private System.Windows.Forms.ListBox lst_transferFrom;
        private System.Windows.Forms.ListBox lst_transferTo;
        private System.Windows.Forms.Panel pnl_accounts;
    }
}