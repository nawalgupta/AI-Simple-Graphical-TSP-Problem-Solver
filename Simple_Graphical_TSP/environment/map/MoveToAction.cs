using System;
using Simple_Graphical_TSP.agent.impl;

namespace Simple_Graphical_TSP.environment.map
{ 
    public class MoveToAction : DynamicAction
    {
	public const String ATTRIBUTE_MOVE_TO_LOCATION = "location";

	public MoveToAction(String location) : base("moveTo")
	{
	    setAttribute(ATTRIBUTE_MOVE_TO_LOCATION, location);
	}

	public String getToLocation()
	{
	    return (String)getAttribute(ATTRIBUTE_MOVE_TO_LOCATION);
	}
    }
}
