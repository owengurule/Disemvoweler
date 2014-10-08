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
        //created a function called Disemvoweler that takes a string parameter called "input" and prints a disemvoweled string.
        static void Disemvoweler (string input)
        {
            //created two string variabals output and vowel
            string output = "";
            string vowel = "";
            //created for loop that counts through each string character, with an if statement that finds letters that aren't vowels to add to your output
            for (int i = 0; i < input.Length; i++)
            {
                if (" bcdfghjklmnpqrstvwxyz!?.,;:".Contains(input[i])) 
                {

                    output = output + input[i];
                }
                {
                    

                    
                }
            }
            //printed results to the console
            //original
            Console.WriteLine("Original" + input);
            //disemvoweled
            Console.WriteLine("Disemvoweled" + output);
            

        }
    }
}
