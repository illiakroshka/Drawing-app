using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_OOP
{
    internal class PointShape : Shape
    {
        private int pointSize = 5;

        public override void Draw(Graphics graphics, MouseEventArgs e)
        {
            int x = e.X - pointSize / 2;
            int y = e.Y - pointSize / 2;

            SolidBrush brush = new SolidBrush(FillColor);

            graphics.FillEllipse(brush, x, y, pointSize, pointSize);
        }
        public override void DrawCircuit(Graphics graphics)
        {

        }
    }
}
