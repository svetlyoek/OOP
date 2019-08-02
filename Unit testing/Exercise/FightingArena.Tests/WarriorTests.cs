using FightingArena;
using NUnit.Framework;
using System;

namespace Tests
{
    public class WarriorTests
    {
        private Warrior warrior;

        [SetUp]
        public void Setup()
        {
            this.warrior = new Warrior("Ivan", 10, 10);
        }

        [Test]
        public void TestConstructorIfWorksCorrectly()
        {
            Assert.AreEqual("Ivan", this.warrior.Name);
            Assert.AreEqual(10, this.warrior.Damage);
            Assert.AreEqual(10, this.warrior.HP);
        }

        [Test]
        public void TestNameShouldThrowExceptionIfNullOrEmpty()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var warrior = new Warrior(null, 10, 10);

            });
        }

        [Test]
        public void TestDamageShouldThrowExceptionIfZero()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var warrior = new Warrior("Dido", 0, 10);

            });
        }

        [Test]
        public void TestDamageShouldThrowExceptionIfNegative()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var warrior = new Warrior("Dido", -10, 10);

            });
        }

        [Test]
        public void TestHpShouldThrowExceptionIfNegative()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var warrior = new Warrior("Dido", 10, -10);

            });
        }

        [Test]
        public void TestAttackShouldThrowExceptionWhenAttackingHpBelowMinimum()
        {
            var firstWarrior = new Warrior("Diqn", 10, 30);
            var secondWarrior = new Warrior("Petko", 5, 60);

            Assert.Throws<InvalidOperationException>(() =>
            {
                firstWarrior.Attack(secondWarrior);
            });
        }

        [Test]
        public void TestAttackShouldThrowExceptionWhenDefenderHpBelowMinimum()
        {
            var firstWarrior = new Warrior("Diqn", 10, 56);
            var secondWarrior = new Warrior("Petko", 5, 28);

            Assert.Throws<InvalidOperationException>(() =>
            {
                firstWarrior.Attack(secondWarrior);
            });
        }

        [Test]
        public void TestAttackShouldThrowExceptionWhenTryToAttackStrongerEnemy()
        {
            var firstWarrior = new Warrior("Diqn", 10, 40);
            var secondWarrior = new Warrior("Petko", 41, 31);

            Assert.Throws<InvalidOperationException>(() =>
            {
                firstWarrior.Attack(secondWarrior);
            });
        }

        [Test]
        public void TestAttackWhenMoreDamageThanEnemyHp()
        {
            var firstWarrior = new Warrior("Diqn", 80, 45);
            var secondWarrior = new Warrior("Petko", 41, 31);

            firstWarrior.Attack(secondWarrior);

            Assert.AreEqual(0, secondWarrior.HP);
        }



    }
}