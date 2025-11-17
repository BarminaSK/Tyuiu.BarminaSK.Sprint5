using Tyuiu.BarminaSK.Sprint5.Task0.V26.Lib;

namespace Tyuiu.BarminaSK.Sprint5.Task0.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            int x = 2;
            string path = ds.SaveToFileTextData(x);

            bool fileExists = File.Exists(path);
            Assert.AreEqual(true, fileExists);

            string fileContent = File.ReadAllText(path).Trim();

            double expectedResult = 0.7 * Math.Pow(2, 3) + 1.52 * Math.Pow(2, 2);
            expectedResult = Math.Round(expectedResult, 3);
            string expectedString = expectedResult.ToString();

            Assert.AreEqual(expectedString, fileContent);

        }
    }
}
