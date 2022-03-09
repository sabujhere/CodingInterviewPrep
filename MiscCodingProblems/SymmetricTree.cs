using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    /// <summary>
    /// 101. Symmetric Tree
    /// </summary>
    public class SymmetricTree
    {
        public bool IsSymmetric(InorderTreeNode root)
        {
            return IsMirror(root, root);
        }

        private bool IsMirror(InorderTreeNode t1, InorderTreeNode t2)
        {
            if (t1 == null && t2 == null) return true;
            if (t1 == null || t2 == null) return false;

            return (t1.val == t2.val) && IsMirror(t1.left, t2.right) && IsMirror(t1.right, t2.left);
        }
    }
}
