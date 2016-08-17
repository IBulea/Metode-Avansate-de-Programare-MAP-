package Repository;

import java.io.*;

import Model.ExeStack;
import Model.Out;
import Model.PrgState;
import Model.Statement;
import Model.SymTable;

public class Repository  {
	public PrgState state;

	public Repository() {

	}

	public Repository(PrgState s) {
		state = s;

	}

	public void AddToSymTable(String id, int n) {
		state.getSymTable().Add(id, n);
	}

	public void AddStatementToStack(Statement s) {
		state.getExeStack().Push(s);
	}

	public void RemoveStatementFromStack() {
		state.getExeStack().Pop();
	}
	public void AddToHeap(int number){
		state.getHeap().add(number);
	}
	public void serialise(){
		try
	      {
	         FileOutputStream fileOut =
	         new FileOutputStream("./src/data/PrgState.ser");
	         ObjectOutputStream out = new ObjectOutputStream(fileOut);
	         out.writeObject(state);
	         out.close();
	         fileOut.close();
	         //System.out.printf("Serialized data is saved in PrgState.ser");
	      }catch(IOException i)
	      {
	          i.printStackTrace();
	      }
	}
	public void deserialise(){
		PrgState s=new PrgState();
		 try
	      {
	         FileInputStream fileIn = new FileInputStream("./src/data/PrgState.ser");
	         ObjectInputStream in = new ObjectInputStream(fileIn);
	         s=(PrgState) in.readObject();
	         state=s;
	         in.close();
	         fileIn.close();
	      }catch(IOException i)
	      {
	         i.printStackTrace();
	         return;
	      }catch(ClassNotFoundException c)
	      {
	         System.out.println("PrgState class not found");
	         c.printStackTrace();
	         return;
	      }
	}
	public void ToFile(){
		String content=state.getExeStack().ToString();
		content+="\n"+state.getSymTable().ToString();
		content+="\n"+state.getOut().ToString();
		try {
			 
			File file = new File("./src/data/file.out");
 
			// if file doesn't exists, then create it
			if (!file.exists()) {
				file.createNewFile();
			}
 
			FileWriter fw = new FileWriter(file.getAbsoluteFile());
			BufferedWriter bw = new BufferedWriter(fw);
			bw.write(content);
			bw.close();
 
			//System.out.println("Done");
 
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
	public void AddToOut(String o) {
		state.getOut().AddToOutTable(o);
	}
}
