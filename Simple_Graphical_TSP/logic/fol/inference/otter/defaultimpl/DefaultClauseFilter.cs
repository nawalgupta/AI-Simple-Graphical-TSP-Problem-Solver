using System.Collections.Generic;
using Simple_Graphical_TSP.logic.fol.kb.data;

namespace Simple_Graphical_TSP.logic.fol.inference.otter.defaultimpl
{
    /**
     * @author Ciaran O'Reilly
     * 
     */
    public class DefaultClauseFilter : ClauseFilter
    {
	public DefaultClauseFilter()
	{

	}

	// START-ClauseFilter

	public HashSet<Clause> filter(HashSet<Clause> clauses)
	{
	    return clauses;
	}

	// END-ClauseFilter
    }
}