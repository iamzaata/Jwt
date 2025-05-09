namespace Jwt.Models
{
    public class LoginHistory
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public DateTime LoginDate { get; set; }
    }
}
