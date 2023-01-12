using AbstactFactoryMetanit.Movements;
using AbstactFactoryMetanit.Weapons;

namespace AbstactFactoryMetanit.HeroFactories
{
    internal class VoinFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new RunMovement();
        }
 
        public override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }
}