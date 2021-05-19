using LowaPasswd.forms;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LowaPasswd.models
{
    class FileManager
    {
        private static string programFilePath = Environment.ExpandEnvironmentVariables("%ProgramW6432%");
        public static string applicationDirectoryPath = programFilePath + "\\LowaPass";
        private static string langDirectoryPath = applicationDirectoryPath + "\\lang";
        private static string themeDirectoryPath = applicationDirectoryPath + "\\theme";
        private static string credentialsFilePath = applicationDirectoryPath + "\\credentials.json";
        private static string credentialsEncryptFilePath = applicationDirectoryPath + "\\credentialsAES.json";
        //private static string langFrFilePath = langDirectoryPath + "\\Fr.xml";
        //private static string langEnFilePath = langDirectoryPath + "\\En.xml";

        public static void createApplicationDirectory()
        {

            try
            {

                if (Directory.Exists(applicationDirectoryPath))
                {
                    System.Diagnostics.Debug.WriteLine("Already Exist");
                    return;
                }

                DirectoryInfo directoryInfo = Directory.CreateDirectory(applicationDirectoryPath);
                System.Diagnostics.Debug.WriteLine("Created");

            }

            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }

        public static void setupApplicationFiles()
        {

            try
            {

                if (Directory.Exists(langDirectoryPath)) {
                    System.Diagnostics.Debug.WriteLine("Already Exist LANG D");
                }
                else {
                    DirectoryInfo directoryInfo = Directory.CreateDirectory(langDirectoryPath);
                }

                if (!File.Exists(credentialsFilePath) && !File.Exists(credentialsEncryptFilePath)) {

                    using (StreamWriter sw = File.CreateText(credentialsFilePath)) {
                        sw.WriteLine("");
                    }
                }
                else {
                    loadDatabaseFile();
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void writeInFile() {

            using (StreamWriter file = File.CreateText(credentialsFilePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, Categorie.Categories_);
            }

            Crypto.AES_Encrypt(credentialsFilePath, credentialsEncryptFilePath);
        }

        private static List<Categorie> loadDatabaseFile() {

            var categories = new List<Categorie>();

            Crypto.AES_Decrypt(credentialsEncryptFilePath, credentialsFilePath);

            //using (StreamReader reader = new StreamReader(credentialsFilePath)) {

            //    string json = reader.ReadToEnd();
            //    categories = JsonConvert.DeserializeObject<List<Categorie>>(json);
            //}
            return categories;
        }

    }
}
