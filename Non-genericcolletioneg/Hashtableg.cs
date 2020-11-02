using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_genericcolletioneg
{
    class Hashtableg
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "Monday");
            ht.Add(3, "wednesday");
            ht.Add(4, "thursday");
            ht.Add("f", "friday");
            ht.Add("fri", "friday");
            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + " " + d.Value);

            }
            Console.WriteLine("-------SortedList-----------");
            //display the information in sorted order
            SortedList st = new SortedList();
            st.Add(1, "monday");
            st.Add(4, "thursday");
            st.Add(3, "wednesday");
            SortedList st1 = new SortedList();
            st1.Add("b", "bala");
            st1.Add("a", "anu");
            foreach (DictionaryEntry di in st)
            {
                Console.WriteLine(di.Key + " " + di.Value);
            }
            foreach (DictionaryEntry di in st1)
            {
                Console.WriteLine(di.Key + " " + di.Value);
            }
            Console.Read();
        }
    }
}


