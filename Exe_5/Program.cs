using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_5
{
    class node
    {
        public string name;
        public node next;
     }

    class Queue
    {
        public node Bagus, Putro;
        public Queue()
        {
            Bagus = null;
            Putro = null;
        }

        public void Insert()
        {
            string add;
            node newnode = new node();
            Console.WriteLine("Masukkan Element : ");
            add = Console.ReadLine();
            newnode.name = add;
            newnode.next = Putro;
            if(Bagus == null)
            {
                Bagus = newnode;
                Putro = newnode;
                return;
            }
            Putro.next = newnode;
            Putro = newnode;
        }
        public void delete()
        {
            if(Putro == null)
            {
                Console.WriteLine("\nList is empty");
                return;
            }
            Putro = Putro.next;
            if (Bagus == null)
                Putro = null;
        }
        public void Display()
        {
            if(Bagus == null)
            {
                Console.WriteLine("\nQueue is empty");
                return;
            }
            node Display;
            for (Display = Bagus; Display != null; Display = Display.next)
                Console.WriteLine(Display.name);
        }
    }
}
