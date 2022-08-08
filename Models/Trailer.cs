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
       
        public string numberVin { get; set; }

    }
}
