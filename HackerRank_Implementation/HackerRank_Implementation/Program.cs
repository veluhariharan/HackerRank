using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


class Solution
{
    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            long n = Convert.ToInt64(Console.ReadLine());

            CalculateDivisors(n); //Adding a comment here in the local github file
        }

        Console.ReadLine();

    }

    static void CalculateDivisors(long n)
    {
        int evenNumOfDivisors = 0;

        string number = n.ToString();

        for (int i = 0; i < number.Length; i++)
        {
            if (Convert.ToInt32(number[i].ToString()) != 0 && (n % Convert.ToInt32(number[i].ToString()) == 0))
            {
                evenNumOfDivisors++;
            }
        }
        Console.WriteLine(evenNumOfDivisors);
    }
}
