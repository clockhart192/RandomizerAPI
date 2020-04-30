using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RandomizerAPI.Models.BaseModels
{
    public class Zone
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public int OrderID { get; set; } = 0;
        [NotMapped]
        public List<Location> Locations { get; set; }
    }
}
