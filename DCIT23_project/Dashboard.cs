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
    public partial class Dashboard : Form
    {
        private static Dashboard instance;
        public static Dashboard Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new Dashboard();
                }
                return instance;
            }
        }
        public Dashboard()
        {
            InitializeComponent();
        }
    }
}
