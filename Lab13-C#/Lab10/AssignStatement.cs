using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Lab10
{
    [Serializable]
    class AssignStatement : Statement
    {
        public string id;
        public Expresion e;
        public AssignStatement()
        {

        }
        public AssignStatement(string id, Expresion e)
        {
            this.id = id;
            this.e = e;
        }
        public override string ToString()
        {
            string result = "";
            result += id + "=" + e.ToString();
            return result;
        }
    }
}
