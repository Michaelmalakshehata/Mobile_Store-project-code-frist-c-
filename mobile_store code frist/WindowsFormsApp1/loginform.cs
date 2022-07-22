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
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        accessContext c1 = new accessContext();

        private void Btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_userpassward.Text.ToString().ToLower();

            try
            {

                var q = c1.Users.Where(u => u.Name == username && u.Password == password).Select(u => u.Id).FirstOrDefault();
                if (q != 0)
                {
                    Mobile_Store c = new Mobile_Store();
                    c.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("login failed");

                }
            }
            catch
            {
                MessageBox.Show("login failed");

            }


        }

        private void Btn_backtoregister_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            serialform sf = new serialform();
            sf.ShowDialog();
            this.Hide();
            /*Form1 f = new Form1();
            f.ShowDialog();*/
        }
     

      

        private void label1_Click(object sender, EventArgs e)
        {
            txt_username.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txt_userpassward.Focus();
        }

    

        

        private void Label3_Click_1(object sender, EventArgs e)
        {
            forgetsernamrworpassword f = new forgetsernamrworpassword();
            f.ShowDialog();
            f.TopMost = true;
        }

       

        private void CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txt_userpassward.PasswordChar = '\0';

            }
            else
            {
                txt_userpassward.PasswordChar = '*';
            }
        }

        private void Loginform_Load(object sender, EventArgs e)
        {
            lnm.Text = "Powered by michael";
        }
    }
    }