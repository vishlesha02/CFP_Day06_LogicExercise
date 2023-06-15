using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLogicExercise
{
    internal class FractionSum
    {
        int num;
        double sum=0.0;
        public void SumOfFraction()
        {
            Console.WriteLine("Enter a Number");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                sum += (1 / (double)(i * i));
            }
            Console.WriteLine($"Sum of Series {sum}");
        }
    }
}
