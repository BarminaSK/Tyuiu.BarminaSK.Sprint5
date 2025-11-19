using System.IO;
using Tyuiu.BarminaSK.Sprint5.Task7.V14.Lib;

namespace Tyuiu.BarminaSK.Sprint5.Task7.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask7V14.txt";
            string outputPath = ds.LoadDataAndSave(path);
            Assert.IsTrue(File.Exists(outputPath));

            string resultText = File.ReadAllText(outputPath);
            string expectedText = "A STRING OF CAPITAL LETTERS";
            Assert.AreEqual(expectedText, resultText);
        }
    }
}
