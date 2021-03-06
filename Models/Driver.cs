using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GlobalTrans.Models
{
    public class Driver
    {
        [Key]
        [DisplayName("Driver ID:")]
        public int id_driver { get; set; }
        [DisplayName("Name:")]
        public string name { get; set; }
        [DisplayName("Surname:")]
        public string surname { get; set; }
        [DisplayName("Date of birth:")]
        public DateTime dateOfBirth { get; set; }
        [DisplayName("Personal ID Number:")]
        public string personalIDNumber { get; set; }
        [DisplayName("Zip Code:")]
        public string zipCode { get; set; }
        [DisplayName("City:")]
        public string city { get; set; }
        [DisplayName("Street:")]
        public string street { get; set; }
        [DisplayName("House Number:")]
        public string houseNumber { get; set; }
        [DisplayName("Flat Number:")]
        public string flatNumber { get; set; }
        [DisplayName("Phone Number:")]
        public string phoneNumber { get; set; }
        [DisplayName("Mail:")]
        public string mail { get; set; }
        

        




    }
}
