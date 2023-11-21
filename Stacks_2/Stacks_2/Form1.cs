using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stacks_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class TreeNode
        {
            public int value;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int val)
            {
                value = val;
                left = null;
                right = null;
            }
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            TreeNode root = new TreeNode(1);
            root.right = new TreeNode(2);
            root.right.right = new TreeNode(3);

            textBoxOut.Text = pass(root);
        }

        private string pass(TreeNode root)
        {
            string elements = "";
            TreeNode current = root;
            Stack<TreeNode> leaves = new Stack<TreeNode>();
            while(current != null || leaves.Count != 0)
            {
                while (current != null)
                {
                    leaves.Push(current);
                    current = current.left;
                }
                TreeNode top = leaves.Pop();
                elements += top.value;
                current = top.right;
            }

            return elements;
        }
    }
}
