using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(" **************** Selection Sort ***************** ");
            var result = new SortingMethods(new int[] { 12, 32, 21, 23, 21, 45 }).SelectionSort();
            
            ShowResult(result);

            Console.WriteLine(" **************** Bubble Sort ***************** ");
            result = new SortingMethods(new int[] { 12, 32, 21, 23, 21, 45 }).BubbleSort();
            ShowResult(result);

            Console.WriteLine(" **************** Insertion Sort ***************** ");
            result = new SortingMethods(new int[] { 12, 32, 21, 23, 21, 45 }).InsertionSort();
            ShowResult(result);

            Console.WriteLine(" **************** Binary Tree Sort ***************** ");
            result = new SortingMethods(new int[] { 12, 32, 21, 23, 21, 45 }).BinaryTreeSort();
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
