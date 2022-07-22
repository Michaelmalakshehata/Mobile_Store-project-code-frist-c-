using DevExpress.XtraBars;
using main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace main
{
    public partial class Mobile_Store : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        #region refrence objects
        mobiles mobform;
        accessiers accform;
        Customer_Form custform;
        Form1 bilform;
        mobileformmain mobmain;
        accessoriesformmain accmain;
        Reports bilmain;
        #endregion
        public Mobile_Store()
        {
            InitializeComponent();
        }
        #region adding forms to main form
        private void AccordionControlElement4_Click(object sender, EventArgs e)
        {
            //////removes form all except this form
            container.Controls.Remove(accform);
            container.Controls.Remove(custform);
            container.Controls.Remove(bilform);
            container.Controls.Remove(mobform);

            container.Controls.Remove(mobmain);

            container.Controls.Remove(accmain);



            /////
            bilmain.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            bilmain.TopLevel = false;
            bilmain.AutoScroll = true;
            bilmain.Dock = DockStyle.Fill;
            container.Controls.Add(bilmain);
            bilmain.Show();
        }

        private void Mobdash_Click(object sender, EventArgs e)
        {
            //////removes form all except this form
            container.Controls.Remove(accform);
            container.Controls.Remove(custform);
            container.Controls.Remove(bilform);

            container.Controls.Remove(accmain);
            container.Controls.Remove(mobmain);


            container.Controls.Remove(bilmain);

            /////
            mobform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            mobform.TopLevel = false;
            mobform.AutoScroll = true;
            mobform.Dock = DockStyle.Fill;
            container.Controls.Add(mobform);
            mobform.Show();
        }

        private void Mobile_Store_Load(object sender, EventArgs e)
        {
            ///////objects forms of all project
            accform = new accessiers();
            mobform = new mobiles();
            custform = new Customer_Form();
            bilform = new Form1();
            mobmain = new mobileformmain();
            accmain = new accessoriesformmain();
            bilmain = new Reports();
            ////////////
            //////removes form all except this form
            container.Controls.Remove(accform);
            container.Controls.Remove(custform);
            container.Controls.Remove(bilform);
            container.Controls.Remove(mobform);

            container.Controls.Remove(accmain);


            container.Controls.Remove(bilmain);
            
            //////formload
            this.Size = new System.Drawing.Size(1300, 720);
            this.CenterToScreen();

            /////
            mobmain.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            mobmain.TopLevel = false;
            mobmain.AutoScroll = true;
            mobmain.Dock = DockStyle.Fill;
            container.Controls.Add(mobmain);
            mobmain.Show();
        }

        private void Accessdash_Click(object sender, EventArgs e)
        {
            //////removes form all except this form
            container.Controls.Remove(mobform);
            container.Controls.Remove(custform);
            container.Controls.Remove(bilform);
            container.Controls.Remove(accmain);
            container.Controls.Remove(mobmain);


            container.Controls.Remove(bilmain);

            ////////////
            accform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            accform.TopLevel = false;
            accform.AutoScroll = true;
            accform.Dock = DockStyle.Fill;
            container.Controls.Add(accform);
            accform.Show();
        }

        private void Mobile_Store_Resize(object sender, EventArgs e)
        {
            mobform.Height = container.Height;
          
            mobform.Width = container.Width;
            /////
            accform.Height = container.Height;
            accform.Width = container.Width;

        }

        private void Custdash_Click(object sender, EventArgs e)
        {
            //////removes form all except this form
            container.Controls.Remove(accform);
            container.Controls.Remove(mobform);
            container.Controls.Remove(bilform);
            container.Controls.Remove(accmain);
            container.Controls.Remove(mobmain);


            container.Controls.Remove(bilmain);
            ///////////////
            try
            {
                accessContext context = new accessContext();
                var dat = context.mobdetailes.Select(n => n.name).ToList();
                var dat2 = context.accdetailes.Select(n => n.name).ToList();
                List<string> lsdat = new List<string>();
                lsdat.AddRange(dat);
                lsdat.AddRange(dat2);
                custform.combomob.DataSource = lsdat;
                custform.combomob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
                custform.combomob.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                custform.combomob.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch
            {

            }
            
            ///
            custform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            custform.TopLevel = false;
            custform.AutoScroll = true;
            custform.Dock = DockStyle.Fill;
            container.Controls.Add(custform);
            custform.Show();
        }

        private void Bills_Click(object sender, EventArgs e)
        {
            //////removes form all except this form
            container.Controls.Remove(accform);
            container.Controls.Remove(custform);
            container.Controls.Remove(mobform);
            container.Controls.Remove(accmain);
            container.Controls.Remove(mobmain);


            container.Controls.Remove(bilmain);

            try
            {
                accessContext context = new accessContext();

                var dat2 = context.customerProducts.Select(n => n.CustomerPhone).Distinct().ToList();
                bilform.combphones.DataSource =dat2;
                ///get last customer phone
                int last = context.customerProducts.Max(b => b.ID);
                var x = context.customerProducts.Where(v => v.ID == last).Select(v => v.CustomerPhone).FirstOrDefault();
                bilform.combphones.Text = x.ToString();

                bilform.combphones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
                bilform.combphones.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                bilform.combphones.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
            catch
            {
                bilform.combphones.Text = 0.ToString();
                MessageBox.Show("not found customer product");
            }
    bilform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            bilform.TopLevel = false;
            bilform.AutoScroll = true;
            bilform.Dock = DockStyle.Fill;
            container.Controls.Add(bilform);
            bilform.Show();
        }

        private void Mob_Click(object sender, EventArgs e)
        {
            //////removes form all except this form
            container.Controls.Remove(accform);
            container.Controls.Remove(custform);
            container.Controls.Remove(bilform);
            container.Controls.Remove(mobform);

            container.Controls.Remove(accmain);


            container.Controls.Remove(bilmain);


            /////
            mobmain.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            mobmain.TopLevel = false;
            mobmain.AutoScroll = true;
            mobmain.Dock = DockStyle.Fill;
            container.Controls.Add(mobmain);
            mobmain.Show();
        }

        private void Acc_Click(object sender, EventArgs e)
        {
            //////removes form all except this form
            container.Controls.Remove(accform);
            container.Controls.Remove(custform);
            container.Controls.Remove(bilform);
            container.Controls.Remove(mobform);

            container.Controls.Remove(mobmain);


            container.Controls.Remove(bilmain);


            /////
            accmain.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            accmain.TopLevel = false;
            accmain.AutoScroll = true;
            accmain.Dock = DockStyle.Fill;
            container.Controls.Add(accmain);
            accmain.Show();
        }

       
        #endregion

        private void AccordionControlElement1_Click(object sender, EventArgs e)
        {
           
            loginform log = new loginform();
            log.Show();
            this.Hide();
        }

        private void AccordionControlElement2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Container_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
