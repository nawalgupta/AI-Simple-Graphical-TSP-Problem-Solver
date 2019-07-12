using System.Collections.Generic;
using Simple_Graphical_TSP.agent;
using Simple_Graphical_TSP.search.framework.problem;

namespace Simple_Graphical_TSP.search.framework.qsearch
{
    /**
     * Artificial Intelligence A Modern Approach (3rd Edition): Figure 3.7, page 77.
     * <br>
     * 
     * <pre>
     * function GRAPH-SEARCH(problem) returns a solution, or failure
     *   initialize the frontier using the initial state of problem
     *   initialize the explored set to be empty
     *   loop do
     *     if the frontier is empty then return failure
     *     choose a leaf node and remove it from the frontier
     *     if the node contains a goal state then return the corresponding solution
     *     add the node to the explored set
     *     expand the chosen node, adding the resulting nodes to the frontier
     *       only if not in the frontier or explored set
     * </pre>
     * 
     * Figure 3.7 An informal description of the general graph-search algorithm.
     * <br>
     * This implementation is based on the template method
     * {@link #search(Problem, Queue)} from superclass {@link QueueSearch} and
     * provides implementations for the needed primitive operations. It is the most
     * efficient variant of graph search for breadth first search. But don't expect
     * shortest paths in combination with priority queue frontiers.
     * 
     * @author Ravi Mohan
     * @author Ciaran O'Reilly
     * @author Ruediger Lunde
     */
    public class GraphSearchBFS : QueueSearch
    {
	private HashSet<object> explored = new HashSet<object>();
	private HashSet<object> frontierStates = new HashSet<object>();

	public GraphSearchBFS() : this(new NodeExpander())
	{

	}

	public GraphSearchBFS(NodeExpander nodeExpander) : base(nodeExpander)
	{

	}

	/**
	 * Clears the set of explored states and calls the search implementation of
	 * <code>QueSearch</code>
	 */
	public override List<Action> search(Problem problem, Queue<Node> frontier)
	{
	    // Initialize the explored set to be empty
	    explored.Clear();
	    frontierStates.Clear();
	    return base.search(problem, frontier);
	}

	/**
	 * Inserts the node at the tail of the frontier if the corresponding state
	 * is not already a frontier state and was not yet explored.
	 */
	protected override void addToFrontier(Node node)
	{
	    if (!explored.Contains(node.State) && !frontierStates.Contains(node.State))
	    {
		frontier.Enqueue(node);
		frontierStates.Add(node.State);
		updateMetrics(frontier.Count);
	    }
	}

	/**
	 * Removes the node at the head of the frontier, adds the corresponding
	 * state to the explored set, and returns the node.
	 * 
	 * @return the node at the head of the frontier.
	 */
	protected override Node removeFromFrontier()
	{
	    Node result = frontier.Dequeue();
	    explored.Add(result.State);
	    frontierStates.Remove(result.State);
	    updateMetrics(frontier.Count);
	    return result;
	}

	/**
	 * Checks whether there are still some nodes left.
	 */
	protected override bool isFrontierEmpty()
	{
	    if (frontier.Count == 0)
	    {
		return true;
	    }
	    else
		return false;
	}
    }
}