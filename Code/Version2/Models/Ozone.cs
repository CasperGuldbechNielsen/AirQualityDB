namespace Version2.Models
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
        [Display(Name = "Measurements Taken")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{yyyy-MM-dd HH:mm:ss}")]
        public DateTime DateTimeStart { get; set; }

        [Display(Name = "Ozone (O3)")]
        public double? Ozone1 { get; set; }

        [Required]
        [StringLength(10)]
        public string Unit { get; set; }
    }
}
