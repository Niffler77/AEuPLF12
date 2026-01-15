using System.Diagnostics;

namespace SortingAlgorithms
{
    internal static class InsertionSortClass
    {
        public static void InsertionSort(int[] arr)
        {
            var sw = Stopwatch.StartNew();
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                int key = arr[i];
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = key;
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds + "ms");
        }
    }
}
