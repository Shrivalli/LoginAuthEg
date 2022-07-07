using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginAuthEg.Models
{
    public class OrgContext:DbContext
    {
        public OrgContext() { }
        public OrgContext(DbContextOptions options):base(options)
        { }

        public DbSet<Users> users { get; set; }
        public DbSet<Supplier> suppliers { get; set; }
        public DbSet<Product> products { get; set; }
    }
}
