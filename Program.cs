using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[] { 12, 32, 21, 23, 21, 45 };
            Console.WriteLine(" **************** Selection Sort ***************** ");
            var result = new SortingMethods(data).SelectionSort();
            
            ShowResult(result);
            Console.WriteLine(" **************** Bubble Sort ***************** ");
            int[] data2 = new int[] { 12, 32, 21, 23, 21, 45 };
            result = new SortingMethods(data2).BubbleSort();
            ShowResult(result);
        }

        private static void ShowResult(int [] result)
        {
            Console.WriteLine(" **************** final Result ***************** ");
            foreach (var item in result)
            {

                Console.Write(" " + item + " ");
            }
            Console.WriteLine();
            Console.WriteLine(" **************** End of Program *****************");
        }
    }
}
