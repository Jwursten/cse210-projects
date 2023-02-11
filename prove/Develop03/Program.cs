using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Enos", 1, 4, 9);
        Scripture scripture = new Scripture(reference,

            "And my soul hungered; and I kneeled " +
            "down before my Maker, and I cried unto " +
            "him in mighty prayer and supplication " +
            "for mine own soul; and all the day long " +
            "did I cry unto him; yea, and when the " +
            "night came I did still raise my voice high " +
            "that it reached the heavens. " +

            "And there came a voice unto me, " +
            "saying: Enos, thy sins are forgiven thee, " +
            "and thou shalt be blessed. " +

            "And I, Enos, knew that God could not " +
            "lie; wherefore, my guilt was swept away. " +

            "And I said: Lord, how is it done? " +

            "And he said unto me: Because of thy " +
            "faith in Christ, whom thou hast never " +
            "before heard nor seen. And many years " +
            "pass away before he shall manifest " +
            "himself in the flesh; wherefore, go to, thy " +
            "faith hath made thee whole.");
        string input;

        int wordCount = 0;

        foreach (string word in scripture.GetDisplayText().Split(" ")) {
            wordCount ++;
        }

        Console.WriteLine("Welcome to the Scripture Memorizer program!");

        Console.WriteLine();

        Console.Write("Enter the difficulty (The number of items removed on each round): ");

        int difficulty;
        do {
            difficulty = int.Parse(Console.ReadLine());
            if (difficulty < 1) {
                Console.Write("Invalid entry. Please enter a number 1 or greater: ");
            }
            if (difficulty > wordCount) {
                difficulty = wordCount;
            }
        }
        while (difficulty < 1);
        

        do
        {
            Console.Clear();

            string scriptureText = scripture.GetDisplayText();

            Console.WriteLine(scriptureText);

            Console.WriteLine();

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");

            input = Console.ReadLine();
            
            if (scripture.IsCompletelyHidden()) {
                break;
            }

            scripture.HideWords(difficulty);

            Console.Clear();
        }

        while (input.ToLower() != "quit");

        Console.WriteLine("Goodbye!");
    }
}