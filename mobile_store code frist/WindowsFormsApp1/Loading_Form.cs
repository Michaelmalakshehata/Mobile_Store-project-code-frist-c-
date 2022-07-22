using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public partial class Loading_Form : Form
    {
        public Loading_Form()
        {
            InitializeComponent();
        }

        private void Loading_Form_Load(object sender, EventArgs e)
        {
            lnm.Text = "Powered by michael";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 10;
            if (panel2.Width >= 699)
            {
                timer1.Stop();
                loginform f = new loginform();
                f.Show();
                this.Hide();
            }
        }
    }
}
