using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLogicExercise
{
    internal class SortArray
    {
        int[] a = { 5, 6, 8, 7 };
        int temp=0;
        public void Ascending()
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i+1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    
                    }
                }

            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);

            }

        }
    }
}
