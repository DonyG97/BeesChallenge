using NUnit.Framework;

namespace Bees.Logic.Tests
{
    [TestFixture]
    public class BaseBeeTests
    {
        [Test]
        public void BeeHealth_StartsAt100()
        {
            var bee = new BeeBase(70);

            Assert.AreEqual(100, bee.Health);
        }

        [Test]
        public void BeeHealthIsAboveThreshold_BeeIsNotDead()
        {
            var bee = new BeeBase(70);

            Assert.False(bee.IsDead);
        }

        [Test]
        public void BeeHealthIsBelowThreshold_BeeIsDead()
        {
            var bee = new BeeBase(100);

            bee.Damage(1);

            Assert.True(bee.IsDead);
        }

        [Test]
        public void BeeHealthThreshold_SetCorrectlyWithinConstructor()
        {
            var healthThreshold = 42;
            var bee = new BeeBase(healthThreshold);

            Assert.AreEqual(healthThreshold, bee.HealthThreshold);
        }

        [Test]
        public void DamageCalled_IfDead_BeeTakesNoDamage()
        {
            var bee = new BeeBase(90);
            bee.Damage(11);
            bee.Damage(40);

            Assert.AreEqual((float) 89, bee.Health);
        }

        [Test]
        public void DamageCalled_IfDead_DamageMethodDoesNotThrow()
        {
            var bee = new BeeBase(100);
            bee.Damage(1);

            Assert.True(bee.IsDead);
            Assert.DoesNotThrow(() => { bee.Damage(30); });
        }

        [Test]
        public void DamageCalled_IfNotDead_BeeTakesCorrectDamage()
        {
            var bee = new BeeBase(70);

            bee.Damage(25);

            Assert.AreEqual((float) 75, bee.Health);
        }

        [Test]
        public void DamageCalled_WithInvalidValues_DamageMethodDoesNotThrow([Values(110, -10)] int damageValue)
        {
            var bee = new BeeBase(70);

            Assert.DoesNotThrow(() => { bee.Damage(damageValue); });
            Assert.False(bee.IsDead);
        }
    }
}