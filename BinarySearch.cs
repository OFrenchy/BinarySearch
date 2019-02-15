using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BinarySearch
{
    class BinarySearch      //<T>
    {

        protected Node baseNode;// = new Node(1);

        public BinarySearch(List<int> list)
        {
            foreach (int thisInt in list)
            {
                // if this is the first node, save it as the base
                if (baseNode == null) baseNode = new Node(thisInt);
                // otherwise, add it to the tree
                else
                {
                    Add(thisInt);
                }
            }
        }
        public void Add(int intToAdd)
        {
            // Start at the base, searching less than/greater than & if null
            Node thisBase = baseNode;
            bool placedNode = false;
            Console.WriteLine("base " + baseNode.Value + "; adding " + intToAdd);

            do
            {
                if (intToAdd < thisBase.Value)
                {
                    if (thisBase.LeftNode == null)
                    {
                        Console.WriteLine("Adding " + intToAdd + " to " + thisBase.Value + "-left");
                        thisBase.LeftNode = new Node(intToAdd);
                        placedNode = true;
                    }
                    else
                    {
                        thisBase = thisBase.LeftNode;
                        Console.WriteLine("base " + thisBase.Value + "; left");
                    }
                }
                else
                {
                    if (thisBase.RightNode == null)
                    {
                        Console.WriteLine("Adding " + intToAdd + " to " + thisBase.Value + "-right");
                        thisBase.RightNode = new Node(intToAdd);
                        placedNode = true;
                    }
                    else
                    {
                        thisBase = thisBase.RightNode;
                        Console.WriteLine("base " + thisBase.Value + "; right");
                    }
                }
            }
            while (placedNode == false);
        }

        public Node Search(int searchValue)
        {
            // Start at the base, searching less than/greater than & if null
            Node thisBase = baseNode;
            Node foundNode = null;

            Console.WriteLine("Search for " + searchValue);
            Console.WriteLine("Base " + baseNode.Value);

            do
            {
                // the value we are searching for might not be in the tree; 
                // if so, both left & right are null

                if (searchValue == thisBase.Value)
                {
                    Console.WriteLine("Found " + thisBase.Value);
                    foundNode = thisBase;
                }
                else if (thisBase.LeftNode == null && thisBase.RightNode == null)
                {
                    Console.WriteLine(searchValue + " not found ");
                    return null;
                }
                else
                {
                    if (searchValue < thisBase.Value)
                    {
                        Console.WriteLine("Left to " + thisBase.LeftNode.Value);
                        thisBase = thisBase.LeftNode;
                    }
                    else
                    {
                        Console.WriteLine("Right to " + thisBase.RightNode.Value);
                        thisBase = thisBase.RightNode;
                    }
                }
            }
            while (foundNode == null);
            return foundNode;
        }
    }
}
