using AbstactFactoryMetanit.Movements;
using AbstactFactoryMetanit.Weapons;

namespace AbstactFactoryMetanit.HeroFactories
{
    internal abstract class HeroFactory
    {
        public abstract Movement CreateMovement();
        public abstract Weapon CreateWeapon();
    }
}