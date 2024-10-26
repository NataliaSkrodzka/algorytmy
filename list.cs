using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class List
    {
        public NodeL head;
        public NodeL tail;
        public int count;
        public void AddFirst(int liczba) { }
        public void AddLast(int liczba) {
            var tmp = new NodeL();
            tmp.p = this.tail;
            this.tail.n = tmp;
        }
    }
}
