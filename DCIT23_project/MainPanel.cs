namespace DCIT23_project
{
    public partial class MainPanel : Form
    {
        private void loadform(Form form)
        {
            //remove existing controls from this panel before adding a new form
            pnl_main.Controls.Clear();

            //configure and add the new form
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            pnl_main.Controls.Add(form);
            form.Show();
        }
        public MainPanel()
        {
            InitializeComponent();
            grpb_Nav.Visible = false; // Initially hide the navigation group box
            btn_back.Visible = false;
            grpb_Login.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txtb_username.Text == "admin" && txtb_password.Text == "admin")
            {
                MessageBox.Show("Login successful!");
                loadform(Dashboard.Instance);
                grpb_Nav.Visible = true;  // Show the navigation group box on successful login
                grpb_Nav.BringToFront();
                grpb_Login.Visible = false;
                // Here you can add code to navigate to the main application
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            loadform(Dashboard.Instance);
        }

        private void btn_rooms_Click(object sender, EventArgs e)
        {
            loadform(Rooms.Instance);
        }

        private void lnkl_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            grpb_register.Visible = true;
            grpb_Login.Visible = false;
        }

        private void lnkl_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            grpb_Login.Visible = true;
            grpb_register.Visible = false;
        }
    }
}
