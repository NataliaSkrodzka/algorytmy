using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class NodeT
    {
        public NodeT rodzic;
        public NodeT lewe;
        public NodeT prawe;
        public int data;
        public NodeT(int liczba)
        {
            this.data = liczba;
        }
    }
}