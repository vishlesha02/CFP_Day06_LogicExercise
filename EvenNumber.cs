using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLogicExercise
{
    internal class EvenNumber
    {

        int i;
        public void Number()
        {
            Console.WriteLine("Enter the Number");
            i=int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                Console.WriteLine("The Number is Even");
            }
            else 
            {

                Console.WriteLine("The Number is not Even");
                    
            }
            
        }
    }
}
