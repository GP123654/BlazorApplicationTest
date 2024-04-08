using System.ComponentModel.DataAnnotations;

namespace BlazorApp3.Data
{
    public class User
    {
        [EmailAddress]
        [Required]
        public string LoginName { get; set; } = String.Empty;

        [Required]
        public string UserRole { get; set; } = String.Empty;
    }
}
