using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_OOP
{
    internal interface ILineShape: IShape
    {
        void drawByCordinates(Graphics graphics,int x, int y);
    }
}
