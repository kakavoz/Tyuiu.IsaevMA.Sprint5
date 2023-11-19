using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IsaevMA.Sprint5.Task0.V25.Lib;
using System.IO;

namespace Tyuiu.IsaevMA.Sprint5.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:\Project's C#\Tyuiu.IsaevMA.Sprint5\Tyuiu.IsaevMA.Sprint5.Task0.V12\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            Assert.IsTrue(fileExists);
        }
    }
}