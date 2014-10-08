using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler___class
{
    class Program
    {
        static void Main(string[] args)
        {
            //call our disemvoweler
            Disemvoweler("Nickleback is Logan's favorite band. Their songwriting cannot be beat! Dark horse is his favorite album");

            //get a string to disemvowel from the user
            Console.WriteLine("Enter a sentence to disemvowel");

            //place the users input into a string
            string input = Console.ReadLine();
            
            // call the disemvoweler with their input
            Disemvoweler(input);

            Console.ReadKey();
        }


        static void Disemvoweler(string input)
        {
            //declare output variable
            string output = string.Empty;
            //declare a variable to hold the vowels
            string vowels = string.Empty;

            //loop over each letter of the string
            for (int i = 0; i < input.Length; i++)
            {
                //put the current letter into a variable
                string letter = input[i].ToString();
                //determine if the letter is a vowel
                if ("aeiou".Contains(letter.ToLower()))
                {
                    //its a vowel
                    vowels = vowels + letter;
                }
                else if (letter == " ")
                {
                    //its a space do nothing
                }
                else
                {
                    //not a vowel or  space add it to the output
                    output += letter;
                }

            }
            //looped through all the letters
            //time to print the output
            Console.WriteLine("original: " + input);
                Console.WriteLine("original: " + output);
                Console.WriteLine("vowels: " + vowels);

        }


    }
}
