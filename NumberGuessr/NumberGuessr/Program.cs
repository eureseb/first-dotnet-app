using System;


namespace NumberGuessr
{
    //Main Class
    class Program
    {
        static void Main(string[] args) {
            string app_ver = "1.0";
            
            programSpec(app_ver);
            Console.Write("What is your name?: ");
            string input = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", input);

            int correct_num = 69;
            int guess = -1;
            Console.WriteLine("Guess a number between 1-100: ");
            while(guess != correct_num)
            
                input = Console.ReadLine();
                guess = Int32.Parse(input);
                bool isCorrect = wrongGuess(correct_num, guess);
                //if (isCorrect)
                //{
                //    Console.WriteLine("wohoo");
                //}
            }
        static void programSpec(string app_ver)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", "NumGuessr", app_ver, "Eurese B");
            Console.ResetColor();
        }
        static bool wrongGuess(int correct_num, int n)
        {
            return correct_num == n;
        }
    }
}
