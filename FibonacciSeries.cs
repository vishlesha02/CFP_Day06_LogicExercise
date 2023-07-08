using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace EasyLogicExercise
{
    internal class FibonacciSeries
    {
        public void FibSeries()
        {

            int a = 0;
            int b = 1;
            int c;
            int num = 5;
            Console.Write(a + " " + b );

            for (int i = 2; i < num; i++)
            {
                c = a + b;
                Console.Write( " " + c);

                a = b;
                b = c;

            }
            
        }
    }
}
