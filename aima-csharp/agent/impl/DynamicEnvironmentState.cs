using System;

namespace Simple_Graphical_TSP.agent.impl
{
    /**
     * @author Ravi Mohan
     * @author Ciaran O'Reilly
     */
     public class DynamicEnvironmentState : ObjectWithDynamicAttributes, EnvironmentState
    {
        public DynamicEnvironmentState()
        {

        }

        public String describeType()
        {
            return typeof(EnvironmentState).Name;
        }
    }
}