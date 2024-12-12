using System.Security.Cryptography;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.StoletovNA.Sprint5.Task1.V12.Lib {
    public class DataService : ISprint5Task1V12 {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string fullPath = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask0.txt" });

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(fullPath);
            }

            double y;
            string strY;

            for (int x = startValue; x <= stopValue; x++)
            {
                double r1 = 5 * x + 2.5;
                double r2 = Math.Sin(x) - 2;

                if (r2 == 0)
                {
                    y = 0;
                    y = Math.Round(y);
                    strY = Convert.ToString(y);
                }
                else
                {
                    y = Math.Round(((r1 / r2) + 2), 2);
                    strY = Convert.ToString(y);
                }


                if (x != stopValue)
                {
                    File.AppendAllText(fullPath, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(fullPath, strY);
                }

            }
            return fullPath;


        }
    }
}
