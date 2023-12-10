using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PolyantsevEI.Sprint6.Task6.V20.Lib
{
    public class DataService : ISprint6Task6V20
    {
        public int len;
        public string CollectTextFromFile(string path)
        {
            {
                string strResult;
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != "")
                    {
                        len++;
                    }
                }

                using (StreamReader reader = new StreamReader(path))
                {
                    int index = 0;
                    string[] res = new string[len];
                    string line;
                    while ((line = reader.ReadLine()) != "")
                    {
                        string[] words = line.Split(' ');
                        res[index] = words[1];
                        index++;
                    }
                    strResult = string.Join(" ", res);
                }
                return strResult;
            }
        }
    }
}
