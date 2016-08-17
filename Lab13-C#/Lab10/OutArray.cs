using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Lab10
{

    interface OutArray<T> 
    {
        Boolean AddToOutTable(T o);

        string ToString();

        int GetSize();

    }
}
