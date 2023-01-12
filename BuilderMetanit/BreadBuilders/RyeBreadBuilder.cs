namespace Builder
{
    internal class RyeBreadBuilder : BreadBuilder
    {
        public override void SetFlour()
        {
            Bread.Flour = new Flour { Sort = "Ржаная мука 1 сорт" };
        }

        public override void SetSalt()
        {
            Bread.Salt = new Salt();
        }

        public override void SetAdditives()
        {
            
        }
    }
}