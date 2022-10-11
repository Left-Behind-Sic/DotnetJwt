namespace DotnetJwt
{
    public class User
    {
        public string Username { get; set; } = String.Empty;
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime TokenCreated { get; set; }
        public DateTime TokenExpires { get; set; }
    }
}
