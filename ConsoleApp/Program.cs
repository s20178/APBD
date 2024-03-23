using System;
using System.Collections.Generic;
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
            Console.WriteLine("Average: " + average);
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
            }

            return (double)sum / array.Length;
        }
    }
}