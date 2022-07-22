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
using System.IO;

namespace main
{
    public partial class accessimages : DevExpress.XtraEditors.XtraForm
    {
        //declare variables
        #region variables
        accessContext context;
        accessdetails objacc;
        accessierimages objimg;
        string mobnm;
        BindingSource bdata;
        #endregion
        public accessimages()
        {
            InitializeComponent();
        }
        // function convert image to array of bytes 
        #region convert
        private byte[] converttobyte(string path)
        {
            byte[] data = null;
            FileInfo finfo = new FileInfo(path);
            long numbytes = finfo.Length;
            FileStream fstream = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            data = br.ReadBytes((int)numbytes);
            return data;

        }
        #endregion

        ///  button to upload images from your device
        #region upload
        private void Btnimg1_Click(object sender, EventArgs e)
        {
            dialogimg1.Title = "please select a photo";
            dialogimg1.Filter = "JPG|*.jpg|PNG|*.png|GIF|*gif";
            dialogimg1.Multiselect = false;
            if (dialogimg1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.img1.ImageLocation = dialogimg1.FileName;
                double heightim1;
                double widthim1;
                using (var im1 = Image.FromFile(this.img1.ImageLocation))
                {
                    heightim1 = im1.Height;
                    widthim1 = im1.Width;
                }
                if (heightim1 > 340 || widthim1 > 330)
                {
                    this.img1.ImageLocation = null;
                    MessageBox.Show("chooce image with dimensions less than 340 * 330 pexel");
                }
            }
        }

        private void Btnimage2_Click(object sender, EventArgs e)
        {
            dialogimg2.Title = "please select a photo";
            dialogimg2.Filter = "JPG|*.jpg|PNG|*.png|GIF|*gif";
            dialogimg2.Multiselect = false;
            if (dialogimg2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.img2.ImageLocation = dialogimg2.FileName;
                double heightim1;
                double widthim1;
                using (var im1 = Image.FromFile(this.img2.ImageLocation))
                {
                    heightim1 = im1.Height;
                    widthim1 = im1.Width;
                }
                if (heightim1 > 340 || widthim1 > 330)
                {
                    this.img1.ImageLocation = null;
                    MessageBox.Show("chooce image with dimensions less than 340 * 330 pexel");
                }
            }
        }

        private void Btnimg3_Click(object sender, EventArgs e)
        {
            dialogimg3.Title = "please select a photo";
            dialogimg3.Filter = "JPG|*.jpg|PNG|*.png|GIF|*gif";
            dialogimg3.Multiselect = false;
            if (dialogimg3.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                this.img3.ImageLocation = dialogimg3.FileName;
                double heightim1;
                double widthim1;
                using (var im1 = Image.FromFile(this.img3.ImageLocation))
                {
                    heightim1 = im1.Height;
                    widthim1 = im1.Width;
                }
                if (heightim1 > 340 || widthim1 > 330)
                {
                    this.img1.ImageLocation = null;
                    MessageBox.Show("chooce image with dimensions less than 340 * 330 pexel");
                }
            }
        }
        #endregion

        
        #region add
        private void Btn1add_Click(object sender, EventArgs e)
        {
            if (mobnm == "" || img1 == null || img2 == null || img3 == null)
            {
                MessageBox.Show("invalid inputs");
            }
            else
            {
                var l = context.accdetailes.Where(k => k.name == mobnm).Select(k => k.id).FirstOrDefault();
                if (l != 0)
                {
                    var exist = context.accimages.Where(k => k.id == l).Select(k => k.id).FirstOrDefault();
                    if (exist == 0)
                    {
                        accessierimages itm = new accessierimages() { id = l, nameproduct = mobnm, productimg1 = converttobyte(this.img1.ImageLocation), productimg2 = converttobyte(this.img2.ImageLocation), productimg3 = converttobyte(this.img3.ImageLocation) };
                        context.accimages.Add(itm);
                        context.SaveChanges();
                        dataimages.Rows.Clear();
                        dataimages.Refresh();
                        this.Mobilesimges_Load(sender, e);
                        MessageBox.Show("added");
                    }
                    else
                    {
                        MessageBox.Show("aceessories images already exist");
                    }
                }
                else
                {
                    MessageBox.Show($"mobile not found in aceessories detailes{mobnm}");
                }
            }
        }
        #endregion
        //form load contain objects and load the data from database and make style for gridview
        #region load
        private void Mobilesimges_Load(object sender, EventArgs e)
        {
            //objects
            context = new accessContext();
            objacc = new accessdetails();
            objimg = new accessierimages();
            //load data
            var datashows = context.accimages.Select(n => new { n.id, n.nameproduct, n.productimg1, n.productimg2, n.productimg3 }).ToList();
            bdata = new BindingSource();
            bdata.DataSource = datashows;
            dataimages.DataSource = bdata;
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
        #endregion
       
        #region input text
        private void Textname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textname.Text != "")
                {
                    mobnm = textname.Text.ToString().ToLower();
                }

            }
            catch
            {
                MessageBox.Show("invalid name");
            }
        }
        #endregion

        #region search
        private void Btnsearch_Click(object sender, EventArgs e)
        {
            if (textname.Text.Trim() != "")
            {
                try
                {
                    var srch = context.accdetailes.Where(m => m.name == mobnm).Select(m => m.id).FirstOrDefault();
                    this.search(srch);
                }
                catch
                {
                    MessageBox.Show("Can't find mobile name");
                }

            }
        }
        #endregion

        //function to convert array of bytes to image
        #region convert
        private Image convertoimage(byte[] photo)
        {
            Image newimg;
            using (MemoryStream ms = new MemoryStream(photo, 0, photo.Length))
            {
                ms.Write(photo, 0, photo.Length);
                newimg = Image.FromStream(ms, true);

            }
            return newimg;
        }
        #endregion

        //search function take name and set the data to controls
        #region function search
        private void search(int d)
        {
            var val = context.accimages.Single(n => n.id == d);
            img1.Image = this.convertoimage(val.productimg1);
            img2.Image = this.convertoimage(val.productimg2);
            img3.Image = this.convertoimage(val.productimg3);
            textname.Text = val.nameproduct;
        }
        #endregion

       
        #region order
        private void SimpleButton2_Click(object sender, EventArgs e)
        {
            dataimages.Rows.Clear();
            dataimages.Refresh();
            var datashows = context.accimages.Select(n => new { n.id, n.nameproduct, n.productimg1, n.productimg2, n.productimg3 }).ToList().OrderBy(r => r.nameproduct);
            bdata = new BindingSource();
            bdata.DataSource = datashows;
            dataimages.DataSource = bdata;
        }
        #endregion

        
        #region remove
        private void Btnremove_Click(object sender, EventArgs e)
        {
            int del = context.accimages.Where(n => n.nameproduct == mobnm).Select(n => n.id).FirstOrDefault();
            if (del != 0)
            {
                try
                {
                    var confirm = MessageBox.Show("Are you sure to delete this item ??", "confirm delete", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        var remov = (accessierimages)context.accimages.Where(i => i.id == del).First();
                        context.accimages.Remove(remov);
                        context.SaveChanges();
                        dataimages.Rows.Clear();
                        dataimages.Refresh();
                        this.Mobilesimges_Load(sender, e);
                        MessageBox.Show("the item deleted");
                    }
                    else
                    {
                        MessageBox.Show("the item not deleted");
                    }
                }
                catch
                {
                    MessageBox.Show("can't remove this item ");
                }
            }


            else
            {
                MessageBox.Show("Enter valid name");
            }
        }
        #endregion

        
        #region reset
        public void reset()
        {
            img1.Image = null;
            img2.Image = null;
            img3.Image = null;
            textname.Text = "";
        }

        #endregion

        private void Btnupdate_Click(object sender, EventArgs e)
        {
            if (mobnm == "" || img1 == null || img2 == null || img3 == null)
            {
                MessageBox.Show("invalid inputs");
            }
            else
            {
                var l = context.accdetailes.Where(k => k.name == mobnm).Select(k => k.id).FirstOrDefault();
                var exist = context.accimages.Where(k => k.id == l).Select(k => k.id).FirstOrDefault();
                if (exist != 0)
                {

                    accessierimages itm = new accessierimages() { id = l, nameproduct = mobnm, productimg1 = imagetobyte(this.img1.Image), productimg2 = imagetobyte(this.img2.Image), productimg3 = imagetobyte(this.img3.Image) };
                    context.Entry(itm).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    dataimages.Rows.Clear();
                    dataimages.Refresh();
                    this.Mobilesimges_Load(sender, e);
                    MessageBox.Show("updated");
                }
                else
                {
                    MessageBox.Show("accessories images not exist to update");
                }
            }
        }
            public byte[] imagetobyte(System.Drawing.Image img)
            {
                using (var m = new MemoryStream())
                {
                    img.Save(m, img.RawFormat);
                    return m.ToArray();
                }
            }
    }
}