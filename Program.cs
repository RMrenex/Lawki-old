using LowaPass;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace LowaPasswd {
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string firstStart = ConfigurationManager.AppSettings.Get("first");
            string directory = ConfigurationManager.AppSettings.Get("directory");
            string lang = ConfigurationManager.AppSettings.Get("lang");
            string theme = ConfigurationManager.AppSettings.Get("theme");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}