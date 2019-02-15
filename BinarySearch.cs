using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch
{
    class BinarySearch
    {
        Node baseNode;// = new Node(1);

        public BinarySearch(List<int> list)
        {
            foreach(int thisInt in list)
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

            do
            {
                if (intToAdd < thisBase.Value)
                {
                    if (thisBase.LeftNode == null)
                    {
                        thisBase.LeftNode = new Node(intToAdd);
                        placedNode = true;
                    }
                    else
                    {
                        thisBase = thisBase.LeftNode;
                    }
                }
                else
                {
                    if (thisBase.RightNode == null)
                    {
                        thisBase.RightNode = new Node(intToAdd);
                        placedNode = true;
                    }
                    else
                    {
                        thisBase = thisBase.RightNode;
                    }
                }
            }
            while (placedNode == false);
        }
    }
}
