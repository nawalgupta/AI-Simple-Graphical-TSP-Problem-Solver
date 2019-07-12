using System;

namespace Simple_Graphical_TSP.logic.fol
{
    /**
     * @author Ciaran O'Reilly
     * 
     */
    public class Quantifiers
    {
	public static readonly String FORALL = "FORALL";
	public static readonly String EXISTS = "EXISTS";

	public static bool isFORALL(String quantifier)
	{
	    return FORALL.Equals(quantifier);
	}

	public static bool isEXISTS(String quantifier)
	{
	    return EXISTS.Equals(quantifier);
	}
    }
}