using Lab4_OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_OOP
{
    public interface IShape
    {
        void refresh(int startZ, int StartY);
        void getStart(int startX, int StartY);
        void Draw(Graphics graphics, MouseEventArgs e);
        void DrawCircuit(Graphics graphics);
        IData getData();
    }
}
