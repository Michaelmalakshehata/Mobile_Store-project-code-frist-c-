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
    public partial class register : Form
    {
        string nm;
        int ph;
        string pass;
        string ques;
        string ansr;
        string passcon;
        public register()
        {
            InitializeComponent();
            error.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();

        }
        accessContext context = new accessContext();

     

        private void lab_name_Click(object sender, EventArgs e)
        {
            txt_name.Focus();
        }

        private void lab_phone_Click(object sender, EventArgs e)
        {
            txt_phone.Focus();
        }

        private void lab_pass_Click(object sender, EventArgs e)
        {
            txt_password.Focus();
        }

        private void lab_conpass_Click(object sender, EventArgs e)
        {
            txt_conpass.Focus();
        }

        private void lab_chkq_Click(object sender, EventArgs e)
        {
            txt_chkq.Focus();
        }

        private void lab_ans_Click(object sender, EventArgs e)
        {
            txt_ans.Focus();
        }

        private void txt_ans_MouseHover(object sender, EventArgs e)
        {
            //toolTip1.SetToolTip(txt_ans, "please write your answer");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txt_password.PasswordChar = '\0';
                txt_conpass.PasswordChar = '\0';
            }
            else
            {
                txt_password.PasswordChar = '*';
                txt_conpass.PasswordChar = '*';

            }
        }

        private void Txt_chkq_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (txt_chkq.Text == null)
                label5.Show();
            else
                label5.Hide();
            ques = txt_chkq.Text.ToString().ToLower();
        }

        private void Btn_register_Click_1(object sender, EventArgs e)
        {
            var exist = context.Users.Where(n => n.Name == nm).Select(n => n.Id).FirstOrDefault();
            if ((txt_password.Text == txt_conpass.Text && txt_name.Text != "" && txt_phone.Text != "" && txt_password.Text != "" && txt_chkq.Text != "" && txt_ans.Text != "" && txt_name.Text.Length >= 3)&& exist ==0)
            {


                user u1 = new user(nm, ph, pass, passcon, ques, ansr);
                context.Users.Add(u1);
                context.SaveChanges();
                MessageBox.Show("Successed Regisration");

                this.Close();

              

            }
            else if(exist!=0)
            {
                MessageBox.Show("user already exist");

            }
            else if (txt_name.Text == null || txt_name.Text.Length < 3)
            {
                label2.Show();
            }
            else if (txt_phone.Text == null)
            {
                label3.Show();
            }
            else if (txt_password.Text == null)
            {
                label4.Show();
            }
            else if (txt_chkq.Text == null)
            {
                label5.Show();
            }
            else if (txt_ans.Text == null)
            {
                label6.Show();
            }
            else
            {
                error.Show();
            }
        }

        private void Txt_phone_TextChanged_1(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_phone.Text, out ph))
            {
                MessageBox.Show("Accept only numbers");
                label3.Show();
            }   
            else
                label3.Hide();
        }

        private void Txt_name_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_name.Text.Length < 3 || txt_name.Text == null)
            {
                label2.Show();

            }
            else
            {
                label2.Hide();
                nm = txt_name.Text.ToString().ToLower();


            }
        }

        private void Txt_conpass_TextChanged(object sender, EventArgs e)
        {
            if (txt_password.Text != txt_conpass.Text)
                label5.Show();
            else
                label5.Hide();
            passcon = txt_conpass.Text.ToString().ToLower();
        }

        private void Txt_password_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_password.Text == null)
                label4.Show();
            else
                label4.Hide();
            pass = txt_password.Text.ToString().ToLower();
        }

        private void Txt_ans_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_ans.Text == null)
                label6.Show();
            else
                label6.Hide();
            ansr = txt_ans.Text.ToString().ToLower();
        }
    }

}
