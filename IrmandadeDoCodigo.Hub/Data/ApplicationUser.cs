using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace IrmandadeDoCodigo.Hub.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Name { get; set; }
    }

}
