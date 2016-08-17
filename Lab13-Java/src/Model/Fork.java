package Model;

import java.io.Serializable;



public class Fork extends Statement implements Serializable
{
	private Statement st;
	
	public Fork(Statement s)
	{
		st=s;
	}
	
	public Statement getStatement()
	{
		return st;
	}
	
	public String ToString()
	{
		return "fork ( "+st.toString()+" )";
	}
}
