using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KubasovIV.Sprint1.Task4.V9.Lib;

namespace Tyuiu.KubasovIV.Sprint1.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 2;
            double wait = 1.179;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);


        }
    }
}
