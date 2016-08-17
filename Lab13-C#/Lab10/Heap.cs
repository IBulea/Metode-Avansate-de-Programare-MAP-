using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab10
{
    [Serializable]
    class Heap<N>:HeapArray<N>
    {
        private List<N> heap = new List<N>();

          void HeapArray<N>.add(N n)
        {
            heap.Add(n);
        }

          int HeapArray<N>.length()
        {
            return heap.Count();
        }

          Boolean HeapArray<N>.isEmpty()
        {
            return heap.Count() == 0;
        }


          int HeapArray<N>.getAddress(N n)
        {
            return heap.IndexOf(n);
        }

          N HeapArray<N>.getContent(int i)
        {
            return heap.ElementAt(i);
        }
          void HeapArray<N>.putInAddress(int ad, N value)
          {
              try
              {
                  heap.Insert(ad, value);
                  //heap.RemoveAt(ad + 1);
              }
              catch (ArgumentOutOfRangeException err)
              {
                  Console.WriteLine("Error in Heap!!!" + err.StackTrace);
              }

          }

         string HeapArray<N>.ToString()
	    {
		    string r="";
            int len = heap.Count();
            int i;
		    for (i=0;i<len;i++)
            {
                r = r + heap.ElementAt(i).ToString()+" ";
		    }
		    return r;
	    }
    }
}
