using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab10
{
    [Serializable]
    class Fork:Statement
    {
        public Statement f;
	    public Fork(Statement s){
		    this.f=s;
	    }
	    public Statement getStatement()
	    {
		    return f;
	    }
	   public override string ToString() {
		    string result = "Fork( ";
		    result += f.ToString()+")";
		    return result;
	    }
    }
}
