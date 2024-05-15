using Microsoft.VisualStudio.TestTools.UnitTesting;
using modul12_1302223146;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul12_1302223146.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void TESTi()
        {
            Assert.AreEqual(1, Form1.CariNilaiPangkat(2, 0));
            //Assert.Fail();
        }

        [TestMethod()]
        public void TESTii()
        {
            Assert.AreEqual(-1, Form1.CariNilaiPangkat(12, -1));
            //Assert.Fail();
        }

        [TestMethod()]
        public void TESTiii()
        {
            Assert.AreEqual(-2, Form1.CariNilaiPangkat(101, 11));
            //Assert.Fail();
        }

        [TestMethod()]
        public void TESTiv()
        {
            Assert.AreEqual(-3, Form1.CariNilaiPangkat(20, 500));
            //Assert.Fail();
        }
    }
}