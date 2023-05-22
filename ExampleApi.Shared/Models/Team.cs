using System.ComponentModel.DataAnnotations.Schema;

namespace ExampleApi.Shared.Models
{
    [Table("Teams")]
    public class Team
    {

        public int ID {get; set;}  

        [Column("Bezeichnung")]
        public string Description { get; set; } = null;

        [Column("Zustaendigkeit")]
        public int? PersonInCharge {get; set;}

        [Column("GueltigAb")] 
        public DateTime? ValidFrom {get; set;}

        [Column("GueltigBis")]
        public DateTime? ValidTo {get; set; }

        [Column("Kapazitaet")]
        public int? Capacity {get; set;}

        [Column("FahrzeugNr")]
        public string VehicleNumber {get; set;} = null;

        [Column("Notiz")]
        public string Note { get; set; } = null;

        [Column("Inaktiv")]
        public Boolean IsInactive { get; set; } = false;  

    }
}