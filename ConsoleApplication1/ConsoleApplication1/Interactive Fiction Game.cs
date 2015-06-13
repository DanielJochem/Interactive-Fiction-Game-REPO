using System;
using System.Threading;

//All that usual set-up
namespace InteractiveFictionGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialization
            Random getRandom = new Random();
            int randNum = getRandom.Next(10);
            string times = randNum.ToString();

            //Sentences setup:
            string defaultPart;
            string part1;
            string part2a;
            string part2b;
            string part3;
            string part4;
            string finalPart;

            //Start of our story:
            Console.WriteLine("Welcome to a little adventure.");
            Thread.Sleep(1000);
            Console.WriteLine("\nAre you a male, lady, girl, man, banana, etc?");
            string gender = Console.ReadLine().ToLower();
            Console.WriteLine("\nNow enter your name:");
            string name = Console.ReadLine().ToLower();

            // Check for empty string.
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Why didn't you enter a name :/ Please do enter a name:");
                name = Console.ReadLine();
            }
            // Return char and concat substring.
            name = char.ToUpper(name[0]) + name.Substring(1);

            Console.WriteLine("\nNow enter your age in number form (pssst, you can lie about your age, you look young anyway!):");
            string age = Console.ReadLine();
            Console.WriteLine("\nThank You. Loading story...");
            Thread.Sleep(2000);
            Console.WriteLine("\n");

            //Sentence 1
            part1 = "There once was a " + gender + " named " + name + " who was " + age + " years old. ";
            Console.WriteLine(part1);
            Console.WriteLine("\nGreat story so far... Help me out here, what is your friend's name over there?");
            string friend = Console.ReadLine().ToLower();

            // Check for empty string.
            if (string.IsNullOrEmpty(friend))
            {
                Console.WriteLine("Why didn't you enter a name :/ Please do enter a name:");
                friend = Console.ReadLine();
            }
            // Return char and concat substring.
            friend = char.ToUpper(friend[0]) + friend.Substring(1);

            Console.WriteLine("\nYou said something to " + friend + ", what was it?");
            string sentence = Console.ReadLine().ToLower();
            sentence = char.ToUpper(sentence[0]) + sentence.Substring(1);
            Console.WriteLine("\nLet's try the story again:");
            Thread.Sleep(2000);
            Console.WriteLine("\n");

            //Sentence 1+2
            part2a = name + " was friends with " + friend + ". " + name + " called out to " + friend + ": \"" + sentence + "\" " + times + " times. ";
            part2b = name + " was friends with " + friend + ". " + name + " called out to " + friend + ": \"" + sentence + "\" over and over, " + times + " times. ";
            if (randNum > 3)
            {
                defaultPart = part1 + part2b;
                Console.WriteLine(defaultPart);
                Thread.Sleep(8000);
                Console.WriteLine("\nWow, that was a few times :/");
                Thread.Sleep(2000);
            }
            else
            {
                defaultPart = part1 + part2a;
                Console.WriteLine(defaultPart);
                Thread.Sleep(8000);
            }
            Console.WriteLine("\n" + friend + " is coming toward you with something in their hand, what does it look like? (plural please)");
            string obj = Console.ReadLine().ToLower();
            Console.WriteLine("\nWhat? How many are they holding?");
            string holding = Console.ReadLine().ToString();
            Console.WriteLine("\nOkay...");
            Thread.Sleep(2000);
            Console.WriteLine("\n");

            //Sentence 3
            part3 = friend + " gave " + name + " " + holding + " " + obj + ".";
            Console.WriteLine(defaultPart + part3);
            Thread.Sleep(8000);
            Console.WriteLine("\n\nAlright, now you get to choose what happend next. If you want something to happen to " + friend + ", enter \"1\". If you want something to happen to " + name + ", enter \"2\". Lastly, if you want something completely random to occur, enter \"3\".");
            string choice = Console.ReadLine().Trim().ToLower();

            switch (choice)
            {
                case "1":
                case "one":
                    part4 = " " + friend + " dropped their " + holding + " " + obj + ", tripped over and broke their neck and was quickly rushed away to hospital. I am sure they'll be fine...";
                    break;
                case "2":
                case "two":
                    part4 = " " + name + " tripped over their clown-size shoelaces, fell to the floor and survived with only minor bruising on the left knee. " + friend + " laughed histerically every time this was brought up in conversation.";
                    break;
                case "3":
                case "three":
                    part4 = friend + " hands over the " + obj + " and tells you to \"Wait here\", you never hear of them again.";
                    break;
                default:
                    Console.WriteLine("\nYou entered " + choice + ", go die.");
                    part4 = " Batman dies. How could you!";
                    Thread.Sleep(2000);
                    break;
            }
            finalPart = defaultPart + part3 + part4;

            Thread.Sleep(1000);
            Console.WriteLine("\nNow for the full story! This may take a bit to load.");
            Thread.Sleep(5000);
            Console.WriteLine("\n");

            Console.WriteLine(finalPart);
            Console.ReadLine();
            Console.WriteLine("\nThank you for playing! Goodbye.");
            Thread.Sleep(3000);
        }
    }
}//End?