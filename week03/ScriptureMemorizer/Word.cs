using System.Dynamic;

public class Word
{
  string _text;
  bool _isHidden;

  public Word(string text)
  {
    _text = text;
    _isHidden = false;
  }

  public void Hide()
  {
    string replaced = new string('_', _text.Length);
    _text = replaced;
    _isHidden = true;
  }

  public void Show()
  {
    _isHidden = false;
  }

  public bool IsHidden()
  {
    return _isHidden;
  }

  public string GetDisplayText()
  {
    return _text;
  }
}