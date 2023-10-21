public class Scripture {

    private Reference _reference;
    private string _text;
    private List<Word> _words = new List<Word>();

    public string GetReference()
    {
        return _reference.GetReference();
    }
    
    public string GetText()
    {
        return _text;
    }
    
    public Scripture(string reference, string text)
    {
        _reference = new Reference(reference);
        _text = text;

        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }
    
    public void HideWords()
    {
        Random random = new Random();
        while (true)
        {
            int randomIndex = random.Next(_words.Count);
            Word word = _words[randomIndex];

            if (!word.IsHidden())
            {
                word.Hide();
                break;
            }
        }
    }

    public string GetRenderedText()
    {
        List<string> renderedWords = new List<string>();
        foreach (Word word in _words)
        {
            renderedWords.Add(word.GetRenderedText());
        }
        return string.Join(" ", renderedWords);
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}