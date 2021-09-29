using System;

namespace determine_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string app_name = "determine number";
            string app_author = "Kamati Karl";

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("{0} by {1}", app_name, app_author);

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("what is yur name");
            string user_name = Console.ReadLine();
            Console.WriteLine("hello {0}, lets play a game",user_name);
            while (true)
            {
                Console.WriteLine("try and guess the correct number, enter a number between 1 and 20");

                Random random = new Random();
                int correct_number = random.Next(1, 10);
                int user_guess = 0;
                //string user_input = Console.ReadLine();


                //user_guess = Int32.Parse(user_input);


                while (user_guess != correct_number)
                {
                    string user_input = Console.ReadLine();
                    if (!int.TryParse(user_input, out user_guess))
                    {
                        Console.WriteLine("please enter a valid number");


                        continue;
                    }
                    if (user_guess != correct_number)
                    {
                        Console.WriteLine("wrong, guess again");
                        user_input = Console.ReadLine();
                        user_guess = Int32.Parse(user_input);

                    }


                }
                Console.WriteLine("you guesssed correctly, well done");
                Console.WriteLine("play again Y/N");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                    return;

            }


       ; }
    }
}
