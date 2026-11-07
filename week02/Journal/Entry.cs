public class Entry
{
    public string _date;
    public string _promptDate;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"{_date} : {_promptDate}");
        Console.WriteLine(_entryText);
    }
}