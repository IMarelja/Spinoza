using Display.Utilities;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Display
{
    public partial class LoginForm : Form
    {
        private static readonly HttpClient httpClient = new HttpClient();
        private const string API_BASE_URL = " http://localhost:5216/api/Auth";
        public class ApiResponse
        {
            public string message { get; set; } = string.Empty;
            public int userId { get; set; }
        }

        public LoginForm()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '⬤';
            lbMessage.Visible = false;
        }

        private async void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();
            lbMessage.Visible = false;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lbMessage.Visible = true;
                lbMessage.ForeColor = Color.Red;
                lbMessage.Text = "Username and password are required.";
                return;
            }

            AuthLogin loginData = new AuthLogin
            {
                username = username,
                password = password
            };

            String json = JsonConvert.SerializeObject(loginData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            btnLogIn.Enabled = false;
            btnLogIn.Text = "Logging in...";

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                
                HttpResponseMessage response = await httpClient.PostAsync($"{API_BASE_URL}/login", content);

                string responseText = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<Dictionary<string, string>>(responseText);

                if (response.IsSuccessStatusCode)
                {
                    lbMessage.ForeColor = Color.Green;
                    lbMessage.Visible = true;
                    lbMessage.Text = responseObject["message"];

                    Utility.SaveLoginToFile(loginData);

                    await Task.Delay(2000);

                    this.Hide();
                    var homeForm = new HomeForms(false);

                    Cursor.Current = Cursors.Default;
                    homeForm.Closed += (object_sender, EventArgs_e) => this.Close();
                    homeForm.Show();
                }
                else
                {
                    lbMessage.ForeColor = Color.Red;
                    lbMessage.Visible = true;
                    lbMessage.Text = responseObject.ContainsKey("message") ? responseObject["message"] : "Login failed";
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Network error: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                btnLogIn.Enabled = true;
                btnLogIn.Text = "Login";
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registerForm = new RegisterForm();
            registerForm.Closed += (object_sender, EventArgs_e) => this.Close();
            registerForm.Show();
        }

        
    }
}
