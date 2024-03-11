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
    internal class DatumHulpMiddelenTests
    {
        private DatumHulpMiddelen _datumHmiddelen;
        [SetUp]
        public void SetUp()
        {
            _datumHmiddelen = new DatumHulpMiddelen();
        }
        [Test]
        public void BerekenLeeftijd_JaarToevogen_LeeftijdReturned()
        {
            
            int result = _datumHmiddelen.BerekenLeeftijd(new DateTime(2000,05,10));
            Assert.That(result, Is.EqualTo(23));
        }
        [Test]
        public void VoegDagenToe_ReturnPlusTweeDagen()
        {
            DateTime date = new DateTime(2020,05,10);
            int day = 3;

            DateTime result = _datumHmiddelen.VoegDagenToe(date, day);
            DateTime expected = new DateTime(2020, 05, 13);

            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void IsWeekend_DateInput_ReturnBoolean_IsSaturdayOrSunday()
        {
            bool result = _datumHmiddelen.IsWeekend(new DateTime(2024,03,11));
            Assert.That(result, Is.False);
          
        }
    }
}
