using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stacks_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            string[] values = parse(textBoxIn.Text);
            textBoxOut.Text = count(values).ToString();
        }

        private string[] parse(string line)
        {
            Queue<string> values = new Queue<string>();
            string temp = "";
            for(int i = 0; i < line.Length; i++)
            {
                if(line[i] != ',' && line[i] != ' ')
                {
                    temp += line[i];
                }
                else if (temp != "")
                {
                    values.Enqueue(temp);
                    temp = "";
                }
            }
            values.Enqueue(temp);
            string[] finish = new string[values.Count];
            for(int i = 0; i < finish.Length; i++)
            {
                finish[i] = values.Dequeue();
            }
            return finish;
        }

        public int count(string[] values)
        {
            Stack<int> stack = new Stack<int>();
            for(int i = 0; i < values.Length; i++)
            {
                if (int.TryParse(values[i], out var number))
                {
                    stack.Push(number);
                }
                else
                {
                    stack.Push(operation(values[i][0], stack.Pop(), stack.Pop()));
                }
            }
            return stack.Pop();
        }

        public int operation(char action, int operand2, int operand1)
        {
            switch(action)
            {
                case '+': return operand1 + operand2;
                case '-': return operand1 - operand2;
                case '*': return operand1 * operand2;
                case '/': return operand1 / operand2;
                default: return 0;
            }
        }
    }
}
