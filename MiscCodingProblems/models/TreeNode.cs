namespace MiscCodingProblems.Models;

public class TreeNode
{
    public int val;
    public IList<TreeNode> children;

    public TreeNode() { }

    public TreeNode(int _val)
    {
        val = _val;
    }

    public TreeNode(int _val, IList<TreeNode> _children)
    {
        val = _val;
        children = _children;
    }
}