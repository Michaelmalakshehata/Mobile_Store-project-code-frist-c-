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
using System.Text.RegularExpressions;
using main;

namespace WindowsFormsApp1
{
    public partial class mobiledetails : DevExpress.XtraEditors.XtraForm
    {
        //declare variables
        #region  variables
        string mobname="";
        double mobprice=0;
        double mobscreen=0;
        int mobstorage=0;
        int mobram=0;
        int mobbattery=0;
        int mobfrontcamera=0;
        int mobbackcamera=0;
        string mobprocessor="";
        string mobandroid="";
        string mobnetwork="";
        int mobquantity=0;
        double mobwarrenty=0;
        string mobdate;
        Regex reg;
        accessContext context;
        mobildetaile objectmob;
        BindingSource bdata;
        mobilesimges objectimg;
        #endregion
        public mobiledetails()
        {
            InitializeComponent();
        }
        //form load
        #region load
        public void Mobiledetails_Load(object sender, EventArgs e)
        {
            ///objects
            objectimg = new mobilesimges();
            context = new accessContext();
            objectmob = new mobildetaile();
            ////load database
            var datashows = context.mobdetailes.Select(n => new { n.id, n.name, n.price, n.screen, n.storage, n.ram, n.battery, n.front_camera, n.back_camera, n.processor, n.android, n.network, n.quantity, n.warranty, n.date}).ToList();
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
            reg = new Regex(@"\d$");

        }
        #endregion

        ///intializing inputs
          #region inputs

        private void Textnm__TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textnm.Texts.Trim() != "")
                {
                    mobname = textnm.Texts.ToString().ToLower();
                }

              }
            catch
            {

                MessageBox.Show("invalid name");
            }
        }

        private void Textprice__TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textprice.Texts,out mobprice))
            {
                MessageBox.Show("Accept only numbers");
            }
        }

        private void Textscreen__TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textscreen.Texts, out mobscreen))
            {
                MessageBox.Show("Accept only numbers");
            }
        }

        private void Textstorage__TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textstorage.Texts, out mobstorage))
            {
                MessageBox.Show("Accept only numbers");
            }
        }

        private void Textram__TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textram.Texts, out mobram))
            {
                MessageBox.Show("Accept only numbers");
            }
        }

        private void Textbattery__TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textbattery.Texts, out mobbattery))
            {
                MessageBox.Show("Accept only numbers");
            }
        }

        private void Textfrontcamera__TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textfrontcamera.Texts, out mobfrontcamera))
            {
                MessageBox.Show("Accept only numbers");
            }
        }

        private void Textbackcamera__TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textbackcamera.Texts, out mobbackcamera))
            {
                MessageBox.Show("Accept only numbers");
            }
        }

        private void Textprocessor__TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textprocessor.Texts.Trim() != "")
                {
                    mobprocessor = textprocessor.Texts.ToString().ToLower();
                }

            }
            catch
            {
                MessageBox.Show("invalid processor");
            }
        }

        private void Textandroid__TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textandroid.Texts.Trim() != "")
                {
                    mobandroid = textandroid.Texts.ToString().ToLower();
                }

            }
            catch
            {
                MessageBox.Show("invalid android");
            }
        }

        private void Textnetwork__TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textnetwork.Texts.Trim() != "")
                {
                    mobnetwork = textnetwork.Texts.ToString().ToLower();
                }

            }
            catch
            {
                MessageBox.Show("invalid network");
            }
        }

        private void Textquantity__TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textquantity.Texts, out mobquantity))
            {
                MessageBox.Show("Accept only numbers");
            }
        }

        private void Textwarranty__TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textwarranty.Texts, out mobwarrenty))
            {
                MessageBox.Show("Accept only numbers");
            }
        }
        private void Datetext_EditValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (datetext.Text.Trim() != "")
                {
                    mobdate = datetext.Text.ToString();
                }

            }
            catch
            {
                MessageBox.Show("invalid date");
            }
        }
        #endregion


        /// button to add mobile detailes using function in class mobildetaile
        #region add
        private void Btnadd_Click_1(object sender, EventArgs e)
        {
            if (mobname == "" || mobprice == 0 || mobquantity == 0)
            {
                MessageBox.Show("invalid inputs");
            }
            else
            {
                bool ad = objectmob.Addnotitmexist(mobname, mobprice, mobscreen, mobstorage, mobram, mobbattery, mobfrontcamera, mobbackcamera, mobprocessor, mobandroid, mobnetwork, mobquantity, mobwarrenty, mobdate);
                if (ad == true)
                {
                    griddatabase.Rows.Clear();
                    griddatabase.Refresh();
                    this.Mobiledetails_Load(sender, e);
                    MessageBox.Show("added");

                }
                else
                {
                    var confirm = MessageBox.Show("Are you sure to increase item quantity ??", "confirm delete", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        this.objectmob.additmexist(mobname, mobprice, mobscreen, mobstorage, mobram, mobbattery, mobfrontcamera, mobbackcamera, mobprocessor, mobandroid, mobnetwork, mobquantity, mobwarrenty, mobdate);
                        griddatabase.Rows.Clear();
                        griddatabase.Refresh();
                        this.Mobiledetails_Load(sender, e);
                        MessageBox.Show("the item increased his quantity by= " + mobquantity);
                    }
                    else
                    {
                        MessageBox.Show("the quantity not increased");
                    }
                }

            }
        }
        #endregion

        // search button for mobile name and set the data in the controls
        #region search

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            string textsr = textsearch.Texts.ToString().ToLower();
            if (textsearch.Texts.Trim() != "")
            {
                try
                {
                    var srch = context.mobdetailes.Where(m => m.name == textsr).Select(m => m.id).FirstOrDefault();
                    this.reset();
                    this.search(srch);
                }
                catch
                {
                    MessageBox.Show("Can't find mobile name");
                }

            }
        }
        private void search(int d)
        {

            var val = context.mobdetailes.Single(n => n.id == d);
            try
            {
                textnm.Texts = val.name.ToString();
                textprice.Texts = val.price.ToString();
                textscreen.Texts = val.screen.ToString();
                textstorage.Texts = val.storage.ToString();
                textram.Texts = val.ram.ToString();
                textbattery.Texts = val.battery.ToString();
                textfrontcamera.Texts = val.front_camera.ToString();
                textbackcamera.Texts = val.back_camera.ToString();
                textprocessor.Texts = val.processor.ToString();
                textandroid.Texts = val.android.ToString();
                textnetwork.Texts = val.network.ToString();
                textquantity.Texts = val.quantity.ToString();
                textwarranty.Texts = val.warranty.ToString();
                datetext.Text = val.date;
            }
            catch
            {
                this.nullvalue();
            }
        }
        #endregion

        // order button for arrange the gridview based on name and price and quantity and date
        #region order
        private void SimpleButton2_Click(object sender, EventArgs e)
        {
            griddatabase.Rows.Clear();
            griddatabase.Refresh();

            if (combocategory.Text == "name")
            {
                var datashows = context.mobdetailes.Select(n => new { n.id, n.name, n.price, n.screen, n.storage, n.ram, n.battery, n.front_camera, n.back_camera, n.processor, n.android, n.network, n.quantity, n.warranty, n.date }).ToList().OrderBy(r => r.name);
                bdata = new BindingSource();
                bdata.DataSource = datashows;
                griddatabase.DataSource = bdata;
            }
            else if (combocategory.Text == "price")
            {
                var datashows = context.mobdetailes.Select(n => new { n.id, n.name, n.price, n.screen, n.storage, n.ram, n.battery, n.front_camera, n.back_camera, n.processor, n.android, n.network, n.quantity, n.warranty, n.date }).ToList().OrderByDescending(r => r.price);
                bdata = new BindingSource();
                bdata.DataSource = datashows;
                griddatabase.DataSource = bdata;
            }
            else if (combocategory.Text == "quantity")
            {
                var datashows = context.mobdetailes.Select(n => new { n.id, n.name, n.price, n.screen, n.storage, n.ram, n.battery, n.front_camera, n.back_camera, n.processor, n.android, n.network, n.quantity, n.warranty, n.date }).ToList().OrderByDescending(r => r.quantity);
                bdata = new BindingSource();
                bdata.DataSource = datashows;
                griddatabase.DataSource = bdata;
            }
            else if (combocategory.Text == "date")
            {
                var datashows = context.mobdetailes.Select(n => new { n.id, n.name, n.price, n.screen, n.storage, n.ram, n.battery, n.front_camera, n.back_camera, n.processor, n.android, n.network, n.quantity, n.warranty, n.date }).ToList().OrderBy(r => r.date);
                bdata = new BindingSource();
                bdata.DataSource = datashows;
                griddatabase.DataSource = bdata;
            }

        }
        #endregion

        // update button for update any value of mobile detailes without name can't change it or edit
        #region update
        private void Btnupdate_Click_1(object sender, EventArgs e)
        {
            if (mobname == "" || mobprice == 0 || mobquantity == 0)
            {
                MessageBox.Show("invalid inputs");
            }
            else
            {
                bool ad = objectmob.update(mobname, mobprice, mobscreen, mobstorage, mobram, mobbattery, mobfrontcamera, mobbackcamera, mobprocessor, mobandroid, mobnetwork, mobquantity, mobwarrenty, mobdate);
                if (ad == true)
                {
                    griddatabase.Rows.Clear();
                    griddatabase.Refresh();
                    this.Mobiledetails_Load(sender, e);
                    MessageBox.Show("Updated");

                }
                else
                {
                    MessageBox.Show("can not update this item");
                }

            }
        }
        #endregion

        //remove item from mobiles detailes but frist you must remove his images from mobiles images
        #region remove
        private void Btndelete_Click_1(object sender, EventArgs e)
        { 
            int del = context.mobdetailes.Where(n => n.name == mobname).Select(n => n.id).FirstOrDefault();
            int t = context.mobimages.Where(n => n.nameproduct == mobname).Select(n => n.mobildetaileId).FirstOrDefault();
                if(t==0&&del!=0)
                {
                    var confirm = MessageBox.Show("Are you sure to delete this item ??", "confirm delete", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        var remov = (mobildetaile)context.mobdetailes.Where(i => i.id == del).First();
                        context.mobdetailes.Remove(remov);
                        context.SaveChanges();
                        griddatabase.Rows.Clear();
                        griddatabase.Refresh();
                        this.Mobiledetails_Load(sender, e);
                        MessageBox.Show("the item deleted");
                    }
                    else
                    {
                        MessageBox.Show("the item not deleted");
                    }
                }
                else
                {
                    MessageBox.Show("make sure that this mobile exist or make sure not exist in mobile images if have images remove item from mobile images the remove it");
                }
        }


        #endregion

        ///reset textbox
        #region reset
        public void reset()
        {
            textandroid.Texts = "";
            textbackcamera.Texts = (0).ToString();
            textfrontcamera.Texts = (0).ToString();
            textprice.Texts = (0).ToString();
            textwarranty.Texts = (0).ToString();
            textbattery.Texts = (0).ToString();
            textquantity.Texts = (0).ToString();
            textram.Texts = (0).ToString();
            textscreen.Texts = (0).ToString();
            textstorage.Texts = (0).ToString();
            textnm.Texts = "";
            datetext.Text = "";
            textnetwork.Texts ="";
            textsearch.Texts = "";
            textprocessor.Texts = "";
        }

        #endregion

        //show data in inputs when click on cell of grid view
        #region display

        private void Griddatabase_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            this.reset();
            int x = e.RowIndex;
            DataGridViewRow row = griddatabase.Rows[x];
            try
            {
                textnm.Texts = row.Cells[0].Value.ToString();
                textprice.Texts = row.Cells[1].Value.ToString();
                textscreen.Texts = row.Cells[2].Value.ToString();
                textstorage.Texts = row.Cells[3].Value.ToString();
                textram.Texts = row.Cells[4].Value.ToString();
                textbattery.Texts = row.Cells[5].Value.ToString();
                textfrontcamera.Texts = row.Cells[6].Value.ToString();
                textbackcamera.Texts = row.Cells[7].Value.ToString();
                textprocessor.Texts = row.Cells[8].Value.ToString();
                textandroid.Texts = row.Cells[9].Value.ToString();
                textnetwork.Texts = row.Cells[10].Value.ToString();
                textquantity.Texts = row.Cells[11].Value.ToString();
                textwarranty.Texts = row.Cells[12].Value.ToString();
            }
            catch
            {
                this.nullvalue();
            }
        }
       
        public void nullvalue()
        {
            if (textnm.Texts == "") { textnm.Texts = ""; }
            if (textprice.Texts == "") { textprice.Texts = ""; }
            if (textscreen.Texts == "") { textscreen.Texts = ""; }
            if (textstorage.Texts == "") { textstorage.Texts = ""; }
            if (textram.Texts == "") { textram.Texts = ""; }
            if (textbattery.Texts == "") { textbattery.Texts = ""; }
            if (textfrontcamera.Texts == "") { textfrontcamera.Texts = ""; }
            if (textbackcamera.Texts == "") { textbackcamera.Texts = ""; }
            if (textprocessor.Texts == "") { textprocessor.Texts = ""; }
            if (textnetwork.Texts == "") { textnetwork.Texts = ""; }
            if (textquantity.Texts == "") { textquantity.Texts = ""; }
            if (textwarranty.Texts == "") { textwarranty.Texts = ""; }
            if (textandroid.Texts == "") { textandroid.Texts = ""; }
        }


        #endregion

        private void Label17_Click(object sender, EventArgs e)
        {

        }

        private void Textsearch__TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Combocategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}