using CefSharp.WinForms;

namespace CefSharpWinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var settings = new CefSettings();
            settings.LogSeverity = CefSharp.LogSeverity.Error;
            settings.LogFile = "debug.log";
            CefSharp.Cef.Initialize(settings);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}