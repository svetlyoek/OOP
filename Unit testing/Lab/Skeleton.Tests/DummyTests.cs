namespace Skeleton.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Text;

    [TestFixture]
    public class DummyTests
    {
        private Axe axe;
        private Dummy dummy;

        [SetUp]
        public void ObjectInitialize()
        {
            this.axe = new Axe(2, 2);
            this.dummy = new Dummy(2, 2);
        }

        [Test]
        public void DummyLoosesHealthWhenAttacked()
        {
            dummy.TakeAttack(1);

            Assert.That(this.dummy.Health, Is.EqualTo(1),

                  "Dummy looses health when attacked.");

        }

        [Test]
        public void DeadDummyThrowsExceptionWhenAttacked()
        {
            this.dummy.TakeAttack(2);

            Assert.Throws<InvalidOperationException>(()
                => this.dummy.TakeAttack(2));
        }

        [Test]
        public void DeadDummyCanGiveExperience()
        {
            this.dummy.TakeAttack(2);

            int experience = this.dummy.GiveExperience();

            Assert.That(this.dummy.GiveExperience(), Is.EqualTo(2),
                "Dead dummy can give experience.");
        }

        [Test]
        public void AliveDummyCanNotGiveExperience()
        {

            Assert.Throws<InvalidOperationException>(() => this.dummy.GiveExperience(),
                "Alive dummy can not give experience.");

        }

    }
}
