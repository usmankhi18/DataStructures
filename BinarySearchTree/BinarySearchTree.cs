using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Tree.BinarySearchTree
{
    public class BinarySearchTree : ITreeOperations
    {
        private BSTNode root;

        public BinarySearchTree()
        {
            root = null;
        }

        public bool IsEmpty()
        {
            return root == null;
        }

        public void Insert(int data)
        {
            root = Insert(root, data);
        }

        private BSTNode Insert(BSTNode node, int data)
        {
            if (node == null)
                node = new BSTNode(data);
            else
            {
                if (data <= node.data)
                    node.left = Insert(node.left, data);
                else
                    node.right = Insert(node.right, data);
            }
            return node;
        }

        public void Delete(int data)
        {
            if (IsEmpty())
                Console.WriteLine("TREE EMPTY");
            else if (!Search(data))
                Console.WriteLine($"SORRY {data} IS NOT PRESENT");
            else
            {
                root = Delete(root, data);
                Console.WriteLine($"{data} DELETED FROM THE TREE");
            }
        }

        private BSTNode Delete(BSTNode root, int data)
        {
            BSTNode p, p2, n;
            if (root.data == data)
            {
                BSTNode lt, rt;
                lt = root.left;
                rt = root.right;
                if (lt == null && rt == null)
                {
                    return null;
                }
                else if (lt == null)
                {
                    p = rt;
                    return p;
                }
                else if (rt == null)
                {
                    p = lt;
                    return p;
                }
                else
                {
                    p2 = rt;
                    p = rt;
                    while (p.left != null)
                        p = p.left;
                    p.left = lt;
                    return p2;
                }
            }
            if (data < root.data)
            {
                n = Delete(root.left, data);
                root.left = n;
            }
            else
            {
                n = Delete(root.right, data);
                root.right = n;
            }
            return root;
        }

        public bool Search(int data)
        {
            return Search(root, data);
        }

        private bool Search(BSTNode node, int data)
        {
            bool found = false;
            while ((node != null) && !found)
            {
                int rval = node.data;
                if (data < rval)
                    node = node.left;
                else if (data > rval)
                    node = node.right;
                else
                {
                    found = true;
                    break;
                }
                found = Search(node, data);
            }
            return found;
        }

        public void PrintTree()
        {
            PrintTree(root, " ");
        }

        private void PrintTree(BSTNode node, string prefix)
        {
            if (node == null)
                return;
            PrintTree(node.left, " " + prefix);
            Console.WriteLine(prefix + "--" + node.data);
            PrintTree(node.right, prefix + " ");
        }
    }
}
