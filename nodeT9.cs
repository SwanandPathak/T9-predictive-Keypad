using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace message
{
    class nodeT9
    {  
        public nodeT9 [] next; // to store all 9 paths possible by clicking any of the numeric digits
        public Dictionary<string, int> myWords; // to store words
        // pConstructor
        public nodeT9()
        {
           next=new nodeT9[10];
            myWords=new Dictionary<string,int>();
            }
    }
}
