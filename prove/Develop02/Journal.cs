using System.IO;

public class Journal
{
    Entry startEntries = new Entry(); 

    public Journal()
    {
    }


    public void NewJournalEntry()
    {
        string newEntry = startEntries.NewEntry();
        File.AppendAllText("Journal.txt", newEntry);
    }
    
    public void DisplayJournal()
    {
        string readText = File.ReadAllText("Journal.txt");
        Console.WriteLine(readText);
    }

    public void SaveJournal()
    {
        Console.Write("Where do you want to save your Journal: ");
        string newFilename = Console.ReadLine();
        string allText = File.ReadAllText("Journal.txt");
        File.WriteAllText($"{newFilename}", allText);
    }

    public void LoadJournal()
    {
        Console.Write("What journal do you want to load: ");
        string loadFile = Console.ReadLine();
        string journalFile = "Journal.txt";
        string backupFile = "backupJournal.txt";
        File.Replace($"{loadFile}", journalFile, backupFile);
    }


}