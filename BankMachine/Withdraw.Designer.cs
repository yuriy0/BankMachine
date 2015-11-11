namespace BankMachine
{
    partial class Withdraw
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add200 = new System.Windows.Forms.Button();
            this.btn_add100 = new System.Windows.Forms.Button();
            this.btn_add50 = new System.Windows.Forms.Button();
            this.btn_add20 = new System.Windows.Forms.Button();
            this.btn_toggleNumpad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstb_accounts = new System.Windows.Forms.ListBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_backHome = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.keyPad1 = new BankMachine.KeyPad();
            this.panel_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(-1, 46);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(584, 55);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Enter an amount to withdraw";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total:    $";
            // 
            // btn_add200
            // 
            this.btn_add200.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add200.Location = new System.Drawing.Point(7, 175);
            this.btn_add200.Name = "btn_add200";
            this.btn_add200.Size = new System.Drawing.Size(109, 64);
            this.btn_add200.TabIndex = 6;
            this.btn_add200.Text = "+$200";
            this.btn_add200.UseVisualStyleBackColor = true;
            this.btn_add200.Click += new System.EventHandler(this.btn_add200_Click);
            // 
            // btn_add100
            // 
            this.btn_add100.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add100.Location = new System.Drawing.Point(122, 175);
            this.btn_add100.Name = "btn_add100";
            this.btn_add100.Size = new System.Drawing.Size(109, 64);
            this.btn_add100.TabIndex = 7;
            this.btn_add100.Text = "+$100";
            this.btn_add100.UseVisualStyleBackColor = true;
            this.btn_add100.Click += new System.EventHandler(this.btn_add100_Click);
            // 
            // btn_add50
            // 
            this.btn_add50.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add50.Location = new System.Drawing.Point(237, 175);
            this.btn_add50.Name = "btn_add50";
            this.btn_add50.Size = new System.Drawing.Size(109, 64);
            this.btn_add50.TabIndex = 8;
            this.btn_add50.Text = "+$50";
            this.btn_add50.UseVisualStyleBackColor = true;
            this.btn_add50.Click += new System.EventHandler(this.btn_add50_Click);
            // 
            // btn_add20
            // 
            this.btn_add20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add20.Location = new System.Drawing.Point(352, 175);
            this.btn_add20.Name = "btn_add20";
            this.btn_add20.Size = new System.Drawing.Size(109, 64);
            this.btn_add20.TabIndex = 9;
            this.btn_add20.Text = "+$20";
            this.btn_add20.UseVisualStyleBackColor = true;
            this.btn_add20.Click += new System.EventHandler(this.btn_add20_Click);
            // 
            // btn_toggleNumpad
            // 
            this.btn_toggleNumpad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_toggleNumpad.Location = new System.Drawing.Point(467, 175);
            this.btn_toggleNumpad.Name = "btn_toggleNumpad";
            this.btn_toggleNumpad.Size = new System.Drawing.Size(109, 64);
            this.btn_toggleNumpad.TabIndex = 10;
            this.btn_toggleNumpad.Text = "Other...";
            this.btn_toggleNumpad.UseVisualStyleBackColor = true;
            this.btn_toggleNumpad.Click += new System.EventHandler(this.btn_toggleNumpad_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-5, -9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(584, 55);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select account to withdraw from:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstb_accounts
            // 
            this.lstb_accounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstb_accounts.FormattingEnabled = true;
            this.lstb_accounts.ItemHeight = 31;
            this.lstb_accounts.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.lstb_accounts.Location = new System.Drawing.Point(118, 49);
            this.lstb_accounts.Name = "lstb_accounts";
            this.lstb_accounts.Size = new System.Drawing.Size(339, 128);
            this.lstb_accounts.TabIndex = 12;
            this.lstb_accounts.SelectedIndexChanged += new System.EventHandler(this.lstb_accounts_SelectedIndexChanged);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Enabled = false;
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.Location = new System.Drawing.Point(196, 200);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(201, 64);
            this.btn_confirm.TabIndex = 13;
            this.btn_confirm.Text = "Confirm withdrawl";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_backHome
            // 
            this.btn_backHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backHome.Location = new System.Drawing.Point(0, 253);
            this.btn_backHome.Name = "btn_backHome";
            this.btn_backHome.Size = new System.Drawing.Size(112, 45);
            this.btn_backHome.TabIndex = 14;
            this.btn_backHome.Text = "Back to home";
            this.btn_backHome.UseVisualStyleBackColor = true;
            this.btn_backHome.Click += new System.EventHandler(this.btn_backHome_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(385, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = ".00";
            // 
            // txt_total
            // 
            this.txt_total.BackColor = System.Drawing.SystemColors.Window;
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(202, 121);
            this.txt_total.MaxLength = 9;
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(185, 38);
            this.txt_total.TabIndex = 17;
            this.txt_total.Text = "0";
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_total.TextChanged += new System.EventHandler(this.txt_total_TextChanged);
            // 
            // panel_bottom
            // 
            this.panel_bottom.Controls.Add(this.lstb_accounts);
            this.panel_bottom.Controls.Add(this.label2);
            this.panel_bottom.Controls.Add(this.btn_confirm);
            this.panel_bottom.Controls.Add(this.btn_backHome);
            this.panel_bottom.Location = new System.Drawing.Point(6, 256);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(572, 298);
            this.panel_bottom.TabIndex = 18;
            // 
            // keyPad1
            // 
            this.keyPad1.AllowDot = false;
            this.keyPad1.Location = new System.Drawing.Point(208, 244);
            this.keyPad1.Name = "keyPad1";
            this.keyPad1.Size = new System.Drawing.Size(169, 286);
            this.keyPad1.TabIndex = 15;
            this.keyPad1.Visible = false;
            this.keyPad1.Submit += new BankMachine.KeyPad.SubmitEventHandler(this.keyPad1_Submit);
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.keyPad1);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_toggleNumpad);
            this.Controls.Add(this.btn_add20);
            this.Controls.Add(this.btn_add50);
            this.Controls.Add(this.btn_add100);
            this.Controls.Add(this.btn_add200);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.panel_bottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Withdraw";
            this.ShowIcon = false;
            this.Text = "Bank Machine";
            this.panel_bottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add200;
        private System.Windows.Forms.Button btn_add100;
        private System.Windows.Forms.Button btn_add50;
        private System.Windows.Forms.Button btn_add20;
        private System.Windows.Forms.Button btn_toggleNumpad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstb_accounts;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_backHome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Panel panel_bottom;
        private KeyPad keyPad1;
    }
}