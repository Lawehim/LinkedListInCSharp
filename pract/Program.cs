using pract.LinkedList;
using System;
namespace AccessSpecifiers
{
    class Programe
    {
        static void Main(string[] args)
        {
            SingleLinkedList lst = new SingleLinkedList();
            lst.AddToFisrt(34);
            lst.AddToLast(23);
            lst.AddToFisrt(9);
            lst.ReadAll();
        }
    }
}