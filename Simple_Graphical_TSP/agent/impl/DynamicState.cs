using System;

namespace Simple_Graphical_TSP.agent.impl
{
    /**
     * @author Ciaran O'Reilly
     */
    public class DynamicState : ObjectWithDynamicAttributes, State
    {
        public DynamicState()
        {

        }


        public String describeType()
        {
            return typeof(State).Name;
        }
    }
}