using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLogicExercise
{
    internal class MultiplicationT
    {
        int mul;
        public void Table()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)

                {
                    mul = i * j;
                    Console.WriteLine(mul);
                    
                }
            
            }
        
        
        }
    }
}
