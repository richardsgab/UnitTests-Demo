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
        }

    }
}
