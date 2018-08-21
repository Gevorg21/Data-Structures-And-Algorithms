using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        public static int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[end];
            int j = start;

            for (int i = start; i < end; i++)
            {
                if (arr[i] <= pivot)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    j++;
                }
            }

            int aTemp = arr[j];
            arr[j] = arr[end];
            arr[end] = aTemp;

            return j;
        }

        public static void QuickSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int position = Partition(arr, start, end);
                QuickSort(arr, start, position - 1);
                QuickSort(arr, position + 1, end);
            }
        }

        static void Main(string[] args)
        {
            var arr = Console.ReadLine();
            string[] arr1 = arr.Split(' ');
            int[] arr2 = Array.ConvertAll(arr1, int.Parse);
            QuickSort(arr2, 0, arr2.Length - 1);

            foreach (int item in arr2)
            {
                Console.Write(item + " ");
            }

        }
    }
}
