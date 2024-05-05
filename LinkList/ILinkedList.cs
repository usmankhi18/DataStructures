using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkList
{
    interface ILinkedList
    {
        void InsertAtBeginning(int data);
        void InsertAtEnd(int data);
        void InsertAfterNode(int data, int key);
        void DeleteAtBeginning();
        void DeleteAtEnd();
        void DeleteNode(int key);
        void Reverse();
        bool Search(int key);
        void PrintList();
    }
}
