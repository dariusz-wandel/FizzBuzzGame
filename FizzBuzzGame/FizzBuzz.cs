using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    internal class FizzBuzz
    {
        public string PlayFizzBuzz(int number)
        {
            string output = "";
                        {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    output += "FizzBuzz\n";
                }
                else if (number % 3 == 0)
                {
                    output += "Fizz\n";
                }
                else if (number % 5 == 0)
                {
                    output += "Buzz\n";
                }
                else
                {
                    output += number.ToString() + "\n";
                }
            }
            return output;
        }
    }
}
