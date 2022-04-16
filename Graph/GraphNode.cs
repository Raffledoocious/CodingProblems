namespace InterviewPrep.Graph
{
    public class GraphNode<T>
    {
        public GraphNode(T value) 
        {
            Value = value;
        }

        public T? Value { get; set; }
        public List<GraphNode<T>> Neighbors { get; } = new List<GraphNode<T>>();
    }
}
