using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Simple_Graphical_TSP.logic.fol.kb.data;
using Simple_Graphical_TSP.logic.fol.parsing.ast;

namespace Simple_Graphical_TSP.logic.fol.inference.proof
{
    /**
     * @author Ciaran O'Reilly
     * 
     */
    public class ProofStepClauseParamodulation : AbstractProofStep
    {
	private List<ProofStep> predecessors = new List<ProofStep>();
	private Clause paramodulated = null;
	private Clause topClause = null;
	private Clause equalityClause = null;
	private TermEquality assertion = null;

	public ProofStepClauseParamodulation(Clause paramodulated,
		Clause topClause, Clause equalityClause, TermEquality assertion)
	{
	    this.paramodulated = paramodulated;
	    this.topClause = topClause;
	    this.equalityClause = equalityClause;
	    this.assertion = assertion;
	    this.predecessors.Add(topClause.getProofStep());
	    this.predecessors.Add(equalityClause.getProofStep());
	}

	// START-ProofStep

	public override List<ProofStep> getPredecessorSteps()
	{
	    return new ReadOnlyCollection<ProofStep>(predecessors).ToList<ProofStep>();
	}

	public override String getProof()
	{
	    return paramodulated.ToString();
	}

	public override String getJustification()
	{
	    return "Paramodulation: " + topClause.getProofStep().getStepNumber()
		    + ", " + equalityClause.getProofStep().getStepNumber() + ", ["
		    + assertion + "]";

	}

	// END-ProofStep
    }
}