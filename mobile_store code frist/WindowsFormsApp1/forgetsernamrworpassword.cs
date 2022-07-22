using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public partial class forgetsernamrworpassword : Form
    {
        public forgetsernamrworpassword()
        {
            InitializeComponent();
        }
        int i = 3;


     
        SqlConnection conn = new SqlConnection("Data Source = DESKTOP-2LNGRRO\\MSSQLSERVER01; Initial Catalog = mobilestore; Integrated Security = True");
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txt_securityquestion.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txt_securityanswer.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            txt_user.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            txt_pass.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            txt_confirm.Focus();
        }

        private void label6_MouseDown(object sender, MouseEventArgs e)
        {
            //toolTip1.SetToolTip(label6, "please write your answer");

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txt_pass.PasswordChar = '\0';
                txt_confirm.PasswordChar = '\0';
            }
            else
            {
                txt_pass.PasswordChar = '*';
                txt_confirm.PasswordChar = '*';
            }
        }

        private void Btn_submitanswer_Click_1(object sender, EventArgs e)
        {
            accessContext db = new accessContext();
            var q = db.Users.Select(y => y).Where(u => u.Check_Answer == txt_securityquestion.Text && u.Name == txt_user.Text && u.Answer == txt_securityanswer.Text).FirstOrDefault();
            var q2 = db.Users.Where(u => u.Name == txt_user.Text).Select(y => y.Id).FirstOrDefault();
            var q_id = q2;
            var q3 = db.Users.Select(y => y).Where(u => u.Id == q_id).FirstOrDefault();

            if ((txt_user.Text != null) && (txt_securityquestion.Text != null) && (txt_securityanswer.Text != null) && (txt_pass.Text != null) && (txt_pass.Text == txt_confirm.Text))
            {
                if (q != null)
                {
                    try
                    {

                        conn.Open();
                        SqlCommand sqlCommand = new SqlCommand("update users set Password=@Password,Confirm_Password =@Confirm_Password where Name = '" + txt_user.Text + "' AND Check_Answer = '" + txt_securityquestion.Text + "' AND Answer = '" + txt_securityanswer.Text + "'", conn);
                        sqlCommand.Parameters.AddWithValue("@Password", int.Parse(txt_pass.Text));
                        sqlCommand.Parameters.AddWithValue("@Confirm_Password", int.Parse(txt_confirm.Text));
                        sqlCommand.ExecuteNonQuery();

                        conn.Close();
                        /*q.Password = int.Parse(txt_pass.Text);
                        q.Confirm_Password = int.Parse(txt_confirm.Text);*/

                        MessageBox.Show("Updated", "Thanks", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Hide();

                    }
                    catch (Exception)
                    {

                        i--;
                        MessageBox.Show("Invalid, you have '" + i + "' times");
                    }
                    finally
                    {
                        conn.Close();
                    }


                }
                else if(i>0)
                {
                    i--;
                    MessageBox.Show($"You Entered Wrong Data You Have {i} Times");

                }
               else if (i == 0 && q2!=0)
                {

                    
                    if (q2 != 0 && q3 != null&&i==0)
                    {
                        db.Users.Remove(q3);
                        db.SaveChanges();
                            MessageBox.Show("user was deleted from database please create new user");
                            this.Hide();
                        
                    }
                    
                  
                }
                else if (i == 0 && q2 == 0 && q3 == null)
                {
                    MessageBox.Show("'" + txt_user + "' not found", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Hide();
                   
                    i = 3;
                }

            }
            else
            {
                MessageBox.Show("You should fill all boxes");
            }
        }

        private void Btn_cancelation_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
