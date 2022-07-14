using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GlobalTrans.Models
{
    public class Client
    {

        [Key]
        [DisplayName("Client ID:")]
        public int id_client{ get; set; }
        [DisplayName("Company name:")]
        public string name_company { get; set; }
        [DisplayName("Name:")]
        public string name { get; set; }
        [DisplayName("Surname:")]
        public string surname { get; set; }
        [DisplayName("Nip")]
        public string nip{ get; set; }  
        [DisplayName("Zip Code:")]
        public string zipCode { get; set; }
        [DisplayName("City:")]
        public string city { get; set; }
        [DisplayName("Street:")]
        public string street { get; set; }
        [DisplayName("Phone Number:")]
        public string phoneNumber { get; set; }
        [DisplayName("Mail:")]
        public string mail { get; set; }



    }
}
