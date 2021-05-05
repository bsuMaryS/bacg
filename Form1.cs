using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        struct lines
        {
            public int x1;
            public int y1;
            public int x2;
            public int y2;
        }

        int i = 0;
        int n = 0;
        int xmin = 0;
        int ymin = 0;
        int xmax = 0;
        int ymax = 0;
        lines[] arrlines;
        string[] stats;
        Graphics g;

        float maxi(float[] arr, int k)
        {
            float m = 0;
            for (int o = 0; o < k; ++o)
                if (m < arr[o])
                    m = arr[o];
            return m;
        }

        float mini(float[] arr, int k)
        {
            float m = 1;
            for (int o = 0; o < k; ++o)
                if (m > arr[o])
                    m = arr[o];
            return m;
        }

        float x_intersect(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4)
        {
            float num = (x1 * y2 - y1 * x2) * (x3 - x4) - (x1 - x2) * (x3 * y4 - y3 * x4);
            float den = (x1 - x2) * (y3 - y4) - (y1 - y2) * (x3 - x4);
            return num / den;
        }

        float y_intersect(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4)
        {
            float num = (x1 * y2 - y1 * x2) * (y3 - y4) - (y1 - y2) * (x3 * y4 - y3 * x4);
            float den = (x1 - x2) * (y3 - y4) - (y1 - y2) * (x3 - x4);
            return num / den;
        }

        PointF[] suth(PointF[] polygon, int polysize, float x1, float y1, float x2, float y2)
        {
            int newpolysize = 0;
            PointF[] newpoly = new PointF[8];

            for (int o = 0; o < polysize; ++o)
            {
                int k = (o + 1) % polysize;
                float ix = polygon[o].X;
                float iy = polygon[o].Y;
                float kx = polygon[k].X;
                float ky = polygon[k].Y;
                float ipos = (x2 - x1) * (iy - y1) - (y2 - y1) * (ix - x1);
                float kpos = (x2 - x1) * (ky - y1) - (y2 - y1) * (kx - x1);

                if (ipos < 0 && kpos < 0)
                {
                    newpoly[newpolysize].X = kx;
                    newpoly[newpolysize].Y = ky;
                    newpolysize++;
                }

                else if (ipos >= 0 && kpos < 0)
                {
                    newpoly[newpolysize].X = x_intersect(x1, y1, x2, y2, ix, iy, kx, ky);
                    newpoly[newpolysize].Y = y_intersect(x1, y1, x2, y2, ix, iy, kx, ky);
                    newpolysize++;

                    newpoly[newpolysize].X = kx;
                    newpoly[newpolysize].Y = ky;
                    newpolysize++;
                }

                else if (ipos < 0 && kpos >= 0)
                {
                    newpoly[newpolysize].X = x_intersect(x1, y1, x2, y2, ix, iy, kx, ky);
                    newpoly[newpolysize].Y = y_intersect(x1, y1, x2, y2, ix, iy, kx, ky);
                    newpolysize++;
                }

                else
                {

                }

            }
            polysize = newpolysize;
            PointF[] ans = new PointF[polysize];
            for (int o = 0; o < polysize; ++o)
            {
                ans[o].X = newpoly[o].X;
                ans[o].Y = newpoly[o].Y;
            }

            return ans;
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (inXmin.Text == "" || inYmin.Text == "" || inXmax.Text == "" || inYmax.Text == "")
                MessageBox.Show("Неверно заданы координаты", "Ошибка");
            else
            {
                g = pictureBox1.CreateGraphics();
                g.Clear(Color.White);
                xmin = Convert.ToInt32(inXmin.Text);
                ymin = Convert.ToInt32(inYmin.Text);
                xmax = Convert.ToInt32(inXmax.Text);
                ymax = Convert.ToInt32(inYmax.Text);

                Brush myBrush = new SolidBrush(Color.LightCyan);
                g.FillRectangle(myBrush, xmin, ymin, xmax - xmin, ymax - ymin);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBoxN1.Text =="")
                MessageBox.Show("Ничего не введено", "Ошибка");
            else
            {
                n = Convert.ToInt32(textBoxN1.Text);
                arrlines = new lines[n];
                stats = new string[n];
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxN1.Text == "")
                MessageBox.Show("Не задано количество отрезков", "Ошибка");
            else if (inx1.Text == "" || iny1.Text == "" || inx2.Text == "" || iny2.Text == "")
                MessageBox.Show("Неверно заданы координаты", "Ошибка");
            else
            {
                if (i < n)
                {
                    arrlines[i].x1 = Convert.ToInt32(inx1.Text);
                    arrlines[i].y1 = Convert.ToInt32(iny1.Text);
                    arrlines[i].x2 = Convert.ToInt32(inx2.Text);
                    arrlines[i].y2 = Convert.ToInt32(iny2.Text);
                    inx1.Clear();
                    iny1.Clear();
                    inx2.Clear();
                    iny2.Clear();
                    Brush br = new SolidBrush(Color.Black);
                    Pen myPen = new Pen(br);
                    g.DrawLine(myPen, arrlines[i].x1, arrlines[i].y1, arrlines[i].x2, arrlines[i].y2);
                    i++;
                }
                if (i >= n)
                {
                    inx1.Clear();
                    iny1.Clear();
                    inx2.Clear();
                    iny2.Clear();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Brush brLB = new SolidBrush(Color.Red);
            Pen myPenLB = new Pen(brLB);
         
            for (int o = 0; o < n; ++o)
            {
                float[] posarr = new float[5];
                float[] negarr = new float[5];
                int posind = 1;
                int negind = 1;
                posarr[0] = 1;
                negarr[0] = 0;

                int p1 = -(arrlines[o].x2 - arrlines[o].x1);
                int p2 = -p1;
                int p3 = -(arrlines[o].y2 - arrlines[o].y1);
                int p4 = -p3;

                int q1 = arrlines[o].x1 - xmin;
                int q2 = xmax - arrlines[o].x1;
                int q3 = arrlines[o].y1 - ymin;
                int q4 = ymax - arrlines[o].y1;

                if ((p1 == 0 && q1 < 0) || (p3 == 0 && q3 < 0))
                    stats[o] = "Линия параллельна отсекающему окну";

                else
                {
                    if (p1 != 0)
                    {
                        float r1 = (float)q1 / (float)p1;
                        float r2 = (float)q2 / (float)p2;
                        if (p1 < 0)
                        {
                            negarr[negind++] = r1;
                            posarr[posind++] = r2;
                        }
                        else
                        {
                            negarr[negind++] = r2;
                            posarr[posind++] = r1;
                        }
                    }

                    if (p3 != 0)
                    {
                        float r3 = (float)q3 / (float)p3;
                        float r4 = (float)q4 / (float)p4;
                        if (p3 < 0)
                        {
                            negarr[negind++] = r3;
                            posarr[posind++] = r4;
                        }
                        else
                        {
                            negarr[negind++] = r4;
                            posarr[posind++] = r3;
                        }
                    }

                    float xn1, yn1, xn2, yn2;
                    float rn1, rn2;
                    rn1 = maxi(negarr, negind);
                    rn2 = mini(posarr, posind);

                    if (rn1 > rn2)
                    {
                        stats[o] = "Вне окна";
                    }
                    
                    else
                    {
                        xn1 = arrlines[o].x1 + p2 * rn1;
                        yn1 = arrlines[o].y1 + p4 * rn1;
                        xn2 = arrlines[o].x1 + p2 * rn2;
                        yn2 =arrlines[o].y1 + p4 * rn2;
                        if (xn1 <= xmax && xn2 <= xmax)
                        g.DrawLine(myPenLB, xn1, yn1, xn2, yn2);
                    }

                }

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            n = 0;
            i = 0;
            g.Clear(Color.White);
            xmin = 0;
            ymin = 0;
            xmax = 0;
            ymax = 0;
            inXmin.Clear();
            inYmin.Clear();
            inXmax.Clear();
            inYmax.Clear();
            textBoxN1.Clear();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBoxN2.Text == "")
                MessageBox.Show("Ничего не введено", "Ошибка");
            else
            {
                n = Convert.ToInt32(textBoxN2.Text);
                arrlines = new lines[n];
                stats = new string[n];
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (inXmin2.Text == "" || inYmin2.Text == "" || inXmax2.Text == "" || inYmax2.Text == "")
                MessageBox.Show("Неверно заданы координаты", "Ошибка");
            else
            {
                g = pictureBox1.CreateGraphics();
                g.Clear(Color.White);
                xmin = Convert.ToInt32(inXmin2.Text);
                ymin = Convert.ToInt32(inYmin2.Text);
                xmax = Convert.ToInt32(inXmax2.Text);
                ymax = Convert.ToInt32(inYmax2.Text);

                Brush myBrush = new SolidBrush(Color.LightCyan);
                g.FillRectangle(myBrush, xmin, ymin, xmax - xmin, ymax - ymin);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBoxN2.Text == "")
                MessageBox.Show("Не задано количество углов", "Ошибка");
            else if (polyx.Text == "" || polyy.Text == "")
                MessageBox.Show("Неверно заданы координаты", "Ошибка");
            else
            {
                if (i == 0)
                {
                    arrlines[i].x1 = Convert.ToInt32(polyx.Text);
                    arrlines[i].y1 = Convert.ToInt32(polyy.Text);
                    i++;
                }
                else if (i < n)
                {
                    arrlines[i].x1 = Convert.ToInt32(polyx.Text);
                    arrlines[i].y1 = Convert.ToInt32(polyy.Text);
                    arrlines[i - 1].x2 = arrlines[i].x1;
                    arrlines[i - 1].y2 = arrlines[i].y1;

                    Brush br = new SolidBrush(Color.Black);
                    Pen myPen = new Pen(br);
                    g.DrawLine(myPen, arrlines[i - 1].x1, arrlines[i - 1].y1, arrlines[i - 1].x2, arrlines[i - 1].y2);

                    if (i == n - 1)
                    {
                        arrlines[i].x2 = arrlines[0].x1;
                        arrlines[i].y2 = arrlines[0].x1;
                        g.DrawLine(myPen, arrlines[i].x1, arrlines[i].y1, arrlines[i].x2, arrlines[i].y2);
                    }
                    i++;


                }
                polyx.Clear();
                polyy.Clear();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            PointF[] polygon = new PointF[n];
            for (int o = 0; o < n; ++o)
             {
                 polygon[o].X = arrlines[o].x1;
                 polygon[o].Y = arrlines[o].y1;
             }
            

            PointF[] clipper = new PointF[4];
            clipper[0].X = xmin;
            clipper[0].Y = ymin;

            clipper[1].X = xmin;
            clipper[1].Y = ymax;
            
            clipper[2].X = xmax;
            clipper[2].Y = ymax;
            
            clipper[3].X = xmax;
            clipper[3].Y = ymin;

            PointF[][] polys = new PointF[5][];
            polys[0] = polygon;
            for (int o = 0; o < 4; ++o)
            {
                int k = (o + 1) % 4;
                polys[o+1] = suth(polys[o], polys[o].Length, clipper[o].X, clipper[o].Y, clipper[k].X, clipper[k].Y);
            }
            Brush myBrushPoly = new SolidBrush(Color.Red);
            if(polys[4].Length != 0)
                g.FillPolygon(myBrushPoly,polys[4]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            n = 0;
            i = 0;
            g.Clear(Color.White);
            xmin = 0;
            ymin = 0;
            xmax = 0;
            ymax = 0;
            inXmin2.Clear();
            inYmin2.Clear();
            inXmax2.Clear();
            inYmax2.Clear();
            textBoxN2.Clear();
        }

      
    }
}

