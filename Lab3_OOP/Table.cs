using Lab3_OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_OOP
{
    internal class Table
    {
        private static Table instance;

        public static Table GetInstance() 
        {
            if (instance == null)
            {
                instance = new Table();
            }
            return instance;
        }

        public void Add(IShape shape, DataGridView dataGridView)
        {
            IData data = shape.getData();
            dataGridView.Rows.Add(data.Name, data.x1, data.y1, data.x2, data.y2);
        }

        public void Clear(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
        }
    }
}
