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
            Console.WriteLine("base " + baseNode.Value);

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
                        Console.WriteLine("base " + thisBase.Value + " left");
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
                        Console.WriteLine("base " + thisBase.Value + " right");
                    }
                }
            }
            while (placedNode == false);
        }

        public Node Search(int searchValue)
        {
            // Start at the base, searching less than/greater than & if null
            Node thisBase = baseNode;
            Console.WriteLine("base " + baseNode.Value);
            Node foundNode = null;
            string path = "Base " + baseNode.Value + "; ";

            do
            {
                if (searchValue == thisBase.Value)
                {
                    path = path + baseNode.Value + " left; ";
                    foundNode = thisBase;
                }
                else
                {
                    if (searchValue < thisBase.Value)
                    {
                        path = path + baseNode.Value + " left; ";
                        thisBase = thisBase.LeftNode;
                    }
                    else
                    {
                        path = path + baseNode.Value + " right; ";
                        thisBase = thisBase.RightNode;
                    }
                }
            }
            while (foundNode == null);
            return foundNode;
        }
    }
}
