using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLogicExercise
{
    internal class SumOfDigit
    {
        int result;
        public void Sum()
        {
            Console.WriteLine("Enter a String "); 
            String str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    result += (int)char.GetNumericValue(str[i]);
                }
            }
            Console.WriteLine(result);
            
        }
    }
}
