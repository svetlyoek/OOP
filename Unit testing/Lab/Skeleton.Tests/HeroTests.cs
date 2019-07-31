namespace Skeleton.Tests
{
    using NUnit.Framework;
    using Skeleton.Contracts;
    using Skeleton.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;

    [TestFixture]
    public class HeroTests
    {
        private const string HERO_NAME = "Pesho";

        [Test]
        public void HeroGainsExperienceAfterAttackWhenTargetDies()
        {
            IWeapon fakeWeapon = new FakeWeapon();
            ITarget fakeTarget = new FakeTarget();

            Hero hero = new Hero(HERO_NAME, fakeWeapon);

            hero.Attack(fakeTarget);

            Assert.AreEqual(40, hero.Experience + fakeTarget.GiveExperience());
        }

    }
}
