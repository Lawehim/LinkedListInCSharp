using pract.LinkedList;
using System;
namespace AccessSpecifiers
{
    class Programe
    {
        static void Main(string[] args)
        {
            SingleLinkedList lst = new SingleLinkedList();
            lst.AddToLast(23);
            lst.AddToLast(34);
            lst.AddToFisrt(9);
            lst.ReadAll();
        }
    }
}