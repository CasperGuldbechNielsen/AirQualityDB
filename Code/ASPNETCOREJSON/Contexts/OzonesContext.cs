using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCOREJSON.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCOREJSON.Contexts
{
    public class OzonesContext : DbContext
    {
        public OzonesContext(DbContextOptions<OzonesContext> options)
            : base(options) { }

        public OzonesContext()
        {
        }
        public DbSet<Ozone> Ozone { get; set; }
    }
}
