using SoundBoardForms.Providers;

namespace SoundBoardForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.ApplicationExit += (sender, eventArgs) => { SettingsProvider.Save(); };
            Application.Run(new MainWindow());
        }
    }
}