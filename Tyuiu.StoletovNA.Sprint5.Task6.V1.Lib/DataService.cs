using System.Security.Cryptography;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.StoletovNA.Sprint5.Task6.V1.Lib {
    public class DataService : ISprint5Task6V1 {
        public int LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);

            int digitCount = str.Count(char.IsDigit);
            return digitCount;

        }
    }
}
