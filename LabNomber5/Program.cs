using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNomber5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (!IsNumber(input))
                Console.WriteLine("Число не корректно");
            else
                Console.WriteLine(CalculateSummOfNumber(input));

            Console.ReadKey();
        }

        static bool IsNumber(string input)
        {
            string checkString = "1234567890";

            input = DeleteMinus(input);

            foreach(char ch in input)
            {
                if (!checkString.Contains(ch))
                    return false;
            }

            return true;
        }

        static string DeleteMinus(string input)
        {
            if (input[0] == '-')
                return input.Substring(1);
            else
                return input;
        }

        static int CalculateSummOfNumber(string input)
        {
            string numerals = "0123456789";
            int summ = 0;

            input = DeleteMinus(input);

            foreach(char ch in input)
            {
                for(int i = 0; i <=9; i++)
                {
                    if (ch == numerals[i])
                        summ += i;
                }
            }
            return summ;
        }
    }
}
