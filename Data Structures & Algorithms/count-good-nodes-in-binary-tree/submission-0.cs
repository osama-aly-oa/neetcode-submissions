/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public int GoodNodes(TreeNode root) {
       return Dfs(root, root.val);
    }

    private int Dfs(TreeNode node, int maxValue) {
        if(node == null){
            return 0;
        }

        int res = (node.val >= maxValue) ? 1 : 0;
        maxValue = Math.Max(node.val, maxValue);
        res += Dfs(node.left, maxValue);
        res += Dfs(node.right, maxValue);
        return res;
    }
}
