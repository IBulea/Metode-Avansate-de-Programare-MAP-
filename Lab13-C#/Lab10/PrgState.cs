using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Lab10
{
    [Serializable]
    class PrgState : ISerializable
    {
        private OutArray<string> oute;
        private ExeStackArray<Statement> stack;
        private SymTableArray<string, int> table;
        private HeapArray<int> heap;
        public Statement s;
        private int identifier;
        public PrgState()
        {
            oute = new Out<string>();
            stack = new ExeStack<Statement>();
            table = new SymTable<string, int>();
            heap = new Heap<int>();
        }
        public PrgState(OutArray<string> oute, ExeStackArray<Statement> stack, SymTableArray<string, int> table, HeapArray<int> heap)
        {
            makeOut(oute);
            makeStack(stack);
            makeTable(table);
            makeHeap(heap);
        }
        public void makeOut(OutArray<string> a)
        {
            oute = a;
        }
        public void makeHeap(HeapArray<int> he)
        {
            heap = he;
        }
        public void makeStack(ExeStackArray<Statement> a)
        {
            stack = a;
        }
        public void makeTable(SymTableArray<string, int> a)
        {
            table = a;
        }
        public SymTableArray<string, int> getSymTable()
        {
            return table;
        }
        public OutArray<string> getOut()
        {
            return oute;
        }
        public ExeStackArray<Statement> getExeStack()
        {
            return stack;
        }
        public HeapArray<int> getHeap()
        {
            return heap;
        }

        public void thread(SymTableArray<string, int> dt, HeapArray<int> ht, OutArray<string> lt, Statement st)
        {
            oute = lt;
            heap = ht;
            table = clone(dt);
            stack.Push(st);
        }
        public SymTableArray<string, int> clone(SymTableArray<string, int> dt)
        {
            SymTableArray<string, int> m;
            m = dt;
            return m;
        }
        public PrgState(SerializationInfo info, StreamingContext ctxt)
        {
            //Get the values from info and assign them to the appropriate properties
            stack = (ExeStackArray<Statement>)info.GetValue("Stack", typeof(ExeStackArray<Statement>));
            oute = (OutArray<string>)info.GetValue("Out", typeof(OutArray<string>));
            table = (SymTableArray<string, int>)info.GetValue("Table", typeof(SymTableArray<string, int>));
            heap = (HeapArray<int>)info.GetValue("Heap", typeof(HeapArray<int>));
        }
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            //You can use any custom name for your name-value pair. But make sure you
            // read the values with the same name. For ex:- If you write EmpId as "EmployeeId"
            // then you should read the same with "EmployeeId"
            info.AddValue("Stack", stack);
            info.AddValue("Out", oute);
            info.AddValue("Table", table);
            info.AddValue("Heap", heap);
        }

        public void setIdentifier(int i)
        {
            identifier = i;
        }
        public int getIdentifier()
        {
            return identifier;
        }

    }
}
