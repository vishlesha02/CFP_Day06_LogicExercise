using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLogicExercise
{
    internal class ThreeAdjacent
    {
        public void Numbers()
        {
            int[] a = { 45, 23, 44, 68, 65, 70, 80, 81, 82 };
            bool found=false;

            for (int i = 1; i <= a.Length-2; i++)
            {
                if (a[i - 1] + 1 == a[i] && a[i + 1] - 1 == a[i])
                {
                    found = true;
                    break;
                }
               
            }
            Console.WriteLine(found);
        }
    }
}
