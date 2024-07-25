using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_tens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ones = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine","ten","eleven","tewlve","thirteen","forteen","fifteen","sixteen","seventeen","eighteen","nineteen" };
            string[] tens = { " ", " ", "tewnty", "thirtee", "fortee", "fifty", "sixty", "seventee", "eighty", "ninety" };
            string[] hundreds = { " ","hundred", "twohundred", "threehundred", "fourhundred", "fivehubdred", "sixhundred", "sevenhundred", "eighthundred", "ninehundred" };
            string[] Thousands = { "","thousand", "twothousand", "threethousand", "fourthousand", "fivethousand", "sixthousand", "seventhousand", "eightthousand", "ninethousand" };
            Console.WriteLine("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 0 && num > 900)
            {
                Console.WriteLine("Enter currect number");
            }
            else if (num % 1000 == 0)
            {
                Console.WriteLine("Enter number is : " + Thousands[num / 1000]);
            }
            else if (num % 100 == 0)
            {
                Console.WriteLine("Enter number is  : " + Thousands[num / 1000] + hundreds[num % 1000 / 100]);
            }
            else if (num % 10 == 0)
            {
                Console.WriteLine("Enter number is  : " + Thousands[num / 1000] + hundreds[num % 1000/100] + tens[num % 100/10]);
            }
            else
            {
                Console.WriteLine("Enter number is  : " + Thousands[num / 1000] + hundreds[num % 1000/100] + tens[num%100/10] + ones[num % 10]);
            }
            Console.ReadLine();
        }
        }

    }
