using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5G
{
    internal class Demo
    {
        static void Main()
        {
            int n = 0;
            do
            {
                Console.Write("Enter an integer: ");
                n = int.Parse(Console.ReadLine());
            } while ((n > -10000 || n < -99999) && (n < 10000 || n > 99999));
            if (n < 0)
            {
                n = Math.Abs(n);
            }
            int n5 = n % 10;
            //Console.WriteLine(n5);
            int n4 = (n / 10) % 10;
            //Console.WriteLine(n4);
            int n3 = (n / 100) % 10;
            //Console.WriteLine(n3);
            int n2 = (n / 1000) % 10;
            //Console.WriteLine(n2);
            int n1 = (n / 10000) % 10;
            //Console.WriteLine(n1);
            int[] array = { n1, n2, n3, n4, n5 };
            int sum_even = GetSumOfEvenDigits(array);
            int sum_odd = GetSumOfOddDigits(array);
            int result = GetMultipleOfEvensAndOdds(sum_even, sum_odd);
            Console.WriteLine(result);
        }

        static int GetSumOfEvenDigits(int[] array)
        {
            int sum = 0;
            for (int i=0; i<array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    sum += array[i];
            }
            return sum;
        }

        static int GetSumOfOddDigits(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1) 
                    sum += array[i];
            }

            return sum;
        }


        static int GetMultipleOfEvensAndOdds(int even, int odd)
        {
            return even * odd;
        }

    }
}
