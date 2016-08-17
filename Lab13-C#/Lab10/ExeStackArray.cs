using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Lab10
{
    interface ExeStackArray<T>
    {
        void Push(T s);
	    T Pop();

	    T SeeTop();

	    Boolean isEmpty();
	    void reverseStack();
	    String ToString();
        int length();
    }
}
