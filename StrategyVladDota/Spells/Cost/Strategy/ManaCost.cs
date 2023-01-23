namespace T04
{
    public class ManaCost : ICost
    {
        public void RemoveRecoucre(Hero hero, int cost)
        {
            hero.ChangeMana(cost);
        }
    }
}