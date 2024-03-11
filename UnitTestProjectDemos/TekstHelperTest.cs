using ClassLibrary1;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectDemos
{
    [TestFixture]
    internal class TekstHelperTest
    {
        private TekstHelper _teksthelper;
        [SetUp]
        public void SetUp()
        {
            _teksthelper = new TekstHelper();
        }

        [Test]
        public void StringInput_NotNull()
        {
            string s = "hi";
            int expected = 2;

            int result = _teksthelper.Lengte(s);

            Assert.That(result, Is.EqualTo(expected));

            //int lengte = _teskshelper.Lengte("Hallo);
            //Assert blabla(Is.EqualTo(5)
        }

        [Test]
        public void StringInput_ReverseArrayCharsReturn() 
        {            
            string result = _teksthelper.Omkeren("yes");            
            Assert.That(result, Is.EqualTo("sey"));
        }
        [Test]
        public void IsLeeg_gegevenLegeString_Retourneerttrue()
        {
            bool resultaat = _teksthelper.IsLeeg("");
            Assert.That(resultaat, Is.EqualTo(true));
        }
        [Test]
        public void Samenvoegen_gegevensTweeStrings_ReturnSamenVoegde()
        {
            string result = _teksthelper.SamenVoegen("Hallo", "dieren");
            Assert.That(result, Is.EqualTo("Hallodieren"));
        }

        [TestCase (1, "Positief")]
        [TestCase (-1, "Negatief")]
        [TestCase (0, "Nul")]
        public void Analyze_ShouldIdentifyCorrectlyNumber(int number, string expected)
        {
            string result = _teksthelper.Analyze(number);
            Assert.That(result, Is.EqualTo(expected));
        }

        
    }

    
}
