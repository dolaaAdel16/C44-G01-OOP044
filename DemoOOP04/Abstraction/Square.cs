﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP04.Abstraction
{
    internal class Square :Shape
    {
        public override double perimeter
        {
            get
            {
                return Dim01 * 4;
            }
        }

        public override double GetArea()
        {
            return Dim01 * Dim01;
        }
    }
}
