using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgo
{
    public class Node
    {
        public int  Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node()
        {

        }
        public Node(int data)
        {
            this.Data = data;

        }
    }

    public class BinaryTree
    {
        private Node _root;
        public BinaryTree()
        {
            _root = null;
        }
        public void Insert(int data)
        {
            if (_root == null)
            {
                _root = new Node(data);
                return;
            }
            InsertRec(_root, new Node(data));
        }
        private void InsertRec(Node root, Node newNode)
        {
            if (root == null)
                root = newNode;

            if (newNode.Data < root.Data)
            {
                if (root.Left == null)
                    root.Left = newNode;
                else
                    InsertRec(root.Left, newNode);

            }
            else
            {
                if (root.Right == null)
                    root.Right = newNode;
                else
                    InsertRec(root.Right, newNode);
            }
        }
        private void DisplayTree(Node root)
        {
            if (root == null) return;

            DisplayTree(root.Left);
            System.Console.Write(root.Data + " ");
            DisplayTree(root.Right);
        }
        public void DisplayTree()
        {
            DisplayTree(_root);
        }
    }
}
