using System;
using System.Collections.Generic;

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

public class PathSumII_113{
    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
        IList<IList<int>> paths = new List<IList<int>>();
        
        FindPaths(root, new List<int>(), 0, targetSum, paths);
        
        return paths;
    }
    
    public void FindPaths(TreeNode node, List<int> currentPath, int currSum, int targetSum, IList<IList<int>> paths)
    {
        // in case we go into null nodes from traversal
        if(node == null) return;
        
        // Add to the path and the current sum
        currentPath.Add(node.val);
        currSum += node.val;
        
        // Are there children to explore?
        if(node.left == null && node.right == null)
        {
            // No children so is the path valid? if so add to the paths
            if(currSum == targetSum)
            {
                paths.Add(new List<int>(currentPath));
            }
        }
        else
        {
            // Traverse left then right
            // remove the last value in the path to traverse to new (lists are by reference remember that :p)
            // What if the child was null? do not remove previous node
            FindPaths(node.left, currentPath, currSum, targetSum, paths);
            if(node.left != null) currentPath.RemoveAt(currentPath.Count - 1);
            
            FindPaths(node.right, currentPath, currSum, targetSum, paths);
            if(node.right != null) currentPath.RemoveAt(currentPath.Count - 1);

        }
    }
}