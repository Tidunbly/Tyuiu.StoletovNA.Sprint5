﻿using System.Security.Cryptography;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.StoletovNA.Sprint5.Task2.V11.Lib {
    public class DataService : ISprint5Task2V11 {
        public string SaveToFileTextData(int[,] matrix)
        {
            string fullPath = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask2.txt" });

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(fullPath);
            }

            int rows = 3;
            int cols = 3;

            

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }


            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0;j < cols; j++)
                {
                    if (j != cols - 1)
                    {
                        str += matrix[i, j] + ";";
                    }
                    else
                    {
                        str += matrix[i, j];  
                    }
                }

                if (i != rows - 1)
                {
                    File.AppendAllText(fullPath, str + Environment.NewLine); 
                }
                else
                {
                    File.AppendAllText(fullPath, str);
                }

                str = "";
            }

            return fullPath;
        }
    }
}
