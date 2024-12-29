using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session3
{
    internal class TypeC:TypeB
    {
        public int C { get; set; }
        public TypeC(int _A , int _B , int _C): base(_A, _B)
        {
            C = _C;
        }
        public new void fun01()
        {
            Console.WriteLine("I am Derived [Grand Chiled]");
        }

        public override void fun02()
        {
            Console.WriteLine($"Type C is : A = {A}\nB = {B}\nC = {C}");
        }
    }
}
