using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLogicExercise
{
    internal class Cube
    {
        int num,result;

        public void GiveCube()
        {
            Console.WriteLine("Enter the Number");
            num=int.Parse(Console.ReadLine());

            result = num * num * num;
            Console.WriteLine($"The cube of Given Number is {result}");

        }
    }
}
