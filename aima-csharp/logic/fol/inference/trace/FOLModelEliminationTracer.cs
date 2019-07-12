namespace Simple_Graphical_TSP.logic.fol.inference.trace
{
    /**
     * @author Ciaran O'Reilly
     * 
     */
    public interface FOLModelEliminationTracer
    {
	void reset();

	void increment(int depth, int noFarParents);
    }
}