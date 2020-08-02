using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Huffman
{
    class BinaryTree // BinaryTree Data structure
    {
        public class TreeNode // tree node structure
        {
            public string Value;
            public string Code  = "";
            public TreeNode Left;
            public TreeNode Right;
        }
        public TreeNode Node;
        public Dictionary<string, string> Tree = new Dictionary<string, string>(); // char - code dict
        private string input_s; // original string reminder
        public BinaryTree(string s) // tree input
        {
            input_s = s;
            AddElem(ref Node, s, "");
            RoundTree(Node);
        }

        private void AddElem(ref TreeNode node, string value, string code)
        {

            node = new TreeNode();
            node.Value = value;
            node.Code = code;
            if (value.Length == 1) { return; }
            if (value == input_s || value.Length == 2) // distribution for the first and last cases
            {
                AddElem(ref node.Left, value[0].ToString(), code + "0");
                value = value.Remove(0, 1);
                AddElem(ref node.Right, value, code + "1");
            }
            else // distribution for other cases
            {
                AddElem(ref node.Right, value[0].ToString(), code + "1");
                value = value.Remove(0, 1);
                AddElem(ref node.Left, value, code + "0");
            }

        }

        private void RoundTree(TreeNode node) // bypass the tree
        {
            if (node != null)
            {
                if (node.Value.Length == 1)
                {
                    Tree.Add(node.Value, node.Code);
                }
                RoundTree(node.Left);
                RoundTree(node.Right);
            }
        }
    }
}
