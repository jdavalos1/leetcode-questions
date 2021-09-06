
//Definition for a binary tree node.
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class SymmetricTree_101{
    public bool IsSymmetric(TreeNode root) {
      return Traverse(root, root);
    }
    
    private bool Traverse(TreeNode node1, TreeNode node2)
    {
        if(node1 == null && node2 == null) return true;
        if(node1 == null || node2 == null) return false;
        
        return (node1.val == node2.val) && Traverse(node1.left, node2.right) && Traverse(node1.right, node2.left);
    }
}