using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Lab09
{
    [TestFixture]
    class MyMathTests
    {
        [TestCase]
        public void Add01()
        {
            MyMath txt = new MyMath();
            Assert.AreEqual(txt.Add(1,1), 2);
        }
        [TestCase]
        public void Add02()
        {
            MyMath txt = new MyMath();
            Assert.AreEqual(txt.Add(1, 3), 4);
        }

        [TestCase]
        public void Add03()
        {
            MyMath txt = new MyMath();
            Assert.IsTrue(txt.Add(1, 1) > 1);
        }

        [TestCase]
        public void Sub01()
        {
            MyMath txt = new MyMath();
            Assert.AreEqual(txt.Sub(1, 1), 0);
        }

        [TestCase]
        public void Sub02()
        {
            MyMath txt = new MyMath();
            Assert.IsFalse(txt.Sub(1, 1) > 0);
        }

        [TestCase]
        public void Sub03()
        {
            MyMath txt = new MyMath();
            Assert.AreNotEqual(txt.Sub(1, 1), 1);
        }

        [TestCase]
        public void Mul01()
        {
            MyMath txt = new MyMath();
            Assert.AreEqual(txt.Mul(2, 2), 4);
        }

        [TestCase]
        public void Mul02()
        {
            MyMath txt = new MyMath();
            Assert.IsNotNull(txt.Mul(2, 2));
        }
        [TestCase]
        public void IntDiv01()
        {
            MyMath txt = new MyMath();
            Assert.AreEqual(txt.IntDiv(2, 2), 1);
        }
        [TestCase]
        public void Div01()
        {
            MyMath txt = new MyMath();
            Assert.AreEqual(txt.Div(2, 2), 1);
        }
    }
}
