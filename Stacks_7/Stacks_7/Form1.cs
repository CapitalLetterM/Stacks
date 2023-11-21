using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stacks_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = count(textBoxIn.Text).ToString();
        }

        private int count(string brackets)
        {
            int longest = 0;
            Stack<int> openingBracketPositions = new Stack<int>();

            int sequenceStart = 0;
            for (int i = 0; i < brackets.Length; i++)
            {
                if (brackets[i] == '(')
                {
                    openingBracketPositions.Push(i);
                }
                else
                {
                    if (openingBracketPositions.Count > 0)
                    {
                        int distance = i - openingBracketPositions.Pop() + 1;
                        if(distance > longest)
                        {
                            longest = distance;
                        }
                        if (openingBracketPositions.Count > 0)
                        {
                            longest = Math.Max(longest, i - openingBracketPositions.Peek());
                        }
                        else
                        {
                            longest = Math.Max(longest, i - sequenceStart + 1);
                        }
                    }
                    else
                    {
                        sequenceStart = i + 1;
                        openingBracketPositions.Clear();
                    }
                }
            }
            return longest;
        }
    }
}
