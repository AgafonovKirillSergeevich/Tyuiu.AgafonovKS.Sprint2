using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AgafonovKS.Sprint2.Task3.V2.Lib;

namespace Tyuiu.AgafonovKS.Sprint2.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();

            double x = 5;

            double y = ds.Calculate(x);

            Assert.AreEqual(-54.716, y);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();

            double x = 2;

            double y = ds.Calculate(x);

            Assert.AreEqual(1.5, y);
        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();

            double x = 0;

            double y = ds.Calculate(x);

            Assert.AreEqual(-0.577, y);
        }
        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();

            double x = -7;

            double y = ds.Calculate(x);

            Assert.AreEqual(-77, y);
        }
    }
}
