using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace Display
{
    public partial class Login : Form
    {

        private const string Path = "users.txt";
        public Login()
        {
            InitializeComponent();
            lblPasswordError.Visible = false;
            lblUsernameError.Visible = false;
            CkeckFile(Path);

        }

        private void CkeckFile(string path)
        {
            if (!File.Exists(Path))
            {
                File.Create(Path).Close();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                var users = GetAllUsers();

                if (!users.Any(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
                {
                    var newUser = new User
                    {
                        Id = users.Count > 0 ? users.Max(u => u.Id) + 1 : 1,
                        Username = username,
                        Password = password
                    };

                    users.Add(newUser);
                    SaveAllUsers(users);
                    this.Close();
                }
                lblUsernameError.Text = "Usename already in use";

            }
            else if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
            {
                lblPasswordError.Visible = true;
                lblUsernameError.Visible = true;
            }
            else if (string.IsNullOrEmpty(username))
            {
                lblUsernameError.Visible = true;
            }
            else if (string.IsNullOrEmpty(password))
            {
                lblPasswordError.Visible = true;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                var users = GetAllUsers();

                
                LogIn(username, password);

                

            }
            else if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
            {
                lblPasswordError.Visible = true;
                lblUsernameError.Visible = true;
            }
            else if (string.IsNullOrEmpty(username))
            {
                lblUsernameError.Visible = true;
            }
            else if (string.IsNullOrEmpty(password))
            {
                lblPasswordError.Visible = true;
            }
        }



        // Validate username and password
        public bool LogIn(string username, string password)
        {
            var users = GetAllUsers();
            var user = users.FirstOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

            if (user == null)
            {
                lblPasswordError.Visible = true;
                lblPasswordError.Text = "Password or Username incorreect";
                return false;
            }

            if (user.Password == password)
            {
                this.Close();
                return true;

            }
            else
            {
                lblPasswordError.Visible = true;
                lblPasswordError.Text = "Password or Username incorreect";
                return false;
            }
        }

        // Read all users from the file
        private IList<User> GetAllUsers()
        {
            IList<User> users = new List<User>();
            string[] lines = File.ReadAllLines(Path);
            lines.ToList().ForEach(line => users.Add(User.Parser(line)));
            return users;
        }

        // Save all users to the file
        private void SaveAllUsers(IList<User> users) => File.WriteAllLines(Path, users.Select(p => p.Format()));
    }
}
