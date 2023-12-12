using Lab4_OOP;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using System.IO;

namespace Lab3_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pic.Width, pic.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            pic.Image = bitmap;
            drawer = new Drawer();
            toolBar = new DrawingToolbar(toolStrip);
            f2 = new Form2();
            table = Table.GetInstance();
            fileManager = new FileManager();
        }

        Form2 f2;
        Bitmap bitmap;
        Graphics graphics;
        Drawer drawer;
        DrawingToolbar toolBar;
        Table table;
        FileManager fileManager;
        bool paint = false;
        private IShape currectShape;
        IShape[] shapes = { new PointShape(), new LineShape(), new RectangleShape(), new EllipseShape(), new CubeShape(new RectangleShape(), new RectangleShape(), new LineShape(), new LineShape(), new LineShape(), new LineShape()), new LineOOShape(new LineShape(), new EllipseShape(), new EllipseShape()) };

        private void selectShape(IShape shape)
        {
            currectShape = shape;
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            if (currectShape != null)
            {
                paint = true;
                drawer.drawerGetStart(currectShape, e.X, e.Y);
            }
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            pic.Refresh();
            if (paint)
            {
                drawer.drawerRefresh(currectShape, e.X, e.Y);
            }
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                paint = false;
                drawer.Draw(currectShape, graphics, e);
                f2.setCordinates(currectShape);

            }
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (paint)
            {
                drawer.DrawCircuit(currectShape, g);
            }
        }

        private void êðàïêàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectShape(shapes[0]);
        }

        private void ë³í³ÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectShape(shapes[1]);
        }

        private void ïðÿìîêóòíèêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectShape(shapes[2]);
        }

        private void åë³ïñToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectShape(shapes[3]);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            selectShape(shapes[0]);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            selectShape(shapes[1]);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            selectShape(shapes[2]);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            selectShape(shapes[3]);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            selectShape(shapes[4]);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            selectShape(shapes[5]);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolBar.clear(graphics, pic);
            table.Clear(f2.dataGridView);
        }

        private void TableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2.Show();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                fileManager.SaveDataToTxtFile(openFileDialog.FileName, f2.dataGridView);
            }
            else
            {
                MessageBox.Show("You didn't select the file");
            }
        }
    }
}