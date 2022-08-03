using System.ComponentModel.DataAnnotations;

namespace GlobalTrans.Models
{
    public class Trailer
    {
        [Key]
        public int id_trailer { get; set; }
        public string registrationNumber { get; set; }
        public int load { get; set; }
        public int height { get; set; }
        public int length { get; set; }
        public int vinNumber { get; set; }
        public int fk_id_vehicle {get; set;}
        public string fk_nr_police { get; set; }
        public string numberVin { get; set; }

    }
}
