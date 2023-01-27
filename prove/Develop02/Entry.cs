using System.IO;

public class Entry
{
    Prompts getPrompt = new Prompts();
    DateTime theCurrentDate = DateTime.Now;    

    public Entry()
    {
    }

    public string NewEntry()
    {
        string dateText = theCurrentDate.ToShortDateString();
        Console.WriteLine($"Date: {dateText}");
        getPrompt.DisplayPrompt();
        Console.Write("Begin Journal Entry: ");
        string journalEntry = Console.ReadLine();
        string combinedEntry = ($"~|~ {dateText}| {getPrompt}: {journalEntry} ~|~        ");
        return combinedEntry;
    }
}