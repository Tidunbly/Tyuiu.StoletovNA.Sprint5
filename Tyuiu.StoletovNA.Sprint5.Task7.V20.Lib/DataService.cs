using System.Security.Cryptography;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.StoletovNA.Sprint5.Task7.V20.Lib {
    public class DataService : ISprint5Task7V20 {
        public string LoadDataAndSave(string path)
        {
            string str = File.ReadAllText(path, Encoding.UTF8);

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (i < str.Length - 1 && str[i] == 'с' && str[i + 1] == 'с')
                {
                    result.Append('с');
                    i++;
                }
                else if (i < str.Length - 1 && str[i] == 'С' && str[i + 1] == 'с')
                {
                    result.Append('С');
                    i++;
                }
                else
                {
                    result.Append(str[i]);
                }
            }

            string fullPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V20.txt");

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(fullPath);
            }

            File.AppendAllText(fullPath, result.ToString() + Environment.NewLine);

            return fullPath;
        }
    }
}
