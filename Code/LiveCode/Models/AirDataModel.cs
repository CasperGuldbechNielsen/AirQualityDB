namespace LiveCode.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AirDataModel : DbContext
    {
        public AirDataModel()
            : base("name=AirDataModel")
        {
        }

        public virtual DbSet<Mercury> Mercuries { get; set; }
        public virtual DbSet<Meteorology> Meteorologies { get; set; }
        public virtual DbSet<Ozone> Ozones { get; set; }
        public virtual DbSet<Particle> Particles { get; set; }
        public virtual DbSet<Precipitation> Precipitations { get; set; }
        public virtual DbSet<StationTemperature> StationTemperatures { get; set; }
        public virtual DbSet<XMLTemporary> XMLTemporaries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mercury>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<Ozone>()
                .Property(e => e.Unit)
                .IsUnicode(false);
        }
    }
}
