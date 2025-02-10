namespace Part_4._5___Intro_to_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Monkey1, Monkey2;
            Monkey1 = "                  __\r\n                 / _,\\\r\n                 \\_\\\r\n      ,,,,    _,_)  #      /)\r\n     (= =)D__/    __/     //\r\n    C/^__)/     _(    ___//\r\n      \\_,/  -.   '-._/,--'\r\n_\\\\_,  /           -//.\r\n \\_ \\_/  -,._ _     ) )\r\n   \\/    /    )    / /\r\n   \\-__,/    (    ( (\r\n              \\.__,-)\\_\r\n               )\\_ / -(\r\n    b'ger     / -(////\r\n             ////";
            Monkey2 = "       .-\"-.            .-\"-.            .-\"-.           .-\"-.\r\n     _/_-.-_\\_        _/.-.-.\\_        _/.-.-.\\_       _/.-.-.\\_\r\n    / __} {__ \\      /|( o o )|\\      ( ( o o ) )     ( ( o o ) )\r\n   / //  \"  \\\\ \\    | //  \"  \\\\ |      |/  \"  \\|       |/  \"  \\|\r\n  / / \\'---'/ \\ \\  / / \\'---'/ \\ \\      \\'/^\\'/         \\ .-. /\r\n  \\ \\_/`\"\"\"`\\_/ /  \\ \\_/`\"\"\"`\\_/ /      /`\\ /`\\         /`\"\"\"`\\\r\n   \\           /    \\           /      /  /|\\  \\       /       \\\r\n\r\n-={ see no evil }={ hear no evil }={ speak no evil }={ have no fun }=-";
        }
        
        public static void PrintHello(string daNAME, int daAGE, string daDOG)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine($"Hello, I'm {daNAME}!");
            Console.WriteLine($"Nice to meet you!, I am {daAGE} year old!");
            Console.WriteLine($"My dog's name is {daDOG}!");
        }



        //Console.WriteLine($"{image1}   {image2}");

    }
}
