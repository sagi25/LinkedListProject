using System;
using System.Collections.Generic;

namespace LinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {

            linkedList list = new linkedList();

            list.Add("Hello");
            list.Add("Test1");
            list.Add("Test2");

            object test = list.Get(1);

            //int index = list.IndexOf("Hello");

            //list.Add("Test1");
            //list.Add("test2");
            //list.Add(1, "test3");

            //list.Remove(1);
            //list.Clear();


            //Console.WriteLine("is it empty? - " + list.Empty);
            //Console.WriteLine("count - " + list.Empty);
            //Console.ReadLine();
        }
    }
}
