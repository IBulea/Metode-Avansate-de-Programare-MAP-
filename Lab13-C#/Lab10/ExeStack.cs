using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Lab10
{
    [Serializable]
    class ExeStack<T> : ExeStackArray<T>
    {
        private List<T> stmt=new List<T>();
        private Boolean is_reversed = false;
        private int top = 0;

         void ExeStackArray<T>.Push(T item)
        {
            stmt.Add(item);
            top++;
        }
         T ExeStackArray<T>.Pop()
        {

            T aux;
            top--;
            if (!is_reversed)
            {
                aux = stmt.ElementAt(stmt.Count() - 1);
                stmt.RemoveAt(stmt.Count() - 1);
            }
            else
            {
                aux = stmt.ElementAt(0);
                stmt.RemoveAt(0);
            }
            return aux;
        }

         void ExeStackArray<T>.reverseStack()
        {
            is_reversed = !is_reversed;
        }
         Boolean ExeStackArray<T>.isEmpty()
        {
            if (stmt.Count() == 0) return true;
            return false;
        }
         T ExeStackArray<T>.SeeTop()
        {
            return stmt.ElementAt(--top);
        }
         int ExeStackArray<T>.length()
        {
            return stmt.Count();
        }
        string ExeStackArray<T>.ToString()
        {
            int i;
            string res = "";
            stmt.Cast<Statement>();
            for (i = 0; i < stmt.Count(); i++)
            {

                res += stmt.ElementAt(i).ToString() + ";";
            }
            res += "";
            return res;
	    }

    }
}
