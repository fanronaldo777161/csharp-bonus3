using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bonustask3
{
    public partial class Form1 : Form
    {
        RectangleSimulator sim = new RectangleSimulator();

        public Form1()
        {
            InitializeComponent();
            pb.Paint += pb_Paint;
            btnAdd.Click += btnAdd_Click;
            btnTurn.Click += btnTurn_Click;
            btnMove.Click += btnMove_Click;
            btnScale.Click += btnScale_Click;
            btnClear.Click += btnClear_Click;
        }
        //  обновить список и перерисовать картинку
        private void updateUI()
        {
            lb.Items.Clear();
            var ls = sim.getList();
            for (int i = 0; i < ls.Count; i++)
            {
                lb.Items.Add($"[{i}] " + ls[i].ToString());
            }
            pb.Invalidate();
        }

        // рисует
        private void pb_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.TranslateTransform(pb.Width / 2, pb.Height / 2);

            var ls = sim.getList();
            foreach (var r in ls)
            {
                var pts = new PointF[4];
                for (int i = 0; i < 4; i++)
                {
                    pts[i] = new PointF((float)r.points[i].x * 10, (float)r.points[i].y * 10);
                }

                g.DrawPolygon(Pens.Black, pts);
                float cx = (float)r.center.x * 10;
                float cy = (float)r.center.y * 10;
                g.FillEllipse(Brushes.Red, cx - 2, cy - 2, 4, 4);
            }
        }

        //  Добавить фигуры 
        private void btnAdd_Click(object sender, EventArgs e)
        {

            var p1 = new Point(-10, -5);
            var p2 = new Point(-10, 5);
            var p3 = new Point(5, 5);
            var p4 = new Point(5, -5);
            var r1 = new Rectangle(new Point[] { p1, p2, p3, p4 });

            var p5 = new Point(-15, -20);
            var p6 = new Point(-15, -10);
            var p7 = new Point(-5, -10);
            var p8 = new Point(-5, -20);
            var r2 = new Rectangle(new Point[] { p5, p6, p7, p8 });

            sim.addRectangle(r1);
            sim.addRectangle(r2);

            updateUI();
        }

        // Поворот [0] на 90
        private void btnTurn_Click(object sender, EventArgs e)
        {
            if (sim.getList().Count > 0)
            {
                sim.turnrecon(0, 90);
                updateUI();
            }
        }

        // Сдвиг [0]
        private void btnMove_Click(object sender, EventArgs e)
        {
            if (sim.getList().Count > 0)
            {
                sim.moverecon(0, 2, 3);
                updateUI();
            }
        }

        // Масштаб [1]
        private void btnScale_Click(object sender, EventArgs e)
        {
            if (sim.getList().Count > 1)
            {
                sim.powonxyrecon(1, 2, 0.5);
                updateUI();
            }
        }

        // Очистить всё
        private void btnClear_Click(object sender, EventArgs e)
        {
            while (sim.getList().Count > 0)
            {
                sim.removeRectangle(0);
            }
            updateUI();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

        }
    }
}
