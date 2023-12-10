using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PolyantsevEI.Sprint6.Task7.V30.Lib;
using System.IO;

namespace Tyuiu.PolyantsevEI.Sprint6.Task7.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Admin\source\repos\Tyuiu.PolyantsevEI.Sprint6\Tyuiu.PolyantsevEI.Sprint6.Task7.V30\bin\Debug\InPutFileTask7V30.csv";
            int[,] res = ds.GetMatrix(path);
            int[,] wait = { { 0, 8, 5, -3, -1, -1, -5, 2, -16, 3 }, { -8, 8, -18, 4, -10, -15, 19, -13, 19, 14 }, { -6, 8, -18, -18, -7, 1, -14, -9, 18, -9 }, { -19, 8, -9, 20, -19, 11, 12, -15, 1, 1 }, { 9, 8, 13, 10, -13, -11, 20, -17, -8, 18 }, { -5, 8, 4, 1, 10, -1, -11, -18, 6, 11 }, { 5, 8, -16, -10, -6, 4, 17, 15, -12, -10 }, { 11, 8, 10, 17, -18, -6, -20, 14, 3, 14 }, { -15, 8, 15, 6, -2, -3, 1, -6, -7, -11 }, { 4, 8, -7, -18, 8, 7, 5, 18, 20, 2 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
