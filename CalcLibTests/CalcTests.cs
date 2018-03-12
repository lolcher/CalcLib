using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;



namespace CalcLibTests
{
    [TestFixture]
    public class CalcTests
    {
        [Test]
        public void Sum_10and20_30returned()
        {
            //arrange
            int x = 10;
            int y = 20;
            int expected = 30;

            //act
            CalcLib.Calc c = new CalcLib.Calc();
            int actual = c.Sum(x, y);

            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}