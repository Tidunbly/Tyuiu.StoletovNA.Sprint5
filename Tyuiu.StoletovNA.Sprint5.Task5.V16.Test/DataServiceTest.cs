using Tyuiu.StoletovNA.Sprint5.Task5.V16.Lib;
namespace Tyuiu.StoletovNA.Sprint5.Task5.V16.Test {
    [TestClass]
    public class DataServiceTest {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask5V16.txt"; ;
            FileInfo fileinfo = new FileInfo(path);

            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}