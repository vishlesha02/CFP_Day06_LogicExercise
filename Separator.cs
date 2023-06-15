using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLogicExercise
{
    internal class Separator
    {
        

        String word,sep="_";
        public void AddSeprator()
        {
            string separatedWord = string.Empty;

            Console.WriteLine("Enter Word");
            word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                separatedWord += word[i];

                if (i < word.Length - 1)
                {
                    separatedWord += sep;

                }
            }
            Console.WriteLine(separatedWord);

        }
    }
}
