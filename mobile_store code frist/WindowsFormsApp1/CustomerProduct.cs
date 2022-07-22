using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;
using main;


namespace main
{
    public class CustomerProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string ProductName { get; set; }

        [Required]
        public int Quantity { get; set; }
        [Required]
        public int CustomerPhone { get; set; }
        [Required]
        public string typeproduct { set; get; }


        [ForeignKey("Customer")]
        [Required]
        public int Customer_ID { get; set; }
        public Customer Customer { get; set; }

        
        public virtual ICollection<Bill> Bills { get; set; }
        accessContext context = new accessContext();

        public bool update(int id, string product, int CPhone, int quantity, string typeproduct, int idcust)
        {
            try
            {
                CustomerProduct dataobject = new CustomerProduct() { ID = id, ProductName = product, CustomerPhone = CPhone, Quantity = quantity, typeproduct = typeproduct, Customer_ID = idcust };
                context.customerProducts.Attach(dataobject);
                context.Entry(dataobject).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
