public class Reference
{
  string _scriptureName;
  string _book;
  int _chapter;
  int _verse;
  int _endVerse;

  public Reference(string scriptureName, string book, int chapter, int verse)
  {
    _scriptureName = scriptureName;
    _book = book;
    _chapter = chapter;
    _verse = verse;
  }

  public Reference(string scriptureName, string book, int chapter, int startVerse, int endVerse)
  {
    _scriptureName = scriptureName;
    _book = book;
    _chapter = chapter;
    _verse = startVerse;
    _endVerse = endVerse;
  }

  public string GetDisplayText()
  {
    Console.WriteLine(_scriptureName);
    if (_endVerse > 0)
    {
      return $"{_book} {_chapter}:{_verse}-{_endVerse}"; 
    }
    return $"{_book} {_chapter}:{_verse}";
  }
}