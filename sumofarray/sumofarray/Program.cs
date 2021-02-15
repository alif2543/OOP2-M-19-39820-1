using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumofarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 5, 8, 9, 10 };
            int sum = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                sum = sum + arr1[i];
            }
            Console.WriteLine("Sum of the array elements is {0}.", sum);
        }
    }
}
