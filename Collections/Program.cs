using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*collections
            // array is fixed length // type specific, insertions,del etc
            // they are dynamic arrays
            // array list
            using System.Collections;

            */
            // array list auto size creation
            ArrayList al = new ArrayList();
            al.Add(100);
            al.Add("Kevin");
            al.Add(true);
            int a = al.Capacity;
            Console.WriteLine(a);
            al.Insert(3, 'S');
            foreach (var item in al)
            {
                Console.WriteLine(item + " ");
                //Key (index) and Value(actual item) combination
            }

            //Hashtable
            Hashtable ht = new Hashtable();
            ht.Add("Eid", 101);
            ht.Add("Ename", "Kevin");
            ht.Add("Salary", 100);
            foreach (object key in ht.Keys)
            {
                Console.WriteLine(ht[key]);
                Console.WriteLine(key);
            }
            
            Console.WriteLine(ht["Ename"]);
            //Generic Collectoins - not fixed length - type safe - insertion - still dynamic// key and value
            //list -no user defined keys

            List<int> li = new List<int>();
            li.Add(10);
            li.Add(0);
            li.Add(11);
            li.Add(132);

            foreach (object obj in li)
            {
                Console.WriteLine(obj);
            }

            //dictionary- list

            Dictionary<object, string> di = new Dictionary<object, string>();
            di.Add("Eid", "101");
            di.Add("Name", "Kevin");
            di.Add("Salary", "101010");

            foreach (object obj in di.Values)
            {
                Console.WriteLine(obj);
                
            }

            //stack

            Stack<int> st = new Stack<int>();
            st.Push(10);
            st.Push(11);
            st.Push(12);
            st.Push(14);

            foreach (object obj in st)
            {
                Console.WriteLine(obj);
            }
            st.Pop();

            //Queue

            Queue<int> qu = new Queue<int>();
            qu.Enqueue(10);
            qu.Enqueue(15);
            qu.Enqueue(17);

            foreach (object obj in qu)
            {
                Console.WriteLine(obj);
            }
            qu.Dequeue();

            //sortedlist
            SortedList<int, string> mysortedlist = new SortedList<int, string>();
            mysortedlist.Add(3, "three");
            mysortedlist.Add(4, "four");
            mysortedlist.Add(1, "one");
            mysortedlist.Add(2, "two");

            foreach (object obj in mysortedlist)
            {
                Console.WriteLine(obj);
            }




            Console.ReadLine();

            //IEnumerable
            //IComparable
            //IEnumerator
            //IComparer
                
            

        }
    }
}
