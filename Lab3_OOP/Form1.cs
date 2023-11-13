using System.Windows.Forms;

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
            toolBar = new DrawingToolbar(toolStrip);
            toolBar.AddButton("Button1", "Tag1");
            toolBar.ButtonClicked += (sender, tag) =>
            {
                MessageBox.Show("Button was clicked with tag" + tag);
            };
        }

        Bitmap bitmap;
        Graphics graphics;
        bool paint = false;
        int index;

        private Shape currectShape;
        DrawingToolbar toolBar;

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;

            switch (index)
            {
                case 1:
                    currectShape = new PointShape();
                    currectShape.FillColor = Color.Black;
                    break;
                case 2:
                    currectShape = new LineShape();
                    currectShape.getStart(e.X, e.Y);
                    currectShape.FillColor = Color.Black;
                    break;
                case 3:
                    currectShape = new RectangleShape();
                    currectShape.getStart(e.X, e.Y);
                    currectShape.FillColor = Color.Black;
                    break;
                case 4:
                    currectShape = new EllipseShape();
                    currectShape.getStart(e.X, e.Y);
                    currectShape.FillColor = Color.Green;
                    break;
            }
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            pic.Refresh();
            if (paint)
            {
                currectShape.refresh(e.X, e.Y);
            }
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            if (index != 0 && index <= 4)
            {
                currectShape.CircuitColor = Color.Black;
                currectShape.Draw(graphics, e);
            }
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (index == 2 && paint == true)
            {
                currectShape.CircuitColor = Color.Blue;
                currectShape.DrawCircuit(g);
            }
            if (index == 3 && paint == true)
            {
                currectShape.CircuitColor = Color.Blue;
                currectShape.DrawCircuit(g);
            }

            if (index == 4 && paint == true)
            {
                currectShape.CircuitColor = Color.Blue;
                currectShape.DrawCircuit(g);
            }
        }

        private void êðàïêàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void ë³í³ÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void ïðÿìîêóòíèêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void åë³ïñToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolBar.clear(graphics, pic);
        }
    }
}