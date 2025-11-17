using Tyuiu.BarminaSK.Sprint5.Task1.V10.Lib;

namespace Tyuiu.BarminaSK.Sprint5.Task1.V10
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

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Старт диапазона = {startValue}");
            Console.WriteLine($"Конец диапазона = {stopValue}");
            int length = ds.GetMassFunction(startValue, stopValue).Length;

            double[] mass;
            mass = new double[length];
            mass = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+----------+-----------+");
            Console.WriteLine("|    X     |    f(x)   |");
            Console.WriteLine("+----------+-----------+");

            double[] result = ds.GetMassFunction(startValue, stopValue);

            for (int i = 0; i <= length - 1; i++)
            {
                int x = startValue + i;
                Console.WriteLine("|{0,5:d}     |  {1,7:f2}  |", x, result[i]);
            }

            Console.WriteLine("+----------+-----------+");

            string filePath = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine($"Данные сохранены в файл: {filePath}");

            Console.ReadKey();

        }
    }
}

