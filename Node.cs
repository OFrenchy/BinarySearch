using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch
{
    class Node
    {
        // Member variables
        int value;
        Node leftNode;
        Node rightNode;

        // Constructor
        public Node(int value)
        {
            this.value = value;
        }
        // Member methods - … Can Do …

        public int Value { get => value; }
        
        public Node LeftNode
        {
            get => leftNode;
            set
            {
                if (leftNode == null) leftNode = value;
            }
        }
        public Node RightNode
        {
            get => rightNode;
            set
            {
                if (rightNode == null) rightNode = value;
            }
        }
    }
}
