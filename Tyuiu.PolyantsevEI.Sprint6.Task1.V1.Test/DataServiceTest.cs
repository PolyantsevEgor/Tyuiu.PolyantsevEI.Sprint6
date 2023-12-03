using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PolyantsevEI.Sprint6.Task1.V1.Lib;

namespace Tyuiu.PolyantsevEI.Sprint6.Task1.V1.Test
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

            wait[0] = -11.22;
            wait[1] = -8.65;
            wait[2] = -4.76;
            wait[3] = -6.47;
            wait[4] = -2.98;
            wait[5] = 1;
            wait[6] = 1.82;
            wait[7] = 3.55;
            wait[8] = 6.99;
            wait[9] = 7.74;
            wait[10] = 9.03;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
