using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Lab10
{
    [Serializable]
    class CompoundStatement : Statement
    {
        public Statement begin;
        public Statement end;

        public CompoundStatement()
        {

        }

        public CompoundStatement(Statement begin, Statement end)
        {
            this.begin = begin;
            this.end = end;
        }

        public override string ToString()
        {
            string result = "";
            result += begin.ToString() + ";" + end.ToString();
            return result;
        }
    }
}
