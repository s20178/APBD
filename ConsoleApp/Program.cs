using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 10, 15, 20, 25 };
            double average = CalculateAverage(numbers);
            int max = FindMax(numbers);

            Console.WriteLine("Average: " + average);
            Console.WriteLine("Max: " + max); 
        }

        static double CalculateAverage(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return 0;
            }

            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
                Console.WriteLine(sum);
            }

            return (double)sum / array.Length;
        }

        static int FindMax(int[] array) 
        {
            if (array == null || array.Length == 0)
            {
                return 0;
            }

            int max = array[0];
            foreach (int num in array) 
            {
                if (num > max) 
                {
                    max = num;
                }
            }
            return max;
        }
    }
}