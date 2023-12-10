using Lab4_OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_OOP
{
    internal class RectangleShape : Shape
    {
        public override void Draw(Graphics graphics, MouseEventArgs e)
        {
            sX = x - cX;
            sY = y - cY;
            Pen pen = new Pen(FillColor, 2);
            graphics.DrawRectangle(pen, new Rectangle(cX, cY, sX, sY));
        }
        public override void DrawCircuit(Graphics graphics)
        {
            sX = x - cX;
            sY = y - cY;
            Pen pen = new Pen(CircuitColor, 2);
            graphics.DrawRectangle(pen, cX, cY, sX, sY);
        }

        public override IData getData()
        {
            return new Data("Rectangle", cX, cY, x, y);
        }
    }
}
