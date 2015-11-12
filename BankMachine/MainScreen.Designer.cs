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
            this.mainWelcomeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.main_accnt_num = new System.Windows.Forms.TextBox();
            this.main_landing = new System.Windows.Forms.Panel();
            this.main_enter_accnt = new System.Windows.Forms.Panel();
            this.mainLabel = new System.Windows.Forms.Label();
            this.mainScreen_keypad = new BankMachine.KeyPad();
            this.label5 = new System.Windows.Forms.Label();
            this.main_errorLabel = new System.Windows.Forms.Label();
            this.main_landing.SuspendLayout();
            this.main_enter_accnt.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainWelcomeLabel
            // 
            this.mainWelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainWelcomeLabel.Location = new System.Drawing.Point(116, 65);
            this.mainWelcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mainWelcomeLabel.Name = "mainWelcomeLabel";
            this.mainWelcomeLabel.Size = new System.Drawing.Size(533, 68);
            this.mainWelcomeLabel.TabIndex = 0;
            this.mainWelcomeLabel.Text = "Welcome to Bank";
            this.mainWelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainWelcomeLabel.Click += new System.EventHandler(this.welcomeLabel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Insert,";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Swipe,";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "or Enter Account";
            // 
            // main_accnt_num
            // 
            this.main_accnt_num.BackColor = System.Drawing.Color.White;
            this.main_accnt_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_accnt_num.Location = new System.Drawing.Point(255, 569);
            this.main_accnt_num.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.main_accnt_num.Name = "main_accnt_num";
            this.main_accnt_num.ReadOnly = true;
            this.main_accnt_num.Size = new System.Drawing.Size(241, 34);
            this.main_accnt_num.TabIndex = 4;
            this.main_accnt_num.MouseClick += new System.Windows.Forms.MouseEventHandler(this.main_accnt_num_MouseClick);
            this.main_accnt_num.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.main_accnt_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.main_accnt_num_KeyPress);
            // 
            // main_landing
            // 
            this.main_landing.Controls.Add(this.label2);
            this.main_landing.Controls.Add(this.label3);
            this.main_landing.Controls.Add(this.label4);
            this.main_landing.Location = new System.Drawing.Point(93, 212);
            this.main_landing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.main_landing.Name = "main_landing";
            this.main_landing.Size = new System.Drawing.Size(596, 337);
            this.main_landing.TabIndex = 5;
            this.main_landing.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // main_enter_accnt
            // 
            this.main_enter_accnt.Controls.Add(this.mainLabel);
            this.main_enter_accnt.Controls.Add(this.mainScreen_keypad);
            this.main_enter_accnt.Location = new System.Drawing.Point(16, 129);
            this.main_enter_accnt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.main_enter_accnt.Name = "main_enter_accnt";
            this.main_enter_accnt.Size = new System.Drawing.Size(747, 550);
            this.main_enter_accnt.TabIndex = 6;
            this.main_enter_accnt.Visible = false;
            // 
            // mainLabel
            // 
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.Location = new System.Drawing.Point(105, 5);
            this.mainLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(527, 91);
            this.mainLabel.TabIndex = 1;
            this.mainLabel.Text = "Enter your account:";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mainLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // mainScreen_keypad
            // 
            this.mainScreen_keypad.AllowDot = false;
            this.mainScreen_keypad.CancelText = "X";
            this.mainScreen_keypad.Location = new System.Drawing.Point(247, 139);
            this.mainScreen_keypad.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.mainScreen_keypad.Name = "mainScreen_keypad";
            this.mainScreen_keypad.Size = new System.Drawing.Size(225, 352);
            this.mainScreen_keypad.TabIndex = 0;
            this.mainScreen_keypad.CharEntered += new BankMachine.KeyPad.CharEnteredEventHandler(this.accn_num_keypad_CharEntered);
            this.mainScreen_keypad.Submit += new BankMachine.KeyPad.SubmitEventHandler(this.mainScreen_keypad_Submit);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 33);
            this.label5.TabIndex = 0;
            this.label5.Text = "Enter your account:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main_errorLabel
            // 
            this.main_errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_errorLabel.ForeColor = System.Drawing.Color.Red;
            this.main_errorLabel.Location = new System.Drawing.Point(129, 133);
            this.main_errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.main_errorLabel.Name = "main_errorLabel";
            this.main_errorLabel.Size = new System.Drawing.Size(520, 39);
            this.main_errorLabel.TabIndex = 7;
            this.main_errorLabel.Text = "err";
            this.main_errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.main_errorLabel.Visible = false;
            this.main_errorLabel.Click += new System.EventHandler(this.main_errorLabel_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 692);
            this.Controls.Add(this.main_errorLabel);
            this.Controls.Add(this.main_accnt_num);
            this.Controls.Add(this.main_enter_accnt);
            this.Controls.Add(this.main_landing);
            this.Controls.Add(this.mainWelcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainWelcomeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox main_accnt_num;
        private System.Windows.Forms.Panel main_landing;
        private System.Windows.Forms.Panel main_enter_accnt;
        private System.Windows.Forms.Label label5;
        private KeyPad mainScreen_keypad;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label main_errorLabel;
    }
}

