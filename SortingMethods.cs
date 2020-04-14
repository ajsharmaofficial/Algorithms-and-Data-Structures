using SortingAlgorithms.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class SortingMethods
    {
        private int[] data;
        private int swapcount;
        public SortingMethods(int[] sortingData)
        {
            data = sortingData;
            swapcount = 0;
        }

        public int[]  SelectionSort()
        {
            for (int i = 0; i < data.Length-1; i++)
            {
                var min = data[i];
                for(int j=i+1;j<data.Length;j++)
                {
                    if(min>data[j])
                    {
                        data[i] = data[j];
                        data[j]=min;
                        min = data[i];
                        swapcount++;
                    }

                    
                }
                Console.Write("  Pass " + (i + 1)+" ");
                foreach (var item in data)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
               
            }
            Console.WriteLine();
            Console.WriteLine(" Total Swap Performed " + swapcount);
            Console.WriteLine();
            return data;
        }

        public int[] BubbleSort()
        {
            for (int i = data.Length-2; i>=0 ; i--)
            {
                
                for (int j = 0; j < i; j++)
                {
                    if (data[j] > data[j+1])
                    {
                        var temp = data[j];
                        data[j] = data[j+1];
                        data[j+1] = temp;
                        swapcount++;
                    }

                }
                Console.Write("  Pass " + (i + 1) + " ");
                foreach (var item in data)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
                if(swapcount == 0)
                {
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine(" Total Swap Performed " + swapcount);
            Console.WriteLine();
            return data;
        }

        public int[] InsertionSort()
        {
            for (int i = 1; i<data.Length; i++)
            {
                int j;
                var temp = data[i];
                for (j = i-1; j>=0 && data[j]>temp; j--)
                {
                        
                        data[j+1] = data[j];
                        
                }
                data[j + 1] = temp;
                Console.Write("  Step " + (i) + " ");
                foreach (var item in data)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
              
            }
            Console.WriteLine();
            return data;
        }

        public int[] BinaryTreeSort()
        {
            var bst = new BinaryTree();
            foreach (var item in data)
            {
                var node = new TreeNode(item);
                bst.InsertNode(node);

            }
            data = bst.TraverseInorder(data.Length);
            return data;
        }
    }
}
