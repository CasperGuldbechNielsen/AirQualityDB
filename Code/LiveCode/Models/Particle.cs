namespace LiveCode.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Particle
    {
        [Key]
        public int Particles_Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateTimeStart { get; set; }

        public double? NumberOfParticlesTotal { get; set; }

        public double? VTotal { get; set; }
    }
}
