using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLogicExercise
{
    class AddAndMultiply
    {
        int num1;
        int num2;
        int num3;
        int result;

        public void Add()
        {
            Console.WriteLine("Enter three numbers");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());

            result = (num1 + num2) * num3;
            Console.WriteLine(result);
                   
        }

    }
}
