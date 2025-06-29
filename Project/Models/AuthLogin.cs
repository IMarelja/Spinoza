using System.Xml.Linq;

namespace Models
{
    public class AuthLogin
    {
        private const char DEL = '|';
        public string username { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
        public string Formate() => $"{username}{DEL}{password}";

        public AuthLogin ParseFromFile(string line)
        {
            string[] lines = line.Split(DEL);

            return new AuthLogin
            {
                username = lines[0],
                password = lines[1]
            };
        }
    }

}
