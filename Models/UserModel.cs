using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace crud_netcore.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        
        public string Username { get; set; }

        [MaxLength(60), JsonIgnore]
        public string PasswordHash { get; set; }

        [MaxLength(28), JsonIgnore]
        public string PasswordSalt { get; set; }

    }
}