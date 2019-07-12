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
    public class ProofStepChainReduction : AbstractProofStep
    {
	private List<ProofStep> predecessors = new List<ProofStep>();
	private Chain reduction = null;
	private Chain nearParent, farParent = null;
	private Dictionary<Variable, Term> subst = null;

	public ProofStepChainReduction(Chain reduction, Chain nearParent,
		Chain farParent, Dictionary<Variable, Term> subst)
	{
	    this.reduction = reduction;
	    this.nearParent = nearParent;
	    this.farParent = farParent;
	    this.subst = subst;
	    this.predecessors.Add(farParent.getProofStep());
	    this.predecessors.Add(nearParent.getProofStep());
	}
	
	// START-ProofStep

	public override List<ProofStep> getPredecessorSteps()
	{
	    return new ReadOnlyCollection<ProofStep>(predecessors).ToList<ProofStep>();
	}

	public override String getProof()
	{
	    return reduction.ToString();
	}

	public override String getJustification()
	{
	    return "Reduction: " + nearParent.getProofStep().getStepNumber() + ","
		    + farParent.getProofStep().getStepNumber() + " " + subst;
	}

	// END-ProofStep
    }
}