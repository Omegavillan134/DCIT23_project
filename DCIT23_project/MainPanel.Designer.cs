namespace DCIT23_project
{
    partial class MainPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnl_main = new Panel();
            grpb_register = new GroupBox();
            label2 = new Label();
            lnkl_login = new LinkLabel();
            lbl_confirmpassword = new Label();
            txtb_usernameR = new TextBox();
            button1 = new Button();
            txtb_Confirmpass = new TextBox();
            lbl_passwordR = new Label();
            txtb_passwordR = new TextBox();
            lbl_usernameR = new Label();
            grpb_Login = new GroupBox();
            label1 = new Label();
            lnkl_register = new LinkLabel();
            txtb_username = new TextBox();
            btn_login = new Button();
            txtb_password = new TextBox();
            lbl_username = new Label();
            lbl_password = new Label();
            grpb_Nav = new GroupBox();
            btn_back = new Button();
            btn_payment = new Button();
            btn_checkin = new Button();
            btn_rooms = new Button();
            btn_Dashboard = new Button();
            pnl_main.SuspendLayout();
            grpb_register.SuspendLayout();
            grpb_Login.SuspendLayout();
            grpb_Nav.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_main
            // 
            pnl_main.Controls.Add(grpb_register);
            pnl_main.Controls.Add(grpb_Login);
            pnl_main.Location = new Point(12, 41);
            pnl_main.Name = "pnl_main";
            pnl_main.Size = new Size(776, 397);
            pnl_main.TabIndex = 0;
            pnl_main.Paint += panel1_Paint;
            // 
            // grpb_register
            // 
            grpb_register.Controls.Add(label2);
            grpb_register.Controls.Add(lnkl_login);
            grpb_register.Controls.Add(lbl_confirmpassword);
            grpb_register.Controls.Add(txtb_usernameR);
            grpb_register.Controls.Add(button1);
            grpb_register.Controls.Add(txtb_Confirmpass);
            grpb_register.Controls.Add(lbl_passwordR);
            grpb_register.Controls.Add(txtb_passwordR);
            grpb_register.Controls.Add(lbl_usernameR);
            grpb_register.Location = new Point(296, 127);
            grpb_register.Name = "grpb_register";
            grpb_register.Size = new Size(200, 194);
            grpb_register.TabIndex = 7;
            grpb_register.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 147);
            label2.Name = "label2";
            label2.Size = new Size(144, 15);
            label2.TabIndex = 8;
            label2.Text = "Already have an Account?";
            // 
            // lnkl_login
            // 
            lnkl_login.AutoSize = true;
            lnkl_login.Location = new Point(154, 147);
            lnkl_login.Name = "lnkl_login";
            lnkl_login.Size = new Size(37, 15);
            lnkl_login.TabIndex = 7;
            lnkl_login.TabStop = true;
            lnkl_login.Text = "Login";
            lnkl_login.LinkClicked += lnkl_login_LinkClicked;
            // 
            // lbl_confirmpassword
            // 
            lbl_confirmpassword.AutoSize = true;
            lbl_confirmpassword.Location = new Point(51, 104);
            lbl_confirmpassword.Name = "lbl_confirmpassword";
            lbl_confirmpassword.Size = new Size(104, 15);
            lbl_confirmpassword.TabIndex = 12;
            lbl_confirmpassword.Text = "Confirm Password";
            // 
            // txtb_usernameR
            // 
            txtb_usernameR.Location = new Point(51, 34);
            txtb_usernameR.Name = "txtb_usernameR";
            txtb_usernameR.Size = new Size(100, 23);
            txtb_usernameR.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(64, 165);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtb_Confirmpass
            // 
            txtb_Confirmpass.Location = new Point(51, 122);
            txtb_Confirmpass.Name = "txtb_Confirmpass";
            txtb_Confirmpass.Size = new Size(100, 23);
            txtb_Confirmpass.TabIndex = 11;
            // 
            // lbl_passwordR
            // 
            lbl_passwordR.AutoSize = true;
            lbl_passwordR.Location = new Point(51, 60);
            lbl_passwordR.Name = "lbl_passwordR";
            lbl_passwordR.Size = new Size(57, 15);
            lbl_passwordR.TabIndex = 8;
            lbl_passwordR.Text = "Password";
            // 
            // txtb_passwordR
            // 
            txtb_passwordR.Location = new Point(51, 78);
            txtb_passwordR.Name = "txtb_passwordR";
            txtb_passwordR.Size = new Size(100, 23);
            txtb_passwordR.TabIndex = 7;
            // 
            // lbl_usernameR
            // 
            lbl_usernameR.AutoSize = true;
            lbl_usernameR.Location = new Point(51, 16);
            lbl_usernameR.Name = "lbl_usernameR";
            lbl_usernameR.Size = new Size(60, 15);
            lbl_usernameR.TabIndex = 9;
            lbl_usernameR.Text = "Username";
            // 
            // grpb_Login
            // 
            grpb_Login.BackColor = SystemColors.Control;
            grpb_Login.Controls.Add(label1);
            grpb_Login.Controls.Add(lnkl_register);
            grpb_Login.Controls.Add(txtb_username);
            grpb_Login.Controls.Add(btn_login);
            grpb_Login.Controls.Add(txtb_password);
            grpb_Login.Controls.Add(lbl_username);
            grpb_Login.Controls.Add(lbl_password);
            grpb_Login.Location = new Point(296, 159);
            grpb_Login.Name = "grpb_Login";
            grpb_Login.Size = new Size(200, 162);
            grpb_Login.TabIndex = 6;
            grpb_Login.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 115);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 7;
            label1.Text = "Dont have an Account?";
            // 
            // lnkl_register
            // 
            lnkl_register.AutoSize = true;
            lnkl_register.Location = new Point(145, 115);
            lnkl_register.Name = "lnkl_register";
            lnkl_register.Size = new Size(49, 15);
            lnkl_register.TabIndex = 6;
            lnkl_register.TabStop = true;
            lnkl_register.Text = "Register";
            lnkl_register.LinkClicked += lnkl_register_LinkClicked;
            // 
            // txtb_username
            // 
            txtb_username.Location = new Point(51, 37);
            txtb_username.Name = "txtb_username";
            txtb_username.Size = new Size(100, 23);
            txtb_username.TabIndex = 1;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(64, 133);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(75, 23);
            btn_login.TabIndex = 5;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // txtb_password
            // 
            txtb_password.Location = new Point(51, 80);
            txtb_password.Name = "txtb_password";
            txtb_password.Size = new Size(100, 23);
            txtb_password.TabIndex = 2;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Location = new Point(51, 19);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(60, 15);
            lbl_username.TabIndex = 4;
            lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(51, 62);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(57, 15);
            lbl_password.TabIndex = 3;
            lbl_password.Text = "Password";
            // 
            // grpb_Nav
            // 
            grpb_Nav.Controls.Add(btn_back);
            grpb_Nav.Controls.Add(btn_payment);
            grpb_Nav.Controls.Add(btn_checkin);
            grpb_Nav.Controls.Add(btn_rooms);
            grpb_Nav.Controls.Add(btn_Dashboard);
            grpb_Nav.Location = new Point(12, -1);
            grpb_Nav.Name = "grpb_Nav";
            grpb_Nav.Size = new Size(770, 36);
            grpb_Nav.TabIndex = 0;
            grpb_Nav.TabStop = false;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(6, 7);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(22, 23);
            btn_back.TabIndex = 4;
            btn_back.Text = "<";
            btn_back.UseVisualStyleBackColor = true;
            // 
            // btn_payment
            // 
            btn_payment.Location = new Point(296, 7);
            btn_payment.Name = "btn_payment";
            btn_payment.Size = new Size(75, 23);
            btn_payment.TabIndex = 3;
            btn_payment.Text = "Payment";
            btn_payment.UseVisualStyleBackColor = true;
            // 
            // btn_checkin
            // 
            btn_checkin.Location = new Point(215, 7);
            btn_checkin.Name = "btn_checkin";
            btn_checkin.Size = new Size(75, 23);
            btn_checkin.TabIndex = 2;
            btn_checkin.Text = "Check-in";
            btn_checkin.UseVisualStyleBackColor = true;
            // 
            // btn_rooms
            // 
            btn_rooms.Location = new Point(134, 7);
            btn_rooms.Name = "btn_rooms";
            btn_rooms.Size = new Size(75, 23);
            btn_rooms.TabIndex = 1;
            btn_rooms.Text = "Rooms";
            btn_rooms.UseVisualStyleBackColor = true;
            btn_rooms.Click += btn_rooms_Click;
            // 
            // btn_Dashboard
            // 
            btn_Dashboard.Location = new Point(53, 7);
            btn_Dashboard.Name = "btn_Dashboard";
            btn_Dashboard.Size = new Size(75, 23);
            btn_Dashboard.TabIndex = 0;
            btn_Dashboard.Text = "Dashboard";
            btn_Dashboard.UseVisualStyleBackColor = true;
            btn_Dashboard.Click += btn_Dashboard_Click;
            // 
            // MainPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnl_main);
            Controls.Add(grpb_Nav);
            Name = "MainPanel";
            Text = "Main";
            pnl_main.ResumeLayout(false);
            grpb_register.ResumeLayout(false);
            grpb_register.PerformLayout();
            grpb_Login.ResumeLayout(false);
            grpb_Login.PerformLayout();
            grpb_Nav.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_main;
        private GroupBox grpb_Nav;
        private Button btn_payment;
        private Button btn_checkin;
        private Button btn_rooms;
        private Button btn_Dashboard;
        private Button btn_login;
        private Label lbl_username;
        private Label lbl_password;
        private TextBox txtb_password;
        private TextBox txtb_username;
        private GroupBox grpb_Login;
        private Button btn_back;
        private GroupBox grpb_register;
        private Label lbl_confirmpassword;
        private TextBox txtb_usernameR;
        private Button button1;
        private TextBox txtb_Confirmpass;
        private Label lbl_passwordR;
        private TextBox txtb_passwordR;
        private Label lbl_usernameR;
        private Label label2;
        private LinkLabel lnkl_login;
        private Label label1;
        private LinkLabel lnkl_register;
    }
}
