using System.IO;

public class Journal
{
    public List<Entry> _enteries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _enteries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _enteries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _enteries)
            {
                outputFile.WriteLine($"{entry._date},{entry._promptDate},{entry._entryText}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptDate = parts[1];
            entry._entryText = parts[2];

            _enteries.Add(entry);
        }
    }
}