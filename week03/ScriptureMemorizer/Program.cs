using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("D&C", 64, 33, 34);

        string text = "Wherefore, be not weary in well-doing, for ye are laying the foundation of a great work. " +
                      "And out of small things proceedeth that which is great. " +
                      "Behold, the Lord requireth the heart and a willing mind; " +
                      "and the willing and obedient shall eat the good of the land of Zion in these last days.";

        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program complete.");
                break;
            }

            scripture.HideRandomWords(3); // Hide 3 new words each time
        }
    }

    benefit of encapsulation