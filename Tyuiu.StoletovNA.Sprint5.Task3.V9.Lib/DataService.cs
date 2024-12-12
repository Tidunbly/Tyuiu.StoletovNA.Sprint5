using System.Security.Cryptography;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.StoletovNA.Sprint5.Task3.V9.Lib {
    public class DataService : ISprint5Task3V9 {
        public string SaveToFileTextData(int x)
        {
            string fullPath = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask3.txt" });

            

            double y = Math.Pow(x, 3) / (Math.Pow(x, 2) - 1);
            y = Math.Round(y, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(fullPath, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }

            return fullPath;
        }
    }
}
