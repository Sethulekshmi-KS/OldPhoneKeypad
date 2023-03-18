using System;

namespace OldPhoneKeypad
{
    partial class OldPhoneKeypadForm
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
            this.components = new System.ComponentModel.Container();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_hash = new System.Windows.Forms.Button();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_star = new System.Windows.Forms.Button();
            this.btn_space = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(24, 125);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(60, 60);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "1\r\n\r\nClear All\r\n";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.Btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(109, 125);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(60, 60);
            this.btn_2.TabIndex = 12;
            this.btn_2.Text = "2\r\n\r\nA B C";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.Btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(194, 125);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(60, 60);
            this.btn_3.TabIndex = 9;
            this.btn_3.Text = "3\r\n\r\nD E F";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.Btn_3_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(24, 205);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(60, 60);
            this.btn_4.TabIndex = 11;
            this.btn_4.Text = "4\r\n\r\nG H I";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.Btn_4_Click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(109, 205);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(60, 60);
            this.btn_5.TabIndex = 10;
            this.btn_5.Text = "5\r\n\r\nJ K L";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.Btn_5_Click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(194, 205);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(60, 60);
            this.btn_6.TabIndex = 8;
            this.btn_6.Text = "6\r\n\r\nM N O";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.Btn_6_Click);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(24, 285);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(60, 60);
            this.btn_7.TabIndex = 7;
            this.btn_7.Text = "7\r\n\r\nP Q R S";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.Btn_7_Click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(109, 285);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(60, 60);
            this.btn_8.TabIndex = 6;
            this.btn_8.Text = "8\r\n\r\nT U V";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.Btn_8_Click);
            // 
            // btn_hash
            // 
            this.btn_hash.Location = new System.Drawing.Point(194, 365);
            this.btn_hash.Name = "btn_hash";
            this.btn_hash.Size = new System.Drawing.Size(60, 60);
            this.btn_hash.TabIndex = 5;
            this.btn_hash.Text = "send";
            this.btn_hash.UseVisualStyleBackColor = true;
            this.btn_hash.Click += new System.EventHandler(this.Btn_hash_Click);
            // 
            // txt_msg
            // 
            this.txt_msg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_msg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_msg.Location = new System.Drawing.Point(24, 22);
            this.txt_msg.Multiline = true;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.ReadOnly = true;
            this.txt_msg.Size = new System.Drawing.Size(230, 79);
            this.txt_msg.TabIndex = 13;
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(194, 285);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(60, 60);
            this.btn_9.TabIndex = 14;
            this.btn_9.Text = "9\r\n\r\nW X Y Z";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.Btn_9_Click);
            // 
            // btn_star
            // 
            this.btn_star.Location = new System.Drawing.Point(24, 365);
            this.btn_star.Name = "btn_star";
            this.btn_star.Size = new System.Drawing.Size(60, 60);
            this.btn_star.TabIndex = 15;
            this.btn_star.Text = "*\r\n\r\nclear";
            this.btn_star.UseVisualStyleBackColor = true;
            this.btn_star.Click += new System.EventHandler(this.Btn_star_Click);
            // 
            // btn_space
            // 
            this.btn_space.Location = new System.Drawing.Point(109, 365);
            this.btn_space.Name = "btn_space";
            this.btn_space.Size = new System.Drawing.Size(60, 60);
            this.btn_space.TabIndex = 16;
            this.btn_space.Text = "0\r\n\r\n[__]";
            this.btn_space.UseVisualStyleBackColor = true;
            this.btn_space.Click += new System.EventHandler(this.Btn_space_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // OldPhoneKeypadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(277, 463);
            this.Controls.Add(this.btn_space);
            this.Controls.Add(this.btn_star);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.txt_msg);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_hash);
            this.Controls.Add(this.btn_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OldPhoneKeypadForm";
            this.Text = "Keypad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_hash;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_star;
        private System.Windows.Forms.Button btn_space;
        private System.Windows.Forms.Timer timer1;
    }
}

