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
        public static Form2 Instance;
        
        public Form2()
        {
            InitializeComponent();
            table = new Table();
            Instance = this;
        }
        Table table;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void setCordinates(IShape shape)
        {
            table.Add(shape, dataGridView1);
        }
    }
}
