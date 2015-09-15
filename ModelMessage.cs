using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace message
{
    public class modelMessage
    {
        // base(root) node of Trie 
        nodeT9 start;
        // String initialize
        string display="";
        //initializing dictionary
        static Dictionary<char, int> label = new Dictionary<char, int>
        {
            {'a',2},{'b',2},{'c',2},{'d',3},{'e',3},{'f',3},{'g',4},{'h',4},{'i',4},
            {'j',5},{'k',5},{'l',5},{'m',6},{'n',6},{'o',6},{'p',7},{'q',7},{'r',7}
            ,{'s',7},{'t',8},{'u',8},{'v',8},{'w',9},{'x',9},{'y',9},{'z',9}
        };
        // Constructor of model
        public modelMessage()
        {
            start = new nodeT9();
            
        }
        // returns boolean value is the word already added on the trie
        public Boolean isFound(string words)
        {
            nodeT9 current = start;
            for (int i = 0; i < words.Length; i++)
            {
                int c = label[words.ElementAt(i)];
                if (current.next[c] == null)
                {
                    return false;                           // if no node == return false
                }
                else
                {
                    current = current.next[c];
                }
            }
            if (current.myWords.ContainsKey(words))
            {
                return true;                            //if already contains return true
            }
            else
            {
                return false;
            }

        }
        // function to initialise display
        public void initDisplay()
        {
            display = "";
        }
        // building trie
        public void buildTrie(string nowWord)
        {
            nodeT9 current = start;
            if (isFound(nowWord))
            {
                return;     //if founf dont put again
            }

            for (int i = 0; i < nowWord.Length; i++)
            {
                int c = label[nowWord.ElementAt(i)];
                if (current.next[c] == null)
                {                                                 //  putting in appropriate place
                    current.next[c] = new nodeT9();
                }
                current = current.next[c];


            }
            current.myWords.Add(nowWord, 1);           // adding to map
        }
       //searching words through the trie path, and going 5 levels down to give other words
        public string showWords(string digit)
        {
            int level = 5;
            nodeT9 current = start;
            for (int i = 0; i < digit.Length; i++)
            {
                int c = digit.ElementAt(i) - '0';               
                current = current.next[c];              
                if (current == null)
                {
                    break;
                }

            }
            if (current != null)
            {
                foreach (string s in current.myWords.Keys)
                {
                    Console.WriteLine(s + " ");                 //checking at current level
                    if (s.Length > 2)
                    {
                        display += s+" ";
                    }
                    
                }



                for (int i = 0; i < level; i++)     //going down 5 levels
                {
                    for (int k = 0; k < current.next.Length; k++)
                    {
                        if (current.next[k] != null)
                        {
                            current = current.next[k];
                            break;
                        }
                    }
                    foreach (string s in current.myWords.Keys)
                    {
                        Console.WriteLine(s + " ");         //showing words only bigger than 3>= length
                        if (s.Length > 2)
                        {
                            display +=s+" ";        //making changes to display
                        }

                    }
                    return display;
                }
            }
            else
            {
                Console.WriteLine("----");          //if not found turn to ----
                display =display+ "----";
                return display;

            }
            return display;
        }

    }
}
