using NUnit.Framework;

namespace Bees.Logic.Tests
{
    [TestFixture]
    public class WorkerBeeTests
    {
        [Test]
        public void HealthThreshold_DefaultsTo70()
        {
            var bee = new WorkerBee();

            Assert.AreEqual(70, bee.HealthThreshold);
        }
    }
}