package Controller;
import java.util.Scanner;

import Repository.Repository;
import Model.*;
public class Controller  {
	public Repository r;
	private String output,exe,sym,heap;
	private int moment=0;
	public Controller()
	{
		r=new Repository(CreateState());
		output="";
		exe="";
		sym="";
	}
	private PrgState CreateState(){
		Out<String> output=new Out<String>();
		SymTable<String,Integer> symTable=new SymTable<String,Integer>();
		ExeStack<Statement> exeStack=new ExeStack<Statement>();
		Heap<Integer> heap=new Heap<Integer>();
		PrgState prog=new PrgState(output,exeStack,symTable,heap);
		return prog;
	}
	
	public ExeStackArray<Statement> getStack(){
		return r.state.getExeStack();
	}
	public OutArray<String> getOut(){
		return r.state.getOut();
	}
	public SymTableArray<String,Integer> getDictionary(){
		return r.state.getSymTable();
	}
	
	public HeapArray<Integer> getHeap(){
		return r.state.getHeap();
	}
	public void AddProgram(Statement s){
		r.AddStatementToStack(s);
		r.state.s=s;
	}
	
	public String FinalResult(){
		return r.state.getOut().ToString();
	}
	
	public void ActualState(){
		output+="Moment "+String.valueOf(moment)+": "+r.state.getOut().ToString()+"\n";
		exe+="Moment "+String.valueOf(moment)+": "+r.state.getExeStack().ToString()+"\n";
		sym+="Moment "+String.valueOf(moment)+": "+r.state.getSymTable().ToString()+"\n";
		heap+=r.state.getHeap().ToString()+"\n";
		moment+=1;

	}
	public String printOutput(){
		return output;
	}
	public String printStack(){
		return exe;
	}
	public String printSym(){
		return sym;
	}
	public String printHeap(){
		return heap;
	}
	
	public void Run(int i){
		if(i==1){ActualState();}
		ExeStackArray<Statement> exeStack=r.state.getExeStack();
		while(!exeStack.isEmpty()){
			exeStack.reverseStack();
			Statement s=exeStack.Pop();
			
			if (s instanceof AssignStatement){
				AssignStatement ass=(AssignStatement)s;	
				r.state.getSymTable().Add(ass.id, ass.e.Evaluation(r.state.getSymTable(),r.state.getHeap()));
			}
			if (s instanceof CompoundStatement){
				CompoundStatement cos=(CompoundStatement)s;
				exeStack.Push(cos.begin);
				exeStack.Push(cos.end);
				
			}
			if (s instanceof IfStatement){
				IfStatement ifs=(IfStatement)s;
				if (ifs.exp.Evaluation(r.state.getSymTable(),r.state.getHeap())!=0){
					exeStack.Push(ifs.th);	
				}
				else{
					exeStack.Push(ifs.els);
				}
			}
			if (s instanceof PrintStatement){
				PrintStatement prs=(PrintStatement)s;
				r.state.getOut().AddToOutTable(String.valueOf(prs.expr.Evaluation(r.state.getSymTable(),r.state.getHeap())));
			}
			exeStack.reverseStack();
			if(i==1 && exeStack.length()>0)
			{
				ActualState();
			}
			
		}
		if (i==0)
		{
			output=r.state.getOut().ToString();
		}
		if (i==1)
		{
			//System.out.println("Program state after execution:");
			ActualState();
		}
	}
	public void deserialise(){
		r.deserialise();
	}
	
	public void serialise()
	{
			r.serialise();

	}
	public void WriteToFile(){

			r.ToFile();

	}
	
	
}
