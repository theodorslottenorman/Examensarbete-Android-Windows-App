using System.ComponentModel.DataAnnotations;

namespace MauiApp1.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public bool LoginFailureHidden { get; set; } = true;

        public bool ValidateLogin(out string jwtToken)
        {
            if(Username.Equals("Test") && Password.Equals("Test"))
            {
                jwtToken = "123456";
                return true;
            }

            
            jwtToken = null;
            LoginFailureHidden = false;
            return false;
        }
    }
}
