using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session3
{
    internal class TypeE:TypeD
    {
        public int E { get; set; }
        public TypeE(int _A, int _B, int _C, int _D, int _E) : base(_A, _B, _C,_D)
        {
            E = _E;
        }
        public new void fun01()
        {
            Console.WriteLine("I am Derived [GrandGrandGrand Chiled]");
        }

        public override void fun02()
        {
            Console.WriteLine($"Type E is : A = {A}\nB = {B}\nC = {C}\nD = {D}\nE = {E}");
        }
    }
}
