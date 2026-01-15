using System.IO;

namespace SortingAlgorithms
{
    internal class Program
    {

        private static int[] sortvalues = {42,18,3,99,12};
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
            //sortvalues = sorttempvalues;
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
