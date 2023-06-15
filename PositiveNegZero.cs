using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLogicExercise
{
    internal class PositiveNegZero
    {
        public void PnZ()
        {
            Console.WriteLine("Enter the Number");
            float num=float.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Positive Number");
            }
            else if (num == 0)
            {
                Console.WriteLine("Zero");
            }
            else if (num < 0)
            { 
                Console.WriteLine("Negative number");
            }
        
        }

    }
}
