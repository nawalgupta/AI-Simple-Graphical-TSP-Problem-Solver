using System;
using System.Collections.Generic;
using Simple_Graphical_TSP.logic.common;

namespace Simple_Graphical_TSP.logic.fol.parsing.ast
{
    /**
     * @author Ravi Mohan
     * @author Ciaran O'Reilly
     */
    public interface FOLNode : ParseTreeNode
    {
	String getSymbolicName();

	bool isCompound();

	List<FOLNode> getArgs();

	Object accept(FOLVisitor v, Object arg);

	FOLNode copy();
    }
}