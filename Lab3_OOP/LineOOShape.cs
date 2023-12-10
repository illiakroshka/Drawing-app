using Lab4_OOP;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_OOP
{
    internal class LineOOShape : IShape
    {
        private readonly IEllipse _shape2;
        private readonly ILineShape _shape1;
        private readonly IEllipse _shape3;

        protected int startX, startY, endX, endY;
        private void setStart(int startX, int startY)
        {
            this.startX = startX;
            this.startY = startY;
        }
        private void setEnd(int startX, int startY)
        {
            this.endX = startX;
            this.endY = startY;
        }

        public LineOOShape(ILineShape shape1, IEllipse shape2, IEllipse shape3)
        {
            _shape1 = shape1; // Line
            _shape2 = shape2; // Elipse
            _shape3 = shape3; // Elipse 
        }
        public void getStart(int startX, int StartY)
        {
            setStart(startX, StartY);
            _shape1.getStart(startX, StartY);
        }
        public void Draw(Graphics graphics, MouseEventArgs e)
        {
            _shape2.drawByCordinates(graphics, startX, startY);
            _shape1.drawByCordinates(graphics, e.X, e.Y);
            _shape3.drawByCordinates(graphics, e.X, e.Y);

        }
        public void refresh(int startX, int StartY)
        {
            _shape1.refresh(startX, StartY);
            setEnd(startX, StartY);
        }
        public void DrawCircuit(Graphics graphics)
        {
            _shape2.drawByCordinates(graphics, startX, startY);
            _shape1.DrawCircuit(graphics);
            _shape3.drawByCordinates(graphics, endX, endY);
        }
        public IData getData()
        {
            return new Data("LineOOShape", startX,startY, endX, endY);
        }
    }
}
