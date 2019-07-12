using System.Collections.Generic;
using Simple_Graphical_TSP.agent;
using Simple_Graphical_TSP.util;

namespace Simple_Graphical_TSP.environment.map
{
    /**
     * @author Ciaran O'Reilly
     * 
     */
    public class MapEnvironmentState : EnvironmentState
    {
	private Dictionary<Agent, Pair<string, double>> agentLocationAndTravelDistance = new Dictionary<Agent, Pair<string, double>>();

	public MapEnvironmentState()
	{

	}

	public string getAgentLocation(Agent a)
	{
	    Pair<string, double> locAndTDistance = agentLocationAndTravelDistance[a];
	    if (null == locAndTDistance)
	    {
		return null;
	    }
	    return locAndTDistance.getFirst();
	}

	public double getAgentTravelDistance(Agent a)
	{
	    Pair<string, double> locAndTDistance = agentLocationAndTravelDistance[a];
	    if (null == locAndTDistance)
	    {
		return double.MinValue;
	    }
	    return locAndTDistance.getSecond();
	}

	public void setAgentLocationAndTravelDistance(Agent a, string location,
			double travelDistance)
	{
	    agentLocationAndTravelDistance.Add(a, new Pair<string, double>(
			    location, travelDistance));
	}
    }
}