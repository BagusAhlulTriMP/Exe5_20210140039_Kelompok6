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
    }
}
