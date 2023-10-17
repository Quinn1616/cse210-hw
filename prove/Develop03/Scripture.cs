public class Scripture {
    
    private string _reference;
    private string _text;
    private List<Word> _words = new List<Word>();

    public string GetReference(){
        return _reference;
    }
    //public void SetReference(string reference)
    //{
        //_reference = reference;
    //}

    public string GetText()
    {
        return _text;
    }
    //public void SetText(string text)
    //{
       //_text = text;
    //}

    public Scripture(string reference, string text)
    {
        _reference = reference;
        _text = text;
    }

    public void HideWords()
    {
        break;
    }

    public string GetRenderedText()
    {
        break;
    }

    public bool IsCompletelyHidden()
    {
        break;
    }

}