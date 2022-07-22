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

namespace main
{
    public partial class accessdetails : DevExpress.XtraEditors.XtraForm
    {
        //declare variables
        #region  variables
        string accname;
        double accprice;
        string acctype;
        int accquantity;
        double accwarrenty;
        string accdate;
        accessContext context;
        accessierdetaile objectacc;
        BindingSource bdata;
        accessimages objectimg;
        #endregion
        public accessdetails()
        {
            InitializeComponent();
        }
        //form load
        #region load
        public void Accessdetails_Load(object sender, EventArgs e)
        {
            ///objects
            objectimg = new accessimages();
            context = new accessContext();
            objectacc = new accessierdetaile();
            ////load database
            var datashows = context.accdetailes.Select(n => new { n.id, n.name, n.price, n.type, n.quantity, n.warranty, n.date }).ToList();
            bdata = new BindingSource();
            bdata.DataSource = datashows;
            griddatabase.DataSource = bdata;
            ////style of selected index
            griddatabase.DefaultCellStyle.SelectionBackColor = Color.PowderBlue;
            griddatabase.DefaultCellStyle.SelectionForeColor = Color.Red;
            ///change grid view font size
            griddatabase.DefaultCellStyle.Font = new Font("Tahoma", 12);
            ///make default for combobox order by 
            combocategory.SelectedItem = null;
            combocategory.Text = "name";

        }
        #endregion
        ///intializing inputs
        #region inputs
        private void Textprice_EditValueChanged(object sender, EventArgs e)
        {
            if (textprice.Text != "")
            {
                accprice = double.Parse(textprice.Text);
            }
            else
            {
                MessageBox.Show("invalid inputs");
            }
        }
      

        
        private void Textquantity_EditValueChanged(object sender, EventArgs e)
        {
            try { 
            accquantity = int.Parse(textquantity.Text);
              }
            catch
            {
                MessageBox.Show("invalid number");
            }
       }

        private void Textwarranty_EditValueChanged(object sender, EventArgs e)
        {
            try { 
            accwarrenty = double.Parse(textwarranty.Text);
          }
            catch
            {
                MessageBox.Show("invalid number");
            }
}
      
        private void Textnm_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (textnm.Text.Trim() != "")
                {
                    accname = textnm.Text.ToString().ToLower();
                }

            }
            catch
            {
                MessageBox.Show("invalid name");
            }

        }
       

        private void Texttype_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (texttype.Text.Trim() != "")
                {
                    acctype = texttype.Text.ToString().ToLower();
                }

            }
            catch
            {
                MessageBox.Show("invalid type");
            }
        }
        private void Datetext_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (datetext.Text.Trim() != "")
                {
                    accdate = datetext.Text.ToString().ToLower();
                }

            }
            catch
            {
                MessageBox.Show("invalid date");
            }
        }
        #endregion

        #region add
        private void Btnadd_Click(object sender, EventArgs e)
        {
            if (accname == null || accprice == 0 || accquantity == 0)
            {
                MessageBox.Show("invalid inputs");
            }
            else
            {
                bool ad = objectacc.Add(accname, accprice, acctype, accquantity, accwarrenty, accdate);
                if (ad == true)
                {
                    griddatabase.Rows.Clear();
                    griddatabase.Refresh();
                    this.Accessdetails_Load(sender, e);
                    MessageBox.Show("added");

                }
                else
                {
                    griddatabase.Rows.Clear();
                    griddatabase.Refresh();
                    this.Accessdetails_Load(sender, e);
                    MessageBox.Show("the item already exist and increase quantity by= " + accquantity);
                }

            }
          
        }

        #endregion

        #region update
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (accname == null && accprice == 0 && accquantity == 0)
            {
                MessageBox.Show("invalid inputs");
            }
            else
            {
                bool ad = objectacc.update(accname, accprice, acctype, accquantity, accwarrenty, accdate);
                if (ad == true)
                {
                    griddatabase.Rows.Clear();
                    griddatabase.Refresh();
                    this.Accessdetails_Load(sender, e);
                    MessageBox.Show("Updated");

                }
                else
                {
                    MessageBox.Show("can not update this item");
                }

            }
        }
        #endregion 
               
        #region reset
        public void reset()
        {

            textprice.EditValue = 0;
            textwarranty.EditValue = 0;
            textquantity.EditValue = 0;

            textnm.Text = "";
            datetext.Text = "";
            textsearch.Text = "";
            texttype.Text = "";
        }




        #endregion

        #region search
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string textsr = textsearch.Text.ToString().ToLower();
            if (textsearch.Text.Trim() != "")
            {
                try
                {
                    var srch = context.accdetailes.Where(m => m.name == textsr).Select(m => m.id).FirstOrDefault();
                    this.search(srch);
                }
                catch
                {
                    MessageBox.Show("Can't find Accessiers name");
                }

            }
        }
        private void search(int d)
        {
            var val = context.accdetailes.Single(n => n.id == d);
            textnm.Text = val.name;
            textprice.Text = val.price.ToString();
            texttype.Text = val.type;
            textquantity.Text = val.quantity.ToString();
            textwarranty.Text = val.warranty.ToString();
            datetext.Text = val.date;
        }
        #endregion

        #region arrange
        private void btnorder_Click(object sender, EventArgs e)
        {
            griddatabase.Rows.Clear();
            griddatabase.Refresh();

            if (combocategory.Text == "name")
            {
                var datashows = context.accdetailes.Select(n => new { n.id, n.name, n.price, n.type, n.quantity, n.warranty, n.date }).ToList().OrderBy(r => r.name);
                bdata = new BindingSource();
                bdata.DataSource = datashows;
                griddatabase.DataSource = bdata;
            }
            else if (combocategory.Text == "price")
            {
                var datashows = context.accdetailes.Select(n => new { n.id, n.name, n.price, n.type, n.quantity, n.warranty, n.date }).ToList().OrderByDescending(r => r.price);
                bdata = new BindingSource();
                bdata.DataSource = datashows;
                griddatabase.DataSource = bdata;
            }
            else if (combocategory.Text == "quantity")
            {
                var datashows = context.accdetailes.Select(n => new { n.id, n.name, n.price, n.type, n.quantity, n.warranty, n.date }).ToList().OrderByDescending(r => r.quantity);
                bdata = new BindingSource();
                bdata.DataSource = datashows;
                griddatabase.DataSource = bdata;
            }
            else if (combocategory.Text == "date")
            {
                var datashows = context.accdetailes.Select(n => new { n.id, n.name, n.price, n.type, n.quantity, n.warranty, n.date }).ToList().OrderBy(r => r.date);
                bdata = new BindingSource();
                bdata.DataSource = datashows;
                griddatabase.DataSource = bdata;
            }
        }
        #endregion

        #region Delete 
        private void btndelete_Click(object sender, EventArgs e)
        {
            int del = context.accdetailes.Where(n => n.name == accname).Select(n => n.id).FirstOrDefault();
            if (del != 0)
            {
                try
                {
                    var confirm = MessageBox.Show("Are you sure to delete this item ??", "confirm delete", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        var remov = (accessierdetaile)context.accdetailes.Where(i => i.id == del).First();
                        context.accdetailes.Remove(remov);
                        context.SaveChanges();
                        griddatabase.Rows.Clear();
                        griddatabase.Refresh();
                        this.Accessdetails_Load(sender, e);
                        MessageBox.Show("the item deleted");
                    }
                    else
                    {
                        MessageBox.Show("the item not deleted");
                    }
                }
                catch
                {
                    MessageBox.Show("can't remove this item , frist you must remove his images from Accessories images");
                }
            }
            else
            {
                MessageBox.Show("the item can't deleted");
            }
        }
        #endregion

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void griddatabase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            this.reset();
            int x = e.RowIndex;
            DataGridViewRow row = griddatabase.Rows[x];
            try
            {
                textnm.Text = row.Cells[1].Value.ToString();
                textprice.Text = row.Cells[2].Value.ToString();
                texttype.Text = row.Cells[3].Value.ToString();
                textquantity.Text = row.Cells[12].Value.ToString();
                textwarranty.Text= row.Cells[13].Value.ToString();
            }
            catch
            {
                this.nullvalue();
            }
        }

        public void nullvalue()
        {
            if (textnm.Text == "") { textnm.Text = ""; }
            if (textprice.Text== "") { textprice.Text= ""; }
            if (texttype.Text == "") { texttype.Text = ""; }
            if (textquantity.Text == "") { textquantity.Text= ""; }
            if (textwarranty.Text == "") { textwarranty.Text = ""; }
        }
    
    }
}