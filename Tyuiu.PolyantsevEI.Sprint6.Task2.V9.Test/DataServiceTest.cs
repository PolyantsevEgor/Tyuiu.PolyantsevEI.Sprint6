using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PolyantsevEI.Sprint6.Task2.V9.Lib;

namespace Tyuiu.PolyantsevEI.Sprint6.Task2.V9.Test
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

            double[] valueWaitArray;
            valueWaitArray = new double[len];
            valueWaitArray[0] = 0.16;
            valueWaitArray[1] = 0.26;
            valueWaitArray[2] = 0.21;
            valueWaitArray[3] = 0.17;
            valueWaitArray[4] = 0.58;
            valueWaitArray[5] = 1.5;
            valueWaitArray[6] = 2.53;
            valueWaitArray[7] = 4.36;
            valueWaitArray[8] = 55.15;
            valueWaitArray[9] = -3.98;
            valueWaitArray[10] = -2.56;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);

        }
    }
}
