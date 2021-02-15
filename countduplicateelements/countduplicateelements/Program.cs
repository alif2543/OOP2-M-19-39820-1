using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countduplicateelements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr4 = new int[] { 1, 1, 2, 3, 2, 5 };
            Console.WriteLine();
            Console.WriteLine("Duplicates are");
            for (int i = 0; i < arr4.Length; i++)
            {
                for (int j = i + 1; j < arr4.Length; j++)
                {
                    if (arr4[i] == arr4[j])
                        Console.WriteLine(arr4[j]);
                }
            }
    }
}
