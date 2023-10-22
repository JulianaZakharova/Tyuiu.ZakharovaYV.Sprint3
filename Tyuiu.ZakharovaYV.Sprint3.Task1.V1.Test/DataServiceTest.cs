using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZakharovaYV.Sprint3.Task1.V1.Lib;

namespace Tyuiu.ZakharovaYV.Sprint3.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMultiplySeriesValid()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 7;
            double P = ds.GetMultiplySeries(startValue, stopValue);
            double wait = 5.311;
            Assert.AreEqual(P, wait);
        }
    }
}
