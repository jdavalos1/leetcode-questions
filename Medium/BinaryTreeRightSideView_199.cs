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

public class Solution {
    public IList<int> RightSideView(TreeNode root) {
        var nodeQueue = BFS(root);
        
        return FindRightSide(nodeQueue);
    }
    

    private List<TreeNode> BFS(TreeNode root)
    {
        if(root == null) return new List<TreeNode>();
        
        // Create two queues: one for traversing and to hold
        var q = new Queue<TreeNode>();
        var returnQ = new Queue<TreeNode>();
        
        q.Enqueue(root);
        returnQ.Enqueue(root);
        q.Enqueue(null);
        returnQ.Enqueue(null);
        
        while(q.Count > 0)
        {
            var current = q.Peek();
            q.Dequeue();
            
            if(current == null)
            {
                if(q.Count > 0)
                {
                    q.Enqueue(null);
                    returnQ.Enqueue(null);
                }
            }
            else
            {
                if(current.left != null)
                {
                    q.Enqueue(current.left);
                    returnQ.Enqueue(current.left);
                }
                
                if(current.right != null)
                {
                    q.Enqueue(current.right);
                    returnQ.Enqueue(current.right);
                }
            }
        }
        
        return returnQ.ToList();
    }
    
    private List<int> FindRightSide(List<TreeNode> nodeQueue)
    {
        // We know that if null is the next value
        // then there are no blocking values to the right of the node
        var rightSide = new List<int>();
        for(int i = 0; i < nodeQueue.Count; i++)
        {
            if(i + 1 < nodeQueue.Count && nodeQueue[i+1] == null)
            {
                rightSide.Add(nodeQueue[i].val);
            }
        }
        
        return rightSide;
    }
}