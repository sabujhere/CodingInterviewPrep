using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    public class MergeTwoBinaryTrees
    {
        /// <summary>
        /// 617. Merge Two Binary Trees
        /// </summary>
        public class Solution
        {
            public InorderTreeNode MergeTrees(InorderTreeNode root1, InorderTreeNode root2)
            {
                if (root1 == null) return root2;
                if (root2 == null) return root1;
                root1.val += root2.val;
                root1.left = MergeTrees(root1.left, root2.left);
                root1.right = MergeTrees(root1.right, root2.right);
                return root1;

            }
        }
}
