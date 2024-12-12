using Tyuiu.StoletovNA.Sprint5.Task2.V11.Lib;
namespace Tyuiu.StoletovNA.Sprint5.Task2.V11.Test {
    [TestClass]
    public class DataServiceTest {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matr = new int[3, 3] { { 4, 9, 3 }, { 5, 8, 8 }, { 5, 7, 5 } };
            FileInfo fileinfo = new FileInfo(ds.SaveToFileTextData(matr));

            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}