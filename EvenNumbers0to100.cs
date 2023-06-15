using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLogicExercise
{
    internal class EvenNumbers0to100
    {
        public void ZerotoHundred()
        {
            string str = string.Empty;

            for (int i=2;i<=100;i++)
            {
                if(i % 2 == 0)
                {
                    str += i + " ";
                }
            }
            Console.WriteLine(str);
        }
    }
}
