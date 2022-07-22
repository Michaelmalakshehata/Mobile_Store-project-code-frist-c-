using main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public partial class Print : Form
    {
        
         accessContext context;
        Bitmap memoryimage;
        List<Bill> list=null;
        double discount=0;
        string s;
        public Print(List<Bill> ls,double dis,string l)
        {
            discount = dis;
            InitializeComponent();
            list = ls;
            s = l;
        }
        private void Print_Load(object sender, EventArgs e)
        {
            context = new accessContext();
            gItems2.Rows.Clear();
            gItems2.Refresh();
            int phone;
            phone = int.Parse(s);
            var dname = context.Customers.Where(n => n.Phone == phone).Select(n =>   n.name).FirstOrDefault();
         
          
            llname.Text = dname;
            gItems2.DataSource = null;
            gItems2.Rows.Add();
            foreach (var itm in list)
            {
                gItems2.Rows.Add(itm.productname.ToString(), itm.quantity, itm.Price);
            }
            gItems2.DefaultCellStyle.SelectionBackColor = Color.White;
            gItems2.DefaultCellStyle.SelectionForeColor = Color.White;
            ///change grid view font size
            gItems2.DefaultCellStyle.Font = new Font("Tahoma", 12);
            lpphone.Text ="0"+s;
            lldate.Text = DateTime.Now.ToShortDateString();
            double sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i].Price;
            }
     
            if (discount >= 1)
            {
                double sum2 = sum - sum * (discount / 100);
                lpprice.Text = sum2.ToString()+"   Pounds";
            }
            else
            {

                lpprice.Text = sum.ToString() + "   Pounds";
            }

        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
             memoryimage = new Bitmap(s.Width, s.Height-24, myGraphics);
            Graphics memorygraphics = Graphics.FromImage(memoryimage);
            memorygraphics.CopyFromScreen(this.Location.X, this.Location.Y+24, 0, 0, s);

            printDocument1.Print();
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryimage, 0, 0);
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GItems2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GItems2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
