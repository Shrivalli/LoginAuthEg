using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LoginAuthEg.Models
{
    public class Product
    {
        [Key]
        public int Pid { get; set; }
        public string Pname { get; set; }
        public float Price { get; set; }

        public virtual Supplier Suppid { get; set; }
    }
}
