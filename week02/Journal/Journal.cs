public class Journal
{
  List<Entry> _entries = new List<Entry>();
  public void AddEntry(Entry newEntry)
  {
    _entries.Add(newEntry);
  }

  public void DisplayAll()
  {
    foreach (Entry entry in _entries) {
      entry.Display();
    }
  }
  
  public void SaveToFile(string file)
  {
    Console.WriteLine($"File: {file}");
    
    using (StreamWriter outputFile = new StreamWriter(file))
    {
      foreach (Entry entry in _entries)
      {
        outputFile.WriteLine($"Date: |{entry._date}| - Prompt: |{entry._promptText}|{entry._entryText}");
      }
    }
  }

  public void LoadFromFile(string file)
  {
    _entries = new List<Entry>();
    string[] lines = System.IO.File.ReadAllLines(file);

    foreach (string line in lines)
    {
        Entry entry = new Entry();
        string[] parts = line.Split("|");

        string date = parts[1];
        string promptText = parts[3];
        string entryText = parts[4];

        entry._date = date;
        entry._promptText = promptText;
        entry._entryText = entryText;
        AddEntry(entry);
    }
  }
}