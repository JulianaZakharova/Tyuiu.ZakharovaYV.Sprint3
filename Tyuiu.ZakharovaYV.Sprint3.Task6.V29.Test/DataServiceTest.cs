using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZakharovaYV.Sprint3.Task6.V29.Lib;

namespace Tyuiu.ZakharovaYV.Sprint3.Task6.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 12;
            int stopValue = 18;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 178;

            Assert.AreEqual(wait, res);
        }
    }
}
