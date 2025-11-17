using System.IO;
using Tyuiu.BarminaSK.Sprint5.Task3.V4.Lib;

namespace Tyuiu.BarminaSK.Sprint5.Task3.V4.Lib
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Бармина С.К. | ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнила: Бармина София Константиновна | ПИНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3;
            Console.WriteLine($"x = {x}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = Math.Log((x + 1.0) / (x + 2.0));
            result = Math.Round(result, 3);

            Console.WriteLine($"Значение функции = {result}");

            string path = ds.SaveToFileTextData(x);
            Console.WriteLine($"Файл: {path}");

            Console.ReadKey();

        }
    }
}


