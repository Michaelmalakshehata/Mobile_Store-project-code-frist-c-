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
    public partial class Reports : DevExpress.XtraEditors.XtraForm
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            accessContext context = new accessContext();
            var c = context.Bills.Select(n => new { n.Id,n.customer_phone,n.productname,n.quantity, n.Price }).ToList();
            BillBindingSource.DataSource = c;
            this.reportViewer1.RefreshReport();
        }
    }
}