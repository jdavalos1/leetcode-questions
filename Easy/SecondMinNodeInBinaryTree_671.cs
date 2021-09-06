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

public class SecondMinNodeInBinaryTree_671{
    public int FindSecondMinimumValue(TreeNode root) {
        int nextMin = -1;
        
        Traverse(root, root.val, ref nextMin);
        
        return nextMin;
    }
    
    private void Traverse(TreeNode node, int minVal, ref int nextMin)
    {
        if(node == null) return;
        
        if(node.val > minVal)
        {
            if(nextMin == -1 || node.val < nextMin)
            {
                nextMin = node.val;
            }
        }
        
        Traverse(node.left, minVal, ref nextMin);
        Traverse(node.right, minVal, ref nextMin);
    }
}