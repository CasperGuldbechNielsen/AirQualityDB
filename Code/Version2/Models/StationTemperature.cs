namespace Version2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StationTemperature")]
    public partial class StationTemperature
    {
        [Key]
        public int StationTemperature_Id { get; set; }

        public DateTime DateTimeStart { get; set; }

        public double? Temperature { get; set; }

        public double? RoomHumidity { get; set; }
    }
}
