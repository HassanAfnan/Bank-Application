using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class Bank
    {
        private int no;
        private string name;
        private int bal;
        public void NewAcc(int a,string b,int c)
        {
            no = a;
            name = b;
            bal = c;
        }
        public void Dep(int a)
        {
              bal = a + bal;
        }
        public void Wed(int b)
        {
              bal = bal - b;
        }
        public int show()
        {
            return bal;
        }
    }
}
