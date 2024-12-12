using Tyuiu.StoletovNA.Sprint5.Task1.V12.Lib;
namespace Tyuiu.StoletovNA.Sprint5.Task1.V12.Test {
    [TestClass]
    public class DataServiceTest {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            FileInfo fileinfo = new FileInfo(ds.SaveToFileTextData(startValue, stopValue));
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}