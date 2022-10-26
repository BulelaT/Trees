using System;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();

            Console.WriteLine("How many values would you like to add?");
            int number = Convert.ToInt32(Console.ReadLine());
            int value = 0;
            Console.WriteLine("Enter you values, pressing 'Enter' after each value");
            //1 2 7 3 10 5 8
            for (int i = 0; i < number; i++)
            {
                value = Convert.ToInt32(Console.ReadLine());
                bt.Add(value);
            }
            Console.WriteLine("printing preorder tree");
            bt.traversePreOrder(bt.root);

            Console.WriteLine("printing inorder tree");
            bt.traverseInOrder(bt.root);

            Console.WriteLine("printing postorder tree");
            bt.traversePostOrder(bt.root);

            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
