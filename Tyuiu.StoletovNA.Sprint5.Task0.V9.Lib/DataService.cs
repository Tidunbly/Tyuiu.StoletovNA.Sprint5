using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.StoletovNA.Sprint5.Task0.V9.Lib {
    public class DataService : ISprint5Task0V9 {
        public string SaveToFileTextData(int x)
        {

            string fullPath = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask0.txt" });

            double y = (Math.Pow(x, 3)) / ((Math.Pow(x, 2) - 1));
            y = Math.Round(y, 3);

            File.WriteAllText(fullPath, Convert.ToString(y), Encoding.UTF8);
            return fullPath;
        }
    }
}
