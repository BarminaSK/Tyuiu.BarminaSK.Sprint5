using System.IO;
using Tyuiu.BarminaSK.Sprint5.Task4.V10.Lib;

namespace Tyuiu.BarminaSK.Sprint5.Task4.V10.Lib
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Бармина С.К. | ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнила: Бармина София Константиновна | ПИНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V10.txt";
            Console.WriteLine($"Файл: {path}");
            Console.WriteLine($"Формула: x^3*1.2*х + 2");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.LoadFromDataFile(path);
            Console.WriteLine($"Результат: {result}");
            Console.ReadKey();

        }
    }
}



