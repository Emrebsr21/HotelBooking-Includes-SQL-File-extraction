using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projPRG455
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            pictureBoxExit.Click += new EventHandler(CloseApp);
            pictureBoxMin.Click += new EventHandler(MinimizeApp);
        }

        private void CloseApp(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MinimizeApp(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
