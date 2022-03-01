using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    public class N_aryTreePostorderTraversal
    {
        public IList<int> Postorder(TreeNode root)
        {
            var stack = new Stack<TreeNode>();
            var result = new Stack<int>();

            if (root == null)
            {
                return result.ToArray();
            }
            stack.Push(root);
            while (stack.Count != 0)
            {
                TreeNode node = stack.Pop();
                result.Push(node.val);
                foreach (var nodeChild in node.children)
                {
                    stack.Push(nodeChild);
                }
            }

            return result.ToArray();
        }
       
    }

    // Definition for a Node.
}
