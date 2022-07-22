using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WindowsFormsApp1
{
    public partial class mobiles : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// this form contain form of mobile detailes and mobile images 
        /// explain this form have a panel and tool menu stripe and panel have controls 
        /// to add form of mobiles detailes and mobiles images and moved between them by remove 
        /// and adds controles with menustripe
        /// </summary>
        //declare variables
        #region variables
        mobiledetails mobform;
        mobilesimges imgform;
        #endregion
        public mobiles()
        {
            InitializeComponent();
        }
        ///form-load load to add start page to main form
        #region load
        private void Mobiles_Load(object sender, EventArgs e)
        {
            mobform = new mobiledetails();
            imgform = new mobilesimges();
            mobform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            mobform.TopLevel = false;
            mobform.AutoScroll = true;
            this.Controls.Add(mobform);
            mobform.Show();
        }
        #endregion

        //form of mobiles detailes and mobile image resize when the main for resize
        #region resize
        private void Mobiles_Resize(object sender, EventArgs e)
        {
            //mobform.Height = this.panel1.Height;
            //mobform.Width = this.panel1.Width;
            //imgform.Height = this.panel1.Height;
            //imgform.Width = this.panel1.Width;
        }
        #endregion

        //set the mobile detaile form on panel of main form
        #region add form 1
        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {
       
            this.Controls.Remove(imgform);
            mobform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            mobform.TopLevel = false;
            mobform.AutoScroll = true;
            this.Controls.Add(mobform);
            mobform.Show();
        }
        #endregion

        ///set the mobile dimages on panel of main form
        #region add form 2
        private void ToolStripLabel2_Click(object sender, EventArgs e)
        {
            
            this.Controls.Remove(mobform);
            imgform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            imgform.TopLevel = false;
            imgform.AutoScroll = true;
            this.Controls.Add(imgform);
            imgform.Show();
        }
        #endregion

        //button refresh that initialize controls and reload data
        #region refresh
        private void Btnrefresh_Click(object sender, EventArgs e)
        {
            if(this.Contains(mobform))
            {
                this.Controls.Clear();
                this.InitializeComponent();
                this.ToolStripLabel1_Click(sender, e);
               this.mobform.Mobiledetails_Load(sender, e);
               
            }
            else
            {
                this.Controls.Clear();
                this.InitializeComponent();
                this.ToolStripLabel2_Click(sender, e);
            }
            
        }
        #endregion

        //button reset page that call reset function
        #region reset
        private void Reset_Click(object sender, EventArgs e)
        {
            if (this.Contains(mobform))
            {
                DialogResult ressult = MessageBox.Show("Are you sure to start new ?it is recommended you save your work frist.this cannot be undone.", "Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ressult == DialogResult.Yes)
                {
                    mobform.reset();
                }
            }
            else
            {
                DialogResult ressult = MessageBox.Show("Are you sure to start new ?it is recommended you save your work frist.this cannot be undone.", "Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ressult == DialogResult.Yes)
                {

                    imgform.reset();
                }
            }
            #endregion
        }
    }
}