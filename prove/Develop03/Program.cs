class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("\n---------------------------- WELCOME TO THE SCRIPTURE MEMORIZER! ------------------------------\n");

        //list of scriptures to choose from
        List<Scripture> scriptures = new List<Scripture>
        {
            CreateScripture("John", 3, 16, "For God so loved the world that he gave his only Son"),
            CreateScripture("1 Nephi", 11, 17, "And I said unto him: I know that he loveth his children; nevertheless, I do not know the meaning of all things."),
            CreateScripture("Alma", 7, 11, "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people.")
        };

        int userChoice;
        do
        {
            //display menu
            Console.WriteLine("Choose a scripture to memorize:");
            Console.WriteLine("0. Quit");
            Console.WriteLine("1. John 3:16");
            Console.WriteLine("2. 1 Nephi 11:17");
            Console.WriteLine("3. Alma 7:11");

            //get user choice
            do
            {
                Console.Write("\nEnter the number of your choice (0-3): ");
            } while (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice < 0 || userChoice > 3);

            if (userChoice != 0)
            {
                //memorizing the selected scripture
                Scripture selectedScripture = scriptures[userChoice - 1];

                Console.Clear();
                Console.WriteLine("\n---------------------------- START MEMORIZING! ------------------------------\n");
                Console.WriteLine("Press Enter to hide a random word or type 'quit' to return to the menu.\n");

                Console.WriteLine(selectedScripture.GetRenderedText());

                string userInput;
                do
                {
                    userInput = Console.ReadLine();
                    Console.Clear();
                    if (userInput.ToLower() == "quit") break;

                    selectedScripture.HideRandomWord();
                    Console.WriteLine("\n" + selectedScripture.GetRenderedText());

                } while (selectedScripture.Words.Exists(word => !word.IsHidden));
                Console.Clear();
            }

        } while (userChoice != 0);

        Console.WriteLine("\nProgram ended.");
        Console.WriteLine("Goodbye!\n");
    }


    //creates a new scripture object
    static Scripture CreateScripture(string book, int chapter, int verse, string text)
    {
        var words = new List<Word>();
        foreach (string word in text.Split(" "))
        {
            Word newWord = new Word(word);
            words.Add(newWord);
        }

        Reference reference = new Reference(book, chapter, verse);
        return new Scripture(reference, words);
    }
}