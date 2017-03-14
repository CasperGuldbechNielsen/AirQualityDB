namespace LiveCode.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Meteorology")]
    public partial class Meteorology
    {
        [Key]
        public int Meteorology_Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateTimeStart { get; set; }

        public double? WindDirection { get; set; }

        public double? WindSpeed { get; set; }

        public double? Temperature { get; set; }

        public double? Humidity { get; set; }

        public double? Radiation { get; set; }

        public double? Pressure { get; set; }
    }
}
