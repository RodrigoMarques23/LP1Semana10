using System;
using System.Collections.Generic;
namespace StringCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "baba";
            string b = "baba";
            string c = "mundo";
            string d = "alien";
            string e = "extra";

            List<string> list = new List<string> { a, b, c, d, e };
            Stack<string> stack = new Stack<string>();
            Queue<string> queue = new Queue<string>();
            foreach(string s in list)
            {
                stack.Push(s);
                queue.Enqueue(s);
            }
            HashSet<string> hashSet = new HashSet<string> { a, b, c, d, e };

            Console.WriteLine("List:");
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("stack:");
            foreach (string s in stack)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Queue:");
            foreach (string s in queue)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("hashSet:");
            foreach (string s in hashSet)
            {
                Console.WriteLine(s);
            }


        }
    }
}
