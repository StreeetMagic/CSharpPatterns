using AbstactFactoryMetanit.Movements;
using AbstactFactoryMetanit.Weapons;

namespace AbstactFactoryMetanit.HeroFactories
{
    internal class ElfFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new FlyMovement();
        }
 
        public override Weapon CreateWeapon()
        {
            return new Arbalet();
        }
    }
}