using System.Diagnostics;

namespace SortingAlgorithms
{
    internal static class SelectionSortClass
    {
        public static int[] SelectionSort(int[] arr)
        {
            var sw = Stopwatch.StartNew();
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                var min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min_idx])
                    {
                        min_idx = j;
                    }
                }

                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds + "ms");
            return arr;
        }
    }
}
