using Simple_Graphical_TSP.logic.fol.kb;
using Simple_Graphical_TSP.logic.fol.parsing.ast;

namespace Simple_Graphical_TSP.logic.fol.inference
{
    /**
     * @author Ciaran O'Reilly
     * 
     */
    public interface InferenceProcedure
    {
	/**
	 * 
	 * @param kb
	 *            the knowledge base against which the query is to be made.
	 * @param query
	 *            the query to be answered.
	 * @return an InferenceResult.
	 */
	InferenceResult ask(FOLKnowledgeBase kb, Sentence query);
    }
}