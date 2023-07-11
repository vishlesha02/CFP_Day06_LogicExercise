using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace EasyLogicExercise
{
    public class Factorial
    {
        public void NumFact()
        {

            int Fact = 1;
            Console.WriteLine("Enter the Number");
            int a=int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                Fact = Fact * i;


            }
            Console.WriteLine(Fact);

        }
    }
}
