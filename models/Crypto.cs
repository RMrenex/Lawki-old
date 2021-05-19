using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LowaPasswd.models {
    class Crypto {

        private static byte[] salt = new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 };
        private static byte[] passwordBytes = Encoding.ASCII.GetBytes("V42ho5qZIUzNHAeq8g");

        public static void AES_Encrypt(string inputFile, string outputFile) {

            string cryptFile = outputFile;
            FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

            RijndaelManaged AES = new RijndaelManaged();

            AES.KeySize = 256;
            AES.BlockSize = 128;

            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Padding = PaddingMode.Zeros;

            AES.Mode = CipherMode.CBC;

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write);
            FileStream fsIn = new FileStream(inputFile, FileMode.Open);

            int data;
            while ((data = fsIn.ReadByte()) != -1) {
                cs.WriteByte((byte)data);
            }

            fsIn.Close();
            cs.Close();
            fsCrypt.Close();

            File.Delete(inputFile);
            Console.WriteLine("ENCRYPT");
        }

        public static void AES_Decrypt(string inputFile, string outputFile) {

            FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

            RijndaelManaged AES = new RijndaelManaged();

            AES.KeySize = 256;
            AES.BlockSize = 128;

            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Padding = PaddingMode.Zeros;

            AES.Mode = CipherMode.CBC;

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateDecryptor(), CryptoStreamMode.Read);
            FileStream fsOut = new FileStream(outputFile, FileMode.Create);

            int data;
            while ((data = cs.ReadByte()) != -1) {

                if (((byte)data) != 0){

                    fsOut.WriteByte((byte)data);
                }
            }

            fsOut.Close();
            cs.Close();
            fsCrypt.Close();

            File.Delete(inputFile);
            Console.WriteLine("DECRYPT");
        }

        private static byte[] GenerateRandomSalt() {

            byte[] data = new byte[32];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider()) {

                for (int i = 0; i < 10; i++) {

                    rng.GetBytes(data);
                }
            }
            return data;
        }

    }
}

