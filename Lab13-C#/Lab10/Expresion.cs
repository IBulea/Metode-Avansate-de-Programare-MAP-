using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Lab10
{
    [Serializable]
    abstract class Expresion
    {
        abstract public int Evaluation(SymTableArray<string, int> symTableArray, HeapArray<int> heap);

        abstract public override string ToString();
    }
}
