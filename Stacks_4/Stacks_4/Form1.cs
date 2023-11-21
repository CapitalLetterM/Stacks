using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stacks_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class MyQueue
        {
            Stack<int> onPush;
            Stack<int> onPop;

            public MyQueue()
            {
                onPush = new Stack<int>();
                onPop = new Stack<int>();
            }

            public void push(int val)
            {
                while (onPop.Count != 0)
                {
                    onPush.Push(onPop.Pop());
                }
                onPush.Push(val);
            }

            public int pop()
            {
                while (onPush.Count != 0)
                {
                    onPop.Push(onPush.Pop());
                }
                return onPop.Pop();
            }

            public int peek()
            {
                while (onPush.Count != 0)
                {
                    onPop.Push(onPush.Pop());
                }
                return onPop.Peek();
            }

            public bool isEmpty()
            {
                if(onPush.Count == 0 && onPop.Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public MyQueue queue;

        private void Form1_Load(object sender, EventArgs e)
        {
            queue = new MyQueue();
        }


        private void buttonPush_Click(object sender, EventArgs e)
        {
            queue.push(Convert.ToInt32(textBoxPush.Text));
        }

        private void buttonPop_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = queue.pop().ToString();
        }

        private void buttonPeek_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = queue.peek().ToString();
        }

        private void buttonIsEmpty_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = queue.isEmpty().ToString();
        }
    }
}
