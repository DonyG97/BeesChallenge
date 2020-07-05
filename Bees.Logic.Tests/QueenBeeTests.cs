using NUnit.Framework;

namespace Bees.Logic.Tests
{
    [TestFixture]
    public class QueenBeeTests
    {
        [Test]
        public void HealthThreshold_DefaultsTo20()
        {
            var bee = new QueenBee();

            Assert.AreEqual(20, bee.HealthThreshold);
        }
    }
}