using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCIT23_project
{
    public partial class Rooms : Form
    {
        private void loadform(Form form)
        {
            //remove existing controls from this panel before adding a new form
            pnl_rooms.Controls.Clear();

            //configure and add the new form
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            pnl_rooms.Controls.Add(form);
            form.Show();
        }
        private static Rooms instance;
        public static Rooms Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new Rooms();
                }
                return instance;
            }
        }
        public Rooms()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loadform(Regular.Instance);      
        }
    }
}
