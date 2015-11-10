namespace BankMachine
{
    partial class MainScreen
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.main_accnt_num = new System.Windows.Forms.TextBox();
            this.main_landing = new System.Windows.Forms.Panel();
            this.main_enter_accnt = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.main_landing.SuspendLayout();
            this.main_enter_accnt.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Bank";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Insert,";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Swipe,";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "or Enter Account";
            // 
            // main_accnt_num
            // 
            this.main_accnt_num.BackColor = System.Drawing.Color.White;
            this.main_accnt_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_accnt_num.Location = new System.Drawing.Point(208, 456);
            this.main_accnt_num.Name = "main_accnt_num";
            this.main_accnt_num.ReadOnly = true;
            this.main_accnt_num.Size = new System.Drawing.Size(182, 29);
            this.main_accnt_num.TabIndex = 4;
            this.main_accnt_num.MouseClick += new System.Windows.Forms.MouseEventHandler(this.main_accnt_num_MouseClick);
            this.main_accnt_num.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // main_landing
            // 
            this.main_landing.Controls.Add(this.label2);
            this.main_landing.Controls.Add(this.label3);
            this.main_landing.Controls.Add(this.label4);
            this.main_landing.Location = new System.Drawing.Point(70, 172);
            this.main_landing.Name = "main_landing";
            this.main_landing.Size = new System.Drawing.Size(447, 274);
            this.main_landing.TabIndex = 5;
            this.main_landing.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // main_enter_accnt
            // 
            this.main_enter_accnt.Controls.Add(this.label5);
            this.main_enter_accnt.Location = new System.Drawing.Point(30, 143);
            this.main_enter_accnt.Name = "main_enter_accnt";
            this.main_enter_accnt.Size = new System.Drawing.Size(560, 415);
            this.main_enter_accnt.TabIndex = 6;
            this.main_enter_accnt.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 33);
            this.label5.TabIndex = 0;
            this.label5.Text = "Enter your account:";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 555);
            this.Controls.Add(this.main_accnt_num);
            this.Controls.Add(this.main_enter_accnt);
            this.Controls.Add(this.main_landing);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainScreen";
            this.ShowIcon = false;
            this.Text = "Bank machine";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainScreen_KeyPress);
            this.main_landing.ResumeLayout(false);
            this.main_landing.PerformLayout();
            this.main_enter_accnt.ResumeLayout(false);
            this.main_enter_accnt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox main_accnt_num;
        private System.Windows.Forms.Panel main_landing;
        private System.Windows.Forms.Panel main_enter_accnt;
        private System.Windows.Forms.Label label5;
    }
}

