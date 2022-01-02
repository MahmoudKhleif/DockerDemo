using Microsoft.VisualStudio.TestTools.UnitTesting;
using DockerDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DockerDemo.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void GiveMeFiveTest()
        {
            var expected = 5;
            var actual = new Class1().GiveMeFive();
            Assert.AreEqual(expected, actual);
        }
    }
}