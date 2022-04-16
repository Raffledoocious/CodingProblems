namespace InterviewPrep.Graph
{
    public struct WeightedEdge
    {
        public WeightedEdge(int from, int to, int weight)
        {
            From = from;
            To = to;
            Weight = weight;
        }

        public int From { get; }
        public int To { get;  }
        public int Weight { get; }
    }

    public static class Graph
    {
        public static double[] BellmanFord(List<WeightedEdge>[] graph, int source)
        {
            double[] distances = Enumerable.Repeat(double.PositiveInfinity, graph.Length).ToArray();
            distances[source] = 0;

            // relaxation of nodes O(VE)
            for (int i = 0; i < graph.Length-1; i++)
            {
                foreach (var vertice in graph)
                {
                   foreach (var edge in vertice)
                    {
                        if (distances[edge.From] != double.PositiveInfinity)
                        {
                            var newDistance = distances[edge.From] + edge.Weight;

                            if (newDistance < distances[edge.To])
                            {
                                distances[edge.To] = newDistance;
                            }
                        }
                    } 
                }
            }

            // see if we have a negative cycle
            foreach (var vertice in graph)
            {
                foreach (var edge in vertice)
                {
                    if (distances[edge.From] != double.PositiveInfinity)
                    {
                        var newDistance = distances[edge.From] + edge.Weight;

                        if (newDistance < distances[edge.To])
                        {
                            throw new Exception("Negative cycle found!");
                        }
                    }
                } 
            }

            return distances;
        }

        public static void KahnsAlgorithm(int[][] graph)
        {
            var ingress = ComputeIngressCounts(graph);
            var noIngressNodes = GetZeroIngresNodes(ingress);

            var toVisit = new Queue<int>();

            foreach (var node in noIngressNodes)
            {
                toVisit.Enqueue(node);
            }

            var result = new List<int>();
            while (toVisit.Count != 0)
            {
                var current = toVisit.Dequeue();
                result.Add(current);
                for (int i = 0; i < graph[current].Length; i++)
                {
                    if (graph[current][i] == 1)
                    {
                        ingress[i]--;
                        if (ingress[i] == 0) { toVisit.Enqueue(i); }
                    }
                }
            }

            result.ForEach(x => Console.WriteLine(x));
        }
        private static IEnumerable<int> GetZeroIngresNodes(int[] ingress)
        {
            var indices = new List<int>();

            for (int i = 0; i < ingress.Length; i++)
            {
                if (ingress[i] == 0)
                {
                    indices.Add(i);
                }
            }

            return indices;
        }

        private static int[] ComputeIngressCounts(int[][] graph)
        {
            var ingress = new int[graph.Length];

            for (int i = 0; i < graph.Length; i++)
            {
                for (int j = 0; j < graph[i].Length; j++)
                {
                    if (graph[i][j] == 1)
                    {
                        ingress[j]++;
                    }
                }
            }

            return ingress;
        }
        
        public static int Djikstra(List<WeightedEdge>[] graph, int start, int end)
        {
            var visited = new bool[graph.Length];
            var distances = Enumerable.Repeat(int.MaxValue, graph.Length).ToArray();
            distances[start] = 0;

            var toVisit = new PriorityQueue<int, int>();
            toVisit.Enqueue(start, distances[start]);

            while (toVisit.Count != 0)
            {
                var current = toVisit.Dequeue();

                if (current == end)
                {
                    break;
                }

                if (!visited[current])
                {
                    foreach (var neighbor in graph[current])
                    {
                        Console.WriteLine(neighbor.To);
                        distances[neighbor.To] = Math.Min(distances[neighbor.From] + neighbor.Weight, distances[neighbor.To]);
                        toVisit.Enqueue(neighbor.To, distances[current]);
                    }

                    visited[current] = true;
                }
            }

            return distances[end];
        }

        public static void TopologicalSort(int[][] graph)
        {
            var visited = new bool[graph.Length];
            var result = new Stack<int>();

            for (int i = 0; i < graph.Length; i++)
            {
                if (!visited[i])
                {
                    TopologicalSortHelper(graph, i, visited, result);
                }
            }

            while (result.Count != 0)
            {
                var node = result.Pop();
                Console.WriteLine(node);
            }
        }
        
        private static void TopologicalSortHelper(int[][] graph, int index, bool[] visited, Stack<int> result)
        {
            visited[index] = true;

            for (int i = 0; i < graph[index].Length; i++)
            {
                if (!visited[i] && graph[index][i] != 0)
                {
                    TopologicalSortHelper(graph, i, visited, result);
                }
            } 
            result.Push(index);
        }

        public static void BFS(int[][] graph)
        {
            var visited = new bool[graph.Length];

            for (int i = 0; i < graph[0].Length; i++)
            {
                var toVisit = new Queue<int>();
                toVisit.Enqueue(i);

                while (toVisit.Count != 0)
                {
                    var current = toVisit.Dequeue();
                    if (!visited[current])
                    {
                        Console.WriteLine(current);
                        visited[current] = true;
                        for (int j = 0; j < graph[i].Length; j++)
                        {
                            if (graph[current][j] == 1)
                            {
                                toVisit.Enqueue(j);
                            }
                        }
                    }
                }
            }
        }

        public static void DFSIterative(int[][] graph)
        {
            var visited = new bool[graph.Length];

            for (int i = 0; i < graph.Length; i++)
            {
                var toVisit = new Stack<int>();
                toVisit.Push(i);

                while (toVisit.Count != 0)
                {
                    var current = toVisit.Pop();
                    if (!visited[current])
                    {
                        visited[current] = true;
                        Console.WriteLine(current);

                        for (int j = 0; j < graph[i].Length; j++)
                        {
                            if (graph[current][j] == 1)
                            {
                                toVisit.Push(j);
                            }
                        }
                    }
                }
            }
        }

        public static void DFSRecursive(int[][] graph)
        {
            var visited = new bool[graph.Length];

            for (int i = 0; i < graph[0].Length; i++)
            {
                DFSRecursiveHelper(i, graph, visited);
            }
        }

        private static void DFSRecursiveHelper(int index, int[][] graph, bool[] visited)
        {
            if (!visited[index])
            {
                Console.WriteLine(index);
                visited[index] = true;

                for (int i = 0; i < graph[index].Length; i++)
                {
                    if (graph[index][i] == 1)
                    {
                        DFSRecursiveHelper(i, graph, visited);
                    }
                }
            }
        }
    }
}  
