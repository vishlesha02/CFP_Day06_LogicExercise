using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLogicExercise
{
    internal class ModuloOperations
    {
        int num1, num2, num3;
        public void Modulos()
        {
            Console.WriteLine("Enter 3 numbers");

            num1=int.Parse(Console.ReadLine());
            num2=int.Parse(Console.ReadLine());
            num3 =int.Parse(Console.ReadLine());

            int result = num1 % num2 % num3;
            Console.WriteLine($"Result = {result}");


        }

    }
}
