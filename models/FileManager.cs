using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace LowaPasswd.models {
    class FileManager
    {
        private static readonly string ProgramFilePath = Environment.ExpandEnvironmentVariables("%ProgramW6432%");
        public static string ApplicationDirectoryPath = ProgramFilePath + "\\LowaPass";
        private static readonly string LangDirectoryPath = ApplicationDirectoryPath + "\\lang";
        private static string themeDirectoryPath = ApplicationDirectoryPath + "\\theme";
        private static readonly string CredentialsFilePath = ApplicationDirectoryPath + "\\credentials.json";
        private static readonly string CredentialsEncryptFilePath = ApplicationDirectoryPath + "\\credentialsAES.json";
        //private static string langFrFilePath = langDirectoryPath + "\\Fr.xml";
        //private static string langEnFilePath = langDirectoryPath + "\\En.xml";

        public static void CreateApplicationDirectory()
        {

            try
            {

                if (Directory.Exists(ApplicationDirectoryPath))
                {
                    System.Diagnostics.Debug.WriteLine("Already Exist");
                    return;
                }

                DirectoryInfo directoryInfo = Directory.CreateDirectory(ApplicationDirectoryPath);
                System.Diagnostics.Debug.WriteLine("Created");

            }

            catch (Exception e)
            {
                Console.WriteLine(@"The process failed: {0}", e.ToString());
            }
        }

        public static void SetupApplicationFiles()
        {

            try
            {

                if (Directory.Exists(LangDirectoryPath)) {
                    System.Diagnostics.Debug.WriteLine("Already Exist LANG D");
                }
                else {
                    DirectoryInfo directoryInfo = Directory.CreateDirectory(LangDirectoryPath);
                }

                if (!File.Exists(CredentialsFilePath) && !File.Exists(CredentialsEncryptFilePath)) {

                    using (StreamWriter sw = File.CreateText(CredentialsFilePath)) {
                        sw.WriteLine("");
                    }
                }
                else {
                    LoadDatabaseFile();
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void WriteInFile() {

            using (StreamWriter file = File.CreateText(CredentialsFilePath))
            {
                JsonSerializer serializer = new JsonSerializer();

                serializer.Serialize(file, Category.Categories_);
            }

            //Crypto.AES_Encrypt(CredentialsFilePath, CredentialsEncryptFilePath);
        }

        private static void LoadDatabaseFile() {

            var categories = new List<Category>();

            //Crypto.AES_Decrypt(CredentialsEncryptFilePath, CredentialsFilePath);

            using (StreamReader reader = new StreamReader(CredentialsFilePath)) {

                string json = reader.ReadToEnd();
                categories = JsonConvert.DeserializeObject<List<Category>>(json);
            }

            Category.Categories_.AddRange(categories);
        }

    }
}
