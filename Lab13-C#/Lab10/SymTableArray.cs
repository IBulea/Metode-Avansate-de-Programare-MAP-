using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Lab10
{

    interface SymTableArray<T, N> 
    {
         int Len();

         Boolean Add(T id, N value);

         Boolean Change(T id, N value);

         int Search(T id);

         string ToString();
    }
}
