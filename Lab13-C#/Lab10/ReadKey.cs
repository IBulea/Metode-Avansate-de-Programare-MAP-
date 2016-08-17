using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab10
{
    [Serializable]
    class ReadKey : Expresion
    {
        public int key;
        public ReadKey()
        {
        }
        public override int Evaluation(SymTableArray<string, int> symT, HeapArray<int> heap)
        {
            //Console.WriteLine("Introduces an integer for ToyLanguage");
            //string s=Console.ReadLine();
            //key = Int32.Parse(s);

            string var = Prompt.ShowDialog("Introduces an integer for ToyLanguage", "Keyboard");
            key = Int32.Parse(var);
            return key;
        }

        public override string ToString()
        {
            return "ReadKey()";
        }
    }
}
