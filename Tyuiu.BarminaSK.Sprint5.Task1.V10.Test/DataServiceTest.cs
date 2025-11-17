using Tyuiu.BarminaSK.Sprint5.Task1.V10.Lib;

namespace Tyuiu.BarminaSK.Sprint5.Task1.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int length = stopValue - startValue + 1;

            double[] mass;
            mass = new double[length];
            mass[0] = 28.05;
            mass[1] = 22.27;
            mass[2] = 17.01;
            mass[3] = 12.35;
            mass[4] = 7.51;
            mass[5] = 0.00;
            mass[6] = 1.62;
            mass[7] = -7.03;
            mass[8] = -12.99;
            mass[9] = -17.55;
            mass[10] = -21.43;
            double[] res;
            res = new double[length];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(mass, res);

        }

        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            string path = ds.SaveToFileTextData(startValue, stopValue);

            // Проверяем, что файл создан
            bool fileExists = File.Exists(path);
            Assert.AreEqual(true, fileExists);

            // Проверяем, что файл не пустой
            string fileContent = File.ReadAllText(path);
            Assert.IsFalse(string.IsNullOrEmpty(fileContent));
        }
    }
}
