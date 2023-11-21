using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stacks_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            Stack<char> st = new Stack<char>();
            for(int i = 0; i < textBoxIn.Text.Length; i++)
            {
                st.Push(textBoxIn.Text[i]);
            }
            if(check(st) == true)
            {
                textBoxOut.Text = "Послідовність вірна";
            }
            else
            {
                textBoxOut.Text = "Послідовність не вірна";
            }
        }

        //потрібна функція
        private bool check(Stack<char> st)
        {
            Stack<char> temp = new Stack<char>();
            while (st.Count != 0)
            {
                char last = st.Pop();
                switch (last)
                {
                    case ')': temp.Push(last); break;
                    case ']': temp.Push(last); break;
                    case '}': temp.Push(last); break;
                    case '(': if (temp.Pop() != ')') { return false; } ; break;
                    case '[': if (temp.Pop() != ']') { return false; } ; break;
                    case '{': if (temp.Pop() != '}') { return false; } ; break;
                }
            }
            return true;
        }
    }
}
