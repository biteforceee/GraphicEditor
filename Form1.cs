using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace GraphicEditor
{
    public partial class Form1 : Form
    {
        bool Edit = false;
        bool MousePressed = false;
        int pointCounter = 0;
        int size = 5;
        Color color = Color.Black;
        ShapeType shapeType = ShapeType.Line;
        CustomPoint first;
        Plex plex = new Plex();
        public Form1()
        {
            InitializeComponent();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
            }
        }

        private void sizeTextBox_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(label2.Text, out size);
        }

        private void Update(Graphics graphics)
        {
            graphics.Clear(Color.White);
            plex.Draw(graphics);
        }

        private void AddPoint(int x, int y)
        {
            Graphics graphics = GraphicPanel.CreateGraphics();
            CustomPoint point = new CustomPoint(pointCounter++.ToString(), x, y, size);
            point.FillColor = color;
            point.Draw(graphics);
            //label1.Text = label1.Text + "\n" + "Name= " + pointCounter.ToString() + "     X=" + x.ToString() + "     Y=" + y.ToString() + "     SIZE=" + size.ToString() + "     COLOR=" + color.ToString();
        }

        private void AddLine(CustomPoint left,CustomPoint right)
        {
            Graphics graphics=GraphicPanel.CreateGraphics();
            CustomLine line = new CustomLine(left,right);
            line.FillColor = color;
            line.Draw(graphics);
            if (shapeType == ShapeType.Plex)
            {
                plex.Add(line);
            }
        }
        
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            size = trackBar1.Value;
            label2.Text=size.ToString();
        }

        private void pOINTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.Point;
            label3.Text = "Type: " + shapeType.ToString();
        }

        private void lINEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.Line;
            label3.Text = "Type: " + shapeType.ToString();
        }

        private void pLEXToolStripMenuItem_Click(object sender, EventArgs e) {
            shapeType = ShapeType.Plex;
            label3.Text = "Type: " + shapeType.ToString();
        }

        void EditPoint(CustomPoint c, int localX, int localY)
        {
            if (!MousePressed)
            {
                c.Shift(
                Cursor.Position.X - c.X - localX,
                Cursor.Position.Y - c.Y - localY);
                Graphics graphics = GraphicPanel.CreateGraphics();
                graphics.Clear(Color.White);
                plex.Draw(graphics);
                Task.Delay(10).ContinueWith(t => EditPoint(c, localX, localY)); ;
            }
        }

        void EditPlex(int localX, int localY)
        {
            if (!MousePressed)
            {
                plex.Shift(
                Cursor.Position.X - localX,
                Cursor.Position.Y - localY);
                Graphics graphics = GraphicPanel.CreateGraphics();
                graphics.Clear(Color.White);
                plex.Draw(graphics);
                localX = Cursor.Position.X;
                localY = Cursor.Position.Y;
                Task.Delay(10).ContinueWith(t => EditPlex(localX, localY)); ;
            }
        }

        private void GraphicPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MousePressed= true;
                if (!Edit)
                {
                    Graphics graphics = GraphicPanel.CreateGraphics();
                    CustomPoint second = new CustomPoint($"A{pointCounter++}", e.X, e.Y, size);
                    switch (shapeType)
                    {
                        case ShapeType.Point:
                            AddPoint(e.X, e.Y);
                            return;
                        case ShapeType.Line:
                            AddLine(first, second);
                            return;
                        case ShapeType.Plex:
                            AddLine(first, second);
                            Update(graphics);
                            return;
                    }
                }
            }
        }

        private void GraphicPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                //first = new CustomPoint($"A{pointCounter++}", e.X, e.Y, size);
                //first.FillColor = color;
                MousePressed = false;
                if (!Edit)
                {
                    first = new CustomPoint($"A{pointCounter++}", e.X, e.Y, size);
                    first.FillColor = color;
                }
                else
                {
                    CustomPoint c;
                    c = plex.FindPoint(new CustomPoint($"A", e.X, e.Y, size));
                    if (c != null)
                    {
                        int localX = Cursor.Position.X - c.X;
                        int localY = Cursor.Position.Y - c.Y;
                        EditPoint(c, localX, localY);
                    }
                    else
                    {
                        int localX = Cursor.Position.X;
                        int localY = Cursor.Position.Y;
                        EditPlex(localX, localY);

                    }
                }
            }
        }

        private void GraphicPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (first != null)
            {
                // Переместить точку и элемент управления
                //first.X = e.X;
                //first.Y = e.Y;

                // Обновить отображение элемента управления
                Control control = this.Controls[this.Controls.Count - 1];
                control.Location = new Point(first.X, first.Y); // Установить позицию
            }
        }

        

        private void sAVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                string textPlex = plex.SaveToString();
                File.WriteAllText(filePath, textPlex);
            }
        }

        private void lOADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                plex = new Plex(File.ReadAllText(filePath));
                Graphics graphics = GraphicPanel.CreateGraphics();
                Update(graphics);
                first = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            plex = new Plex();
            pointCounter = 0;
            Graphics graphics = GraphicPanel.CreateGraphics();
            graphics.Clear(Color.White);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit = !(Edit);
            if (Edit)
            {
                button2.Text = "Cancel";
            }
            else
            {
                button2.Text = "Redact";
            }
        }

        private void rEDACTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit = !(Edit);
            if (Edit)
            {
                button2.Text = "Cancel";
                rEDACTToolStripMenuItem.Text= "CANCEL";
            }
            else
            {
                button2.Text = "Redact";
                rEDACTToolStripMenuItem.Text = "REDACT";
            }
        }

        private void cLEARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            plex = new Plex();
            pointCounter = 0;
            Graphics graphics = GraphicPanel.CreateGraphics();
            graphics.Clear(Color.White);
        }

        private void cHANGECOLORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
            }
        }
    }
}
