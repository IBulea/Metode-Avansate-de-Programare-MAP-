using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab10
{
    class Controller
    {
        public Repository r;
        private string output, exe, sym, heap;
        OutArray<string> outList;
        SymTableArray<string, int> symTable;
        ExeStackArray<Statement> exeStack;
        HeapArray<int> heapList;
        private int moment = 0;
        public Controller()
        {
            r = new Repository(CreateState());
            this.outList = r.getPrfromPos(0).getOut();
            this.symTable = r.getPrfromPos(0).getSymTable();
            this.exeStack = r.getPrfromPos(0).getExeStack();
            this.heapList = r.getPrfromPos(0).getHeap();
            output = "";
            exe = "";
            sym = "";
            heap = "";
        }
        private PrgState CreateState()
        {
            Out<string> output = new Out<string>();
            SymTable<string, int> symTable = new SymTable<string, int>();
            ExeStack<Statement> exeStack = new ExeStack<Statement>();
            Heap<int> heap = new Heap<int>();
            PrgState prog = new PrgState(output, exeStack, symTable, heap);
            return prog;
        }

        public void AddProgram(Statement s)
        {
            r.AddStatementToStack(0, s);
            r.getState(0).s = s;
        }

        public string FinalResult()
        {
            return outList.ToString();
        }

        public void ActualState()
        {
            if(outList.ToString()!="")
                output ="Moment "+moment.ToString()+"\n"+ outList.ToString() + "\n\n";
            if (r.stackToString() != "")
                exe ="Moment "+moment.ToString()+"\n"+ r.stackToString()+"\n";
            if (r.dictToString() != "")
                sym = "Moment "+moment.ToString()+"\n"+r.dictToString()+"\n";
            //if (heapList.ToString() != "")
                heap ="Moment "+moment.ToString()+"\n"+ heapList.ToString() + "\n\n";
            moment++;

        }
        public string printOutput()
        {
            return output;
        }
        public string printStack()
        {
            return exe;
        }
        public string printSym()
        {
            return sym;
        }
        public string printHeap()
        {
            return heap;
        }
        public void step()
        {
            exeStack.reverseStack();
		    Statement s=exeStack.Pop();
		
		    if (s is AssignStatement){
			    AssignStatement ass=(AssignStatement)s;	
			    symTable.Add(ass.id, ass.e.Evaluation(symTable,heapList));
		    }
		    if (s is CompoundStatement){
			    CompoundStatement cos=(CompoundStatement)s;
			    exeStack.Push(cos.begin);
			    exeStack.Push(cos.end);
			
		    }
		    if (s is IfStatement){
			    IfStatement ifs=(IfStatement)s;
			    if (ifs.exp.Evaluation(symTable,heapList)!=0){
				    exeStack.Push(ifs.th);	
			    }
			    else{
				    exeStack.Push(ifs.els);
			    }
		    }
		    if (s is PrintStatement){
			    PrintStatement prs=(PrintStatement)s;
			    outList.AddToOutTable(prs.expr.Evaluation(symTable,heapList).ToString());
		    }
		    if (s is Fork){
			    Fork prs=(Fork)s;
			    r.thread(prs.getStatement());

		    }
            if (s is WH)
            {
                WH wrh = (WH)s;
                Expresion e = wrh.e;
                int w = symTable.Search(wrh.varname);
                heapList.putInAddress(w, e.Evaluation(symTable, heapList));
            }
            exeStack.reverseStack();
	    }
        public void Run(int i)
        {
            int size = r.length();
           if (i == 1) { stepi(); }
            else if (i == 0)
                while (r.crnt() != null)
                    stepi();
        }

        public void stepi()
        {
            if (r.crnt() != null)
            {
                setCurrent(r.crnt());
                step();
                ActualState();
                r.next();
            }

        }

        public void setCurrent(PrgState ps)
        {
            exeStack = ps.getExeStack();
            symTable = ps.getSymTable();
        }

        public void deserialise()
        {
            r.deserialise();
        }

        public void serialise()
        {
            r.serialise();

        }
        public void WriteToFile()
        {

            r.ToFile();

        }
    }
}
