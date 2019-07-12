using System;
using System.Diagnostics;
using System.Text;

namespace Simple_Graphical_TSP.agent.impl.aprog.simplerule
{
    /**
     * Implementation of an EQUALity condition.
     * 
     * @author Ciaran O'Reilly
     * 
     */
     public class EQUALCondition : Condition
    {
        private Object key;

        private Object value;

        public EQUALCondition(Object k, Object val)
        {
            Debug.Assert(null != key);
            Debug.Assert(null != value);

            key = k;
            value = val;
        }

        public override bool evaluate(ObjectWithDynamicAttributes p)
        {
            return value.Equals(p.getAttribute(key));
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();

            return sb.Append(key).Append("==").Append(value).ToString();
        }
    }
}