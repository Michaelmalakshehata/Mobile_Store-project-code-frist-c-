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
using WindowsFormsApp1;
using DevExpress.ClipboardSource.SpreadsheetML;

namespace main
{
    public partial class mobileformmain : DevExpress.XtraEditors.XtraForm
    {
        mobilesimges objectimg;
        accessContext context;
        mobildetaile objectmob;
        BindingSource bdata;
        BindingSource bimg;
        public mobileformmain()
        {
            InitializeComponent();
        }

        private void Mobileformmain_Load(object sender, EventArgs e)
        {
            objectimg = new mobilesimges();
            context = new accessContext();
            objectmob = new mobildetaile();
         


            ////load database
            var datash = context.mobdetailes.Select(n => new { n.name, n.price, n.screen, n.storage, n.ram, n.battery, n.front_camera, n.back_camera, n.processor, n.android, n.network, n.quantity, n.warranty, n.date }).ToList();
            bdata = new BindingSource();


            bdata.DataSource = datash;
            griddatabase.DataSource = bdata;
            griddatabase.DefaultCellStyle.SelectionBackColor = Color.PowderBlue;
            griddatabase.DefaultCellStyle.SelectionForeColor = Color.Red;
            ///change grid view font size
            griddatabase.DefaultCellStyle.Font = new Font("Tahoma", 12);
            ///make default for combobox order by 
            combocategory.SelectedItem = null;
            combocategory.Text = "name";

            ///gridview images
            var imgshow = context.mobimages.Select(n => new { n.mobildetaileId, n.nameproduct, n.productimg1, n.productimg2, n.productimg3 }).ToList();
            bimg = new BindingSource();
            bimg.DataSource = imgshow;
            dataimages.DataSource = bimg;
            ////change grid view style show 


            ////change grid view style show 
            dataimages.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataimages.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataimages.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataimages.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            for (int i = 0; i < dataimages.Columns.Count - 1; i++)
            {
                int clow = dataimages.Columns[i].Width;
                dataimages.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dataimages.Columns[i].Width = clow;
            }
            dataimages.DefaultCellStyle.SelectionBackColor = Color.Black;
            dataimages.DefaultCellStyle.Font = new Font("Tahoma", 14);
        
      
    }

        private void Textsearch__TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnorder_Click(object sender, EventArgs e)
        {
            
            griddatabase.Rows.Clear();
            griddatabase.Refresh();

            if (combocategory.Text == "name")
            {
                var datashows = context.mobdetailes.Select(n => new { n.id, n.name, n.price, n.screen, n.storage, n.ram, n.battery, n.front_camera, n.back_camera, n.processor, n.android, n.network, n.quantity, n.warranty, n.date }).ToList().OrderBy(r => r.name);
                bdata.DataSource = datashows;
                griddatabase.DataSource = bdata;


                dataimages.Rows.Clear();
                dataimages.Refresh();
                var dash = context.mobimages.Select(n => new { n.mobildetaileId, n.nameproduct, n.productimg1, n.productimg2, n.productimg3 }).ToList().OrderBy(r => r.nameproduct);
                bimg.DataSource = dash;
                dataimages.DataSource = bimg;
            }
            else if (combocategory.Text == "price")
            {
                var datashows = context.mobdetailes.Select(n => new { n.id, n.name, n.price, n.screen, n.storage, n.ram, n.battery, n.front_camera, n.back_camera, n.processor, n.android, n.network, n.quantity, n.warranty, n.date }).ToList().OrderByDescending(r => r.price);
                bdata.DataSource = datashows;
                griddatabase.DataSource = bdata;
            }
            else if (combocategory.Text == "quantity")
            {
                var datashows = context.mobdetailes.Select(n => new { n.id, n.name, n.price, n.screen, n.storage, n.ram, n.battery, n.front_camera, n.back_camera, n.processor, n.android, n.network, n.quantity, n.warranty, n.date }).ToList().OrderByDescending(r => r.quantity);
                bdata.DataSource = datashows;
                griddatabase.DataSource = bdata;
            }
            else if (combocategory.Text == "date")
            {
                var datashows = context.mobdetailes.Select(n => new { n.id, n.name, n.price, n.screen, n.storage, n.ram, n.battery, n.front_camera, n.back_camera, n.processor, n.android, n.network, n.quantity, n.warranty, n.date }).ToList().OrderBy(r => r.date);
                bdata.DataSource = datashows;
                griddatabase.DataSource = bdata;
            }
        }

        private void Btnsearch_Click(object sender, EventArgs e)
        {
            string textsr = textsearch.Texts.ToString().ToLower();
            if (textsearch.Texts.Trim() != "")
            {
                try
                {
                    griddatabase.Rows.Clear();
                    griddatabase.Refresh();
                    var dats = context.mobdetailes.Where(n=>n.name==textsr).Select(n => new { n.id, n.name, n.price, n.screen, n.storage, n.ram, n.battery, n.front_camera, n.back_camera, n.processor, n.android, n.network, n.quantity, n.warranty, n.date }).ToList();
                    bdata.DataSource = dats;
                    griddatabase.DataSource = bdata;
                    dataimages.Rows.Clear();
                    dataimages.Refresh();
                    var das = context.mobimages.Where(n => n.nameproduct == textsr).Select(n => new { n.mobildetaileId, n.nameproduct, n.productimg1, n.productimg2, n.productimg3 }).ToList().OrderBy(r => r.nameproduct);
                    bimg.DataSource = das;
                    dataimages.DataSource = bimg;
                }
                catch
                {
                    MessageBox.Show("Can't find mobile name");
                }

            }
        }

        private void Btnrefresh_Click(object sender, EventArgs e)
        {
            griddatabase.Rows.Clear();
            griddatabase.Refresh();
            dataimages.Rows.Clear();
            dataimages.Refresh();
            this.Mobileformmain_Load(sender, e);
        }
    }
}