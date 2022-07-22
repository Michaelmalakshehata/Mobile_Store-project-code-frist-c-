using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using main;
using WindowsFormsApp1;

namespace main
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public int Phone { get; set; }
        public string Address { get; set; }
      
        public virtual ICollection<CustomerProduct> CustomerProducts { get; set; }
       
        public virtual ICollection<Bill> Bills { get; set; }







    }
}
