using System.ComponentModel.DataAnnotations;

namespace DA3.Service.Request
{
    public class LoginRequest
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
