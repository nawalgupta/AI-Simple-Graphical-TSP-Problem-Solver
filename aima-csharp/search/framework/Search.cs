using System.Collections.Generic;
using Simple_Graphical_TSP.agent;
using Simple_Graphical_TSP.search.framework.problem;

namespace Simple_Graphical_TSP.search.framework
{

    /**
     * @author Ravi Mohan
     * @author Mike Stampone
     */
    public interface Search
    {
        /**
	 * Returns a list of actions to the goal if the goal was found, a list
	 * containing a single NoOp Action if already at the goal, or an empty list
	 * if the goal could not be found.
	 * 
	 * @param p
	 *            the search problem
	 * 
	 * @return a list of actions to the goal if the goal was found, a list
	 *         containing a single NoOp Action if already at the goal, or an
	 *         empty list if the goal could not be found.
	 */
        List<Action> search(Problem p);

        /**
	 * Returns all the metrics of the search.
	 * 
	 * @return all the metrics of the search.
	 */
        Metrics getMetrics();
    }
}