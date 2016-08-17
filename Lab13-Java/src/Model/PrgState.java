package Model;
import Model.Statement;

import java.io.*;
public class PrgState implements Serializable {
	private OutArray<String> out;
	private ExeStackArray<Statement> stack;
	private SymTableArray<String,Integer> table;
	private HeapArray<Integer> heap;
	public Statement s;
	public PrgState(){}
	public PrgState(OutArray<String> out,ExeStackArray<Statement> stack,SymTableArray<String,Integer> table, HeapArray<Integer> heap){
		makeOut(out);
		makeStack(stack);
		makeTable(table);
		makeHeap(heap);
	}
	public void makeOut(OutArray<String> a){
		out=a;
	}
	public void makeHeap(HeapArray<Integer> he){
		heap=he;
	}
	public void makeStack(ExeStackArray<Statement> a){
		stack=a;
	}
	public void makeTable(SymTableArray<String,Integer> a){
		table=a;
	}
	public SymTableArray<String,Integer> getSymTable(){
		return table;
	}
	public OutArray<String> getOut(){
		return out;
	}
	public ExeStackArray<Statement> getExeStack(){
		return stack;
	}
	public HeapArray<Integer> getHeap(){
		return heap;
	}
	
	
}
