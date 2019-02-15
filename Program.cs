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
            List<int> list = new List<int>() { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            BinarySearch binarySearch = new BinarySearch(list);
            
            Console.WriteLine(  binarySearch.ToString()  );



            Console.WriteLine("Hello World!");
        }
    }
}
