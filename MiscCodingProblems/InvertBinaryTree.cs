using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    /// <summary>
    /// 226. Invert Binary Tree
    /// </summary>
    public class InvertBinaryTree
    {
        public InorderTreeNode InvertTree(InorderTreeNode root)
        {
            if (root == null) return root;

            var left = InvertTree(root.left);
            var right = InvertTree(root.right);
            //swap
            root.right = left;
            root.left = right;
            return root;
        }
    }
}
