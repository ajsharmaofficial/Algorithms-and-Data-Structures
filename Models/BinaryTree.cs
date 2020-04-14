using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Models
{
    class BinaryTree
    {
        public TreeNode Root { get; set; }
        private int index = 0;
        public BinaryTree()
        {
            Root = null;
        }

        public void InsertNode(TreeNode node)
        {
            if(Root==null)
            {
                Root = node;
            }
            else
            {
                var current = Root;
                TreeNode parent;
                while(true)
                {
                    parent = current;
                    if(current.Key>node.Key)
                    {
                        current = current.LeftChild;
                        if (current == null)
                        {
                            parent.LeftChild = node;
                            break;
                        }
                           
                    }
                    else
                    {
                        current = current.RightChild;
                        if (current == null)
                        {
                            parent.RightChild = node;
                            break;
                        }
                            
                    }
                }
            }
        }

        public int[] TraverseInorder(int numofnodes)
        {
            int[] nodes = new int[numofnodes]; ;
            var current = Root;
            index = 0;
            InOrder(current, nodes);
            return nodes;
        }

        public void InOrder(TreeNode treeNode, int [] keys)
        {
            if(treeNode == null)
                return;
            InOrder(treeNode.LeftChild, keys);
            keys[index++] = treeNode.Key;
            InOrder(treeNode.RightChild, keys);
        }
    }
}
