using main;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace main
{
    public class Bill
    {
  
        public int Id { get; set; }
       public int customer_phone { set; get; }
       public string productname { set; get; }
        public int quantity { get; set; }
        public double  Price { get; set; }
     
        public virtual ICollection<mobildetaile> Mobildetailes { get; set; }
        public Customer Customer { get; set; }
        public virtual ICollection<CustomerProduct> CustomerProducts { get; set; }

        public virtual ICollection<accessierdetaile> Accessierdetailes { get; set; }



    }
}
