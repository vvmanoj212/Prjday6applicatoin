﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectiongenerics
{
    class Dictionaryeg
    {
        static void Main()
        {
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(8, "a");
            dt.Add(9, "b");
            dt.Add(10, "s");
            dt.ContainsKey(9);
            Console.WriteLine("Contains:{0}", dt.ContainsKey(9));
            Console.WriteLine("Count:{0}", dt.Count());
            foreach (KeyValuePair<int, string> k in dt)
            {
                Console.WriteLine(k.Key + " " + k.Value);
            }
            Console.Read();
        }

    }
}
