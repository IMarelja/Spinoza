using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Models
{
    public class User
    {
        private const string Path = "users.txt";
        private const char DELIMITER = '|';


        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User()
        {
            if (!File.Exists(Path))
            {
                File.Create(Path).Close();
            }
        }
        public string Format() => $"{Id}{DELIMITER}{Username}{DELIMITER}{Password}";

        public static User Parser(string line)
        {
            string[] details = line.Split(DELIMITER);
            return new User
            {
                Id = int.Parse(details[0]),
                Username = details[1],
                Password = details[2]
            };
        }
    }
}