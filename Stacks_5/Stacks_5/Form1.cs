using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stacks_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = decode(textBoxIn.Text);
        }

        public string decode(string line)
        {
            Stack<char> stack = new Stack<char>();

            for(int i = 0; i < line.Length; i++)
            {
                string temp1 = "";
                string temp2 = "";

                if (line[i] != ']')
                {
                    stack.Push(line[i]);
                    continue;
                }

                while (stack.Any() && char.IsLetter(stack.Peek()))
                {
                    temp1 += stack.Pop();
                }

                stack.Pop();

                temp1 = new string(temp1.Reverse().ToArray());

                while (stack.Any() && char.IsDigit(stack.Peek()))
                {
                    temp2 += stack.Pop();
                }

                temp2 = new string(temp2.Reverse().ToArray());

                var n = int.Parse(temp2);
                temp2 = temp1;

                while (--n > 0)
                {
                    temp1 += temp2;
                }

                foreach (var c in temp1)
                {
                    stack.Push(c);
                }
            }

            return new string(stack.Reverse().ToArray());
        }
    }
}
