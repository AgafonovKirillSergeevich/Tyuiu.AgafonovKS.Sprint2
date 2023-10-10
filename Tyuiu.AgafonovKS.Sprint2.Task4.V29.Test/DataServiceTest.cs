using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AgafonovKS.Sprint2.Task4.V29.Lib;

namespace Tyuiu.AgafonovKS.Sprint2.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 23;
            double res = ds.Calculate(x,y);
            double wait = 281.333;
            Assert.AreEqual(wait,res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 7;
            Assert.AreEqual(wait, res);
        }
    }
}
