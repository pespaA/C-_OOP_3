using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session3
{
    internal class TypeB:TypeA
    {
        public int B { get; set; }
        public TypeB(int _A, int _B) : base(_A)
        {
            B = _B;
        }
        // Static Binding [ Early Binding ]
        // Compiler Will Bind Function Call Based On Reference Not Object
        // At Compilation Time 
        public new void fun01() // => new Version From fun01
        {
            Console.WriteLine(" I am Derived [Chiled]");
        }
        // Aplly Over Riding using Override ( By using Public - Virtiul )
        // Dynamic Binding [Late Binding]
        // Clr Will Bind Function Call Based On Object Not Refernce

        //At Run Time 
        public override void fun02()
        {
            Console.WriteLine($"Type B is : A = {A}\nB = {B}");
        }
        
    }
}
