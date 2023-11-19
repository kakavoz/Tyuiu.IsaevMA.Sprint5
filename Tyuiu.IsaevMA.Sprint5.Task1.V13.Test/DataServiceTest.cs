using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.IsaevMA.Sprint5.Task1.V13.Lib;

namespace Tyuiu.IsaevMA.Sprint5.Task1.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:\Project's C#\Tyuiu.IsaevMA.Sprint5\Tyuiu.IsaevMA.Sprint5.Task1.V2\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            Assert.IsTrue(fileExists);
        }
    }
}
