using System.IO;
using Tyuiu.StoletovNA.Sprint5.Task5.V16.Lib;
namespace Tyuiu.StoletovNA.Sprint5.Task5.V16 {
    class Program {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Столетов Никита Андреевич | ИИПБ-24-2";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Класс File. Запись набора данных в текстовый файл                       *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Столетов Никита Андреевич | ИИПБ-24-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");

            Console.WriteLine("*Дан файл С:\\DataSprint5\\InPutDataFileTask5V16.txt                      *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V16.txt";

            





            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");




            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.LoadFromDataFile(path);
            Console.WriteLine(result);



            Console.ReadKey();
        }
    }
}