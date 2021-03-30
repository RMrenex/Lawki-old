using System;
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
        private static string applicationDirectoryPath = programFilePath + "\\LowaPass";
        private static string credentialsFilePath = applicationDirectoryPath + "\\credentials.json";

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

        public static void createJsonDatabaseFile()
        {

            try
            {

                using (FileStream fs = File.Create(credentialsFilePath))
                {

                    byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                    fs.Write(info, 0, info.Length);
                }

                using (StreamReader sr = File.OpenText(credentialsFilePath))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

    }
}
