using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiscCodingProblems.Models;
namespace MiscCodingProblems
{
    /// <summary>
    /// 589. N-ary Tree Preorder Traversal
    /// </summary>
    public class N_aryTreePreorderTraversal
    {
        public IList<int> Preorder(TreeNode root)
        {
            var stack = new Stack<TreeNode>();
            var traversedValues = new List<int>();

            if (root == null) return traversedValues;
            stack.Push(root);
            while (stack.Count != 0)
            {
                var currentNode = stack.Pop();
                traversedValues.Add(currentNode.val);
                var children = currentNode.children.Reverse().ToList();
                foreach (var child in children)
                {
                    stack.Push(child);
                }
            }

            return traversedValues;
        }
    }
}
