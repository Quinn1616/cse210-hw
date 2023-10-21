
public class Word {
    private string _text;
    private bool _hidden;

    public string GetText()
    {
        return _text;
    }
  
    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public void Show()
    {
        _hidden = false;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public string GetRenderedText()
    {
       if (_hidden == true)
       {
        //for each letter return "-"
        return new string('-', _text.Length);
       }
       
       else
       {
        return _text;
       }
    }

}