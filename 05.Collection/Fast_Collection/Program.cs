using System;
using System.Collections.Generic;

/**
 * ? Fastest Collections in C#
*/

namespace Fast_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * ? HashSet<T> Class:
            */
            var hashSet = new HashSet<int>();

            hashSet.Add(71);
            hashSet.Add(57);
            hashSet.Add(32);
            hashSet.Add(57); // Only Take Unique values, Duplicate values is ignored.

            Console.WriteLine("\n= = = = = = HashSet ::");
            foreach (var item in hashSet)
            {
                Console.Write($"Value: {item}, ");
            }
            Console.WriteLine($"\nTotal No. of Values: {hashSet.Count}");

            /**
             * ? Dictionary<TKey, TValue> Class:
            */
            var dictSet = new Dictionary<int, string>();
            dictSet.Add(1, "Hawgarts I");
            dictSet.Add(2, "Hawgarts II");
            dictSet.Add(3, "Hawgarts IV");
            dictSet.Add(4, "Python-5.0");

            Console.WriteLine("\n= = = = = = Dictionary ::");
            Console.WriteLine($"2nd Dictionary Set: {dictSet[2]}");
            Console.WriteLine($"3rd Dictionary Set: {dictSet[3]}");
            Console.WriteLine($"Total No. of Values: {dictSet.Count}");

            /**
             * ? LinkedList<T> Class:
            */
            var linkedList = new LinkedList<string>();
            linkedList.AddLast("Parallel");
            linkedList.AddLast("Universe");
            linkedList.AddLast("Paradox");

            Console.WriteLine("\n= = = = = = LinkedList ::");
            foreach (var item in linkedList)
            {
                Console.Write($"Value: {item}, ");
            }
            Console.WriteLine($"\nTotal No. of Values: {linkedList.Count}");

            /**
             * ? Stack<T> Class:
            */
            var stack = new Stack<string>();
            stack.Push("ONE");
            stack.Push("TWO");
            stack.Push("THREE");

            Console.WriteLine("\n= = = = = = Stack ::");
            foreach (var item in stack)
            {
                Console.Write($"Value: {item}, ");
            }
            Console.WriteLine($"\nTotal No. of Values: {stack.Count}");

            /**
             * ? Queue<T> Class:
            */
            var queue = new Queue<string>();
            queue.Enqueue("FOUR");
            queue.Enqueue("FIVE");
            queue.Enqueue("SIX");

            Console.WriteLine("\n= = = = = = Queue ::");
            foreach (var item in queue)
            {
                Console.Write($"Value: {item}, ");
            }
            Console.WriteLine($"\nTotal No. of Values: {queue.Count}");
        }
    }
}
