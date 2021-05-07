using LowaPasswd.forms;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        private static string langFrFilePath = langDirectoryPath + "\\Fr.xml";
        private static string langEnFilePath = langDirectoryPath + "\\En.xml";

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
                    System.Diagnostics.Debug.WriteLine("Already Exist");
                    return;
                }

                DirectoryInfo directoryInfo = Directory.CreateDirectory(langDirectoryPath);

                using (FileStream fs = File.Create(credentialsFilePath))
                {

                    byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                    fs.Write(info, 0, info.Length);
                }

                using (FileStream fs = File.Create(langFrFilePath))
                {
                    byte[] header = new UTF8Encoding(true).GetBytes("\"<?xml version=\"1.0\" encoding=\"utf - 8\"?>\"");
                    fs.Write(header, 0, header.Length);

                    byte[] field_start = new UTF8Encoding(true).GetBytes("<field>");
                    fs.Write(field_start, 0, field_start.Length);

                    byte[] empty = new UTF8Encoding(true).GetBytes("<add key=\"empty_field\" value=" + Language.EMPTY_FIELD_FR +"/>");
                    fs.Write(empty, 0, empty.Length);

                    byte[] multi = new UTF8Encoding(true).GetBytes("<add key=\"multi_lines\" value=" + Language.MULTI_LINES_FR + "/>");
                    fs.Write(multi, 0, multi.Length);

                    byte[] nameAlreadyUse = new UTF8Encoding(true).GetBytes("<add key=\"name_already_use\" value=" + Language.NAME_ALREADY_USE_FR + "/>");
                    fs.Write(nameAlreadyUse, 0, nameAlreadyUse.Length);

                    byte[] field_end = new UTF8Encoding(true).GetBytes("</field>");
                    fs.Write(field_end, 0, field_end.Length);
                }

                using (FileStream fs = File.Create(langEnFilePath)) {
                    byte[] header = new UTF8Encoding(true).GetBytes("\"<?xml version=\"1.0\" encoding=\"utf - 8\"?>\"");
                    fs.Write(header, 0, header.Length);

                    byte[] field_start = new UTF8Encoding(true).GetBytes("<field>");
                    fs.Write(field_start, 0, field_start.Length);

                    byte[] empty = new UTF8Encoding(true).GetBytes("<add key=\"empty_field\" value=" + Language.EMPTY_FIELD_EN + "/>");
                    fs.Write(empty, 0, empty.Length);

                    byte[] multi = new UTF8Encoding(true).GetBytes("<add key=\"multi_lines\" value=" + Language.MULTI_LINES_EN + "/>");
                    fs.Write(multi, 0, multi.Length);

                    byte[] nameAlreadyUse = new UTF8Encoding(true).GetBytes("<add key=\"name_already_use\" value=" + Language.NAME_ALREADY_USE_EN + "/>");
                    fs.Write(nameAlreadyUse, 0, nameAlreadyUse.Length);

                    byte[] field_end = new UTF8Encoding(true).GetBytes("</field>");
                    fs.Write(field_end, 0, field_end.Length);
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
        }

        public static List<Categorie> loadDatabaseFile() {

            var categories = new List<Categorie>();

            using (StreamReader reader = new StreamReader(credentialsFilePath)) {

                string json = reader.ReadToEnd();
                categories = JsonConvert.DeserializeObject<List<Categorie>>(json);
            }
            return categories;
        }

    }
}
