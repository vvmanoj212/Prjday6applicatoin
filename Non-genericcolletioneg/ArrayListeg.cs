using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Non_genericcolletioneg
{
    //collection of objects : heterogeneous ,allows dynamic memory,duplicate elements,index is zero based
    // no supported for multiplication
    class ArrayListeg
    {
        static void Main()
        {
            int[] arr = { 90, 60, 89, 10, 34 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("after sorting");
            Array.Sort(arr);
            //for(int i=0;i<arr.length;i++)
            //foreach(element in iterable-item)
            //var: implicit typed variable
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------arraylist-------------------");
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add(78.90);
            al.Add("kalai");
            al.Add(90);
            al.Add("kalai");
            foreach (var item in al)
            {
                Console.WriteLine("Arraylist:{0}", item);
            }
            Console.WriteLine("count:{0}", al.Count);//no of elements in arraylist
            Console.WriteLine("capacity:{0}", al.Capacity);
            Console.WriteLine("Contains:{0}", al.Contains("saketh"));
            al.Remove(78.90);
            foreach (var item in al)
            {
                Console.WriteLine("ArrayList:{0}", item);
            }
            Console.Read();
        }
    }
}