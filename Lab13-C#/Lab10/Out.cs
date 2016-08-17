using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Lab10
{
    [Serializable]
    class Out<T> : OutArray<T>
    {
        private List<T> table=new List<T>();
         Boolean OutArray<T>.AddToOutTable(T t)
        {
            table.Add(t);
            return true;
        }

         int OutArray<T>.GetSize()
        {
            return table.Count();
        }

         string OutArray<T>.ToString()
        {
            string res = "";
            int i;
            for (i = 0; i < table.Count(); i++)
            {
                res += table.ElementAt(i).ToString() + ";";
            }
            return res;
        }
    }
}
