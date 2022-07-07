using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LoginAuthEg.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; }
        public string Sname { get; set; }
        public string loc { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
