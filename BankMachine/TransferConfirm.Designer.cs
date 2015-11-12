namespace BankMachine
{
    partial class TransferConfirm
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
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.chk_receipt = new System.Windows.Forms.CheckBox();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.lbl_err = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_confirm
            // 
            this.btn_confirm.Enabled = false;
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.Location = new System.Drawing.Point(329, 415);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(201, 64);
            this.btn_confirm.TabIndex = 14;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(62, 415);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(201, 64);
            this.btn_back.TabIndex = 15;
            this.btn_back.Text = "Back to transfers";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // chk_receipt
            // 
            this.chk_receipt.AutoSize = true;
            this.chk_receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_receipt.Location = new System.Drawing.Point(352, 494);
            this.chk_receipt.Name = "chk_receipt";
            this.chk_receipt.Size = new System.Drawing.Size(161, 33);
            this.chk_receipt.TabIndex = 16;
            this.chk_receipt.Text = "Print receipt";
            this.chk_receipt.UseVisualStyleBackColor = true;
            // 
            // lbl_msg
            // 
            this.lbl_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg.Location = new System.Drawing.Point(-2, 89);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(584, 299);
            this.lbl_msg.TabIndex = 17;
            this.lbl_msg.Text = "Enter an amount to withdraw";
            this.lbl_msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_err
            // 
            this.lbl_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_err.ForeColor = System.Drawing.Color.Red;
            this.lbl_err.Location = new System.Drawing.Point(-2, 16);
            this.lbl_err.Name = "lbl_err";
            this.lbl_err.Size = new System.Drawing.Size(584, 58);
            this.lbl_err.TabIndex = 18;
            this.lbl_err.Text = "Error";
            this.lbl_err.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TransferConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.lbl_err);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.chk_receipt);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_confirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransferConfirm";
            this.ShowIcon = false;
            this.Text = "Bank Machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.CheckBox chk_receipt;
        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.Label lbl_err;
    }
}