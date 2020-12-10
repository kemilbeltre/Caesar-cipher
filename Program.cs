using System.Collections.Generic;
using System;
/**
 * This application performs the encryption of a string of characters 
 * using the Caesar cipher which is to move the letters of the abc
 * to a certain number (in this case it could be from 1 to 27)
 * By KEMIL BELTRE LEDESMA. 
 */

namespace ConsoleApp5
{
    class Program
    {
        /**
         * Here I implement a string of characters with the abc X2 so that it goes through
         * with the 27 spaces as the "ñ" is included.
         */
        static readonly List<char> abc = new List<char>()
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
            'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w',
            'x', 'y','z','a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
            'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w',
            'x', 'y','z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
            'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w',
            'x', 'y','z','a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
            'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w',
            'x', 'y','z'
        };
        static void Main(string[] args)
        {
            string str;
            int trips;
            Console.WriteLine("Introduces a word or tense: ");
            str = Console.ReadLine();

            Console.WriteLine("Introduces the number of trips: ");
            trips = int.Parse(Console.ReadLine());

            str = Encrypt(str, trips);
            Console.WriteLine("The cipher code is: ");
            Console.WriteLine(str.ToUpperInvariant()); //Converts entered characters to uppercase
            Console.ReadLine();
        }

        /**
         * This method encryps a string entered by the user 
         * and return it to the main method, to be displayed
         * on the screen
         */
        static string Encrypt(string str, int n = 3)
        {
            string temp = string.Empty;
            int result = 0;

            if (!string.IsNullOrEmpty(str))
            {
              
                foreach (char letter in str.ToLower())
                {
                    int x = abc.IndexOf(letter);
                    if (x == abc.Count - 1) { result = 0; }
                    else { result = x + n % 27; }
                    temp += abc[result].ToString();
                }
            }
            return temp;
        }


    }
}
