using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLogicExercise
{
    internal class TwoSevens
    {
        int Count=0;
        public void Sevens()
        {
            int[] a = { 5, 6, 9, 7, 7, 3, 6, 7, 5, 7, 7 ,7};

            for(int i=0;i<a.Length-1;i++) 
            {
                if (a[i] == 7 && a[i + 1] == 7)
                {
                    Count++;
                }
            }
                Console.WriteLine(Count);


        }
    }
}
