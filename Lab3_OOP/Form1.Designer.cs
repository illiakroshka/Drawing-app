namespace Lab3_OOP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            contextMenuStrip1 = new ContextMenuStrip(components);
            файлToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem1 = new ToolStripMenuItem();
            обєктиToolStripMenuItem = new ToolStripMenuItem();
            крапкаToolStripMenuItem = new ToolStripMenuItem();
            лініяToolStripMenuItem = new ToolStripMenuItem();
            прямокутникToolStripMenuItem = new ToolStripMenuItem();
            еліпсToolStripMenuItem = new ToolStripMenuItem();
            TableToolStripMenuItem = new ToolStripMenuItem();
            pic = new PictureBox();
            toolStrip = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            toolStripButton7 = new ToolStripButton();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(114, 28);
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(113, 24);
            файлToolStripMenuItem.Text = "файл";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem1, обєктиToolStripMenuItem, TableToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(782, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem1
            // 
            файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            файлToolStripMenuItem1.Size = new Size(59, 24);
            файлToolStripMenuItem1.Text = "Файл";
            // 
            // обєктиToolStripMenuItem
            // 
            обєктиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { крапкаToolStripMenuItem, лініяToolStripMenuItem, прямокутникToolStripMenuItem, еліпсToolStripMenuItem });
            обєктиToolStripMenuItem.Name = "обєктиToolStripMenuItem";
            обєктиToolStripMenuItem.Size = new Size(75, 24);
            обєктиToolStripMenuItem.Text = "Об'єкти";
            // 
            // крапкаToolStripMenuItem
            // 
            крапкаToolStripMenuItem.Name = "крапкаToolStripMenuItem";
            крапкаToolStripMenuItem.Size = new Size(185, 26);
            крапкаToolStripMenuItem.Text = "Крапка";
            крапкаToolStripMenuItem.Click += крапкаToolStripMenuItem_Click;
            // 
            // лініяToolStripMenuItem
            // 
            лініяToolStripMenuItem.Name = "лініяToolStripMenuItem";
            лініяToolStripMenuItem.Size = new Size(185, 26);
            лініяToolStripMenuItem.Text = "Лінія ";
            лініяToolStripMenuItem.Click += лініяToolStripMenuItem_Click;
            // 
            // прямокутникToolStripMenuItem
            // 
            прямокутникToolStripMenuItem.Name = "прямокутникToolStripMenuItem";
            прямокутникToolStripMenuItem.Size = new Size(185, 26);
            прямокутникToolStripMenuItem.Text = "Прямокутник";
            прямокутникToolStripMenuItem.Click += прямокутникToolStripMenuItem_Click;
            // 
            // еліпсToolStripMenuItem
            // 
            еліпсToolStripMenuItem.Name = "еліпсToolStripMenuItem";
            еліпсToolStripMenuItem.Size = new Size(185, 26);
            еліпсToolStripMenuItem.Text = "Еліпс";
            еліпсToolStripMenuItem.Click += еліпсToolStripMenuItem_Click;
            // 
            // TableToolStripMenuItem
            // 
            TableToolStripMenuItem.Name = "TableToolStripMenuItem";
            TableToolStripMenuItem.Size = new Size(58, 24);
            TableToolStripMenuItem.Text = "Table";
            TableToolStripMenuItem.Click += TableToolStripMenuItem_Click;
            // 
            // pic
            // 
            pic.Location = new Point(12, 58);
            pic.Name = "pic";
            pic.Size = new Size(782, 476);
            pic.TabIndex = 2;
            pic.TabStop = false;
            pic.Paint += pic_Paint;
            pic.MouseDown += pic_MouseDown;
            pic.MouseMove += pic_MouseMove;
            pic.MouseUp += pic_MouseUp;
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4, toolStripButton5, toolStripButton6, toolStripButton7 });
            toolStrip.Location = new Point(0, 28);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(782, 27);
            toolStrip.TabIndex = 3;
            toolStrip.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "Очистити";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 24);
            toolStripButton2.Text = "Крапка";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(29, 24);
            toolStripButton3.Text = "Лінія";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(29, 24);
            toolStripButton4.Text = "Прямокутник";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(29, 24);
            toolStripButton5.Text = "Еліпс";
            toolStripButton5.Click += toolStripButton5_Click;
            // 
            // toolStripButton6
            // 
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(29, 24);
            toolStripButton6.Text = "Cube";
            toolStripButton6.Click += toolStripButton6_Click;
            // 
            // toolStripButton7
            // 
            toolStripButton7.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton7.Image = (Image)resources.GetObject("toolStripButton7.Image");
            toolStripButton7.ImageTransparentColor = Color.Magenta;
            toolStripButton7.Name = "toolStripButton7";
            toolStripButton7.Size = new Size(29, 24);
            toolStripButton7.Text = "Лінія з кружечками";
            toolStripButton7.Click += toolStripButton7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 503);
            Controls.Add(toolStrip);
            Controls.Add(pic);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem1;
        private ToolStripMenuItem обєктиToolStripMenuItem;
        private ToolStripMenuItem крапкаToolStripMenuItem;
        private ToolStripMenuItem лініяToolStripMenuItem;
        private ToolStripMenuItem прямокутникToolStripMenuItem;
        private ToolStripMenuItem еліпсToolStripMenuItem;
        private ToolStripMenuItem TableToolStripMenuItem;
        private PictureBox pic;
        private ToolStrip toolStrip;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private ToolStripButton toolStripButton7;
    }
}