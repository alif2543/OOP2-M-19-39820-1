using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copyarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 2,3,5,7,8,9};
            int[] arr2 = new int[5];
            for (int k = 0; k < arr1.Length; k++)
            {
                arr2[k] = arr1[k];
            }
            for (int l = 0; l < arr2.Length; l++)
            {
                Console.Write(arr2[l] + " ");
            }
            Console.WriteLine();
        }
    }
}
