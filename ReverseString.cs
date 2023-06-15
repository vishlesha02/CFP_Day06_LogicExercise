using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLogicExercise
{
    internal class ReverseString
    {
        int count;
        public void Rev()
        {
            Console.WriteLine("Enter the String");
            String str=Console.ReadLine();

            string reverseString = string.Empty;

            for (int i = str.Length - 1; i >= 0; i--) 
            {
                reverseString += str[i];
            }

            Console.WriteLine($"The Reverse of given String is {reverseString}");
        }
    }
}
