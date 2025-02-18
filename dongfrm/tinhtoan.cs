using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidu01
{
    class tinhtoan
    {
        
        int a;
        int b;
       
        public tinhtoan(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }

        public int cong()
        { return a + b; }
        public int tru()
        { return a - b; }
        public int nhan()
        { return a * b; }
        public int chia()
        { return a / b; }
    }
}
