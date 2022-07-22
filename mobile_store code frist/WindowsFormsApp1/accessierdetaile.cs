using main;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace main
{
   public partial class accessierdetaile
    {
        /// code frist create mobile detailes table with relation one to one 
        #region data
        public int id { get; private set; }
        [Required]
        public string name { get; set; }
        [Required]
        public double price { get; set; }
        public string type { get; set; }   
        public int quantity { get; set; }
        public double warranty { get; set; }
        public string date { get; set; }
        public virtual accessierimages Accessierimages { get;set;}
        public virtual ICollection<Bill> Bills { get; set; }


        accessContext context = new accessContext();
        #endregion

        //add new item and if exist increase with new quantity
        #region add function
        public bool Add(string nms,double prices,string types, int quantitys, double warrantys,string dates)
        {
            var datashow = context.accdetailes.Where(n => n.name == nms).Select(n => n.name).FirstOrDefault();
            if (datashow == null)
            {
                accessierdetaile dataobject = new accessierdetaile() { name = nms, price = prices, type = types, quantity = quantitys, warranty = warrantys, date = dates };
                context.accdetailes.Add(dataobject);
                context.SaveChanges();
                return true;
        }
            else
            {
                   int q = context.accdetailes.Where(n => n.name == nms).Select(n => n.quantity).FirstOrDefault();
        int newquantity = q + quantitys;
        int indexrow = context.accdetailes.Where(m => m.name == nms).Select(m => m.id).FirstOrDefault();
        accessierdetaile dataobject = new accessierdetaile() { id = indexrow, name = nms, price = prices, type = types, quantity = newquantity, warranty = warrantys, date = dates };
        context.Entry(dataobject).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                    return false;
            }

        }
        #endregion

        ///function to update searched item
        #region update function
        public bool update(string nms, double prices, string types, int quantitys, double warrantys, string dates)
        {
            try
            {
                int indexrow = context.accdetailes.Where(m => m.name == nms).Select(m => m.id).FirstOrDefault();
                accessierdetaile dataobject = new accessierdetaile() { id = indexrow, name = nms, price = prices, type = types, quantity = quantitys, warranty = warrantys, date = dates };
                context.Entry(dataobject).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

    }
}
