using System.IO;

namespace SortingAlgorithms
{
    internal class Program
    {

        private static int[] sortvalues = {27, 11, 90, 73, 45, 68, 99, 3, 79, 55, 23, 86, 37, 41, 8, 94, 51, 49, 64, 80, 60, 67, 70, 20, 96, 2, 13, 21, 15, 36, 83, 24, 89, 18, 91, 16, 25, 33, 19, 98, 92, 97, 54, 10, 87, 31, 30, 47, 75, 14, 52, 9, 1, 81, 56, 7, 72, 42, 66, 46, 77, 32, 76,22, 35, 6, 44, 29, 95, 43, 59, 63, 58, 48, 26, 53, 40, 5, 17, 74, 57, 39, 69, 85, 84, 50, 65, 78, 62, 38, 71, 28, 12, 4, 61, 88,34};
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var lines = File.ReadAllLines("C:\\Users\\Benjamin\\source\\repos\\AEuPLF12\\SortingAlgorithms\\random_0_to_25000.txt");
            var firstLine = lines[0];
            var fields = firstLine.Split(',');
            int[] sorttempvalues = new int[fields.Length];
            foreach (var i in Enumerable.Range(0, fields.Length))
            {
                int.TryParse(fields[i], out int result);
                sorttempvalues[i] = result;
            }
            sortvalues = sorttempvalues;
            //Console.WriteLine("Start Bubble Sort");
            //BubbleSortClass.BubbleSort(sortvalues);
            //Console.WriteLine("Start Selection Sort");
            //SelectionSortClass.SelectionSort(sortvalues);
            Console.WriteLine("Start InsertionSort");
            InsertionSortClass.InsertionSort(sortvalues);

            //Console.WriteLine("Sorted Values: "+ string.Join(",", resoult));
        }
    }
}
