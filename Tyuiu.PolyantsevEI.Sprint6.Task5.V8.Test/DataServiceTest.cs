using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.PolyantsevEI.Sprint6.Task5.V8.Lib;

namespace Tyuiu.PolyantsevEI.Sprint6.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidMass()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Admin\source\repos\Tyuiu.PolyantsevEI.Sprint6\Tyuiu.PolyantsevEI.Sprint6.Task5.V8\bin\Debug\InPutFileTask5V8.txt";
            double[] wait = { -13, -19, -9, 82, -9, 71, -0, 11, -17, 36, -12, -12, 35 };
            double[] res = ds.LoadFromDataFile(path);
        }
    }
}
