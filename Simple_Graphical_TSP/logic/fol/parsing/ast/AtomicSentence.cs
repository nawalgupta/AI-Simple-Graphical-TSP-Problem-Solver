using System.Collections.Generic;

namespace Simple_Graphical_TSP.logic.fol.parsing.ast
{
    /**
     * @author Ciaran O'Reilly
     * 
     */
    public interface AtomicSentence : Sentence
    {
	List<Term> getArgs();

	AtomicSentence copy();
    }
}