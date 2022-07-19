using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GlobalTrans.Models
{
    public class Vehicle
    {
        [Key]
        [DisplayName("Vehcile id:") ]
        public int id_vehicle { get; set; }
        [DisplayName("Model:")]
        public int mdoel { get; set; }
        [DisplayName("Brand:")]
        public int brand { get; set; }
        [DisplayName("Registration Number:")]
        public int registrationNUmber { get; set; }
        [DisplayName("Year production:")]
        public int yearProduction { get; set; }
        [DisplayName("Vin number:")]
        public int vinNumber { get; set; }
        [DisplayName("Course:")]
        public int course { get; set; }
        [DisplayName("Kind of vehicle:")]
        public int rodzaj_pojazdu { get; set; }
        [DisplayName("Exhaust emissions:")]
        public int emisja_spalin { get; set; }
        
        public int fk_number_policy { get; set; }
        public int fk_id_trailers { get; set; }



    }
}
