using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab10
{
    [Serializable]
    class NewExpresion:Expresion
    {
        private int _value;

        public NewExpresion(int value)
        {
            _value = value;
        }

        public int LookUp(HeapArray<int> heap, int value)
        {

            return heap.getAddress(value);
        }

        public override int Evaluation(SymTableArray<string, int> table, HeapArray<int> heap)
        {
            heap.add(_value);
            return LookUp(heap, _value);
        }

        public override string ToString()
        {
            return "New(" + _value + ")";
        }
    }
}
