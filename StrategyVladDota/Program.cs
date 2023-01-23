namespace T04
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Player player = new Player();
            Hero lina = player.Hero;

            lina.Cast();
            lina.SwitchSpell();
            lina.Cast();
            
            lina.CurrentSpell.ChangeCostType(new ManaCost());
            lina.Cast();
        }
    }
}