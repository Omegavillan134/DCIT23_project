namespace DCIT23_project
{
    partial class Rooms
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
            pcb_regular = new PictureBox();
            pnl_rooms = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcb_regular).BeginInit();
            pnl_rooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pcb_regular
            // 
            pcb_regular.BackColor = SystemColors.ActiveCaption;
            pcb_regular.Location = new Point(62, 57);
            pcb_regular.Name = "pcb_regular";
            pcb_regular.Size = new Size(282, 142);
            pcb_regular.TabIndex = 0;
            pcb_regular.TabStop = false;
            pcb_regular.Click += pictureBox1_Click;
            // 
            // pnl_rooms
            // 
            pnl_rooms.Controls.Add(pictureBox2);
            pnl_rooms.Controls.Add(pictureBox3);
            pnl_rooms.Controls.Add(pictureBox1);
            pnl_rooms.Controls.Add(pcb_regular);
            pnl_rooms.Location = new Point(12, 12);
            pnl_rooms.Name = "pnl_rooms";
            pnl_rooms.Size = new Size(776, 388);
            pnl_rooms.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaption;
            pictureBox2.Location = new Point(418, 216);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(282, 142);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ActiveCaption;
            pictureBox3.Location = new Point(62, 216);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(282, 142);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(418, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 142);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Rooms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnl_rooms);
            Name = "Rooms";
            Text = "Rooms";
            ((System.ComponentModel.ISupportInitialize)pcb_regular).EndInit();
            pnl_rooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pcb_regular;
        private Panel pnl_rooms;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
    }
}