using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.IsaevMA.Sprint5.Task4.V5.Lib;

namespace Tyuiu.IsaevMA.Sprint5.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        [TestMethod]
        public void TestMethod1()
        {

            {
                string path = @"C:\DataSprint5\InPutDataFileTask4V5.txt";

                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;
                bool wait = true;
                Assert.AreEqual(wait, fileExists);
            }
        }
    }

}
