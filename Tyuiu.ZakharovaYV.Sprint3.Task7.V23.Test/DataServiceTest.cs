using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZakharovaYV.Sprint3.Task7.V23.Lib;

namespace Tyuiu.ZakharovaYV.Sprint3.Task7.V23.Test
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

            valueWaitArray[0] = 6.29;
            valueWaitArray[1] = 7.31;
            valueWaitArray[2] = 6.48;
            valueWaitArray[3] = 4.42;
            valueWaitArray[4] = 2.73;
            valueWaitArray[5] = 2.00;
            valueWaitArray[6] = 1.27;
            valueWaitArray[7] = -0.42;
            valueWaitArray[8] = -2.48;
            valueWaitArray[9] = -3.31;
            valueWaitArray[10] = -2.29;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);

        }
    }
}
