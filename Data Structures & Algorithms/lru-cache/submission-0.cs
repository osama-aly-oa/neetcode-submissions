public class Node {
    public int Key;
    public int Val;
    public Node Prev;
    public Node Next;

    public Node(int key, int val) {
        Key = key;
        Val = val;
    }
}

public class LRUCache {
    private int capacity;
    private Dictionary<int, Node> cache;
    private Node left; 
    private Node right;

    public LRUCache(int capacity) {
        this.capacity = capacity; 
        this.cache = new Dictionary<int, Node>();

        left = new Node(0, 0);
        right = new Node(0, 0); 
        left.Next = right;
        right.Prev = left;
    }

    public void Remove(Node node) {
        Node prev = node.Prev;
        Node nxt = node.Next;
        prev.Next = nxt;
        nxt.Prev = prev;
    }

    public void Insert(Node node) {
        Node prev = right.Prev;
        prev.Next = node;
        node.Prev = prev;
        node.Next = right;
        right.Prev = node;
    }
    
    public int Get(int key) {
        if (cache.ContainsKey(key)) {
            Node node = cache[key];

            Remove(node);
            Insert(node);
            return node.Val; 
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        if (cache.ContainsKey(key)) {
            Remove(cache[key]);
        }

        Node newNode = new Node(key, value);
        cache[key] = newNode;
        Insert(newNode);

        if (cache.Count > capacity) {
            Node old = left.Next;
            Remove(old);
            cache.Remove(old.Key); 
        }
    }
}