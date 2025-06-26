namespace Models
{
    public class User
    {
        public int id { get; set; }
        public string username { get; set; } = string.Empty;
        public string passwordHash { get; set; } = string.Empty;
    }

}