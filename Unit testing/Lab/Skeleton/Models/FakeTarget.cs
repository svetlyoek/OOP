using Skeleton.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skeleton.Models
{
    public class FakeTarget : ITarget
    {
        public int GiveExperience()
        {
            return 20;
        }

        public bool IsDead()
        {
            return true;
        }

        public void TakeAttack(int attackPoints)
        {
            this.Health -= 2;
        }

        public int Health { get; set; } = 0;
    }
}
