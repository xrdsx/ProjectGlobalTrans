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
        public int lengthLoad { get; set; }
        [DisplayName("Type of cargo:")]
        public string kindOf { get; set; }



    }
}
