using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stacks_3
{
    public partial class Form1 : Form
    {
        public class MinStack
        {
            int topElement;
            Stack<int> min = new Stack<int>();
            int current;
            int[] elements;

            public MinStack()
            {
                elements = new int[1000];
                current = 0;
            }

            public void push(int val)
            {
                if(min.Count == 0)
                {
                    min.Push(val);
                }
                else if(val <= min.Peek())
                {
                    min.Push(val);
                }
                topElement = val;
                elements[current] = val;
                current++;
            }

            public void pop()
            {
                if (current != 0)
                {
                    current--;
                }
                if(current != 0)
                {
                    if (topElement == min.Peek())
                    {
                        min.Pop();
                    }
                    topElement = elements[current - 1];
                }
                else
                {
                    topElement = 0;
                }
            }

            public int top()
            {
                return topElement;
            }

            public int getMin()
            {
                return min.Peek();
            }
        }

        MinStack stack;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreateStack_Click(object sender, EventArgs e)
        {
            stack = new MinStack();
        }

        private void buttonPush_Click(object sender, EventArgs e)
        {
            stack.push(Convert.ToInt32(textBoxPush.Text));
        }

        private void buttonPop_Click(object sender, EventArgs e)
        {
            stack.pop();
        }

        private void buttonTop_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = stack.top().ToString();
        }

        private void buttonGetMin_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = stack.getMin().ToString();
        }
    }
}
