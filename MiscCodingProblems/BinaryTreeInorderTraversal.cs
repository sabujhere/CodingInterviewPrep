using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    /// <summary>
    /// 94. Binary Tree Inorder Traversal
    /// </summary>
    public class BinaryTreeInorderTraversal
    {
        public IList<int> InorderTraversal(InorderTreeNode root)
        {
            var stack = new Stack<InorderTreeNode>();
            var traversedValues = new List<int>();

            if (root == null) return traversedValues;
            var currentNode = root;
            while (currentNode != null || stack.Count != 0)
            {
                while (currentNode != null)
                {
                    stack.Push(currentNode);
                    currentNode = currentNode.left;
                }
                currentNode = stack.Pop();
                traversedValues.Add(currentNode.val);
                currentNode = currentNode.right;
            }
            return traversedValues.ToArray();
        }
       
    }

    public class InorderTreeNode
    {
        public int val;
        public InorderTreeNode left;
        public InorderTreeNode right;
        public InorderTreeNode(int val = 0, InorderTreeNode left = null, InorderTreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }


}
