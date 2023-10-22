using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZakharovaYV.Sprint3.Task2.V27.Lib;
namespace Tyuiu.ZakharovaYV.Sprint3.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
            public void GetSumSeriesValid()
            {
                DataService ds = new DataService();
                int value = 5;
                int startValue = 1;
                int stopValue = 14;
                double Sum = ds.GetSumSeries(value, startValue, stopValue);
                double wait = 0.69;
                Assert.AreEqual(Sum, wait);
        }
    }
}
