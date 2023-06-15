using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLogicExercise
{
    internal class BiggestNumber
    {
        int temp;
        public void ArrayBiggest()
        {
            int[] a = { 4, 8, 6, 3, 56, 98, 55, };

            for(int i=0;i<a.Length;i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    { 
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.WriteLine($"The Biggest Element is {a[0]}");


        
        
        
        }
    }
}
