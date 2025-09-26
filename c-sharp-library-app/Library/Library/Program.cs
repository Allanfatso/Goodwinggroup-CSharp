using System;
using System.Windows.Forms;

namespace Library
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
   
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // standard modern WinForms init for .NET 6+
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            Application.Run(new MainForm());
        }
    }
}