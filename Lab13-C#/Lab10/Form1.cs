using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Lab10
{
    public partial class Form1 : Form
    {
        private Controller con;
        //private Repository repo;
        public Form1() {
          //  repo= new Repository();
            con = new Controller();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void deserialise_Click(object sender, EventArgs e)
        {
            con.deserialise();
        }

        private void toFile_Click(object sender, EventArgs e)
        {
            con.WriteToFile();
        }

        private void serialise_Click(object sender, EventArgs e)
        {
            con.serialise();
        }

        private Statement ChooseStatement()
        {
            string s = Prompt.ShowDialog("Statement Menu \n 1. Assignment \n 2. Print \n 3. If \n 4. Compound \n 5 - Fork\n 6 - Write Heap", "Choose Statement");
            if (s == "1")
            {
                string var= Prompt.ShowDialog("Give a variable name", "Variable");
                Expresion e = ChooseExpresion();
                return new AssignStatement(var, e);

            }
            else if (s == "2")
            {
                Expresion e = ChooseExpresion();
                return new PrintStatement(e);
            }
            else if (s == "3")
            {
                Expresion e = ChooseExpresion();
                Statement st = ChooseStatement();
                Statement stt = ChooseStatement();
                return new IfStatement(e, st, stt);
            }
            else if (s == "4")
            {
                Statement st = ChooseStatement();
                Statement stt = ChooseStatement();
                return new CompoundStatement(st, stt);
            }
            else if (s == "5")
            {
                Statement st = ChooseStatement();
                return new Fork(st);
            }
            else if (s == "6")
            {
                string var = Prompt.ShowDialog("Give a variable name", "Variable");
                Expresion e = ChooseExpresion();
                return new WH(e,var);
            }
            else ChooseStatement();
            return null;
        }

        private Expresion ChooseExpresion()
        {
            string s = Prompt.ShowDialog("Expression Menu \n 1. Variable \n 2. Constant \n 3. Arithmetic \n4. New\n5. Heap-Reading\n6. Keyboard Reading", "Choose Expression");

            if (s=="2")
            {
                    string cc = Prompt.ShowDialog("Give a value", "Choose Expression");
                    int cont;
                    cont=int.Parse(cc);
                    return new ConstantExpresion(cont);
            }

            if (s=="1")
            {
                string var = Prompt.ShowDialog("Give a variable name", "Choose Expression");
                return new VarExpresion(var);
            }

            if (s == "3")
            {
                Expresion e = ChooseExpresion();
                Expresion ex = ChooseExpresion();
                string op = ChooseOperation();
                if (op == "+" | op == "-" | op == "*" | op == "/")
                    return new ArithmeticExpresion(e, ex, op);
                else
                {
                    op = ChooseOperation();
                    if (op == "+" | op == "-" | op == "*" | op == "/")
                        return new ArithmeticExpresion(e, ex, op);
                }
            }
            if (s == "5")
            {
                string var = Prompt.ShowDialog("Give a variable name", "Choose Expression");
                return new HeapReadingExpresion(var);
            }
            if (s == "4")
            {
                string cc = Prompt.ShowDialog("Give a value", "Choose Expression");
                int cont;
                cont = int.Parse(cc);
                return new NewExpresion(cont);
            }
            if (s == "6")
            {
                //string var = Prompt.ShowDialog("Introduces an integer for ToyLanguage", "Keyboard");
                ReadKey k= new ReadKey();
                //k.key = Int32.Parse(var);
                return k;

            }
            return null;
        }
        public string ChooseOperation()
        {
            string s = Prompt.ShowDialog("Please enter either +, -, *, /", "Choose Operator");
            if (s=="+")
            {
                return s;
            }
            if (s=="-")
            {
                return s;
            }
            if (s=="*")
            {
                return s;
            }
            if (s=="/")
            {
                return s;
            }
            return "NOT";
        }

        private void add_Click(object sender, EventArgs e)
        {
            Statement st = ChooseStatement();
            con.AddProgram(st);
        }

        private void test_Click(object sender, EventArgs e)
        {
            //v=new(read());print(r(v));                                                                                                                 fork(wh(v,1+read());print(r(v));                                                   fork(wh(v,20));print(r(v)));print(r(v)+1)
            Statement s = new CompoundStatement(new AssignStatement("v", new NewExpresion(10)), new CompoundStatement(new PrintStatement(new HeapReadingExpresion("v")), new CompoundStatement(new Fork(new WH(new ArithmeticExpresion(new ConstantExpresion(1), new ReadKey(), "+"), "v")), new CompoundStatement(new Fork(new WH(new ConstantExpresion(20), "v")), new CompoundStatement(new PrintStatement(new HeapReadingExpresion("v")), new PrintStatement(new ArithmeticExpresion(new HeapReadingExpresion("v"),new ConstantExpresion(1),"+")))))));// new Fork(new CompoundStatement(new AssignStatement("b", new ArithmeticExpresion(new VarExpresion("a"), new ConstantExpresion(1), "+")), new IfStatement(new VarExpresion("a"), new PrintStatement(new VarExpresion("b")), new PrintStatement(new ArithmeticExpresion(new VarExpresion("a"), new VarExpresion("a"), "*"))))));
            con.AddProgram(s);
        }

        private void Run_Click(object sender, EventArgs e)
        {
            con.Run(0);
            string oupit=con.printOutput();
            outList.Items.Add(oupit);

        }

        private void debug_Click(object sender, EventArgs e)
        {
            con.Run(1);
            string oupit = con.printOutput();
            string exe = con.printStack();
            string sym = con.printSym();
            string he = con.printHeap();
            string[] exel = exe.Split('\n');
            string[] oul = oupit.Split('\n');
            string[] sl = sym.Split('\n');
            string[] hl = he.Split('\n');
            int size = exel.Length;
            int i;
            
            for (i = 0; i < size; i++)
                exeList.Items.Add(exel[i]);
            
            size = oul.Length;
            for (i = 0; i < size; i++)
                outList.Items.Add(oul[i]);
            size = sl.Length;
            for (i = 0; i < size; i++)
                symList.Items.Add(sl[i]);
            size = hl.Length;
            for (i = 0; i < size; i++)
                heapList.Items.Add(hl[i]);
        }

        private void exeList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    
}
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
    {
        Form prompt = new Form();
        prompt.Width = 500;
        prompt.Height = 500;
        prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
        prompt.Text = caption;
        prompt.StartPosition = FormStartPosition.CenterScreen;
        Label textLabel = new Label() { Left = 50, Top=50, Text=text };
        textLabel.Width = 200;
        textLabel.Height = 300;
        TextBox textBox = new TextBox() { Left = 50, Top=300, Width=400 };
        Button confirmation = new Button() { Text = "Ok", Left=300, Width=100, Top=400 };
        confirmation.Click += (sender, e) => { prompt.Close(); };
        prompt.Controls.Add(textBox);
        prompt.Controls.Add(confirmation);
        prompt.Controls.Add(textLabel);
        prompt.AcceptButton = confirmation;
        prompt.ShowDialog();
        return textBox.Text;
    }
    }
}
