using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bublesort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] {20, 1, 30,2, 5, 6, 3};
            BubbleSort(array,array.Length);
            for (int count = 0; count < array.Length; count++)
            {
                Console.WriteLine(array[count]);
            }
        }

        public static void BubbleSort(int[] arrey, int lengthOfArray)
        {
            for (int i = 1; i < arrey.Length; i++)
            {
                for (int j = 0; j < arrey.Length - 1; j++)
                {
                    if (arrey[j] > arrey[j + 1])
                    {
                        int temp = arrey[j];
                        arrey[j] = arrey[j + 1];
                        arrey[j + 1] = temp;
                    }
                }

            }
        }
    }
}

