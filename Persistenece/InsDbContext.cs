using Insurance.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Persistenece
{
    public class InsDbContext :DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Feature> Features { get; set; }
        public InsDbContext(DbContextOptions<InsDbContext> options) :base(options)
        {

        }


    }
}
