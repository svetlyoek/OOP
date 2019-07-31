namespace Skeleton.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public interface ITarget
    {
        void TakeAttack(int attackPoints);

        int GiveExperience();

        bool IsDead();

        int Health { get; }
    }
}
