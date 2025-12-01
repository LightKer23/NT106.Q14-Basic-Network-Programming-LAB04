using Bai07.Forms;
using Bai07.Services;

namespace Bai07
{
    internal static class Program
    {
        public static ApiClient ApiClient { get; private set; } 
        public static AuthService AuthService { get; private set; }
        public static FoodService FoodService { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApiClient = new ApiClient(); ;
            AuthService = new AuthService(ApiClient);
            FoodService = new FoodService(ApiClient);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}