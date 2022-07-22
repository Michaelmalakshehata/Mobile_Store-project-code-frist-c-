using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
   public partial class accessierimages
    {
        /// cteate table in databse with relation one to one table mobile detailes


        public int id { set; get; }
        [Required]
        public string nameproduct { get; set; }
        public byte[] productimg1 { get; set; }
        public byte[] productimg2 { get; set; }
        public byte[] productimg3 { get; set; }
       
        public virtual accessierdetaile Accessierdetaile { set; get; }

      
    }
}
