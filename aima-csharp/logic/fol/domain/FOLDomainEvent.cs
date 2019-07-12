using System;

namespace Simple_Graphical_TSP.logic.fol.domain
{
    /**
     * @author Ciaran O'Reilly
     * 
     */
    public abstract class FOLDomainEvent
    {
	private static readonly long serialVersionUID = 1L;

	public FOLDomainEvent(Object source)
	{
	    
	}

	public abstract void notifyListener(FOLDomainListener listener);
    }
}