using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCOREJSON.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCOREJSON.Contexts
{
    public class MercuriesContext : DbContext
    {
        public MercuriesContext(DbContextOptions<MercuriesContext> options)
            : base(options){}

        public MercuriesContext()
        {
        }
        public DbSet<Mercury> Mercury { get; set; }

    }
}
