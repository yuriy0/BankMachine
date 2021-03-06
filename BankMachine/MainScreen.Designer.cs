﻿namespace BankMachine
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
            this.dummyPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.main_landing.SuspendLayout();
            this.main_enter_accnt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // mainWelcomeLabel
            // 
            this.mainWelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainWelcomeLabel.Location = new System.Drawing.Point(87, 53);
            this.mainWelcomeLabel.Name = "mainWelcomeLabel";
            this.mainWelcomeLabel.Size = new System.Drawing.Size(400, 55);
            this.mainWelcomeLabel.TabIndex = 0;
            this.mainWelcomeLabel.Text = "Welcome to Bank";
            this.mainWelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainWelcomeLabel.Click += new System.EventHandler(this.welcomeLabel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Insert,";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Swipe,";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "or Enter Account";
            this.label4.Click += new System.EventHandler(this.label4_Click_2);
            // 
            // main_accnt_num
            // 
            this.main_accnt_num.BackColor = System.Drawing.Color.White;
            this.main_accnt_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_accnt_num.Location = new System.Drawing.Point(150, 462);
            this.main_accnt_num.Margin = new System.Windows.Forms.Padding(4);
            this.main_accnt_num.Name = "main_accnt_num";
            this.main_accnt_num.ReadOnly = true;
            this.main_accnt_num.Size = new System.Drawing.Size(257, 29);
            this.main_accnt_num.TabIndex = 4;
            this.main_accnt_num.Text = "Press to enter account #";
            this.main_accnt_num.MouseClick += new System.Windows.Forms.MouseEventHandler(this.main_accnt_num_MouseClick);
            this.main_accnt_num.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.main_accnt_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.main_accnt_num_KeyPress);
            // 
            // main_landing
            // 
            this.main_landing.Controls.Add(this.pictureBox4);
            this.main_landing.Controls.Add(this.pictureBox3);
            this.main_landing.Controls.Add(this.pictureBox2);
            this.main_landing.Controls.Add(this.pictureBox1);
            this.main_landing.Controls.Add(this.label2);
            this.main_landing.Controls.Add(this.label3);
            this.main_landing.Controls.Add(this.label4);
            this.main_landing.Location = new System.Drawing.Point(70, 160);
            this.main_landing.Name = "main_landing";
            this.main_landing.Size = new System.Drawing.Size(447, 286);
            this.main_landing.TabIndex = 5;
            this.main_landing.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // main_enter_accnt
            // 
            this.main_enter_accnt.Controls.Add(this.mainLabel);
            this.main_enter_accnt.Controls.Add(this.mainScreen_keypad);
            this.main_enter_accnt.Location = new System.Drawing.Point(12, 105);
            this.main_enter_accnt.Name = "main_enter_accnt";
            this.main_enter_accnt.Size = new System.Drawing.Size(560, 447);
            this.main_enter_accnt.TabIndex = 6;
            this.main_enter_accnt.Visible = false;
            // 
            // mainLabel
            // 
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.Location = new System.Drawing.Point(79, 4);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(395, 74);
            this.mainLabel.TabIndex = 1;
            this.mainLabel.Text = "Enter your account:";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mainLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // mainScreen_keypad
            // 
            this.mainScreen_keypad.AllowDot = false;
            this.mainScreen_keypad.CancelText = "X";
            this.mainScreen_keypad.Location = new System.Drawing.Point(185, 113);
            this.mainScreen_keypad.Margin = new System.Windows.Forms.Padding(4);
            this.mainScreen_keypad.Name = "mainScreen_keypad";
            this.mainScreen_keypad.Size = new System.Drawing.Size(169, 286);
            this.mainScreen_keypad.TabIndex = 0;
            this.mainScreen_keypad.TextMode = false;
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
            this.main_errorLabel.Location = new System.Drawing.Point(97, 108);
            this.main_errorLabel.Name = "main_errorLabel";
            this.main_errorLabel.Size = new System.Drawing.Size(390, 32);
            this.main_errorLabel.TabIndex = 7;
            this.main_errorLabel.Text = "err";
            this.main_errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.main_errorLabel.Visible = false;
            this.main_errorLabel.Click += new System.EventHandler(this.main_errorLabel_Click);
            // 
            // dummyPanel
            // 
            this.dummyPanel.Location = new System.Drawing.Point(526, 12);
            this.dummyPanel.Name = "dummyPanel";
            this.dummyPanel.Size = new System.Drawing.Size(35, 41);
            this.dummyPanel.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::BankMachine.Properties.Resources.credit_card_r;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(282, 130);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(92, 139);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(266, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 111);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BankMachine.Properties.Resources.credit_card;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(268, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 83);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.Location = new System.Drawing.Point(267, 120);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 160);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.dummyPanel);
            this.Controls.Add(this.main_errorLabel);
            this.Controls.Add(this.main_accnt_num);
            this.Controls.Add(this.main_landing);
            this.Controls.Add(this.mainWelcomeLabel);
            this.Controls.Add(this.main_enter_accnt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.Panel dummyPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

