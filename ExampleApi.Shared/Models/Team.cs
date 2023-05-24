using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExampleApi.Shared.Models
{
    public class Team
    {
        [Key]
        public int ID { get; set; }
        public string Description { get; set; } = null;
        public int? PersonInCharge { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public int? Capacity { get; set; }
        public string VehicleNumber { get; set; } = null;
        public string Note { get; set; } = null;
        public Boolean IsInactive { get; set; } = false;

    }
}