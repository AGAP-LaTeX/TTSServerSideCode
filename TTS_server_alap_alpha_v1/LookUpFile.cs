using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

/**
* @author $Ahtsham Manzoor$
*/

namespace TTS_server_alap_alpha_v1
{
   static class LookUpFile
    {

        private static string FilePath = Path.GetDirectoryName((new System.Uri(Assembly.GetExecutingAssembly().CodeBase)).LocalPath);
        private static Dictionary<string, string> LookUpTable = new Dictionary<string, string>();
        private static Dictionary<string, string> MathCharLookUp = new Dictionary<string, string>();

        private static void ReadFile()
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(FilePath + "\\lookup.txt");
                string[] Mathlines = System.IO.File.ReadAllLines(FilePath + "\\MathChar.txt");
                // System.IO.File.ReadAllLines(@"D:\study\MS\Thesis\Latex Code\tts-server\TTS_server_alap_alpha_v1\bin\Debug\lookup.txt");

                if (LookUpTable.Count <= 0)
                {
                    foreach (string line in lines)
                    {
                        string[] KeyValue = line.Split(',');
                        LookUpTable.Add(KeyValue[0], KeyValue[1]);
                    }
                }
                if (MathCharLookUp.Count <= 0)
                {
                    foreach (string line in Mathlines)
                    {
                        string[] KeyValue = line.Split(',');
                        MathCharLookUp.Add(KeyValue[0], KeyValue[1]);
                    }
                }
            } catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            
        }

        public static Dictionary<string, string> GetLookTable()
        {
            if (LookUpTable.Count <= 0)
            {
                ReadFile();
                return LookUpTable;
            }
            else
            {
                return LookUpTable;
            }
        }
        public static Dictionary<string, string> GetMathCharLookTable()
        {           
                ReadFile();
                return MathCharLookUp;             
        }
    }
}
