using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Simple_Graphical_TSP.logic.fol.kb.data;

namespace Simple_Graphical_TSP.logic.fol.inference.proof
{
    /**
     * @author Ciaran O'Reilly
     * 
     */
    public class ProofStepFoChAlreadyAFact : AbstractProofStep
    {
	private readonly List<ProofStep> _noPredecessors = new List<ProofStep>();
	private Literal fact = null;

	public ProofStepFoChAlreadyAFact(Literal fact)
	{
	    this.fact = fact;
	}
	
	// START-ProofStep

	public override List<ProofStep> getPredecessorSteps()
	{
	    return new ReadOnlyCollection<ProofStep>(_noPredecessors).ToList<ProofStep>();
	}

	public override String getProof()
	{
	    return fact.ToString();
	}

	public override String getJustification()
	{
	    return "Already a known fact in the KB.";
	}

	// END-ProofStep
    }
}