﻿using Tyuiu.StoletovNA.Sprint5.Task3.V9.Lib;
namespace Tyuiu.StoletovNA.Sprint5.Task3.V9.Test {
    [TestClass]
    public class DataServiceTest {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            
            FileInfo fileinfo = new FileInfo(ds.SaveToFileTextData(3));

            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}