using System;
using System.Linq;

namespace Bin2Dec
{
    class Program
    {
        static int BinToDec(string binary)
        {
            double sum = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                sum += Convert.ToInt32(binary[i].ToString()) * Math.Pow(2, binary.Length-i-1);
            }

            return Convert.ToInt32(sum);

            //return Convert.ToInt32(binary, 2); Built-in method
        }
        static void Main(string[] args)
        {
            char[] validChars = {'0', '1'};
            Console.Write("Enter a number in binary(up to 8 digits): ");
            string binary = Console.ReadLine();

            bool isValid = false;
            for (int i = 0; i < binary.Length; i++)
            {
                if (validChars.Contains(binary[i]))
                {
                    isValid = true;
                } else
                {
                    isValid = false;
                    break;
                }
            }

            if (binary.Length <= 8 && isValid)
            {
                Console.WriteLine("Converted to decimal: " + BinToDec(binary));
            } else
            {
                Console.WriteLine("The given number is not a binary number or it's too long.");
            }

            Console.ReadLine();
        }
    }
}