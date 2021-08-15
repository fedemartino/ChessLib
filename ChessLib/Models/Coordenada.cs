﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessLib.Models
{
    public class Coordenada
    {
        int x;
        int y;
        public Coordenada(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        { get { return this.x; } }

        public int Y
        { get { return this.y; } }
    }
}
