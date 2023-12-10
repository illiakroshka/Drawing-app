using Lab4_OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_OOP
{
    internal abstract class Shape : IShape
    {
        public Color FillColor = Color.Black;
        public Color CircuitColor = Color.Blue;
        protected int cX, cY, sX, sY, x, y;

        public void refresh(int startX, int StartY)
        {
            x = startX;
            y = StartY;
            sX = x - cX;
            sY = y - cY;
        }

        public void getStart(int startX, int StartY)
        {
            cX = startX;
            cY = StartY;
        }

        public abstract void DrawCircuit(Graphics graphics);

        public abstract void Draw(Graphics graphics, MouseEventArgs e);

        public abstract IData getData();
    }
}
