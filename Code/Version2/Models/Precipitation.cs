namespace Version2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Precipitation")]
    public partial class Precipitation
    {
        [Key]
        public int Precipitation_Id { get; set; }

        public DateTime DateTimeStart { get; set; }

        public double? PrepHour { get; set; }

        public double? PrepTotal { get; set; }
    }
}
