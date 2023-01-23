using System;

namespace T04
{
    public abstract class Hero : ICast
    {
        private readonly Spell _spell1;
        private readonly Spell _spell2;
        private int _health;
        private int _mana;

        protected Hero()
        {
            _health = 1000;
            _mana = 500;
            _spell1 = new DragonSlave(new Area(), "Dragon Slave", 50, new ManaCost(), this);
            _spell2 = new LagunaBlade(new SingleTarget(), "Laguna Blade", 150, new HealthCost(), this);
            CurrentSpell = _spell1;
            Console.WriteLine("Готова запуска  " +  CurrentSpell.Name);
        }

        public Spell CurrentSpell { get; private set; }

        public void ChangeHealth(int health)
        {
            Console.WriteLine();
            Console.Write("ХП было:" + _health);
            _health -= health;
            Console.WriteLine("ХП стало:" + _health);
        }        
        
        public void ChangeMana(int mana)
        {
            Console.WriteLine();
            Console.Write("Маны было:" + _mana);
            _mana -= mana;
            Console.WriteLine("Маны стало:" + _mana);
        }
        
        public void Cast()
        {
            CurrentSpell.Cast();
        }

        public void SwitchSpell()
        {
            if (CurrentSpell == _spell1)
            {
                CurrentSpell = _spell2;
                Console.WriteLine("Помяняла на  " +  CurrentSpell.Name);
            }
            else
            {
                CurrentSpell = _spell1;
                Console.WriteLine("Помяняла на  " +  CurrentSpell.Name);
            }
        }
    }
}