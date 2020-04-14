using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Models
{
    class TreeNode
    {
        public int Key { get; set; }
        public TreeNode LeftChild { get; set; }
        public TreeNode RightChild{ get; set; }

        public TreeNode(int key)
        {
            Key = key;
            LeftChild = null;
            RightChild = null;
        }


    }
}
