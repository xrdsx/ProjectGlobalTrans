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
        public int fk_id_client { get; set; }
        public int fk_id_driver { get; set; }
        public int fk_id_load { get; set; }
        public int fk_id_trailer { get; set; }
        public int fk_id_vehicle { get; set; }
    }
}
