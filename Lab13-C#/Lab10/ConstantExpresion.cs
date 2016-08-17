using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Lab10
{
    [Serializable]
    class ConstantExpresion : Expresion
    {
        public int nr;
        public ConstantExpresion()
        {

        }
        public ConstantExpresion(int n)
        {
            nr = n;

        }
        public override int Evaluation(SymTableArray<string, int> t, HeapArray<int> heap)
        {
            return nr;
        }

        public override string ToString()
        {
            return nr.ToString();
        }
    }

}
