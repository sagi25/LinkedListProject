using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProject
{
    class Util
    {
        public static void PrintList<T>(LinkedList<T> list)
        {
            Console.WriteLine($"List Data: [{list.Count}]\n");
            //int i = 0;

            if (list.Count > 0)
            {
                //for (Node<T> node = _nFirst; node != null; node = node.Next)
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}] - {list.GetAt(i)}\n");
                    //++i;
                }
            }
            Console.WriteLine("--------------------");
            Console.WriteLine();
        }

        public static void Print<T>(this LinkedList<T> input)
        {
            PrintList(input);
        }
    }
}
