﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session3.Binding
{
    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
        public void MyFun01()
        {
            Console.WriteLine("Iam Employee");
        }
        public virtual void MyFun02()
        {
            Console.WriteLine($"Employee :Id {Id} , Name : {Name} , Age : {Age}");
        }
    }
}
