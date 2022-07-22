using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public partial class Customer_Form : DevExpress.XtraEditors.XtraForm
    {
        accessContext context = new accessContext();
        Customer Custom;
        CustomerProduct CProduct;
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=mobilestore;Integrated Security=true ");
        string Cname;
        int Cphonecust;
        string Caddress;
        string product;
        int CPhone;
        int quantity;
        string idp = "";
        BindingSource bdata;
        int textsr;

        public Customer_Form()
        {

            InitializeComponent();
        }
        #region
        private void Customer_Form_Load(object sender, EventArgs e)
        {
            Custom = new Customer();
            CProduct = new CustomerProduct();
            var grid1dt = context.Customers.ToList();

            bdata = new BindingSource();
            bdata.DataSource = grid1dt;
            gridControl1.DataSource = bdata;

          var grid2dt = context.customerProducts.ToList();
            bdata = new BindingSource();
            bdata.DataSource = grid2dt;
            gridControl2.DataSource = bdata;

            var dat = context.mobdetailes.Select(n => n.name).ToList();
            var dat2 = context.accdetailes.Select(n => n.name).ToList();
            List<string> lsdat = new List<string>();
            lsdat.AddRange(dat);
            lsdat.AddRange(dat2);
            combomob.DataSource = lsdat;
            combomob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            combomob.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            combomob.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

       

        private void Add_customer_Click_1(object sender, EventArgs e)
        {
            Customer c = new Customer();
            if (Cname == "" || Cphonecust == 0 || Caddress == "")
            {
                MessageBox.Show("invalid inputs");
            }

            else
            {
                var d = context.Customers.Where(n => n.Phone == Cphonecust).Select(n => n.ID).FirstOrDefault();
                if (Cphonecust != 0 && d == 0)
                {


                    Customer dataobject = new Customer() { name = Cname, Address = Caddress, Phone = Cphonecust };
                    context.Customers.Add(dataobject);
                    context.SaveChanges();
                    gridControl1.DataSource = null;
                    gridControl1.Refresh();
                    this.Customer_Form_Load(sender, e);
                    MessageBox.Show("Customer Added");
                }
                else
                {
                    MessageBox.Show("mobile was exist");
                }



            }
        }

        private void Add_Product_Click(object sender, EventArgs e)
        {
            CustomerProduct cp = new CustomerProduct();
            if (product == "" || quantity == 0 || CPhone == 0||comtype.Text=="")
            {
                MessageBox.Show("invalid inputs");

            }
            else
            {
               
                int d = context.Customers.Where(n => n.Phone == CPhone).Select(n => n.ID).FirstOrDefault();
                if ( d != 0)
                {
                    if (comtype.Text == "mobile")
                    {
                        var pmobquantity = context.mobdetailes.Where(n => n.name == product).Select(n => n.quantity).FirstOrDefault();

                        if (pmobquantity >= quantity)
                        {
                            int c = context.Customers.Where(n => n.Phone == CPhone).Select(n => n.ID).FirstOrDefault();

                            CustomerProduct customerProduc = new CustomerProduct() { ProductName = product, Quantity = quantity, CustomerPhone = CPhone, typeproduct=comtype.Text.ToString().ToLower(),Customer_ID = c };
                            context.customerProducts.Add(customerProduc);
                            context.SaveChanges();
                            gridControl2.DataSource = null;
                            gridControl2.Refresh();
                            this.Customer_Form_Load(sender, e);
                            MessageBox.Show("Product mobile Added Successfully..!");
                        }
                        else
                        {
                            MessageBox.Show("mobile not have enough quantity");
                        }
                    }
                    else if(comtype.Text=="accessory")
                    {
                        var pmobquantity = context.accdetailes.Where(n => n.name == product).Select(n => n.quantity).FirstOrDefault();

                        if (pmobquantity >= quantity)
                        {
                            int c = context.Customers.Where(n => n.Phone == CPhone).Select(n => n.ID).FirstOrDefault();

                            CustomerProduct customerProduct = new CustomerProduct() { ProductName = product, Quantity = quantity, CustomerPhone = CPhone,typeproduct="accessory", Customer_ID = c };
                            context.customerProducts.Add(customerProduct);
                            context.SaveChanges();
                            gridControl2.DataSource = null;
                            gridControl2.Refresh();
                            this.Customer_Form_Load(sender, e);
                            MessageBox.Show("Product Added Successfully..!");
                        }

                        else
                        {
                            MessageBox.Show("accessories not have enough quantity");
                        }

                    }
                }

                else
                {
                    MessageBox.Show("not exist mobile phone or product name ");

                }
            }

        }
        private void textName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textName.Text.Trim() != ""&&textName.Text.ToString().Length<30)
                {
                  
                    Cname = textName.Text.ToString().ToLower();
                }
                else
                {
                    MessageBox.Show("name must between 1 and 30 character");
                }
            }
            catch
            {
               
            }
        }

        private void textAddress_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textAddress.Text.Trim() != "")
                {
                    Caddress = textAddress.Text.ToString().ToLower();
                }

            }
            catch
            {
                MessageBox.Show("invalid address");
            }
        }

        private void textPhone_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textPhone.Text != "")
                {
                    Cphonecust = int.Parse(textPhone.Text);
                }
            }
            catch
            {
                MessageBox.Show("invalid Phone");

            }
        }

        private void textCustomerPhone_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textCustomerPhone.Text != "")
                {
                    CPhone = int.Parse(textCustomerPhone.Text);

                }

            }
            catch
            {
                MessageBox.Show("invalid phone number");

            }


        }

      
        private void textQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textQuantity.Text != "")
                {
                    quantity = int.Parse(textQuantity.Text);

                }

            }
            catch
            {
                MessageBox.Show("invalid Quantity");

            }
        }

        private void Btnsearch_Click(object sender, EventArgs e)
        {

            if (textsearch.Texts.Trim() != "")
            {
                try
                {
                    var srch = context.Customers.Where(m => m.Phone == textsr).Select(m => m.ID).FirstOrDefault();
                    this.search(srch);
                    gridControl2.DataSource = null;
                    gridControl2.Refresh();
                    gridControl2.DataSource = context.customerProducts.Where(m => m.CustomerPhone == textsr).Select(m => new { m.ID, m.ProductName, m.Quantity, m.CustomerPhone, m.typeproduct }).ToList();
                }
                catch
                {
                    MessageBox.Show("Can't find customer name");
                }

            }
        }
        private void search(int d)
        {

            var val = context.Customers.Single(n => n.ID == d);

            textAddress.Text = val.name.ToString();
            textName.Text = val.name.ToString();
            textPhone.Text = val.Phone.ToString();


        }
        #endregion

        private void Btnorder_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = null;
            gridControl1.Refresh();
            if (combocategory.Text == "name")
            {
                gridControl1.DataSource = context.Customers.ToList().OrderBy(n => n.name);
            }
            else if (combocategory.Text == "phone")
            {
                gridControl1.DataSource = context.Customers.ToList().OrderBy(n => n.Phone);

            }

        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            gridControl2.DataSource = null;
            gridControl2.Refresh();
            if (comboBox1.Text == "name")
            {
                gridControl2.DataSource = context.customerProducts.ToList().OrderBy(n => n.ProductName);
            }
            else if (comboBox1.Text == "phone")
            {
                gridControl2.DataSource = context.customerProducts.ToList().OrderBy(n => n.CustomerPhone);

            }
            else if (comboBox1.Text == "quantity")
            {
                gridControl2.DataSource = context.customerProducts.ToList().OrderBy(n => n.Quantity);

            }
        }

        private void Btnrefresh_Click(object sender, EventArgs e)
        {
          
            gridControl2.DataSource = null;
            gridControl2.Refresh();
            gridControl1.DataSource = null;
            gridControl1.Refresh();
            this.Customer_Form_Load(sender, e);
        }

      
        private void Button1_Click(object sender, EventArgs e)
        {
            int del = context.Customers.Where(n => n.Phone ==Cphonecust).Select(n => n.ID).FirstOrDefault();
            if (del != 0)
            {
                var confirm = MessageBox.Show("Are you sure to delete this item ??", "confirm delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    var remov = (Customer)context.Customers.Where(i => i.ID == del).First();
                    context.Customers.Remove(remov);
                    context.SaveChanges();
                    gridControl1.Refresh();
                    this.Customer_Form_Load(sender, e);
                    MessageBox.Show("the item deleted");
                }
                else
                {
                    MessageBox.Show("the item not deleted");
                }
            }
            else
            {
                MessageBox.Show("enter valid phone number");
            }
        }

        private void GridControl2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.reset();
            int x = e.RowIndex;
            DataGridViewRow row = gridControl2.Rows[x];
            try
            {
                idp = row.Cells[0].Value.ToString();
                combomob.Text= row.Cells[1].Value.ToString();
                textQuantity.Text= row.Cells[2].Value.ToString();
                textCustomerPhone.Text = row.Cells[3].Value.ToString();
                comtype.Text = row.Cells[4].Value.ToString();
              
            }
            catch
            {
            }
        }
        public void reset()
        {
            combomob.Text = "";
            textQuantity.Text = "";
            textCustomerPhone.Text = "";
            comtype.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var phfind = context.customerProducts.Where(v => v.CustomerPhone == CPhone).Select(v => v.ID).FirstOrDefault();
            if (phfind != 0)
            {
                var confirm = MessageBox.Show("Are you sure to delete this item ??", "confirm delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    var remov = (CustomerProduct)context.customerProducts.Where(i => i.ID == phfind).First();
                    context.customerProducts.Remove(remov);
                    context.SaveChanges();
                    gridControl2.Refresh();
                    this.Customer_Form_Load(sender, e);
                    MessageBox.Show("the item deleted");
                }
                else
                {
                    MessageBox.Show("the item not deleted");
                }
            }
            else
            {
                MessageBox.Show("make sure you are enter valid phone number");
            }
        }

        private void Combomob_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (combomob.Text.Trim() != "")
                {
                    product = combomob.Text.ToString().ToLower();
                }

            }
            catch
            {
                MessageBox.Show("invalid mobile name");
            }
        }

        private void Btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerProduct cust = new CustomerProduct();
                int del = context.Customers.Where(n => n.Phone == CPhone).Select(n => n.ID).FirstOrDefault();

                int pnm = context.mobdetailes.Where(b => b.name == product).Select(b => b.id).FirstOrDefault();
                int qnm = context.mobdetailes.Where(b => b.name == product).Select(b => b.quantity).FirstOrDefault();

                int qaccess = context.accdetailes.Where(b => b.name == product).Select(b => b.quantity).FirstOrDefault();
                int paccess= context.accdetailes.Where(b => b.name == product).Select(b => b.id).FirstOrDefault();

                int idcus = int.Parse(idp);
                int idcust = context.customerProducts.Where(g => g.ID == idcus).Select(g => g.Customer_ID).FirstOrDefault();
                if (del != 0 && pnm != 0 && quantity <= qnm&&comtype.Text=="mobile")
                {
                    var f = context.mobdetailes.Where(a => a.name == product).Select(a => a.id).FirstOrDefault();
                    bool up = cust.update(int.Parse(idp), product, CPhone, quantity, comtype.Text.ToString(), idcust);
                    if (up == true&&f!=0)
                    {
                        gridControl2.DataSource = null;
                        gridControl2.Refresh();
                        this.Customer_Form_Load(sender, e);
                        MessageBox.Show("the item updated");
                    }
                    if (up == false&&f!=0)
                    {
                        MessageBox.Show("the item not updated");
                    }
                
                }
               else if (del != 0 && paccess != 0 && quantity <= qaccess && comtype.Text == "accessory")
                {
                    bool up = cust.update(int.Parse(idp), product, CPhone, quantity, comtype.Text.ToString(), idcust);
                    var f = context.accdetailes.Where(a => a.name == product).Select(a => a.id).FirstOrDefault();
                    if (up == true && f != 0)
                    {
                        gridControl2.DataSource = null;
                        gridControl2.Refresh();
                        this.Customer_Form_Load(sender, e);
                        MessageBox.Show("the item updated");
                    }
                    if (up == false && f != 0)
                    {
                        MessageBox.Show("the item not updated");
                    }
                }
                else if (quantity > qaccess && quantity > qnm)
                {
                    MessageBox.Show("not enough quantity");

                }
                else
                {
                    MessageBox.Show("invalid inputs");
                }
               
            }

            catch
            {
                MessageBox.Show("invalid");
            }
        }

        private void Btnclear_Click(object sender, EventArgs e)
        {
            
            var confirm = MessageBox.Show("Are you sure to delete all item ??", "confirm delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                var custpro = context.customerProducts.Select(y => y).ToList();
                foreach (var itm in custpro)
                {
                    context.customerProducts.Remove(itm);
                }
                context.SaveChanges();
                gridControl2.DataSource = null;
                gridControl2.Refresh();
                this.Customer_Form_Load(sender, e);
                MessageBox.Show("the item cleared");
            }
            else
            {
                MessageBox.Show("the item not not cleared");
            }
        }

        private void Textsearch__TextChanged(object sender, EventArgs e)
        {

            if (!int.TryParse(textsearch.Texts, out textsr))
            {
                MessageBox.Show("Accept only numbers");
            }
        }
    }
}


