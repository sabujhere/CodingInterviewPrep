using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    public class MaximumDepthofBinaryTree
    {
        public int MaxDepth(InorderTreeNode root)
        {
            if (root == null) return 0;
            int leftDepth = MaxDepth(root.left);
            int rightDepth = MaxDepth(root.right);
            return Math.Max(leftDepth, rightDepth) + 1;
        }
    }
}
