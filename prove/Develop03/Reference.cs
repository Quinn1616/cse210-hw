
public class Reference {
    private string _book;
    private int _chapter;
    private int _verse;
    private int _secondVerse;

    public string GetBook()
    {
        return _book;
    }
    //public void SetBook(string book)
    //{
        //_book = book;
    //}

    public int GetChapter()
    {
        return _chapter;
    }
    //public void SetChapter(int chapter)
    //{
        //_chapter = chapter;
    //}

    public int GetVerse()
    {
        return _verse;
    }
    //public void SetChapter(int verse)
    //{
        //_verse = verse;
    //}

    public int GetSecondVerse()
    {
        return _secondVerse;
    }
    //public void SetSecondVerse(int secondVerse)
    //{
        //_secondVerse = secondVerse;
    //}

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int verse, int secondVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _secondVerse = secondVerse;
    }

}

//Possibly save entire reference as a string. Just display the reference.
//Console.WriteLine(${reference.GetReference()});