using System;
using Tyuiu.StoletovNA.Sprint5.Task7.V20.Lib;
namespace Tyuiu.StoletovNA.Sprint5.Task7.V20.Test {
    [TestClass]
    public class DataServiceTest {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            FileInfo fileinfo = new FileInfo(ds.LoadDataAndSave(@"C:\DataSprint5\InPutDataFileTask7V20.txt"));

            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}