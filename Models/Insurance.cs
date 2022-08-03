using System.ComponentModel.DataAnnotations;

namespace GlobalTrans.Models
{
    public class Insurance
    {
        [Key]
        public int id_police { get; set; }
        public DateTime startDateInsurance { get; set; }
        public DateTime endDateInsurance { get; set; }
        public int contribution { get; set; }
        public Boolean isPaid { get; set; }


    }
}
