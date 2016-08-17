using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Lab10
{
    [Serializable]
    class IfStatement : Statement
    {
        public Expresion exp;
        public Statement th;
        public Statement els;
        public IfStatement() { }
        public IfStatement(Expresion e, Statement t, Statement el)
        {
            exp = e;
            th = t;
            els = el;
        }
        public override string ToString()
        {
            string result = "";
            result += "If " + exp.ToString() + " Then " + th.ToString() + " Else " + els.ToString();
            return result;
        }
    }
}
