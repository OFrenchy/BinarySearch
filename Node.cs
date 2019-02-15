using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch
{
    class Node
    {
        // Member variables
        int value;
        Node baseNode;
        Node leftNode;
        Node rightNode;

        // Constructor
        public Node(int value, Node baseNode, Node leftNode = null, Node rightNode = null)
        {
            this.value = value;
            this.baseNode = baseNode;
            if (leftNode != null) this.leftNode = leftNode;
            if (rightNode != null) this.rightNode = rightNode;
        }
        // Member methods - … Can Do …

        public int Value { get; }

        public Node Find (int searchValue)
        {
            Node returnNode;



            // always start the search at the base;  if this node's base is null, 
            // start here, because the only node with null for the base is the first one
            if (baseNode == null)
            {
                returnNode = Find(searchValue);
            }
            else 
                returnNode = baseNode.Find(searchValue);

            return returnNode;

        }

    }
}
