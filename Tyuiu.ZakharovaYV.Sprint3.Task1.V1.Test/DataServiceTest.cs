using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZakharovaYV.Sprint3.Task1.V1.Lib;

namespace Tyuiu.ZakharovaYV.Sprint3.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMuliplySeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 7;

            double res = ds.GetMultiplySeries(startValue, stopValue);

            double wait = 5.31084;

            Assert.AreEqual(wait, res);
        }
    }
}
