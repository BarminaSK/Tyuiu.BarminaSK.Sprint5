using System.IO;
using Tyuiu.BarminaSK.Sprint5.Task7.V14.Lib;

namespace Tyuiu.BarminaSK.Sprint5.Task7.V14.Lib
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Бармина С.К. | ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнила: Бармина София Константиновна | ПИНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V14.txt";
            string outputPath = ds.LoadDataAndSave(path);
            Console.WriteLine($"Файл: {outputPath}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string result = File.ReadAllText(outputPath);
            Console.WriteLine($"Преобразованный текст = {result}");
            Console.ReadKey();

        }
    }
}

