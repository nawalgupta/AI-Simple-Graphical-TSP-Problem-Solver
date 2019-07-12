using Simple_Graphical_TSP.agent;

namespace Simple_Graphical_TSP.search.framework.problem
{
    /**
     * Returns one for every action.
     * 
     * @author Ravi Mohan
     */
    public class DefaultStepCostFunction : StepCostFunction
    {


        public double c(System.Object stateFrom, Action action, System.Object stateTo)
        {
            return 1;
        }
    }
}