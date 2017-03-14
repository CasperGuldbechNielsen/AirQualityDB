namespace LiveCode.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ozone")]
    public partial class Ozone
    {
        [Key]
        public int Ozone_Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateTimeStart { get; set; }

        [Column("Ozone")]
        public double? Ozone1 { get; set; }

        [Required]
        [StringLength(10)]
        public string Unit { get; set; }
    }
}
