using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLogicExercise
{
    internal class NumberPalindrome
    {
        public void pal()
        {
            Console.WriteLine("Enter the numer");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int rem =0;
            int rev=0;

                while(num > 0)
                {
                    rem = num % 10;
                    rev=(rev * 10)+rem;
                    num = num / 10;

                
                }
            
            if (temp == rev)
            {
                Console.WriteLine("The Number is Palindrome");
            }

            else
            {
                Console.WriteLine("The Number is not Palindrome");

            }

        }
    }
}
