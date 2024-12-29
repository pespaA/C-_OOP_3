using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session3
{
    internal interface IMyType
    {
        // Defult Access Modifier Inside The Interface Public 
        // What we can Write Inside The Interface
        // 1- Signature For Property
        public int Salary { get; set; }
        
        // 2- Signature For Method
        public void Myfun();

        //3- Default Implemented Method
        public void Print()
        {
            Console.WriteLine("Heloo I am Default Implemented Method");
        }
    }
}
