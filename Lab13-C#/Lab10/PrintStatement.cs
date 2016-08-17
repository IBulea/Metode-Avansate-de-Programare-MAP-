using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Lab10
{
    [Serializable]
    class PrintStatement : Statement
    {
        public Expresion expr;
        public PrintStatement() { }
        public PrintStatement(Expresion s)
        {
            expr = s;
        }
        public override string ToString()
        {
            string r = "Print (" + expr.ToString() + ")";
            return r;
        }
    }
}
