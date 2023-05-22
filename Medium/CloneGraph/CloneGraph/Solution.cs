namespace CloneGraph;

public class Node {
    public int val;
    public IList<Node> neighbors;

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


public class Solution
{
    public Node CloneGraph(Node node)
    {
        var cloneGraph = new Node(node.val);
        
        var dict = new Dictionary<int, Node>();
        dict[cloneGraph.val] = cloneGraph;

        var nodeQueue = new Queue<Node>();
        var cloneGraphQueue = new Queue<Node>();
        
        nodeQueue.Enqueue(node);
        cloneGraphQueue.Enqueue(cloneGraph);

        var nodesDone = new HashSet<int>();
        
        while (nodeQueue.Count > 0)
        {
            var iNode = nodeQueue.Dequeue();
            var cloneNode = cloneGraphQueue.Dequeue();

            if (!nodesDone.Contains(iNode.val))
            {
                for (int i = 0; i < iNode.neighbors.Count; i++)
                {
                    var neighbor = iNode.neighbors[i];
                    if (dict.ContainsKey(neighbor.val))
                    {
                        cloneNode.neighbors.Add(dict[neighbor.val]);
                    }
                    else
                    {
                        var cloneNeighbor = new Node(neighbor.val);
                        cloneNode.neighbors.Add(cloneNeighbor);

                        dict[cloneNeighbor.val] = cloneNeighbor;
                    }

                    if (!nodesDone.Contains(neighbor.val))
                    {
                        nodeQueue.Enqueue(neighbor);
                        cloneGraphQueue.Enqueue(cloneNode.neighbors[i]);    
                    }
                }
            }

            nodesDone.Add(iNode.val);
            Console.Write($"{cloneNode.val}: ");
            cloneNode.neighbors.ToList().ForEach(n => Console.Write($"{n.val}  "));
            Console.WriteLine();
        }

        return cloneGraph;
    }
}

// public class Solution {
//     public Node CloneGraph(Node node) {
//         var cloneTree = new Node();
//         cloneTree.val = node.val;
//         
//         var queue = new Queue<Node>();
//         queue.Enqueue(node);
//
//         var cloneQueue = new Queue<Node>();
//         cloneQueue.Enqueue(cloneTree);
//
//         var hs = new HashSet<int>();
//         hs.Add(node.val);
//
//         
//         while (queue.Count > 0)
//         {
//             var node1 = queue.Dequeue();
//             var clone = cloneQueue.Dequeue();
//             for (int i = 0; i < node1.neighbors.Count; i++)
//             {
//                 clone.neighbors.Add(new Node(node1.neighbors[i].val));
//                 
//                 if (!hs.Contains(node1.neighbors[i].val))
//                 {
//                     queue.Enqueue(node1.neighbors[i]);
//                     cloneQueue.Enqueue(clone.neighbors[i]);
//                 }
//             }
//
//             hs.Add(node1.val);
//             
//             
//         }
//
//         cloneTree.neighbors.ToList().ForEach(n => Console.WriteLine(n.val));
//
//         Console.WriteLine();
//         Console.WriteLine(cloneTree.neighbors[0].val);
//         cloneTree.neighbors[0].neighbors.ToList().ForEach(n => Console.WriteLine(n.val));
//
//         Console.WriteLine();
//         Console.WriteLine(cloneTree.neighbors[1].val);
//         cloneTree.neighbors[1].neighbors.ToList().ForEach(n => Console.WriteLine(n.val));
//
//         Console.WriteLine();
//         Console.WriteLine(cloneTree.neighbors[0].neighbors[1].val);
//         cloneTree.neighbors[0].neighbors[1].neighbors.ToList().ForEach(n => Console.WriteLine(n.val));
//         
//
//
//
//         return cloneTree;
//     }
// }