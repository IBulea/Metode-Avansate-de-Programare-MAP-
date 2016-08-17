using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Lab10
{
    [Serializable]
    class VarExpresion:Expresion
    {
        public string var;
        public VarExpresion()
        {

        }
        public VarExpresion(string var)
        {
            this.var = var;
        }
        public override int Evaluation(SymTableArray<string, int> t, HeapArray<int> heap)
        {
            return t.Search(var);
        }
        public override string ToString()
        {
            return var;
        }
    }
}
