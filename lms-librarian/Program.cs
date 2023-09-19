using lms_librarian.Model;

namespace lms_librarian
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // This causes LmsLibrarianApplication singleton to be initialize at the begining of the program
            var app = LmsLibrarianApplication.Instance;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new lms_common.View.Login());
        }
    }
}