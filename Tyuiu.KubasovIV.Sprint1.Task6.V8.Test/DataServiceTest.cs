using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KubasovIV.Sprint1.Task6.V8.Lib;
namespace Tyuiu.KubasovIV.Sprint1.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "hello world";
            DataService ds = new DataService();
            string res = ds.MoveLetterToEnd(strTest);
            string wait = "elloh orldw";
            Assert.AreEqual(wait, res);

        }
    }
}
