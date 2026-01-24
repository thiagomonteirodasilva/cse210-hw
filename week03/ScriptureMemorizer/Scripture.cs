public class Scripture
{
  Reference _reference;
  List<Word> _words = new List<Word>();

  public Scripture(Reference reference, string text)
  {
    _reference = reference;
    string[] textList = text.Split(" ");
    foreach (string word in textList)
    {
      Word wordObj = new Word(word);
      _words.Add(wordObj);
    }
    Console.WriteLine(GetDisplayText());
  }

  public void HideRandomWords(int numberToHide)
  {
    Random random = new Random();

    List<int> indexes = _words
      .Select((v, i) => new { v, i })
      .Where(x => !x.v.IsHidden())
      .Select(x => x.i)
      .OrderBy(x => random.Next())
      .Take(numberToHide)
      .ToList();

    foreach (int i in indexes)
    {
      Word word = _words[i];
      if (!word.IsHidden())
      {
        word.Hide();
      }
    }
  }

  public string GetDisplayText()
  {
    List<string> scriptureWords = new List<string>();
    foreach (Word word in _words)
    {
      scriptureWords.Add(word.GetDisplayText());
    }
    string scripture = $"{_reference.GetDisplayText()} - {string.Join(" ", scriptureWords)}";
    return scripture;
  }

  public bool IsCompletelyHidden()
  {
    bool allHidden = _words.All(w => w.IsHidden());
    if (allHidden)
    {
      return true;
    }
    return false;
  }
}