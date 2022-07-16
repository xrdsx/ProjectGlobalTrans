using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GlobalTrans.Models
{
    public class Load
    {
        [Key]
        [DisplayName("Load ID:")]
        public int id_load { get; set; }
        [DisplayName("Weight load:")]
        public int weightLoad { get; set; }
        [DisplayName("Length load:")]
        public int length { get; set; }
        [DisplayName("Type of cargo:")]
        public int kindOf { get; set; }



    }
}
