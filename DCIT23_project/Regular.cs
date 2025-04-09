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
    public partial class Regular : Form
    {
        private static Regular instance;
        public static Regular Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new Regular();
                }
                return instance;
            }
        }
        public Regular()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            
        }
    }
}
