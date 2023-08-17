TreeNode root1 = new TreeNode();
root1.Left = new TreeNode();
root1.Right = new TreeNode();
root1.Left.Left = new TreeNode();
root1.Left.Right = new TreeNode();
root1.Left.Left.Left = new TreeNode();
root1.Left.Left.Right = new TreeNode();
root1.Right.Left = new TreeNode();
root1.Right.Right = new TreeNode();
root1.Right.Right.Right = new TreeNode();
root1.Right.Right.Left = new TreeNode();

TreeNode root2 = new TreeNode();
root2.Left = new TreeNode();
root2.Right = new TreeNode();
root2.Left.Left = new TreeNode();
root2.Left.Right = new TreeNode();
root2.Right.Left = new TreeNode();
root2.Right.Right = new TreeNode();
//root2.Right.Right.Right = new TreeNode();
//root2.Right.Right.Left= new TreeNode(); 

//Console.WriteLine(CompareTrees(root1, root2));
Console.WriteLine(CompletedTreeLeavesCounter(root1));
Console.WriteLine(CountTreeLeaves(root1));

static bool CompareTrees(TreeNode? firstTree, TreeNode? secondTree)
{
    if (firstTree == null && secondTree == null)
    {
        return true;
    }
    else if (firstTree == null || secondTree == null)
    {
        return false;
    }
    else if (firstTree.Left == null && secondTree.Left != null || firstTree.Left != null && secondTree.Left == null)
    {
        return false;
    }
    else if (firstTree.Right == null && secondTree.Right != null || firstTree.Right != null && secondTree.Right == null)
    {
        return false;
    }

    return CompareTrees(firstTree.Left, secondTree.Left) && CompareTrees(firstTree.Right, secondTree.Right);
}

static int CountTreeLeaves(TreeNode tree)
{
    if (tree.Left != null && tree.Right != null)
    {
        return 2 + CountTreeLeaves(tree.Left) + CountTreeLeaves(tree.Right);
    }
    if (tree.Left != null)
    {
        return 1 + CountTreeLeaves(tree.Left);
    }
    if (tree.Right != null)
    {
        return 1 + CountTreeLeaves(tree.Right);
    }

    return 0;
}
static int CompletedTreeLeavesCounter(TreeNode tree)
{
    if (tree.Left != null && tree.Right != null)
    {
        return 1 + CompletedTreeLeavesCounter(tree.Left) + CompletedTreeLeavesCounter(tree.Right);
    }
    if (tree.Left != null && tree.Left.Left != null && tree.Left.Right != null)
    {
        return 1 + CompletedTreeLeavesCounter(tree.Left.Left);
    }
    if (tree.Right != null && tree.Right.Left != null && tree.Right.Right != null)
    {
        return 1 + CompletedTreeLeavesCounter(tree.Right.Right);
    }

    return 0;
}

class TreeNode
{
    public TreeNode? Left { get; set; }
    public TreeNode? Right { get; set; }
}