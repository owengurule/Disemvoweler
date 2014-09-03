using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            Disemvoweler("Nickleback is my favorite band. Their songwriting can't be beat!");
            Disemvoweler("How many bears could bear grylls grill if bear grylls could grill bears?");
            Disemvoweler("I'm a code ninja, bab. I make the functions and I make the calls");

                


                Console.ReadKey();
        }
        //create a function called Disemvoweler that takes a string parameter called "input" and prints a disemvoweled string.
        static void Disemvoweler (string input)
        {
            //created two string vaariabls output and vowel
            string output = "";
            string vowel = "";
            
            for (int i = 0; i < input.Length; i++)
            {
                if (" aeiou".Contains(input[i])) 
                {

                    output = output + input[i];
                }
                {
                    

                    
                }
            }
            //original
            Console.WriteLine("Original" + input);
            //disemvoweled
            Console.WriteLine("Disemvoweled" + output);
            

        }
    }
}
