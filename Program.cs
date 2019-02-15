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
            //List<int> list = new List<int>() { 7, 6, 5, 9, 8, 4, 3, 2, 1 };  //{ 7, 6, 5, 9, 8, 4, 3, 2, 1, 22,19,500,456,2, };
            List<int> list = new List<int>() { 7, 6, 5, 9, 8, 100, 4, 3, 2, 1, 22, 19, 500, 456, 2, };

            BinarySearch binarySearch = new BinarySearch(list);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine( binarySearch.Search(9) );

            Console.WriteLine(binarySearch.Search(11)); // not found
            binarySearch.Add(11);
            Console.WriteLine(binarySearch.Search(11)); // found

            Console.WriteLine(binarySearch.Search(9));



            Console.ReadLine();
            
        }
    }
}
