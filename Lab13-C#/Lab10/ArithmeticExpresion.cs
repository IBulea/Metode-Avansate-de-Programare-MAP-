using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Lab10
{
    [Serializable]
    class ArithmeticExpresion : Expresion
    {
        private Expresion exp1;
	    private Expresion exp2;
	    public string operat;

    	public  ArithmeticExpresion(Expresion e1, Expresion e2, string op) {
	    	exp1 = e1;
	    	exp2 = e2;
    		operat = op;
	    }

        public override int Evaluation(SymTableArray<string, int> t, HeapArray<int> h)
        {
	    	int left = exp1.Evaluation(t,h);
	    	int right = exp2.Evaluation(t,h);
	    	switch (operat) {
	    	case "+":
	    		return left + right;
		    case "-":
			    return left - right;
		    case "*":
			    return left * right;
		    case "/":
	    		return left / right;
	    	default:
	    		return 0;
		    }
	    }

	    public override string ToString() {
	    	string result = "";
	    	result += exp1.ToString() + operat + exp2.ToString();
	    	return result;
	    }
    }
}
