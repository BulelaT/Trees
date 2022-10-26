using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    class BinaryTree
    {
        public Node root { get; set; }
        Node before;
        Node after;

        public bool Add(int value)
        {
            before = null;
            after = this.root;

            while(after != null)
            {
                before = after;
                if(value < after.data)
                {
                    after = after.leftNode;
                }
                else if(value > after.data)
                {
                    after = after.rightNode;
                }
                else
                {
                    return false;
                }
            }

            Node newNode = new Node();
            newNode.data = value;

            if(this.root == null)
            {
                this.root = newNode;
            }
            else
            {
                if(value < before.data)
                {
                    before.leftNode = newNode;
                }
                else
                {
                    before.rightNode = newNode;
                }
            }

            return true;
        }

        public void traversePreOrder(Node parent)
        {
            if(parent != null)
            {
                Console.WriteLine(parent.data);
                traversePreOrder(parent.leftNode);
                traversePreOrder(parent.rightNode);
            }
            
        }

        public void traverseInOrder(Node parent)
        {
            if (parent != null)
            {
                traverseInOrder(parent.leftNode);
                Console.WriteLine(parent.data);
                traverseInOrder(parent.rightNode);
            }
        }

        public void traversePostOrder(Node parent)
        {
            if (parent != null)
            {
                traversePostOrder(parent.leftNode);
                traversePostOrder(parent.rightNode);
                Console.WriteLine(parent.data);
            }
        }
    }
}
