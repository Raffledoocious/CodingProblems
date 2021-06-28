using System;
using System.Collections.Generic;

namespace CodingProblems
{
	class CloneGraph
	{
		public Node Clone(Node node)
		{
            if (node == null)
            {
                return null;
            }

            var root = new Node(node.val);
            Dictionary<int, Node> clonedNodes = new Dictionary<int, Node>();
            Queue<Node> nodesToVisit = new Queue<Node>();

            nodesToVisit.Enqueue(node);
            clonedNodes[node.val] = root;

            while (nodesToVisit.Count != 0)
            {
                var current = nodesToVisit.Dequeue();
                var neighbors = current.neighbors;

                foreach (var neighbor in neighbors)
                {
                    if (!clonedNodes.ContainsKey(neighbor.val))
                    {
                        Node clonedNode = new Node(neighbor.val);
                        clonedNodes[neighbor.val] = clonedNode;
                        clonedNodes[current.val].neighbors.Add(clonedNode);
                        nodesToVisit.Enqueue(neighbor);
                    }
                    else
                    {
                        clonedNodes[current.val].neighbors.Add(clonedNodes[neighbor.val]);
                    }
                }
            }
            
            return root;
		}

		public class Node
        {
            public int val;
            public IList<Node> neighbors;

            public Node()
            {
                val = 0;
                neighbors = new List<Node>();
            }

            public Node(int _val)
            {
                val = _val;
                neighbors = new List<Node>();
            }

            public Node(int _val, List<Node> _neighbors)
            {
                val = _val;
                neighbors = _neighbors;
            }
        }
    }
}
