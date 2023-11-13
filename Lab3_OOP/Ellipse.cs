using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_OOP
{
    internal class EllipseShape : Shape
    {
        public override void Draw(Graphics graphics, MouseEventArgs e)
        {
            sX = x - cX;
            sY = y - cY;
            int ix = cX - sX / 2;
            int iy = cY - sY / 2;
            SolidBrush brush = new SolidBrush(FillColor);
            graphics.FillEllipse(brush, ix, iy, sX, sY);
            Pen pen = new Pen(CircuitColor, 2);
            graphics.DrawEllipse(pen, ix, iy, sX, sY);
        }
        public override void DrawCircuit(Graphics graphics)
        {
            Pen pen = new Pen(CircuitColor, 2);
            sX = x - cX;
            sY = y - cY;
            int ix = cX - sX / 2;
            int iy = cY - sY / 2;
            graphics.DrawEllipse(pen, ix, iy, sX, sY);
        }
    }
}
