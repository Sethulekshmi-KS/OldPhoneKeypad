using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OldPhoneKeypad
{
    public partial class OldPhoneKeypadForm : Form
    {
        readonly Helper ObjHelp = new Helper();
        public char LastChar = ' ';
        public OldPhoneKeypadForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method restarts the timer on each button click, 
        /// so that timer tick event will not get fired as long as 
        /// user continues to inpput any number
        /// </summary>
        private void RestartTimer(char buttonText)
        {
            if(!timer1.Enabled)
            {
                if(buttonText != ' ' &&  LastChar == buttonText)
                    txt_msg.Text += " " + buttonText;
                else
                    txt_msg.Text += buttonText;
            }
            else
                txt_msg.Text += buttonText;

            timer1.Stop();
            timer1.Start();
            LastChar = buttonText;
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            txt_msg.Text = "";
            LastChar = ' ';
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            char ButtonText = btn_2.Text[0];
            RestartTimer(ButtonText);
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            char ButtonText = btn_3.Text[0];
            RestartTimer(ButtonText);
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            char ButtonText = btn_4.Text[0];
            RestartTimer(ButtonText);
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            char ButtonText = btn_5.Text[0];
            RestartTimer(ButtonText);
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            char ButtonText = btn_6.Text[0];
            RestartTimer(ButtonText);
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            char ButtonText = btn_7.Text[0];
            RestartTimer(ButtonText);
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            char ButtonText = btn_8.Text[0];
            RestartTimer(ButtonText);
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            char ButtonText = btn_9.Text[0];
            RestartTimer(ButtonText);
        }

        private void Btn_star_Click(object sender, EventArgs e)
        {
            char ButtonText = btn_star.Text[0];
            RestartTimer(ButtonText);
        }

        private void Btn_space_Click(object sender, EventArgs e)
        {
            char ButtonText = btn_space.Text[0];
            RestartTimer(ButtonText);
        }

        /// <summary>
        /// When 'send' or '#' is clicked, the number string input by the user
        /// gets converted to corresponding alphabets as in old phone keypad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_hash_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (!string.IsNullOrEmpty(txt_msg.Text))
                txt_msg.Text = ObjHelp.OldPhonePad(txt_msg.Text);
            else
                MessageBox.Show("Invalid input");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }

        }
    }
}
