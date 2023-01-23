namespace T04
{
    public class HealthAndManaCost : ICost
    {
        public void RemoveRecoucre(Hero hero, int cost)
        {
            hero.ChangeMana(cost);
            hero.ChangeHealth(cost);
        }
    }
}