using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_OOP
{
    internal class DrawingToolbar
    {
        private ToolStrip toolStrip;
        public event EventHandler<string> ButtonClicked;


        public DrawingToolbar(ToolStrip parentToolStrip)
        {
            toolStrip = parentToolStrip;
        }

        public void AddButton(string name, string tag)
        {
            ToolStripButton button = new ToolStripButton(name);
            button.Tag = tag;
            button.Click += Button_Click;
            toolStrip.Items.Add(button);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (ButtonClicked != null)
            {
                ToolStripButton button = sender as ToolStripButton;
                if (button != null)
                {
                    string buttonText = button.Text;
                    ButtonClicked(this, buttonText);
                }
            }
        }
        public void clear(Graphics graphics, PictureBox pic)
        {
            graphics.Clear(Color.White);
            pic.Refresh();
        }
    }
}
