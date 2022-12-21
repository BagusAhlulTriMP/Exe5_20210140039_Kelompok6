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
            newnode.next = null;
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
    class Program
    {
        static void Main(string[] args)
        {
            Queue qe = new Queue();
            char ch;
            while(true)
            {
                try
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("1.Menambahkan Data ke dalam List");
                    Console.WriteLine("2.Menghapus  Data dari dalam List");
                    Console.WriteLine("3.Melihat semua data  di dalam List");
                    Console.WriteLine("4.Exit");
                    Console.WriteLine("Masukkan pilihan anda (1 - 4: ");
                    ch = Convert.ToChar(Console.ReadKey());
                    switch (ch)
                    {
                        case '1':
                            qe.Insert();
                            break;
                        case '2':
                            qe.delete();
                            break;
                        case '3':
                            qe.Display();
                            break;
                        case '4':
                            return;
                        default:
                            Console.WriteLine("Wrong Option");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nCheck for the value entered ");
                }
            }
        }
    }
}
