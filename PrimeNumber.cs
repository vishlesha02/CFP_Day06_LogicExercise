using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLogicExercise
{
    internal class PrimeNumber
    {
        public void PNum()
        {

            int num = 17;
                bool isprime = true;

                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        isprime = false;
                        break;
                    }

                }

            if (isprime)
            {
                Console.WriteLine("It is prime Number");
            }
            else
            {
                Console.WriteLine("It is not prime Number");
            }
        
        
        }
    }
}
