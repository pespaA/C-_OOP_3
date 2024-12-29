﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session3.Binding
{
    internal class PartTimeEmployee:Employee
    {
        public decimal HourRate { get; set; }
        public new void MyFun01()
        {
            Console.WriteLine("I am Part Time Employee");
        }
        public override void MyFun02()
        {
            Console.WriteLine($"Employee :Id {Id} , Name : {Name} , Age : {Age} , HourRate : {HourRate}");
        }
    }
}
