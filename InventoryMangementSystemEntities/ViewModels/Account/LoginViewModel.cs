using System.ComponentModel.DataAnnotations;

namespace InventoryMangementSystemEntities.ViewModels.Account
{
    public class LoginViewModel
    {
        [Display(Name = "User name")]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Display(Name ="Remember me")]
        public bool RememberMe { get; set; }
    }
}
