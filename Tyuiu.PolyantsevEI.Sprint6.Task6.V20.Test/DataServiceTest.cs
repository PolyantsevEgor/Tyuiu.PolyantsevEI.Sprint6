using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PolyantsevEI.Sprint6.Task6.V20.Lib;

namespace Tyuiu.PolyantsevEI.Sprint6.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Admin\source\repos\Tyuiu.PolyantsevEI.Sprint6\Tyuiu.PolyantsevEI.Sprint6.Task6.V20\bin\Debug\InPutFileTask6V20.txt";
            string res = ds.CollectTextFromFile(path);
            string wait = "dKOPBC IqjpIlKAaSCBuaQUU GPeEqZo FPsrQHsImzbTBckw NgAfitECn";
            Assert.AreEqual(wait, res);
        }
    }
}
