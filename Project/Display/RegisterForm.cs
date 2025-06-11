using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Display.LoginForm;

namespace Display
{
    public partial class RegisterForm : Form
    {
        private static readonly HttpClient httpClient = new HttpClient();
        private const string API_BASE_URL = " http://localhost:5216/api/Auth";

        public RegisterForm()
        {
            InitializeComponent();

            tbPassword.PasswordChar = '⬤';
            tbPasswordAgain.PasswordChar = '⬤';
            lbMessage.Visible = false;
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();
            lbMessage.Visible = false;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lbMessage.ForeColor = Color.Red;
                lbMessage.Text = "Username and password are required.";
                return;
            }

            if (tbPassword.Text != tbPasswordAgain.Text)
            {
                lbMessage.ForeColor = Color.Red;
                lbMessage.Text = "Passwords do not match";
                return;
            }

            AuthLogin registerData = new AuthLogin { 
                username = username,
                password = password
            };


            string json = JsonConvert.SerializeObject(registerData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");


            btnRegister.Enabled = false;
            btnRegister.Text = "Registering...";

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                HttpResponseMessage response = await httpClient.PostAsync($"{API_BASE_URL}/register", content);
                
                string responseText = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<Dictionary<string, string>>(responseText);

                if (response.IsSuccessStatusCode)
                {
                    lbMessage.ForeColor = Color.Green;
                    lbMessage.Visible = true;
                    lbMessage.Text = responseObject["message"];

                    //Utility.SaveLoginToFile(loginData);

                    await Task.Delay(2000);

                    this.Hide();
                    var homeForm = new HomeForms(true);

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
                lbMessage.ForeColor = Color.Red;
                lbMessage.Text = "Error: " + ex.Message;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                btnRegister.Enabled = true;
                btnRegister.Text = "Register";
            }
        }
    }
}
