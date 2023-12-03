using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PolyantsevEI.Sprint6.Task3.V6.Lib;

namespace Tyuiu.PolyantsevEI.Sprint6.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] matrix = {
                {  22 , 32, -16 , 24 , 27 },
                {  3, -20,  24, -20,  25 },
                {  21,  17  ,-8 ,-19 , 17 },
                { 8 , 22 , 28,  27,  19 },
                { 11,  20,  12,  27,  29 }
            };

            int[,] wait = {
                { 22 , 32 , -16 , 24 , 27},
                { 3 , -20,  24 , -20 , 25},
                { 21 , 17 , 0 , -19 , 17},
                { 8 , 22 , 28 , 27 , 19},
                { 11 ,  20 ,  12 ,  27 , 29}
            };

            int[,] res = ds.Calculate(matrix);


            CollectionAssert.AreEqual(wait, res);
        }
    }
}
