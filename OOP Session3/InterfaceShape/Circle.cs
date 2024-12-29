using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session3.InterfaceShape
{
    internal class Circle : ICircle
    {
        public int AreaCircle { get; set; }
        public int Area { get; set; }

        public Circle(int _AreaCircle)
        {
            AreaCircle = _AreaCircle;
            Area = _AreaCircle*2;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape Circle\nArea = {Area}\nAreaCircle = {AreaCircle}"); 
        }
    }
}
