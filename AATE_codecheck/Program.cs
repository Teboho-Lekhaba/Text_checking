using System;
using System.Collections.Generic;
using System.Linq;

namespace AATE_codecheck
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Duplicate check – Represented by a ‘1’ 
            //2.Count the number of unique vowels – Represented by ‘2’
            //3.Output if there are more unique vowels or unique non vowels – Represented by ‘3’
            string text;
            int num;

            Console.WriteLine("Good day, please enter your text:");
            text = Console.ReadLine().Trim();

            Console.WriteLine("Please enter a number 1, 2 or 3 \n 1 to check for duplicates in your sentence " +
                "\n 2 to count the number of vowels " +
                "\n 3 Output if there are more unique vowels or unique non vowels ");

            text.Trim();
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                Duplicate_check(text);
            }
            else if (num == 2)
            {
                VowelCounter(text);
            }
            else if (num == 12)
            {
                Duplicate_check(text);
                VowelCounter(text);
            }
            else if (num == 3)
            {
                VowelComparison(text);
            }
           
            Console.ReadKey();
        }

        static void Duplicate_check(string text)
        {
            //This method checks for duplicates in a text entered by the user
            Console.WriteLine("------Duplicate checker------");

            List<char> seenChars = new List<char>();
            string duplicate = "";
            foreach (char charector in text.Trim())
            {
                if (seenChars.Contains(charector))
                {
                    duplicate += charector;
                   
                }
                else 
                {
                    seenChars.Add(charector);
                }
            }
            Console.WriteLine("duplicates: "+ duplicate);
            if (text.Length == text.Distinct().Count())
            {
                Console.WriteLine("no duplicates");
            }
            Console.WriteLine();
            Console.WriteLine("Good day, please enter your text:");
            text = Console.ReadLine().Trim();

            Console.WriteLine("Please enter a number 1, 2 or 3 \n 1 to check for duplicates in your sentence " +
                "\n 2 to count the number of vowels " +
                "\n 3 Output if there are more unique vowels or unique non vowels ");

            text.Trim();
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                Duplicate_check(text);
            }
            else if (num == 2)
            {
                VowelCounter(text);
            }
            else if (num == 12)
            {
                Duplicate_check(text);
                VowelCounter(text);
            }
            else if (num == 3)
            {
                VowelComparison(text);
            }


        }

        static void VowelCounter(string text)
        {
            // This method is used to count the number of vowels in a text entered by the user
            Console.WriteLine("-----Vowel Counter------");

            int counter = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            foreach (char charector in text)
            {
                if (vowels.Contains(charector))
                {
                    counter++;
                 
                }
               
                
            }
            Console.WriteLine("no vowels");
            Console.WriteLine("number is : " + counter);

            Console.WriteLine();
            Console.WriteLine("Good day, please enter your text:");
            text = Console.ReadLine().Trim();

            Console.WriteLine("Please enter a number 1, 2 or 3 \n 1 to check for duplicates in your sentence " +
                "\n 2 to count the number of vowels " +
                "\n 3 Output if there are more unique vowels or unique non vowels ");

            text.Trim();
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                Duplicate_check(text);
            }
            else if (num == 2)
            {
                VowelCounter(text);
            }
            else if (num == 12)
            {
                Duplicate_check(text);
                VowelCounter(text);
            }
            else if (num == 3)
            {
                VowelComparison(text);
            }

        }

        static void VowelComparison(string text)
        {
            Console.WriteLine("------Vowel comparisons-------");

            int vowelCounter = 0;
            int nonVowel = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            foreach (char charector in text)  
            {
                if (vowels.Contains(charector))
                {
                    vowelCounter++;
                }
                else
                {
                    nonVowel++;
                }
                
            }
            if (vowelCounter > nonVowel)
            {
                Console.WriteLine("The text has more vowels than non vowels");
            }
            else if (vowelCounter == nonVowel)
            {
                Console.WriteLine("The text has an equal amount of vowels and non vowels");
            }
            else
            {
                Console.WriteLine("The text has more non vowels than vowels");
            }

            Console.WriteLine();
            Console.WriteLine("Good day, please enter your text:");
            text = Console.ReadLine().Trim();

            Console.WriteLine("Please enter a number 1, 2 or 3 \n 1 to check for duplicates in your sentence " +
                "\n 2 to count the number of vowels " +
                "\n 3 Output if there are more unique vowels or unique non vowels ");

            text.Trim();
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                Duplicate_check(text);
            }
            else if (num == 2)
            {
                VowelCounter(text);
            }
            else if (num == 12)
            {
                Duplicate_check(text);
                VowelCounter(text);
            }
            else if (num == 3)
            {
                VowelComparison(text);
            }

        }
    }
}