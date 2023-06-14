using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLogicExercise
{
    internal class CtoF
    {
        double celsius;
        double temperature;
 
        public void Convert()
        {
            
            Console.WriteLine("Enter the temperature in degrees");
            celsius=double.Parse(Console.ReadLine());

            if (celsius < -271.15)
            {
                Console.WriteLine("Temperature below -271.15 does not exist!");
                
            }
            else {

                temperature = (celsius * 9 / 5) + 32;
                Console.WriteLine($"The Temperature is {temperature} degree Fahrenheit");
            
            }
            
           

        }
    }
}
