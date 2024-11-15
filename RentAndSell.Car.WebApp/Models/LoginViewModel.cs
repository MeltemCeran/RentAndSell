using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RentAndSell.Car.WebApp.Models
{
    public class LoginViewModel
    {
        [DisplayName("Kullanıcı Adı")]

        public string UserName { get; set; }
        [DisplayName("Şifre")]
        [DataType(DataType.Password)]

        public string Password { get; set; }
    }
}
