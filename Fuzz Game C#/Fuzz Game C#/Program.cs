using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuzz_Game_C_
{
    internal class Program
    {
        static void Main(string[] args) {
            /*Create a For Loop 1 to  X {15} = (number needed)
             *  3 and 5 = FizzBuzz
             *  %3  = Fizz
             *  %5 = Buzz
             *  else = number */


            bool divBy3 = false;
            bool divBy5 = false;

            for (int i = 1; i <= 15; i++) {

                divBy3 = i % 3 == 0;
                divBy5 = i % 5 == 0;

                if (divBy3 && divBy5) {
                    Console.WriteLine("FizzBuzz !!");
                }
                else if (divBy3) {
                    Console.WriteLine("Fizz");
                }
                else if (divBy5) {
                    Console.WriteLine("Buzz");
                }
                else {
                    Console.WriteLine(i);
                }

                
            }
            Console.ReadKey();
        }
    }
}
