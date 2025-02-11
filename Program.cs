using Microsoft.Win32.SafeHandles;
using System;

namespace Part_4._5___Intro_to_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

        //Part 1 = Text art

            //print method monkey 1
            PrintMonkey1();
            //print method pic 2
            PrintcuteBear();
            //print method pic 3
            PrintMewing();

            //press enter to go to part 2
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();

            //Part 2 - Knock Knock Joke
            PrintKnockKnock();




        }
        //method for knock knock
        public static void PrintKnockKnock()
        {
            Console.Clear();
            Console.WriteLine("Knock Knock");
            Thread.Sleep(1000);
            Console.WriteLine("Who's there?");
            Thread.Sleep(1000);
            Console.WriteLine("Come in...");
            Thread.Sleep(1000);
            Console.WriteLine("Huh what!!??");
            Thread.Sleep(1000);
            Console.WriteLine("Let's try again...");
            Thread.Sleep(2000);
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine("Knock Knock");
            Thread.Sleep(1000);
            Console.WriteLine("Who's there?");
            Thread.Sleep(1000);
            Console.WriteLine("Interrupting sloth");
            Thread.Sleep(1000);
            Console.WriteLine("Interrupting sloth who?");
            Thread.Sleep(1000);
            Console.WriteLine("(insert 15 seconds of silence)");
            Thread.Sleep(5000);
            Console.WriteLine("SLOOOTTTHHHHH");
            Thread.Sleep(1000);
            PrintMewing();
            Console.ReadLine();
        }


        // method for pic 1
        public static void PrintMonkey1()
        {
            Console.WriteLine("        _\r\n      |>(|)<|\r\n      .-'^'-.\r\n     '/\"'\"^\"\\'\r\n    :( *   * ):\r\n    ::)  ,| (::\r\n    '(       )'          _.\r\n     '\\ --- /'          / /\r\n   .-'       '-.      .__D\r\n ,\"      |      \\    / : (=|\r\n:   Y    |    \\  \\  /  : (=|\r\n|   |o__/ \\__o:   \\/  \" \\ \\\r\n|   |          \\     '   \"-.\r\n|    `.    ___ \\:._.'\r\n \".__  \"-\" __ \\ \\\r\n  .|''---''------|               _\r\n  / -.          _\"\"-.--.        C )\r\n '    '/.___.--'        '._    : |\r\n|     --_   ^\"--...__      ''-.' |\r\n|        ''---.o)    \"\"._        |\r\n ^'--.._      |o)        '`-..._.jku\r\n        '--.._|o)\r\n              'O)");
        }
        // method for pic 2
        public static void PrintcuteBear()
        {
            Console.WriteLine("  /\\_/\\\r\n ( o.o )\r\n  > ^ <");
        }

        // method for pic 3
        public static void PrintMewing()
        {
            Console.WriteLine("                _\r\n            ,.-\" \"-.,\r\n           /   ===   \\\r\n          /  =======  \\\r\n       __|  (o)   (0)  |__      \r\n      / _|    .---.    |_ \\         \r\n     | /.----/ O O \\----.\\ |       \r\n      \\/     |     |     \\/        \r\n      |                   |            \r\n      |                   |           \r\n      |                   |          \r\n      _\\   -.,_____,.-   /_         \r\n  ,.-\"  \"-.,_________,.-\"  \"-.,\r\n /          |       |          \\  \r\n|           l.     .l           | \r\n|            |     |            |\r\nl.           |     |           .l             \r\n |           l.   .l           | \\,     \r\n l.           |   |           .l   \\,    \r\n  |           |   |           |      \\,  \r\n  l.          |   |          .l        |\r\n   |          |   |          |         |\r\n   |          |---|          |         |\r\n   |          |   |          |         |\r\n   /\"-.,__,.-\"\\   /\"-.,__,.-\"\\\"-.,_,.-\"\\\r\n  |            \\ /            |         |\r\n  |             |             |         |\r\n   \\__|__|__|__/ \\__|__|__|__/ \\_|__|__/ Sandra");
        }



        }
}
