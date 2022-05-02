using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    /// <summary>
    /// 208. Implement Trie (Prefix Tree)
    /// </summary>
    public class TrieNode
    {
        public Dictionary<char, TrieNode> Children { get; set; } = new();
        public bool IsEndOfWord { get; set; } = false;
    }
    public class Trie
    {
        private TrieNode _root;
        public Trie()
        {
            _root = new TrieNode();
        }

        public void Insert(string word)
        {
            var cur = _root;
            foreach (var charItem in word)
            {
                if (!cur.Children.ContainsKey(charItem))
                {
                    cur.Children[charItem] = new TrieNode();
                }

                cur = cur.Children[charItem];
            }
            cur.IsEndOfWord = true;
        }

        public bool Search(string word)
        {
            var cur = _root;
            foreach (var charItem in word)
            {
                if (!cur.Children.ContainsKey(charItem))
                {
                    return false;
                }
                cur = cur.Children[charItem];
            }

            return cur.IsEndOfWord;
        }

        public bool StartsWith(string prefix)
        {
            var cur = _root;
            foreach (var charItem in prefix)
            {
                if (!cur.Children.ContainsKey(charItem))
                {
                    return false;
                }
                cur = cur.Children[charItem];
            }

            return true;
        }
    }
}
