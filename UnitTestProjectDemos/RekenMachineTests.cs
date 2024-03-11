using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using NUnit;
using NUnit.Framework;

namespace UnitTestProjectDemos
{
    [TestFixture]
    public class RekenMachineTests
    {
        private RekenMachine _rekenmachine;
        [SetUp]
        public void SetUp()//it's like a constructor
        {
            _rekenmachine = new RekenMachine();
        }
        [Test]
        public void Add_TweeGetallen_ReturnSom() 
        {
            //Arrange
            int a = 1;
            int b = 2;

            //Act
            int result = _rekenmachine.Add(a, b);
            int expected = 3;

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Sub_TweeGetallen_ReturnVerschill()
        {
            //Arrange
            int a = 1;
            int b = 2;

            //Add
            int result = _rekenmachine.Sub(a, b);
            int expected = -1;

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Mult_TweeGetallen_ReturnProduct()
        {
            //Arrange
            int a = 2;
            int b = 2;

            //Add
            int result = _rekenmachine.Mult(a, b);
            int expected = 4;

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Div_TweeGetallen_ReturnDivision()
        {
            //Arrange
            int a = 2;
            int b = 2;

            //Add
            int result = _rekenmachine.Div(a, b);
            int expected = 1;

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Delen_OpNull_Divident0()
        {
            //Arrange
            int a = 2;
            int b = 0;

            //Act
            
            //Assert
            Assert.Throws<DivideByZeroException>(() => _rekenmachine.Div(a,b));
        }

        [TestCase(0, false)]
        [TestCase(1, true)]
        [TestCase(101, false)]
        [TestCase(-1, false)]
        public void IsInRange_ShouldValidate_CorrectRange(int n, bool expected)
        {
            //Act
            bool result = _rekenmachine.IsInRange(n);
            //Assert
            Assert.That(expected, Is.EqualTo(result));
        }
    }
}
