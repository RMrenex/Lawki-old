using LowaPass;
using LowaPasswd.models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LowaPasswd {
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        /// 
        private static string directory;
        private static string lang;
        private static string theme;
        private static XDocument lang_file;
        private static Dictionary<string, string> xmlFields = new Dictionary<string, string>();

        [STAThread]
        static void Main()
        {
            FileManager.SetupApplicationFiles();

            if (ConfigurationManager.AppSettings.Get("first").Equals("true")) {

                directory = ConfigurationManager.AppSettings.Get("directory");
                lang = ConfigurationManager.AppSettings.Get("lang");

                if (lang.Equals("fr")) {
                    lang_file = XDocument.Load(FileManager.ApplicationDirectoryPath + "/lang/Fr.xml");
                }
                else {
                    lang_file = XDocument.Load(FileManager.ApplicationDirectoryPath + "/lang/En.xml");
                }

                xmlFields = lang_file.Descendants("add").ToDictionary(key => key.Attribute("key").Value, value => value.Attribute("value").Value);
                Theme = ConfigurationManager.AppSettings.Get("theme");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static string Directory { get => directory; set => directory = value; }
        public static string Lang { get => lang; set => lang = value; }
        public static string Theme { get => theme; set => theme = value; }
        public static Dictionary<string, string> Fields { get => xmlFields; set => xmlFields = value; }
        public static XDocument Lang_file { get => lang_file; set => lang_file = value; }
    }
}