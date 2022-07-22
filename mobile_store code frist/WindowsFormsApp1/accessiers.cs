using System;
using System.Linq;
using System.Windows.Forms;
namespace main
{
    public partial class accessiers : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// this form contain form of mobile detailes and mobile images 
        /// explain this form have a panel and tool menu stripe and panel have controls 
        /// to add form of mobiles detailes and mobiles images and moved between them by remove 
        /// and adds controles with menustripe
        /// </summary>
        //declare variables
        #region variables
        accessdetails accform;
        accessimages imgform;
        #endregion
        public accessiers()
        {
           
            InitializeComponent();
        }
        ///form-load load to add start page to main form
        #region load
        private void Accessiers_Load(object sender, EventArgs e)
        {
            accform = new accessdetails();
            imgform = new accessimages();
            accform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            accform.TopLevel = false;
            accform.AutoScroll = true;
            this.Controls.Add(accform);
            accform.Show();
        }
        #endregion

        
        //form of mobiles detailes and mobile image resize when the main for resize
        #region resize
        //private void Mobiles_Resize(object sender, EventArgs e)
        //{
        //    accform.Height = this.Height;
        //    accform.Width = this.Width;
        //    imgform.Height = this.Height;
        //    imgform.Width = this.Width;
        //}
        #endregion

        //set the mobile detaile form on panel of main form

        private void ToolStripLabel1_Click_1(object sender, EventArgs e)
        {
            this.Controls.Remove(imgform);
            accform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            accform.TopLevel = false;
            accform.AutoScroll = true;
            this.Controls.Add(accform);
            accform.Show();
        }

        private void ToolStripLabel2_Click_1(object sender, EventArgs e)
        {

            this.Controls.Remove(accform);
            imgform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            imgform.TopLevel = false;
            imgform.AutoScroll = true;
            this.Controls.Add(imgform);
            imgform.Show();

        }

        private void Btnrefresh_Click_1(object sender, EventArgs e)
        {
            if (this.Contains(accform))
            {
                this.Controls.Clear();
                this.InitializeComponent();
                this.ToolStripLabel1_Click_1(sender, e);
                this.accform.Accessdetails_Load(sender, e);

            }
            else
            {
                this.Controls.Clear();
                this.InitializeComponent();
                this.ToolStripLabel2_Click_1(sender, e);
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            if (this.Contains(accform))
            {
                DialogResult ressult = MessageBox.Show("Are you sure to start new ?it is recommended you save your work frist.this cannot be undone.", "Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ressult == DialogResult.Yes)
                {
                    accform.reset();
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
        }
    }
}