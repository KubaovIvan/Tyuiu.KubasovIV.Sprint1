using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KubasovIV.Sprint1.Task3.V18.Lib;

namespace Tyuiu.KubasovIV.Sprint1.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 4;
            double b = 5;
            double c = 2;
            var res = ds.HowManySquares(a, b, c);
            Assert.AreEqual(5, res);

        }
    }
}
