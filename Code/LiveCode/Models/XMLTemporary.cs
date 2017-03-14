namespace LiveCode.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("XMLTemporary")]
    public partial class XMLTemporary
    {
        [Key]
        public int XMLTemporary_Id { get; set; }

        [Column(TypeName = "xml")]
        [Required]
        public string XMLData { get; set; }

        [Column(TypeName = "date")]
        public DateTime InsertedDate { get; set; }
    }
}
