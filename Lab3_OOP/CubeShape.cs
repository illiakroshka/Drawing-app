using Lab4_OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace Lab3_OOP
{
    internal class CubeShape : IShape
    {
        private readonly IShape _shape1;
        private readonly IShape _shape2;
        private readonly ILineShape _shape3;
        private readonly ILineShape _shape4;
        private readonly ILineShape _shape5;
        private readonly ILineShape _shape6;
        private int starttX, starttY, endX, endY;

        private void setStart(int startX, int startY)
        {
            this.starttX = startX;
            this.starttY = startY;
        }

        private void setEnd(int endX, int endY)
        {
            this.endX = endX;
            this.endY = endY;
        }

        public CubeShape(IShape shape1, IShape shape2, ILineShape shape3, ILineShape shape4, ILineShape shape5, ILineShape shape6)
        {
            _shape1 = shape1; 
            _shape2 = shape2; 
            _shape3 = shape3; 
            _shape4 = shape4; 
            _shape5 = shape5; 
            _shape6 = shape6; 
        }

        public void getStart(int startX, int StartY)
        {
            _shape1.getStart(startX + 50, StartY + 50);
            _shape2.getStart(startX, StartY );
            _shape3.getStart(startX, StartY ); 
            setStart(startX, StartY );
        }
        public void Draw(Graphics graphics, MouseEventArgs e)
        {
            _shape1.Draw(graphics, e);
            _shape2.Draw(graphics, e);
            _shape3.getStart(starttX, starttY);
            _shape3.drawByCordinates(graphics, starttX + 50, starttY + 50);
            _shape4.getStart(e.X, e.Y);
            _shape4.drawByCordinates(graphics, e.X + 50, e.Y +50 );
            _shape5.getStart( starttX, e.Y);
            _shape5.drawByCordinates(graphics, starttX + 50, e.Y + 50);
            _shape6.getStart(e.X, starttY);
            _shape6.drawByCordinates(graphics, e.X + 50, starttY + 50);
            setEnd(e.X, e.Y);
        }
        public void DrawCircuit(Graphics graphics)
        {
            _shape1.DrawCircuit(graphics);
            _shape2.DrawCircuit(graphics);
            _shape3.DrawCircuit(graphics);
            _shape4.DrawCircuit(graphics);
            _shape5.DrawCircuit(graphics);
            _shape6.DrawCircuit(graphics);
        }
        public void refresh(int StartX, int StartY)
        {
            _shape1.refresh(StartX + 50, StartY + 50);
            _shape2.refresh(StartX, StartY);
            _shape3.refresh(starttX + 50, starttY + 50);
            _shape4.getStart(StartX, StartY);
            _shape4.refresh(StartX + 50, StartY + 50);
            _shape5.getStart(starttX, StartY);
            _shape5.refresh(starttX + 50, StartY + 50);
            _shape6.getStart(StartX, starttY);
            _shape6.refresh(StartX + 50, starttY + 50);
        }

        public IData getData()
        {
            return new Data("CubeShape", starttX, starttY, endX, endY);
        }
    }
}
