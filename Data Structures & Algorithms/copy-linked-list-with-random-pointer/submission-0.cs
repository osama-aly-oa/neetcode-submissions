/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        Dictionary<Node, Node> oldCopy = new Dictionary<Node, Node>();

        Node curr = head;
        while(curr != null){
            Node copy = new Node(curr.val);
            oldCopy[curr] = copy;
            curr = curr.next;
        }

        curr = head;
        while(curr != null){
            Node copy = oldCopy[curr];
            copy.next = curr.next != null ? oldCopy[curr.next] : null;
            copy.random = curr.random != null ? oldCopy[curr.random] : null;
            curr = curr.next;
        }
        return head != null ? oldCopy[head] : null;
    }
}
