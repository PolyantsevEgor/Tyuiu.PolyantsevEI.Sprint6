using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PolyantsevEI.Sprint6.Task4.V25.Lib;

namespace Tyuiu.PolyantsevEI.Sprint6.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] wait;
            wait = new double[len];

            wait[0] = 4.67;
            wait[1] = 0.43;
            wait[2] = -8.26;
            wait[3] = -9.87;
            wait[4] = -3.98;
            wait[5] = 1;
            wait[6] = 0.02;
            wait[7] = -1.87;
            wait[8] = 3.74;
            wait[9] = 16.43;
            wait[10] = 24.67;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
