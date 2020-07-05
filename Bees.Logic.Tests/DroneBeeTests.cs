using NUnit.Framework;

namespace Bees.Logic.Tests
{
    [TestFixture]
    public class DroneBeeTests
    {
        [Test]
        public void HealthThreshold_DefaultsTo50()
        {
            var bee = new DroneBee();

            Assert.AreEqual(50, bee.HealthThreshold);
        }
    }
}