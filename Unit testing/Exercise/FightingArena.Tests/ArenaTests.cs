using FightingArena;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Tests
{
    public class ArenaTests
    {
        private List<Warrior> warriors;
        private Arena arena;

        [SetUp]
        public void Setup()
        {
            this.arena = new Arena();
        }

        [Test]
        public void TestConstructorIfWorksCorrectly()
        {
            Assert.IsNotNull(this.arena);
        }

        [Test]
        public void TestCountIfWorksCorrectly()
        {
            Assert.AreEqual(0, this.arena.Count);
        }

        [Test]
        public void TestEnrollIShouldAddWarriorInCollection()
        {
            var warrior = new Warrior("Ivan", 34, 98);

            this.arena.Enroll(warrior);

            Assert.AreEqual(1, this.arena.Count);
        }

        [Test]
        public void TestEnrollShouldThrowExceptionWhenNameIsTheSame()
        {
            var warrior = new Warrior("Ivan", 65, 95);
            var secondWarrior = new Warrior("Ivan", 87, 39);

            this.arena.Enroll(warrior);

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.arena.Enroll(secondWarrior);
            });
        }

        [Test]
        public void TestFightIfWorksCorrectly()
        {
            var attacker = new Warrior("Ivan", 5, 95);
            var defender = new Warrior("Paskal", 10, 90);

            this.arena.Enroll(attacker);
            this.arena.Enroll(defender);

            this.arena.Fight("Ivan", "Paskal");

            Assert.AreEqual(85, attacker.HP);
            Assert.AreEqual(85, defender.HP);

        }

        [Test]
        public void TestFightShouldThrowExceptionIfAttackernameIsNull()
        {
            var attacker = new Warrior("Ivailo", 5, 95);
            var defender = new Warrior("Paskal", 10, 90);

            this.arena.Enroll(attacker);
            this.arena.Enroll(defender);

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.arena.Fight("Dido", defender.Name);
            });
        }

        [Test]
        public void TestFightShouldThrowExceptionIfDefenderNameIsNull()
        {
            var attacker = new Warrior("Ivailo", 5, 95);
            var defender = new Warrior("Paskal", 10, 90);

            this.arena.Enroll(attacker);
            this.arena.Enroll(defender);

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.arena.Fight(attacker.Name, "Pencho");
            });

        }

    }
}
