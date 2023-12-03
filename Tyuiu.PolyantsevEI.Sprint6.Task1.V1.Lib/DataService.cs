using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PolyantsevEI.Sprint6.Task1.V1.Lib
{
    public class DataService : ISprint6Task1V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] vallueArray;
            int len = (stopValue - startValue) + 1;
            vallueArray = new double[len];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                vallueArray[count] = Math.Round(Math.Cos(2*x) + Math.Sin(x) / (x + 2.5) + 2 * x, 2);
                count++;
            }
            return vallueArray;
        }
    }
}
