using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab10
{
    interface HeapArray<N>
    {
         N getContent(int index);
         Boolean isEmpty();
         int length();
         string ToString();
         int getAddress(N number);
         void add(N number);
         void putInAddress(int ad, N value); 
    }
}
