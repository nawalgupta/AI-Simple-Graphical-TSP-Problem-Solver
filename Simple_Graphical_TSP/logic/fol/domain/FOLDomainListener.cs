namespace Simple_Graphical_TSP.logic.fol.domain
{
    /**
     * @author Ciaran O'Reilly
     * 
     */
    public interface FOLDomainListener
    {
	void skolemConstantAdded(FOLDomainSkolemConstantAddedEvent _event);

	void skolemFunctionAdded(FOLDomainSkolemFunctionAddedEvent _event);

	void answerLiteralNameAdded(FOLDomainAnswerLiteralAddedEvent _event);
    }
}