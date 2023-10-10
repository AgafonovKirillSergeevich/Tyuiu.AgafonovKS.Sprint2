using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AgafonovKS.Sprint2.Task5.V8.Lib;

namespace Tyuiu.AgafonovKS.Sprint2.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthName()
        {
            DataService ds = new DataService();
            int m = 3;
            int n = 2;
            string expected = "1.3";

            string result = ds.FindDateOfPreviousDay(m, n);

            Assert.AreEqual(expected, result);
        }
    }
}
