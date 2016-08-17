using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab10
{
    [Serializable]
    class HeapReadingExpresion:Expresion
    {
        private string _var;

        public HeapReadingExpresion(string var)
        {
            _var = var;
        }

        public int LookUp(HeapArray<int> heap, int value)
        {
            return heap.getAddress(value);
        }

        public override int Evaluation(SymTableArray<string, int> symT, HeapArray<int> heap)
        {
            int address = symT.Search(_var);
            //try
            //{
            //    return LookUp(heap, address);
            //}
            //catch (ExpressionException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //return -1;
            return heap.getContent(address);
        }

        public override string ToString()
        {
            return "HeapReading(" + _var + ")";
        }
    }
}
