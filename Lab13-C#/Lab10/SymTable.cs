using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Lab10
{
    [Serializable]
    class SymTable<T, N> : SymTableArray<T, N>
    {
        private Dictionary<T,N> table=new Dictionary<T,N>();

         int SymTableArray<T, N>.Len()
        {
            return table.Count();
        }
         int SymTableArray<T, N>.Search(T id)
        {
                if (table.ContainsKey(id))
                {
                    return Convert.ToInt32(table[id]);
                }
            
            return 0;
        }
         Boolean SymTableArray<T,N>.Add(T id, N n)
        {
            
                table.Add(id,n);
                return true;


        }
         Boolean SymTableArray<T,N>.Change(T id, N n){

                if (table.ContainsKey(id))
                {
                    table[id]=n;
                    return true;
                }
            
		return false;
	}
        string SymTableArray<T,N>.ToString()
        {
            string rez = "";
   
            foreach (T i in table.Keys)
            {
                rez += i.ToString()+"=";
                rez+=table[i].ToString() + ";";
            }
            return rez;
        }
    }
}
