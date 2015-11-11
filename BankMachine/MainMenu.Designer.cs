namespace BankMachine
{
    partial class MainMenu
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
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.btn_withdrawls = new System.Windows.Forms.Button();
            this.btn_deposit = new System.Windows.Forms.Button();
            this.btn_transfer = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.btn_payBills = new System.Windows.Forms.Button();
            this.btn_balances = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(0, 53);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(584, 55);
            this.lbl_welcome.TabIndex = 1;
            this.lbl_welcome.Text = "Welcome to Bank";
            this.lbl_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_withdrawls
            // 
            this.btn_withdrawls.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_withdrawls.Location = new System.Drawing.Point(55, 193);
            this.btn_withdrawls.Name = "btn_withdrawls";
            this.btn_withdrawls.Size = new System.Drawing.Size(235, 68);
            this.btn_withdrawls.TabIndex = 2;
            this.btn_withdrawls.Text = "Withdrawls";
            this.btn_withdrawls.UseVisualStyleBackColor = true;
            this.btn_withdrawls.Click += new System.EventHandler(this.btn_withdrawls_Click);
            // 
            // btn_deposit
            // 
            this.btn_deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deposit.Location = new System.Drawing.Point(55, 286);
            this.btn_deposit.Name = "btn_deposit";
            this.btn_deposit.Size = new System.Drawing.Size(235, 68);
            this.btn_deposit.TabIndex = 3;
            this.btn_deposit.Text = "Deposit";
            this.btn_deposit.UseVisualStyleBackColor = true;
            // 
            // btn_transfer
            // 
            this.btn_transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transfer.Location = new System.Drawing.Point(55, 382);
            this.btn_transfer.Name = "btn_transfer";
            this.btn_transfer.Size = new System.Drawing.Size(235, 68);
            this.btn_transfer.TabIndex = 4;
            this.btn_transfer.Text = "Make a transfer";
            this.btn_transfer.UseVisualStyleBackColor = true;
            // 
            // btn_quit
            // 
            this.btn_quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quit.Location = new System.Drawing.Point(308, 382);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(235, 68);
            this.btn_quit.TabIndex = 7;
            this.btn_quit.Text = "Quit";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // btn_payBills
            // 
            this.btn_payBills.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payBills.Location = new System.Drawing.Point(308, 286);
            this.btn_payBills.Name = "btn_payBills";
            this.btn_payBills.Size = new System.Drawing.Size(235, 68);
            this.btn_payBills.TabIndex = 6;
            this.btn_payBills.Text = "Pay bills";
            this.btn_payBills.UseVisualStyleBackColor = true;
            // 
            // btn_balances
            // 
            this.btn_balances.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_balances.Location = new System.Drawing.Point(308, 193);
            this.btn_balances.Name = "btn_balances";
            this.btn_balances.Size = new System.Drawing.Size(235, 68);
            this.btn_balances.TabIndex = 5;
            this.btn_balances.Text = "View account balances";
            this.btn_balances.UseVisualStyleBackColor = true;
            this.btn_balances.Click += new System.EventHandler(this.btn_balances_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_payBills);
            this.Controls.Add(this.btn_balances);
            this.Controls.Add(this.btn_transfer);
            this.Controls.Add(this.btn_deposit);
            this.Controls.Add(this.btn_withdrawls);
            this.Controls.Add(this.lbl_welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.Text = "Bank Machine";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button btn_withdrawls;
        private System.Windows.Forms.Button btn_deposit;
        private System.Windows.Forms.Button btn_transfer;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Button btn_payBills;
        private System.Windows.Forms.Button btn_balances;
    }
}