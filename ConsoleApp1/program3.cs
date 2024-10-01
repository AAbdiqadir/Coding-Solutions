namespace HelloWorld;

public class Node {
    public int val;
    public List<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
public class Solution3
{
    Dictionary <int, Node> maps = new Dictionary <int, Node>();
    public Node CloneGraph(Node node) {
        if (node == null) return null;
        
        if( maps.ContainsKey(node.val) ) return maps[node.val];
        Node copy = new Node(node.val);
        
        maps[node.val]= copy;
        
        foreach (  Node nei in node.neighbors){
            copy.neighbors.Add(CloneGraph (nei));
        }
        return copy;
        
        
    }
}