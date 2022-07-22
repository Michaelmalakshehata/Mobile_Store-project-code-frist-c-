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
    public partial class serialform : Form
    {
        public serialform()
        {
            InitializeComponent();
        }
       

        private void serialform_Load(object sender, EventArgs e)
        {
            txt_serialnumber.Focus();
        }

       

        private void CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_serialnumber.PasswordChar = '\0';
            }
            else
            {
                txt_serialnumber.PasswordChar = '*';
            }
        }

        private void Btn_validate_Click_1(object sender, EventArgs e)
        {
            if (txt_serialnumber.Text == "AB12-CD34-EF56-GH78")
            {
                this.Close();
                register f = new register();
                f.ShowDialog();
            }
            else
                MessageBox.Show("Invalid ");
            this.Close();
            loginform log = new loginform();
            log.Show();
        }
    }
}
