using System;
//This is the ScriptureMemorizer Project.
class Program
{
    static void Main(string[] args)
    {
        Reference scriptureReference = new Reference("John", 3, 16);
        
        string text = " For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Scripture scriptureGame = new Scripture(scriptureReference, text);

        string userInput = "";

        while (userInput.ToLower() != "quit" && !scriptureGame.IsCompletelyHidden())
        {
            Console.WriteLine(scriptureGame.GetDisplayText());
            Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit.");
            userInput = Console.ReadLine();

            if (userInput.ToLower() != "quit")
            {
                scriptureGame.HideRandomWords(3);
            }
        }

        if (scriptureGame.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scriptureGame.GetDisplayText());
            Console.WriteLine("\nCongratulations! You Learn the scriptutre!");
        }
    }
}