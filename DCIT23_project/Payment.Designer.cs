﻿namespace DCIT23_project
{
    partial class Payment
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(451, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 150);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(12, 199);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(389, 248);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(30, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(178, 23);
            textBox2.TabIndex = 3;
            textBox2.Text = "0000-0000-0000-0000\r\n";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(30, 134);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(73, 23);
            textBox3.TabIndex = 4;
            textBox3.Text = "MM/YY";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(214, 90);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 72);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 6;
            label1.Text = "Card. No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 116);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 7;
            label2.Text = "Expiration Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 72);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 8;
            label3.Text = "CCV";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 28);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 9;
            label4.Text = "Name Of Card";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(454, 209);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 10;
            label5.Text = "Room Details";
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Payment";
            Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}