namespace Skeleton.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class AxeTests
    {
        private Axe axe;
        private Dummy dummy;

        [SetUp]
        public void ObjectInitialize()
        {
            this.axe = new Axe(2, 2);
            this.dummy = new Dummy(10, 10);
        }

        [Test]
        public void AxeLooseDurabilityAfterAttack()
        {
            this.axe.Attack(this.dummy);

            Assert.That(this.axe.DurabilityPoints, Is.EqualTo(1),
                  "Axe Durability doesn't change after attack");
        }

        [Test]
        public void BrokenAxeCanNotAttack()
        {
            this.axe.Attack(this.dummy);
            this.axe.Attack(this.dummy);

            Assert.That(() => this.axe.Attack(dummy),
             Throws.InvalidOperationException.With.Message
             .EqualTo("Axe is broken."));

        }
    }
}
