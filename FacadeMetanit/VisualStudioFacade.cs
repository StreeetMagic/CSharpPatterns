namespace FacadeMetanit
{
    internal class VisualStudioFacade
    {
        private readonly TextEditor _textEditor;
        private readonly Compiller _compiller;
        private readonly CLR _clr;
        
        public VisualStudioFacade(TextEditor textEditor, Compiller compiller, CLR clr)
        {
            _textEditor = textEditor;
            _compiller = compiller;
            _clr = clr;
        }
        
        public void Start()
        {
            _textEditor.CreateCode();
            _textEditor.Save();
            _compiller.Compile();
            _clr.Execute();
        }
        
        public void Stop()
        {
            _clr.Finish();
        }
    }
}