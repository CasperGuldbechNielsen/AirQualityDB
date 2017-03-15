

namespace Version2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Entity.Spatial;

    [Table("Mercury")]
    public partial class Mercury
    {
        [Key]
        public int Mercury_Id { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Measurements Taken")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateTimeStart { get; set; }

        [Display(Name = "Mercury (Hg)")]
        public double? Hg { get; set; }

        [Required]
        [StringLength(10)]
        public string Unit { get; set; }

        private AirDataModel2 db = new AirDataModel2();

        public Dictionary<string, string> ReturnDictionary()
        {
            var entities = db.Mercuries.ToList().Take(150);

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            
            foreach (var keyValuePairs in entities)
            {
                string time = keyValuePairs.DateTimeStart.ToString();
                string unit = keyValuePairs.Hg.ToString();

                dictionary.Add(time, unit);
            }
            return dictionary;
        }
    }
}
