using Display.Utilities;
using Models;
using Newtonsoft.Json;
using System.Text;

namespace Display
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        private static readonly HttpClient httpClient = new HttpClient();
        private const string API_BASE_URL = "http://localhost:5216/api/Auth";

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            RunApp().GetAwaiter().GetResult(); // run async login logic
        }

        static async Task RunApp()
        {
            Form startForm;

            try
            {
                AuthLogin loginData = Utility.LoadLoginFile(); // You must make sure this doesn't crash if file missing
                string json = JsonConvert.SerializeObject(loginData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await httpClient.PostAsync($"{API_BASE_URL}/login", content);

                if (response.IsSuccessStatusCode)
                {
                    startForm = new HomeForms(false); // use MainForm if login successful
                }
                else
                {
                    startForm = new LoginForm(); // fallback to login screen
                }
            }
            catch
            {
                startForm = new LoginForm(); // any failure means show login screen
            }

            Application.Run(startForm);
        }
    }
}