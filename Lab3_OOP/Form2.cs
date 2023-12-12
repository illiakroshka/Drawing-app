using Lab3_OOP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_OOP
{
    public partial class Form2 : Form
    {
        public DataGridView dataGridView;

        public Form2()
        {
            InitializeComponent();
            table = Table.GetInstance();
            dataGridView = this.dataGridView1;
        }
        Table table;

        public void setCordinates(IShape shape)
        {
            table.Add(shape, dataGridView);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
