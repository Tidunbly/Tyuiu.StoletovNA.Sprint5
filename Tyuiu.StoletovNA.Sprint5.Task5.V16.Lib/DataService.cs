using System.Security.Cryptography;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.StoletovNA.Sprint5.Task5.V16.Lib {
    public class DataService : ISprint5Task5V16 {
        public double LoadFromDataFile(string path)
        {
            double maxValue = -100000;

            string str = File.ReadAllText(path);
            string[] numbers = str.Split(' ');

            foreach (string number in numbers)
            {
                double x = Convert.ToDouble(number.Replace('.', ','));
                if (x % 10 == 0 & x != 0)
                {
                    if (maxValue < x)
                    {
                        maxValue = x;
                    }
                }
                
            }
            return maxValue;
        }
    }
}
