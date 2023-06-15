using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLogicExercise
{
    internal class LengthOfString
    {
        int count;
        public void Length()
        {
            Console.WriteLine("Enter String");
            String str=Console.ReadLine();

            for (int i = 0; i <= str.Length - 1; i++)
            {
                count++;
            
            }
            Console.WriteLine(count);
        
        }
    }
}
