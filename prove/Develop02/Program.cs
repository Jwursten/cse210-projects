using System;

class Program
{
    static void Main(string[] args)
    {
        int useMenu = 66;

        while (useMenu != 0)
        {
            Console.WriteLine("Welcome to the Journal!");
            Console.WriteLine("[1] Write");
            Console.WriteLine("[2] Display");
            Console.WriteLine("[3] Save");
            Console.WriteLine("[4] Load");
            Console.WriteLine("[0] End");
            Console.Write("Type the number for the operation you wish to do: ");
            string menu = Console.ReadLine();
            int menuSelection = int.Parse(menu);

            Journal newJournal = new Journal();

            if (menuSelection == 1)
            {
                Console.WriteLine("");
                newJournal.NewJournalEntry();
                Console.WriteLine("");
            }
            else if (menuSelection == 2)
            {
                Console.WriteLine("");
                Console.WriteLine("Displaying Journal: ");
                newJournal.DisplayJournal();
                Console.WriteLine("");
            }
            else if (menuSelection == 3)
            {
                Console.WriteLine("");
                newJournal.SaveJournal();
                Console.WriteLine("");
            }
            else if (menuSelection == 4)
            {
                Console.WriteLine("");
                newJournal.LoadJournal();
                Console.WriteLine("");
            }
            else
            {
                useMenu = 0;
            }
        }

        

        
    }
}