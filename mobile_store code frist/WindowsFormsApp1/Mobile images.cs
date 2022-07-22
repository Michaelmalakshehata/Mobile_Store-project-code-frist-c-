using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public class mobile_images
    {
        /// create table in databse with relation one to one table mobile detailes

        [Key]
        [ForeignKey("Mobildetaile")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mobildetaileId { get; set; }
        [Required]
        public string nameproduct { get; set; }
        public byte[] productimg1 { get; set; }
        public byte[] productimg2 { get; set; }
        public byte[] productimg3 { get; set; }
        public virtual mobildetaile Mobildetaile { set; get; }
      
     

    }
}
