using main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public partial class Form1 : Form
    {
        accessContext context;
        public double discount;
        string s;
        public Form1()
        {
            InitializeComponent();
        }

        #region checkout

        private void BCheckout_Click(object sender, EventArgs e)
        {
            accessContext context = new accessContext();
            int phone = int.Parse(s);
            var phcust = context.customerProducts.Where(n => n.CustomerPhone == phone).Select(n => n.ID).FirstOrDefault();
           
            if (phcust != 0)
            {
                var data = this.search(phone);
                List<Bill> bcheckout = new List<Bill>();
            for (int i = 0; i < data.Count; i++)
            {
                    string sp = data[i].productname;
                    string typenm = data[i].productname;
                    var type = context.customerProducts.Where(n => n.ProductName == typenm).Select(n => n.typeproduct).First();


                    var p = context.mobdetailes.Where(n => n.name == sp).Select(n => n).FirstOrDefault();

                    var p2 = context.accdetailes.Where(n => n.name == sp).Select(n => n).FirstOrDefault();
              try
                 {
                    if (p != null&&p.quantity>= data[i].quantity && type.ToString()=="mobile")
                    {
                        p.quantity -= data[i].quantity;
                        Bill b = new Bill() { Id = data[i].Id, customer_phone = data[i].customer_phone, productname = data[i].productname, quantity = data[i].quantity, Price = data[i].Price };
                        context.Bills.Add(b);
                            bcheckout.Add(b);
                    }
                  

                   else if (p2 != null&&p2.quantity>= data[i].quantity && type.ToString() == "accessory")
                    {
                        p2.quantity -= data[i].quantity;
                        Bill c = new Bill() { Id = data[i].Id, customer_phone = data[i].customer_phone, productname = data[i].productname, quantity = data[i].quantity, Price = data[i].Price };
                        context.Bills.Add(c);
                            bcheckout.Add(c);
                    }
                   else if (p.quantity < data[i].quantity && type.ToString()=="mobile")
                    {
                        MessageBox.Show($"not have enough quantity for this mobile= {data[i].productname} ");
                    }
                  else  if (p2.quantity <data[i].quantity && type.ToString() == "mobile")
                    {
                        MessageBox.Show($"not have enough quantity for this accessory= {data[i].productname}");
                    }
                    
              }
                    catch
                    {

                    }
                   
            }
              if(bcheckout.Count == 0)
                {
                    MessageBox.Show("you dont have enough quantity for this items");
                }
               else if (data.Count>bcheckout.Count)
                {
                    var confirm = MessageBox.Show($"you dont have enough quantity for{data.Count-bcheckout.Count} itmes", "confirm checkout", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        context.SaveChanges();
                        Print frm2 = new Print(bcheckout, discount, s);
                        frm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                        frm2.AutoScroll = true;
                        frm2.Show();
                    }
                    else
                    {
                    }
                }
                else if(data.Count== bcheckout.Count)
                {
                    context.SaveChanges();
                    Print frm2 = new Print(bcheckout, discount, s);
                    frm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm2.AutoScroll = true;
                    frm2.Show();
                }
              


            }
            else
            {
                MessageBox.Show("customer not found or enter correct customer phone");
            }


        }

        #endregion
        public List<Bill> search(int s)
        {
            List<Bill> list = new List<Bill>();
            double pric;
            context = new accessContext();
           
            var custpro = context.customerProducts.Where(c => c.CustomerPhone == s).Select(y => new { y.ID, y.ProductName, y.CustomerPhone, y.Quantity,y.typeproduct}).ToList();
            foreach (var itm in custpro)
            {
                pric = 0;

                var findmob = context.mobdetailes.Where(i => i.name == itm.ProductName).Select(i => new { i.name, i.price, i.quantity }).FirstOrDefault();
                var findaccess = context.accdetailes.Where(i => i.name == itm.ProductName).Select(i => new { i.name, i.price, i.quantity }).FirstOrDefault();

                if (itm.typeproduct.ToString()=="mobile")
                {
                    if ( findmob.price > 0)
                    {
                        pric = (findmob.price * itm.Quantity) ;
                        Bill b2 = new Bill() { Id = itm.ID, customer_phone = itm.CustomerPhone, productname = itm.ProductName, quantity = itm.Quantity, Price = pric };
                        list.Add(b2);
                    }

                }
                else if(itm.typeproduct.ToString()=="accessory")
                
                    {

                        if (findaccess.price > 0)
                        {
                            pric = (findaccess.price * itm.Quantity);
                            Bill b1 = new Bill() { Id = itm.ID, customer_phone = itm.CustomerPhone, productname = itm.ProductName, quantity = itm.Quantity, Price = pric };
                            list.Add(b1);

                        }
                    }

                }
            return list;
        }

    

     

        private void Textbox1__TextChanged(object sender, EventArgs e)
        {
            if(!double.TryParse(textbox1.Texts,out discount))
            {
                MessageBox.Show("Enter valid number");
            }

        }


        private void Combphones_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Combphones_TextChanged(object sender, EventArgs e)
        {
            int phone;
            if (!int.TryParse(combphones.Text, out phone))
            {
                MessageBox.Show("Accept only numbers");
            }
            else
            {
                s = phone.ToString();
                gItems.Rows.Clear();
                gItems.Refresh();
                context = new accessContext();
                var exist = context.customerProducts.Where(c => c.CustomerPhone == phone).Select(c => c.ID).FirstOrDefault();
                if (exist != 0)
                {
                    var data = this.search(phone);
                    foreach (var itm in data)
                    {
                        gItems.Rows.Add(itm.Id, itm.customer_phone, itm.productname, itm.quantity, itm.Price);
                    }
                    data = null;
                }
                gItems.DefaultCellStyle.SelectionBackColor = Color.PowderBlue;
                gItems.DefaultCellStyle.SelectionForeColor = Color.Red;
                ///change grid view font size
                gItems.DefaultCellStyle.Font = new Font("Tahoma", 12);
            }
        }
    }
}
