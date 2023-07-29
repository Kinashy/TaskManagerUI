using NLog;

namespace TaskManagerUI
{
    internal static class Program
    {
        public static Logger Logger = LogManager.GetCurrentClassLogger();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Logger.Info("Start application.");
            Application.Run(new MainViewForm());
            Logger.Info("Stop application.");

        }
    }
}