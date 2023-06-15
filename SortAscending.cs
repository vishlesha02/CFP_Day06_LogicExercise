using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLogicExercise
{
    internal class SortAscending
    {
        int[] a = { 20, 21, 23 };
        public void SortArray()
        {
            if (a[0] <= a[1] && a[1] <= a[2])
            {
                Console.WriteLine("Array is sorted in ascending order");
            
            }
            else
            {
                Console.WriteLine("Array is not sorted in ascending order");
            }
        }
    }
}
