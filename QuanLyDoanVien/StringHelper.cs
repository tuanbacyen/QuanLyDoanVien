using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace QuanLyDoanVien
{
    public class StringHelper
    {
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public static string GetLine(string path, int line)
        {
            using (var sr = new StreamReader(path))
            {
                for (int i = 1; i < line; i++)
                    sr.ReadLine();
                return sr.ReadLine();
            }
        }

        public static void WriteLine(string path, string[] line)
        {
            bool FileTonTai = File.Exists(path);
            if (!FileTonTai)
            {
                File.Create(path).Dispose();
                using (StreamWriter tw = new StreamWriter(path))
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        tw.WriteLine(line[i]);
                    }
                }

            }

            else if (FileTonTai)
            {
                using (StreamWriter tw = new StreamWriter(path))
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        tw.WriteLine(line[i]);
                    }
                }
            }
        }
    }
}
