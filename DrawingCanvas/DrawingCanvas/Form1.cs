using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseDrawing
{
    public partial class Form1 : Form
    {
        private bool isDrawing = false;
        private Point lastPoint;
        public Form1()
        {
            InitializeComponent();
        }

        private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            lastPoint = e.Location;
        }

        private void pnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = pnlCanvas.CreateGraphics())
                {
                    g.DrawLine(Pens.Black, lastPoint, e.Location);
                    lastPoint = e.Location;
                }
            }
        }

        private void pnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }
    }
}
