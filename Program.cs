using InterviewPrep.Graph;

int x = 10;
Console.WriteLine(x);

public enum Orange
{
    Empty = 0,
    Fresh = 1,
    Rotten = 4
}

public class Test
{
    public static IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        var result = new List<IList<int>>[target + 1];

        for (int i = 0; i <= target; i++)
        {
            result[i] = new List<IList<int>>();
        }
        result[0].Add(new List<int>());

        foreach (var candidate in candidates)
        {
            for (int j = candidate; j <= target; j++)
            {
                foreach (var combination in result[j - candidate])
                {
                    List<int> newCombination = new List<int>(combination);
                    newCombination.Add(candidate);
                    result[j].Add(newCombination);
                }
            }
        }

        return result[target];
    }

    public static List<WeightedEdge>[] BuildWeightedGraph()
    {
        var edge1 = new WeightedEdge(0, 1, 4);
        var edge2 = new WeightedEdge(0, 5, -5);
        var edge3 = new WeightedEdge(1, 3, 6);
        var edge4 = new WeightedEdge(2, 1, 3);
        var edge5 = new WeightedEdge(2, 3, 10);
        var edge6 = new WeightedEdge(3, 2, -2);
        var edge7 = new WeightedEdge(4, 3, 3);
        var edge8 = new WeightedEdge(4, 1, 10);
        var edge9 = new WeightedEdge(5, 4, 8);

        var graph = new List<WeightedEdge>[6];

        graph[0] = new List<WeightedEdge>() { edge1, edge2 };
        graph[1] = new List<WeightedEdge>() { edge3 };
        graph[2] = new List<WeightedEdge>() { edge4, edge5 };
        graph[3] = new List<WeightedEdge>() { edge6 };
        graph[4] = new List<WeightedEdge>() { edge7, edge8 };
        graph[5] = new List<WeightedEdge>() { edge9 };

        return graph;
    }

    public static int[][] BuildGraph()
    {
        var node0 = new int[8];
        var node1 = new int[8];
        var node2 = new int[8];
        var node3 = new int[8];
        var node4 = new int[8];
        var node5 = new int[8];
        var node6 = new int[8];
        var node7 = new int[8];

        node0[3] = 1;
        node0[4] = 1;

        node1[3] = 1;

        node2[4] = 1;
        node2[7] = 1;

        node3[5] = 1;
        node3[6] = 1;
        node3[7] = 1;

        node6[4] = 1;

        var graph = new int[][] { node0, node1, node2, node3, node4, node5, node6, node7 };

        return graph;
    }
}
