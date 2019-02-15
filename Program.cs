using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>() { 7, 6, 5, 9, 8, 4, 10, 3, 2, 1 };
            List<int> list = new List<int>() { 7, 6, 5, 9, 8, 100, 4, 3, 2, 1, 22, 19, 500, 456, 2, };
            
            BinarySearch binarySearch = new BinarySearch(list);
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(binarySearch.Search(11)); // 11 not found
            Console.ReadLine();
            Console.Clear();

            binarySearch.Add(11);                       // add 11
            Console.ReadLine();
            Console.Clear();

            binarySearch.Search(11);                    // 11 found
            Console.ReadLine();
            Console.Clear();

            binarySearch.Search(456);
            Console.ReadLine();
            
        }
    }
}
