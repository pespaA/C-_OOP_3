﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session3.InterfaceShape
{
    internal interface IRectangle: IShape
    {
        public int AreaRectangle { get; set; }
    }
}
