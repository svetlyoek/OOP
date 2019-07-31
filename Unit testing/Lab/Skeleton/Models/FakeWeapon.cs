namespace Skeleton.Models
{
    using Skeleton.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class FakeWeapon : IWeapon
    {
        public int Experience { get; set; } = 0;

        public string Name { get; set; }

        public IWeapon Weapon { get; set; }

        public int AttackPoints => 0;

        public int DurabilityPoints => 0;

        public void Attack(ITarget dummy)
        {
            this.Experience += 10;
        }
    }
}
