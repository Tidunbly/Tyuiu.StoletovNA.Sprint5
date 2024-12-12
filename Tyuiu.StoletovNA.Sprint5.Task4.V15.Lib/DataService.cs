using System.Security.Cryptography;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.StoletovNA.Sprint5.Task4.V15.Lib {
    public class DataService : ISprint5Task4V15 {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x = Convert.ToDouble(strX.Replace(".", ","));
            double y = Math.Sin(x) + Math.Pow(x, 2) / 2;
            y = Math.Round(y, 3);
            return y;
        }
    }
}
