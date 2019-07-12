using System.Collections.Generic;
using Simple_Graphical_TSP.logic.fol.kb.data;

namespace Simple_Graphical_TSP.logic.fol.inference.otter
{
    /**
     * @author Ciaran O'Reilly
     * 
     */
    public interface ClauseFilter
    {
	HashSet<Clause> filter(HashSet<Clause> clauses);
    }
}