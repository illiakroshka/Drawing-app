using Lab4_OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_OOP
{
    internal class EllipseShape : Shape, IEllipse
    {
        protected void setColor(Color fillColor, Color circuitColor)
        {
            FillColor = fillColor;
            CircuitColor = circuitColor;
        }

        public override void Draw(Graphics graphics, MouseEventArgs e)
        {
            setColor(Color.Green, Color.Black);
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
            setColor(Color.Green, Color.Blue);
            Pen pen = new Pen(CircuitColor, 2);
            sX = x - cX;
            sY = y - cY;
            int ix = cX - sX / 2;
            int iy = cY - sY / 2;
            graphics.DrawEllipse(pen, ix, iy, sX, sY);
        }

        public void drawByCordinates(Graphics graphics, int x, int y)
        {
            setColor(Color.Green, Color.Blue);
 
            int ix = x - 20;
            int iy = y - 20;
            Pen pen = new Pen(CircuitColor, 2);
            graphics.DrawEllipse(pen, ix, iy, 40, 40);
        }

        public override IData getData()
        {
            return new Data("Ellipse", cX, cY, x, y);
        }
    }
}
