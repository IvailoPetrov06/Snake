﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Interfaces
{
    public interface IPosition
    {
        int X { get; set; }

        int Y { get; set; }

        bool Intersects(IPosition other);
    }
}
