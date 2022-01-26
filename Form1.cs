using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Grafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           Thread firverde = new Thread(() => desenez(Color.Green,150,50));
            firverde.Start();
        }

        private void desenez(Color culoare, int Rx, int Ry)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen creion = new Pen(culoare) ;
            Pen sterg = new Pen(Color.Black);
            int x1, y1,x2,y2,x3,y3,x4,y4,a1,b1,a2,b2,a3,b3,a4,b4;
            Double alpha;

            g.DrawEllipse(creion, 100, 200, 400, 200);

            for(alpha=-3.14;alpha<=3.14; alpha+=0.02)
            {
                x1 = (int)(300 + Rx * Math.Cos(alpha));
                y1 = (int)(300 + Ry * Math.Sin(alpha));
                x2 = (int)(300 + Rx * Math.Cos(alpha +1.6));
                y2 = (int)(300 + Ry * Math.Sin(alpha +1.6));
                x3 = (int)(300 + Rx * Math.Cos(alpha -1.6));
                y3 = (int)(300 + Ry * Math.Sin(alpha -1.6));
                x4 = (int)(300 + Rx * Math.Cos(alpha +3.2));
                y4 = (int)(300 + Ry * Math.Sin(alpha +3.2));

                a1 = (int)(300 + Rx * Math.Cos(alpha));
                b1 = (int)(200 + Ry * Math.Sin(alpha));
                a2 = (int)(300 + Rx * Math.Cos(alpha + 1.6));
                b2 = (int)(200 + Ry * Math.Sin(alpha + 1.6));
                a3 = (int)(300 + Rx * Math.Cos(alpha - 1.6));
                b3 = (int)(200 + Ry * Math.Sin(alpha - 1.6));
                a4 = (int)(300 + Rx * Math.Cos(alpha + 3.2));
                b4 = (int)(200 + Ry * Math.Sin(alpha + 3.2));

                g.DrawLine(creion, x1, y1, x2, y2);
                g.DrawLine(creion, x1, y1, x3, y3);
                g.DrawLine(creion, x2, y2, x4, y4);
                g.DrawLine(creion, x3, y3, x4, y4);
                g.DrawLine(creion, x1, y1, a1, b1);
                g.DrawLine(creion, x2, y2, a2, b2);
                g.DrawLine(creion, x3, y3, a3, b3);
                g.DrawLine(creion, a4, b4, x4, y4);

                g.DrawLine(creion, a1, b1, a2, b2);
                g.DrawLine(creion, a1, b1, a3, b3);
                g.DrawLine(creion, a2, b2, a4, b4);
                g.DrawLine(creion, a3, b3, a4, b4);

                Thread.Sleep(15);
                g.DrawLine(sterg, x1, y1, x2, y2);
                g.DrawLine(sterg, x1, y1, x3, y3);
                g.DrawLine(sterg, x2, y2, x4, y4);
                g.DrawLine(sterg, x3, y3, x4, y4);
                g.DrawLine(sterg, x1, y1, a1, b1);
                g.DrawLine(sterg, x2, y2, a2, b2);
                g.DrawLine(sterg, x3, y3, a3, b3);
                g.DrawLine(sterg, a4, b4, x4, y4);

                g.DrawLine(sterg, a1, b1, a2, b2);
                g.DrawLine(sterg, a1, b1, a3, b3);
                g.DrawLine(sterg, a2, b2, a4, b4);
                g.DrawLine(sterg, a3, b3, a4, b4);

                g.DrawEllipse(creion, 100, 200, 400, 200);
            }


        }
    }
}
