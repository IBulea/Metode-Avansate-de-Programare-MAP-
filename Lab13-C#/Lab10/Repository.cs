using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Lab10
{
    class Repository
    {
        public List<PrgState> states;
        private int current, iden = 1;
        private PrgState pro;
        public Repository()
        {
        }
        public void add(PrgState p)
        {
            states.Add(p);
            p.setIdentifier(iden);
            iden++;
        }
        public Repository(PrgState s)
        {
            states = new List<PrgState>();
            states.Add(s);
            s.setIdentifier(iden);
            iden++;
            pro = s;
            current = 0;

        }

        public void AddStatementToStack(int index, Statement s)
        {
            states.ElementAt(index).getExeStack().Push(s);
        }

        public void thread(Statement s)
        {
            PrgState pr = new PrgState();
            pr.thread(getPrfromPos(current).getSymTable(), getPrfromPos(current).getHeap(), getPrfromPos(current).getOut(), s);
            add(pr);
        }

        public int getNextValid()
        {
            if (current >= length() - 1)
                for (int j = 0; j < length(); j++)
                    if (valid(j))
                    {
                        current = j;
                        return j;
                    }
                    else
                    { removePr(j); }
            else
                for (int ji = current+1; ji < length(); ji++)
                    if (valid(ji))
                    {
                        current = ji;
                        return ji;
                    }
                    else
                    {
                        removePr(ji);
                    }
            return (-1);
        }

        public void next()
        {
            int a = getNextValid();
        }
        public PrgState crnt()
        {
            if (getPrfromPos(current) != null && valid(current))
                return getPrfromPos(current);
            else
                if (getNextValid() == (-1))
                    return null;
            return getPrfromPos(getNextValid());

        }

        public PrgState getPrfromPos(int i)
        {
            PrgState a;
            try
            {
                a = states.ElementAt(i);
            }
            catch (ArgumentOutOfRangeException) { a = null; }
            return a;
        }

        public Boolean valid(int i)
        {
            return !(states.ElementAt(i).getExeStack().isEmpty());
        }

        public void removePr(int p)
        {
            states.RemoveAt(p);
        }

        public string dictToString()
        {
            string r = "";
            for (int i = 0; i < length(); i++)
            {
                r += "Program State " + states.ElementAt(i).getIdentifier().ToString() + ": " + states.ElementAt(i).getSymTable().ToString() + " \n ";
            }
            return r;
        }

        public string stackToString()
        {
            string r = "";
            for (int i = 0; i < length(); i++)
            {
                r = r + "Program State " + states.ElementAt(i).getIdentifier().ToString() + ": " + states.ElementAt(i).getExeStack().ToString() + " \n ";
            }
            return r;
        }
        public int length()
        {
            return states.Count();
        }
        public Boolean isEmpty()
        {
            return length() == 0;
        }

        public PrgState getState(int index)
        {
            return states.ElementAt(index);
        }

        public void serialise()
        {
            Stream stream = File.Open(@"d:\Users\user\Desktop\facultate\Anul 2\Semestrul 1\Metode avansate de programare\C# Projects\Lab13\Lab10\PrgState.osl", FileMode.Create);
            BinaryFormatter bformatter = new BinaryFormatter();

            Console.WriteLine("Writing Program Information");
            bformatter.Serialize(stream, pro);
            stream.Close();
        }
        public void deserialise()
        {
            Stream stream = File.Open(@"d:\Users\user\Desktop\facultate\Anul 2\Semestrul 1\Metode avansate de programare\C# Projects\Lab13\Lab10\PrgState.osl", FileMode.Open);
            BinaryFormatter bformatter = new BinaryFormatter();

            Console.WriteLine("Reading Employee Information");
            PrgState np = new PrgState();
            np = (PrgState)bformatter.Deserialize(stream);
            states.Add(np);
            stream.Close();
            pro = np;
        }
        public void ToFile()
        {
            int i, size = length();
            string content="";
            for (i = 0; i < size; i++)
            {
                content += states.ElementAt(i).getExeStack().ToString();
                content += "\n" + states.ElementAt(i).getSymTable().ToString();
                content += "\n" + states.ElementAt(i).getOut().ToString();
            }
            System.IO.File.WriteAllText(@"d:\Users\user\Desktop\facultate\Anul 2\Semestrul 1\Metode avansate de programare\C# Projects\Lab13\Lab10\WriteText.txt", content);
        }
    }
}
