using System.IO;
using Tyuiu.BarminaSK.Sprint5.Task2.V26.Lib;

namespace Tyuiu.BarminaSK.Sprint5.Task2.V26.Lib
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Бармина С.К. | ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнила: Бармина София Константиновна | ПИНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[3, 3]
            {
                { 2, -3, -3 },
                { -8, 8, 0 },
                { -6, 1, 0 }
            };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = ds.SaveToFileTextData(matrix);
            string fileContent = File.ReadAllText(path);

            Console.WriteLine("Данные сохранены в файл:");
            Console.WriteLine(fileContent);
            Console.WriteLine($"Путь к файлу: {path}");

            Console.ReadKey();

        }
    }
}


