using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLogicExercise
{
    internal class Palindrome
    {
        public void StringPalindrom()
        {
            Console.WriteLine("Enter the word");
            string str=Console.ReadLine();

            for (int i = 0; i <= str.Length/2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                { 
                    Console.WriteLine("false");
                }

            }
            Console.WriteLine("true");
        }
    }
}
