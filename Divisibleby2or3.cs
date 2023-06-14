using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLogicExercise
{
    internal class Divisibleby2or3
    {
        int num1;
        int num2;
        int result;
        public void Divisible()
        {
            Console.WriteLine("Enter 2 numbers");
            num1=int.Parse(Console.ReadLine());
            num2=int.Parse(Console.ReadLine());

            if (num1 % 2 == 0 && num2 % 2 == 0 || num1 % 3 == 0 && num2 % 3 == 0)
            {
                result = num1 * num2;
                Console.WriteLine($"The Multiplication is {result}");
            }
            else
            {
                result = num1 + num2;
                Console.WriteLine($"The Sum is {result}");



            }



        }
    }
}
