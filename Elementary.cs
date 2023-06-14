using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLogicExercise
{
    internal class Elementary
    {
        int num1,num2;
        
        public void Operations()
        {

            Console.WriteLine("Enter 1st Number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd Number");
            num2 = int.Parse(Console.ReadLine());


            int addition = num1 + num2;
            int substraction = num1 - num2;
            int multiplication = num1 * num2;
            double division;

            /*addition=int.Parse(Console.ReadLine());
            substraction=int.Parse(Console.ReadLine()); 
            multiplication=int.Parse(Console.ReadLine());   
            division=int.Parse(Console.ReadLine()); 
*/
            if (num2 != 0)
            {
                division = num1 / (double)num2;

            }
            else
            {
                division = 0;
            }
            Console.WriteLine($" a + b = {addition}\n a - b = {substraction}\n a * b = {multiplication}\n a / b = {division}");

         
        }
        
    }
}
