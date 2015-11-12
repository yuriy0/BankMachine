namespace BankMachine
{
    partial class Payee
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
            this.btn_backHome = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage payees";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_backHome
            // 
            this.btn_backHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backHome.Location = new System.Drawing.Point(-1, 497);
            this.btn_backHome.Margin = new System.Windows.Forms.Padding(4);
            this.btn_backHome.Name = "btn_backHome";
            this.btn_backHome.Size = new System.Drawing.Size(149, 55);
            this.btn_backHome.TabIndex = 15;
            this.btn_backHome.Text = "Back to home";
            this.btn_backHome.UseVisualStyleBackColor = true;
            this.btn_backHome.Click += new System.EventHandler(this.btn_backHome_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 58);
            this.button1.TabIndex = 16;
            this.button1.Text = "Pay selected payee...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 16;
            this.list.Location = new System.Drawing.Point(88, 139);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(383, 148);
            this.list.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 44);
            this.label3.TabIndex = 19;
            this.label3.Text = "Pay a bill";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(478, -2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 37);
            this.button2.TabIndex = 20;
            this.button2.Text = "Edit...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "You have selected payee:";
            this.label2.Visible = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(373, 41);
            this.label4.TabIndex = 22;
            this.label4.Text = "Water bill, account # 60436432";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(178, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Enter transfer amount";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 296);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 22);
            this.textBox1.TabIndex = 24;
            this.textBox1.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(285, 418);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 62);
            this.button3.TabIndex = 25;
            this.button3.Text = "Continue...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(-1, 497);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 55);
            this.button4.TabIndex = 26;
            this.button4.Text = "Back to payees";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(36, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "You are about to transfer:";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "$100";
            this.label7.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(164, 301);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(189, 23);
            this.button5.TabIndex = 29;
            this.button5.Text = "Back to transfer amount ...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 23);
            this.label8.TabIndex = 30;
            this.label8.Text = "Select account to transfer from";
            this.label8.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(39, 396);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(232, 84);
            this.listBox1.TabIndex = 31;
            this.listBox1.Visible = false;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(83, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(301, 44);
            this.label9.TabIndex = 32;
            this.label9.Text = "Error";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(-4, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(587, 39);
            this.label10.TabIndex = 33;
            this.label10.Text = "You are unable to pay $100.00 to Water bill, account # 60436432 because you have " +
    "insufficient funds.";
            this.label10.Visible = false;
            // 
            // Payee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.list);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_backHome);
            this.Controls.Add(this.label1);
            this.Name = "Payee";
            this.Text = "Payee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_backHome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}