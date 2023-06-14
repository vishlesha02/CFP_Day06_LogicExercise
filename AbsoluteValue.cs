using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLogicExercise
{
    internal class AbsoluteValue
    {
        int absoluteValue;
        public void Value()
        {
            Console.WriteLine("Enter the Number ");
            int num=int.Parse(Console.ReadLine());

            if (num < 0)
            {
                absoluteValue = Math.Abs(num);
            }
            else
            {
                absoluteValue = num;
            }
            Console.WriteLine($"The Absolute value is {absoluteValue}");
        
        }
    }
}
