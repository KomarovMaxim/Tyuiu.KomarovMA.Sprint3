using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomarovMA.Sprint3.Task0.V24.Lib;
namespace Tyuiu.KomarovMA.Sprint3.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            
            DataService ds = new DataService();
            double value = 5;
            int startValue = 1;
            int stopValue = 7;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 0;
            Assert.AreEqual(wait, res);
        }
    }
}