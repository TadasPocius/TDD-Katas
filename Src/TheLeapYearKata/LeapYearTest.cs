using NUnit.Framework;

namespace TDD_Katas_project.The_LeapYear_Kata
{
    [TestFixture]
    [Category("The LeapYear")]
    public class LeapYearTest
    {
        [Test]
        public void CanTestForLeapYear()
        {
            Assert.That(true, Is.EqualTo(LeapYear.IsLeapYear(1996)));
        }
    }
}
