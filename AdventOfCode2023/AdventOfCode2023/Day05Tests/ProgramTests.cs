using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void Part2Try2Test()
        {
            var start = DateTime.Now;
            long answer = Day05.Program.Part2Try2();
            var stop = DateTime.Now;
            Assert.AreEqual(11611182, answer, $"Runtime: {stop-start}");
        }
    }
}