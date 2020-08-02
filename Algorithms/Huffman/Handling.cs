using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Huffman
{
    static class Handling
    {
        public static void Encode(string input)
        {
            // creating the alphabet with input string in true order, then creating the tree and encoding
            HashSet<char> set = new HashSet<char>(input);
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach(var item in set)
            {
                dict[item.ToString()] = input.Count(key => key == item);
            }
            string alphabet = "";
            foreach (var item in dict.OrderByDescending(key => key.Value))
            {
                alphabet += item.Key;
            }

            BinaryTree binary = new BinaryTree(alphabet);
            string encoded = "";
            foreach (var item in input)
            {
                encoded += binary.Tree[item.ToString()];
            }
            Console.WriteLine("Encoded string: " + encoded);
        }
    }
}
