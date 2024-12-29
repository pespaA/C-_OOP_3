using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session3
{
    internal class TypeD:TypeC
    {
        public int D { get; set; }
        public TypeD(int _A, int _B, int _C, int _D) : base(_A, _B, _C)
        {
            D = _D;
        }
        public new void fun01()
        {
            Console.WriteLine("I am Derived [GrandGrand Chiled]");
        }

        public new virtual void fun02()
        {
            Console.WriteLine($"Type D is : A = {A}\nB = {B}\nC = {C}\nD = {D}");
        }
    }
}
