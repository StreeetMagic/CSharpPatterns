namespace T04
{
    public class HealthCost : ICost
    {
        public void RemoveRecoucre(Hero hero, int cost)
        {
            hero.ChangeHealth(cost);
        }
    }
}