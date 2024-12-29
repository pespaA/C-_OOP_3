using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session3.InterfaceShape
{
    internal interface IShape
    {
        public int Area { get; set; }

        public void DisplayShapeInfo();
    }
}
