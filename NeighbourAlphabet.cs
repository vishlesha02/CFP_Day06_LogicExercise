using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLogicExercise
{
    internal class NeighbourAlphabet
    {
        String str;
        public void Neighbour()
        {
            Console.WriteLine("Enter the String");
            str = Console.ReadLine();

            if (str[0] == str[1] -1 || str[0] == str[1] + 1 || str[1] == str[2] -1 || str[1] == str[2] +1)
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
