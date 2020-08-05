using crud_netcore.Models;

namespace crud_netcore.DTO
{
    public class AuthToken
    {
        public UserModel User { get; set; }
        public string Token { get; set; }
        public bool IsOK { get; set; }
    }
}