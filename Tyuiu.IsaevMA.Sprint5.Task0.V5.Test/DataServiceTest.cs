using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.IsaevMA.Sprint5.Task4.v5.Lib;

namespace Tyuiu.IsaevMA.Sprint5.Task4.v5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            {
                string path = @"C:\DataSprint5\InPutDataFileTask4v5.txt";

                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;
                bool wait = true;
                Assert.AreEqual(wait, fileExists);
            }
        }
    }

}
