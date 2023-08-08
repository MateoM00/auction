using System.ComponentModel.DataAnnotations;

namespace eAuction.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
    }
}
