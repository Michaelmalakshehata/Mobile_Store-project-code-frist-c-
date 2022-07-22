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
    public partial class accessoriesformmain : DevExpress.XtraEditors.XtraForm
    {
        accessContext context;
        accessdetails objacc;
        accessierimages objimg;
        BindingSource bimg ;
        BindingSource bdata;

        public accessoriesformmain()
        {
            InitializeComponent();
        }

        private void Griddatabase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Textsearch__TextChanged(object sender, EventArgs e)
        {

        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            string textsr = textsearch.Texts.ToString().ToLower();
            if (textsearch.Texts.Trim() != "")
            {
                try
                {
                        griddatabase.Rows.Clear();
                        griddatabase.Refresh();
                        var datashows = context.accdetailes.Where(n=>n.name==textsr).Select(n => new { n.id, n.name, n.price, n.type, n.quantity, n.warranty, n.date }).ToList().OrderBy(r => r.name);
                        bdata.DataSource = datashows;
                        griddatabase.DataSource = bdata;
                        dataimages.Rows.Clear();
                        dataimages.Refresh();
                        var dd = context.accimages.Where(n => n.nameproduct == textsr).Select(n => new { n.id, n.nameproduct, n.productimg1, n.productimg2, n.productimg3 }).ToList().OrderBy(r => r.nameproduct);
                        bimg.DataSource = dd;
                        dataimages.DataSource = bimg;
                    }
                catch
                {
                    MessageBox.Show("Can't find Accessiers name");
                }

            }
        }

        private void Accessoriesformmain_Load(object sender, EventArgs e)
        {
            context = new accessContext();
            objacc = new accessdetails();
            objimg = new accessierimages();
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
            ///////////gridviewimages
            
            //load data
            var dats = context.accimages.Select(n => new { n.id, n.nameproduct, n.productimg1, n.productimg2, n.productimg3 }).ToList();
            bimg = new BindingSource();
            bimg.DataSource = dats;
            dataimages.DataSource = bimg;
            //change grid view style show 
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

        private void SimpleButton2_Click(object sender, EventArgs e)
        {
            griddatabase.Rows.Clear();
            griddatabase.Refresh();

            if (combocategory.Text == "name")
            {
                var datashows = context.accdetailes.Select(n => new { n.id, n.name, n.price, n.type, n.quantity, n.warranty, n.date }).ToList().OrderBy(r => r.name);
                bdata.DataSource = datashows;
                griddatabase.DataSource = bdata;
                dataimages.Rows.Clear();
                dataimages.Refresh();
                var dd = context.accimages.Select(n => new { n.id, n.nameproduct, n.productimg1, n.productimg2, n.productimg3 }).ToList().OrderBy(r => r.nameproduct);
                bimg.DataSource = dd;
                dataimages.DataSource = bimg;
            }
            else if (combocategory.Text == "price")
            {
                var datashows = context.accdetailes.Select(n => new { n.id, n.name, n.price, n.type, n.quantity, n.warranty, n.date }).ToList().OrderByDescending(r => r.price);
                bdata.DataSource = datashows;
                griddatabase.DataSource = bdata;
            }
            else if (combocategory.Text == "quantity")
            {
                var datashows = context.accdetailes.Select(n => new { n.id, n.name, n.price, n.type, n.quantity, n.warranty, n.date }).ToList().OrderByDescending(r => r.quantity);
                bdata.DataSource = datashows;
                griddatabase.DataSource = bdata;
            }
            else if (combocategory.Text == "date")
            {
                var datashows = context.accdetailes.Select(n => new { n.id, n.name, n.price, n.type, n.quantity, n.warranty, n.date }).ToList().OrderBy(r => r.date);
                bdata.DataSource = datashows;
                griddatabase.DataSource = bdata;
            }
        }

        private void Btnrefresh_Click(object sender, EventArgs e)
        {
            griddatabase.Rows.Clear();
            griddatabase.Refresh();
            dataimages.Rows.Clear();
            dataimages.Refresh();
            this.Accessoriesformmain_Load(sender, e);

        }
    }
}