using System.ComponentModel.DataAnnotations;

namespace GlobalTrans.Models
{
    public class Road
    {
        [Key]
        public int id_road { get; set; }
        public string placeOfLoading { get; set; }
        public string placeOfUnloading { get; set; }
        public int routeLength { get; set; }
        public int fk_id_driver { get; set; }
        
    }
}
