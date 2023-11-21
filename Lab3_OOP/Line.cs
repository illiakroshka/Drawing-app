﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_OOP
{
    internal class LineShape : Shape, ILineShape
    {
        public override void Draw(Graphics graphics, MouseEventArgs e)
        {
            Pen pen = new Pen(FillColor, 2);
            graphics.DrawLine(pen, cX, cY, e.X, e.Y);
        }
        public void drawByCordinates(Graphics graphics, int x, int y)
        {
            Pen pen = new Pen(FillColor, 2);
            graphics.DrawLine(pen, cX, cY, x, y);
        }
        public override void DrawCircuit(Graphics graphics)
        {
            Pen pen = new Pen(CircuitColor, 2);
            graphics.DrawLine(pen, cX, cY, x, y);
        }
    }
}
