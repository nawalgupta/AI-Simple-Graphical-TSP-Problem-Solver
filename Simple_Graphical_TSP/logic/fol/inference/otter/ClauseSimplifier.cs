using Simple_Graphical_TSP.logic.fol.kb.data;

namespace Simple_Graphical_TSP.logic.fol.inference.otter
{
    /**
     * @author Ciaran O'Reilly
     * 
     */
    public interface ClauseSimplifier
    {
	Clause simplify(Clause c);
    }
}
