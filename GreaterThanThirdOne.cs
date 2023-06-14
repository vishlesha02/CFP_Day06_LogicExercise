using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLogicExercise
{
    internal class GreaterThanThirdOne
    {
        int[] a = {2,6,15 };

        public void Checks()
        {
           
           
                if (a[0] * a[1] > a[2] || a[0] + a[1] > a[2])
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
