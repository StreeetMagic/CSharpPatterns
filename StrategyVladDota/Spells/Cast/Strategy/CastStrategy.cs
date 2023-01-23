namespace T04
{
    public abstract class CastStrategy : ICast
    {
        public void Cast()
        {
            SpecialCast();
        }

        protected abstract void SpecialCast();
    }
}