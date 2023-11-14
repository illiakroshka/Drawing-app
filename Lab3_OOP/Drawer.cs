using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_OOP
{
    internal class Drawer
    {
        public void drawerRefresh(IShape shape, int startX, int StartY)
        {
            shape.refresh(startX, StartY);
        }
        public void drawerGetStart(IShape shape, int startX, int StartY)
        {
            shape.getStart(startX, StartY);
        }
        public void Draw(IShape shape, Graphics graphics, MouseEventArgs e)
        {
            shape.Draw(graphics, e);
        }
        public void DrawCircuit(IShape shape, Graphics graphics)
        {
            shape.DrawCircuit(graphics);
        }
    }
}
