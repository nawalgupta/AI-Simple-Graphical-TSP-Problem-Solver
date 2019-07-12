using System.Collections.Generic;
using Simple_Graphical_TSP.agent;
using Simple_Graphical_TSP.agent.impl;
using Simple_Graphical_TSP.search.framework.problem;

namespace Simple_Graphical_TSP.search.framework
{
    /**
     * @author Ravi Mohan
     * 
     */
     public class SearchAgent : AbstractAgent
    {
        protected List<Action> actionList;

        private List<Action>.Enumerator actionIterator;

        private Metrics searchMetrics;

        public SearchAgent(Problem p, Search search)
        {
            actionList = search.search(p);
            actionIterator = actionList.GetEnumerator();
            searchMetrics = search.getMetrics();
        }

        public override Action execute(Percept p)
        {

            if (actionIterator.MoveNext())
            {
                return actionIterator.Current;
            }
            else
            {
                return NoOpAction.NO_OP;
            }
        }

        public bool isDone()
        {
            return null != actionIterator.Current;
        }

        public List<Action> getActions()
        {
            return actionList;
        }

        public Dictionary<string, string> getInstrumentation()
        {
            Dictionary<string, string> retVal = new Dictionary<string, string>();
            foreach (string key in searchMetrics.keySet())
            {
                System.String value = searchMetrics.get(key);
                retVal.Add(key, value);
            }
            return retVal;
        }
    }
}