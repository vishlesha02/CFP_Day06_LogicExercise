using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLogicExercise
{
    internal class IsResultSame
    {
        int num1, num2, num3, num4, num5, num6, num7, num8;

        public void Sameres()
        {
            Console.WriteLine("Enter  Number for addition");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number for multiplication");
            num3 = int.Parse(Console.ReadLine());
            num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Numbers for substraction ");
            num5 = int.Parse(Console.ReadLine());
            num6 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter  Numbers for division ");
            num7 = int.Parse(Console.ReadLine());
            num8 = int.Parse(Console.ReadLine());



            int addition = num1 + num2;
            int substraction = num3 - num4;
            int multiplication = num5 * num6;
            int division = num7 / num8;
            
            if (addition == multiplication)
            {
                Console.WriteLine("True, Addition and Multiplication return same result");
            }
            else
            {
                Console.WriteLine("False, Addition and Multiplication does not return same result");
            }
        
            if ( substraction == division) 
            {
                Console.WriteLine("True, substraction and division return same result"); 
            }
            else
            {
                Console.WriteLine("False, substraction and division does not return same result"); 
            }
        }
    }
}
