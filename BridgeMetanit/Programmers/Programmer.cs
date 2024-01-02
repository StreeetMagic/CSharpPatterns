namespace BridgeMetanit
{
    internal abstract class Programmer
    {
        private ILanguage _language;

        public Programmer(ILanguage lang)
        {
            _language = lang;
        }

        public ILanguage SetLanguage(ILanguage language)
        {
            return _language = language;
        }

        public virtual void DoWork()
        {
            _language.Build();
            _language.Execute();
        }

        public abstract void EarnMoney();
    }
}