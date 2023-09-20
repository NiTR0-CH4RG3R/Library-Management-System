using lms_client.Model;

namespace lms_client
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // This causes LmsClientApplication singleton to be initialize at the begining of the program
            var app = LmsClientApplication.Instance;
            //app.Database.Test();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var formDashboard = new View.Dashboard();
            Application.Run(formDashboard);
        }
    }
}