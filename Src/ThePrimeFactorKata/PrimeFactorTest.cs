using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace TDD_Katas_project.The_PrimeFactor_Kata
{
    [TestFixture]
    [Category("The PrimeFactor Kata")]
    public class PrimeFactorTest
    {
        private static IList<int?> List(params int[] ints)
        {
            return ints.Select(i => (int?) i).ToList();
        }

        [Test]
        public void Testone()
        {
            Assert.That(List(), Is.EqualTo(PrimeFactor.Generate(1)));
        }

        [Test]
        public void Testwo()
        {
            Assert.That(List(2), Is.EqualTo(PrimeFactor.Generate(2)));
        }
    }
}
