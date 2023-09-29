using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KubasovIV.Sprint1.Task7.V13.Lib;
namespace Tyuiu.KubasovIV.Sprint1.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 2;
            double wait = 0.345;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
