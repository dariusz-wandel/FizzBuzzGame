using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new FizzBuzz();
            bool playAgain = true;
            
            while (playAgain)
            {
                Console.WriteLine("Wprowadź liczbę, aby zagrać w grę FizzBuzz:");
                var number = GetNumber();
                Console.WriteLine(game.PlayFizzBuzz(number));
                Console.WriteLine($"Gramy jeszcze raz? (T/N)");
                string answer = Console.ReadLine();
                if (answer.ToLower() != "t")
                {
                    playAgain= false;
                }
            }
        }

        private static int GetNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Wprowadzona wartość nie jest prawidłową liczbą. Spróbuj jeszcze raz.");
                    continue;
                }
                return number;
            }
        }
    }
}
