using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankMachine
{
    public partial class KeyPad : UserControl
    {
        public delegate void CharEnteredEventHandler(object sender, char digit);
        public event CharEnteredEventHandler CharEntered;

        public delegate void SubmitEventHandler(object sender, bool isOk);
        public event SubmitEventHandler Submit;

        private bool _allowDot;
        public bool AllowDot { get { return _allowDot; } 
            set
            {
                b_dot.Enabled = !value; 
                _allowDot = value; 
            }
        }

        public TextBoxBase outputTextBox; 

        public KeyPad()
        {
            InitializeComponent();
        }

        public KeyPad(bool dot)
        {
            InitializeComponent();
            AllowDot = dot;
        }

        public KeyPad(bool dot, TextBoxBase b)
        {
            InitializeComponent();
            AllowDot = dot;
            outputTextBox = b; 
        }

        protected virtual void OnSubmit(bool isOk)
        {
            if (Submit != null)
                Submit(this, isOk);
        }

        protected virtual void OnCharEntered(char digit)
        {
            if (CharEntered != null)
                CharEntered(this, digit);
        }

        private void b_ok_Click(object sender, EventArgs e) { OnSubmit(true); }
        private void b_clr_Click(object sender, EventArgs e) { OnSubmit(false); }
        private void numButtonClick(object sender, EventArgs e) 
        {
            char pressed = (((Button)sender).Text)[0];
            if (outputTextBox != null && outputTextBox.TextLength < outputTextBox.MaxLength)
            {
                outputTextBox.Text = outputTextBox.Text.Insert(outputTextBox.Text.Length, pressed.ToString());
            }
            OnCharEntered(pressed); 
        }

        private void b_del_Click(object sender, EventArgs e)
        {
            OnCharEntered((char)8);
            if (outputTextBox != null && outputTextBox.Text.Count() != 0)
            {
                outputTextBox.Text = outputTextBox.Text.Remove(Math.Max(0,outputTextBox.Text.Length - 1), 1);
            }
        }

        private void b_dot_Click(object sender, EventArgs e)
        {
            if (AllowDot) 
            { 
                OnCharEntered('.');
                if (outputTextBox != null && 
                    outputTextBox.Text.Count() != 0 && 
                    !(outputTextBox.Text.Contains('.')) &&
                    outputTextBox.TextLength < outputTextBox.MaxLength
                    )
                {
                    outputTextBox.Text = outputTextBox.Text.Insert(outputTextBox.Text.Length, ".");
                }
            }
        }
    }
}
