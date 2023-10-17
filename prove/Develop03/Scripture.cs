public class Scripture {
    
    private string _reference;
    private string _text;
    private List<Word> _verse = new List<Word>();  //list of words - split the verse into reference and text - split the text into word objects by spaces in a readfile function in program.cs

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
        //needs work
    }

    public string GetRenderedText()
    {
        return null;
        //needs work
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }

}