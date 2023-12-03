using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PolyantsevEI.Sprint6.Task0.V3.Lib;

namespace Tyuiu.PolyantsevEI.Sprint6.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            Assert.AreEqual(4.571, ds.Calculate(2));
        }
    }
}
