using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab10
{
    [Serializable]
    class WH : Statement
    {
        public Expresion e;
        public string varname;
        public WH() { }
        public WH(Expresion s, string v)
        {
            e = s;
            varname = v;
        }
        public override string ToString()
        {
            string result = "";
            result +="WH"+ varname + "," + e.ToString();
            return result;
        }
    }
}
