using Cnsl.DataStructures;

namespace graphFacebook.Searching.Graph
{
    public class BreadthFirstSearch
    {

        public static GraphSearchResult Search(IGraph graph, IVertex source, IVertex target)
        {
            if (graph is null)
                throw new ArgumentNullException(nameof(graph));
            if (source is null)
                throw new ArgumentNullException(nameof(source));
            if (target is null)
                throw new ArgumentNullException(nameof(target));

            var result = new GraphSearchResult(graph.Count);
            var queue = new Queue<IVertex>(graph.Count);

            result.MarkAsVisited(source);
            queue.Enqueue(source);

            while (queue.Count > 0)
            {
                var vertex = queue.Dequeue();
                if (vertex == target)
                    break;

                foreach (var edge in vertex.Edges)
                {
                    if (!result.IsVisited(edge.U))
                    {
                        result.MarkAsVisited(edge.U);
                        queue.Enqueue(edge.U);
                    }
                }
            }

            return result;
        }
    }
}
