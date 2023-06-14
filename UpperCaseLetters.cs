using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLogicExercise
{
    
    internal class UpperCaseLetters
    {
        string str;
        public void Letters()
        {
            Console.WriteLine("Enter the Characters");
            str = (Console.ReadLine());

            if (str[0] >= 65 && str[1] >= 65 && str[2] >= 65 && str[0] <= 90 && str[1] <= 90 && str[2] <= 90)
            {
                Console.WriteLine("True");
            }
            
            else
            { 
                Console.WriteLine("False");
            }

        }
    }
}
