using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    /// <summary>
    /// 112. Path Sum
    /// </summary>
    public class PathSum
    {
        public bool HasPathSum(InorderTreeNode root, int targetSum)
        {
            if (root == null) return false;
            var nodeStack = new Stack<InorderTreeNode>();
            var sumStack = new Stack<int>();
            nodeStack.Push(root);
            sumStack.Push(targetSum - root.val);
            while (nodeStack.Count != 0)
            {
                var currentNode = nodeStack.Pop();
                var currentSum = sumStack.Pop();
                if (currentNode.left == null && currentNode.right == null && currentSum == 0) return true;

                if (currentNode.left != null)
                {
                    nodeStack.Push(currentNode.left);
                    sumStack.Push(currentSum - currentNode.left.val);

                }
                if (currentNode.right != null)
                {
                    nodeStack.Push(currentNode.right);
                    sumStack.Push(currentSum - currentNode.right.val);

                }
            }

            return false;
        }
    }
}
