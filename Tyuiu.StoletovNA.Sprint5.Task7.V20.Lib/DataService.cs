using System.Security.Cryptography;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.StoletovNA.Sprint5.Task7.V20.Lib {
    public class DataService : ISprint5Task7V20 {
        public string ReplaceUsingFor(string input)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                
                if (i < input.Length - 1 && input[i] == 'с' && input[i + 1] == 'с')
                {
                    result.Append('с');
                    i++;
                }
                else
                {
                    result.Append(input[i]);
                }
            }

            return result.ToString();
        }



        public string LoadDataAndSave(string path)
        {
            string str = File.ReadAllText(path, Encoding.UTF8);

            string fullPath = Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V20.txt" });
            
            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(fullPath);
            }

            str = ReplaceUsingFor(str);
            
            File.AppendAllText(fullPath, str + Environment.NewLine);

            return fullPath;
        }
    }
}
