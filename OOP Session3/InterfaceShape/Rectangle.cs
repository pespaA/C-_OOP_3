using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session3.InterfaceShape
{
    internal class Rectangle : IRectangle
    {
        public int AreaRectangle { get ; set ; }
        public int Area { get ; set ; }

        public Rectangle(int _AreaRectangle)
        {
            AreaRectangle = _AreaRectangle;
            Area = _AreaRectangle*3;
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape Rectangle\nArea = {Area}\nAreaRectangle = {AreaRectangle}");
        }
    }
}
