using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colors
{
    struct XYZ
    {
        public double x;
        public double y;
        public double z;
    }
    struct Lab
    {
        public double l;
        public double a;
        public double b;
    }
    struct HSL
    {
        public double h;
        public double s;
        public double l;
    }
    struct RGB
    {
        public double r;
        public double g;
        public double b;
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            colorDialog1.FullOpen = true;
            colorDialog1.Color = this.BackColor;
            trackBarH.Scroll += trackBarH_Scroll;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        double Fxtol(double x)
        {
            double ans;
            if (x >= 0.008856)
                ans = Math.Pow(x, 1 / 3.0);
            else ans = 7.787 * x + 16 / 116.0;
            return ans;
        }
        double Fltox(double x)
        {
            double ans;
            if (Math.Pow(x, 3) >= 0.008856)
                ans = Math.Pow(x, 3);
            else ans = (x - 16 / 116.0) / 7.787;
            return ans;
        }
        double Fxtor(double x)
        {
            double ans;
            if (x >= 0.0031308)
                ans = 1.055 * Math.Pow(x, 1 / 2.4) - 0.055;
            else ans = 12.92 * x;
            return ans;
        }
        double Frtox(double x)
        {
            double ans;
            if (x >= 0.04045)
                ans = Math.Pow((x + 0.055) / 1.055, 2.4);
            else ans = x / 12.92;
            return ans;
        }

        private Lab xtol(XYZ color)
        {
            Lab ans;
            ans.l = 116 * Fxtol(color.y / 100.0) - 16;
            ans.a = 500 * (Fxtol(color.x / 95.057) - Fxtol(color.y / 100.0));
            ans.b = 200 * (Fxtol(color.y / 100.0) - Fxtol(color.z / 108.883));
            return ans;
        }
        private XYZ ltox(Lab color)
        {
            XYZ ans;
            ans.x = Fltox(color.a / 500.0 + (color.l + 16) / 116.0) * 95.047;
            ans.y = Fltox((color.l + 16) / 116.0) * 100;
            ans.z = Fltox((color.l + 16) / 116.0 - color.b / 200.0) * 108.883;
            return ans;
        }
        private RGB xtor(XYZ color)
        {
            RGB ans;
            ans.r = Fxtor((3.2406 * color.x - 1.5372 * color.y - 0.4986 * color.z) * 0.01) * 255;
            ans.g = Fxtor((-0.9689 * color.x + 1.8758 * color.y + 0.0415 * color.z) * 0.01) * 255;
            ans.b = Fxtor((0.0557 * color.x - 0.2040 * color.y + 1.0570 * color.z) * 0.01) * 255;
            if (ans.r < 0 || ans.r>=256) ans.r = 0;
            if (ans.g < 0|| ans.g>=256) ans.g = 0;
            if (ans.b < 0||ans.b>=256) ans.b = 0;
            return ans;
        }
        private XYZ rtox(RGB color)
        {
            XYZ ans;
            ans.x = (0.412453 * Frtox(color.r / 255.0) + 0.357580 * Frtox(color.g / 255.0) + 0.180423 * Frtox(color.b / 255.0)) * 100;
            ans.y = (0.212671 * Frtox(color.r / 255.0) + 0.715160 * Frtox(color.g / 255.0) + 0.072169 * Frtox(color.b / 255.0)) * 100;
            ans.z = (0.019334 * Frtox(color.r / 255.0) + 0.119193 * Frtox(color.g / 255.0) + 0.950227 * Frtox(color.b / 255.0)) * 100;
            return ans;
        }
        private HSL rtoh(RGB color)
        {
            HSL ans;
            ans.h = 0;
            double cmax = Math.Max(Math.Max(color.r / 255.0, color.g / 255.0), color.b / 255.0);
            double cmin = Math.Min(Math.Min(color.r / 255.0, color.g / 255.0), color.b / 255.0);
            double delta = cmax - cmin;
            if (delta == 0) ans.h = 0;
            if (cmax == color.r / 255.0) ans.h = 60 * (((color.g - color.b) / (255 * delta))% 6.0);
            if (cmax == color.g / 255.0) ans.h = 60 * ((color.b - color.r) / (delta * 255) + 2);
            if (cmax == color.b / 255.0) ans.h = 60 * ((color.r - color.g) / (delta * 255) + 4);
            ans.l = 100 * (cmax + cmin) / 2;
            ans.s = 100 * delta / (1 - Math.Abs(0.02 * ans.l - 1));
            return ans;
        }
        private RGB htor(HSL color)
        {
            RGB ans;
            double m, c, x, r, g, b;
            c = (1 - Math.Abs(2 * color.l / 100.0 - 1)) * color.s / 100.0;
            x = c * (1 - Math.Abs((color.h / 60.0)% 2 - 1));
            m = color.l / 100.0 - c / 2.0;
            if (color.h >= 0 && color.h < 60)
            {
                r = c;
                g = x;
                b = 0;
            }
            else if (color.h >= 60 && color.h < 120)
            {
                r = x;
                g = c;
                b = 0;
            }
            else if (color.h >= 120 && color.h < 180)
            {
                r = 0;
                g = c;
                b = x;
            }
            else if (color.h >= 180 && color.h < 240)
            {
                r = 0;
                g = x;
                b = c;
            }
            else if (color.h >= 240 && color.h < 300)
            {
                r = x;
                g = 0;
                b = c;
            }
            else
            {
                r = c;
                g = 0;
                b = x;
            }
            ans.r = (r + m) * 255;
            ans.g = (g + m) * 255;
            ans.b = (b + m) * 255;
            return ans;
        }
        private void paint(RGB color)
        {
            pictureBox1.BackColor = Color.FromArgb((int)color.r, (int)color.g, (int)color.b);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            XYZ color;
            color.x = Convert.ToDouble(numX.Text);
            color.y = Convert.ToDouble(numY.Text);
            color.z = Convert.ToDouble(numZ.Text);
            RGB r = xtor(color);
            Lab l = xtol(color);
            HSL h = rtoh(r);
            numL.Text = l.l.ToString();
            numA.Text = l.a.ToString();
            numB.Text = l.b.ToString();

            numH.Text = h.h.ToString();
            numS.Text = h.s.ToString();
            numHSL.Text = h.l.ToString();

            

            trackBarH.Value = (int)Convert.ToDouble(numH.Text);
            trackBarS.Value = (int)Convert.ToDouble(numS.Text);
            trackBarHSL.Value = (int)Convert.ToDouble(numHSL.Text);

            paint(r);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab color;
            color.l = Convert.ToDouble(numL.Text);
            color.a = Convert.ToDouble(numA.Text);
            color.b = Convert.ToDouble(numB.Text);
            XYZ x = ltox(color);
            RGB r = xtor(x);
            HSL h = rtoh(r);

            numX.Text = x.x.ToString();
            numY.Text = x.y.ToString();
            numZ.Text = x.z.ToString();

            numH.Text = h.h.ToString();
            numS.Text = h.s.ToString();
            numHSL.Text = h.l.ToString();

            
            trackBarH.Value = (int)Convert.ToDouble(numH.Text);
            trackBarS.Value = (int)Convert.ToDouble(numS.Text);
            trackBarHSL.Value = (int)Convert.ToDouble(numHSL.Text);


            paint(r);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HSL color;
            color.h = Convert.ToDouble(numH.Text);
            color.s = Convert.ToDouble(numS.Text);
            color.l = Convert.ToDouble(numHSL.Text);

            RGB r = htor(color);
            XYZ x = rtox(r);
            Lab l = xtol(x);

            numX.Text = x.x.ToString();
            numY.Text = x.y.ToString();
            numZ.Text = x.z.ToString();

            numL.Text = l.l.ToString();
            numA.Text = l.a.ToString();
            numB.Text = l.b.ToString();

           

            trackBarH.Value = (int)Convert.ToDouble(numH.Text);
            trackBarS.Value = (int)Convert.ToDouble(numS.Text);
            trackBarHSL.Value = (int)Convert.ToDouble(numHSL.Text);

            paint(r);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            pictureBox1.BackColor = colorDialog1.Color;
            RGB r;
            XYZ x;
            Lab l;
            HSL h;
            r.r = colorDialog1.Color.R;
            r.g = colorDialog1.Color.G;
            r.b = colorDialog1.Color.B;
            x = rtox(r);
            l = xtol(x);
            h = rtoh(r);

            numX.Text = x.x.ToString();
            numY.Text = x.y.ToString();
            numZ.Text = x.z.ToString();

            numL.Text = l.l.ToString();
            numA.Text = l.a.ToString();
            numB.Text = l.b.ToString();

            numH.Text = h.h.ToString();
            numS.Text = h.s.ToString();
            numHSL.Text = h.l.ToString();

           

            trackBarH.Value = (int)Convert.ToDouble(numH.Text);
            trackBarS.Value = (int)Convert.ToDouble(numS.Text);
            trackBarHSL.Value = (int)Convert.ToDouble(numHSL.Text);
        }

        private void trackBarH_Scroll(object sender, EventArgs e)
        {
            numH.Text = trackBarH.Value.ToString();
            HSL color;
            color.h = Convert.ToDouble(numH.Text);
            color.s = Convert.ToDouble(numS.Text);
            color.l = Convert.ToDouble(numHSL.Text);

            RGB r = htor(color);
            XYZ x = rtox(r);
            Lab l = xtol(x);

            numX.Text = x.x.ToString();
            numY.Text = x.y.ToString();
            numZ.Text = x.z.ToString();

            numL.Text = l.l.ToString();
            numA.Text = l.a.ToString();
            numB.Text = l.b.ToString();

            paint(r);
        }

        private void trackBarS_Scroll(object sender, EventArgs e)
        {
            numS.Text = trackBarS.Value.ToString();
            HSL color;
            color.h = Convert.ToDouble(numH.Text);
            color.s = Convert.ToDouble(numS.Text);
            color.l = Convert.ToDouble(numHSL.Text);

            RGB r = htor(color);
            XYZ x = rtox(r);
            Lab l = xtol(x);

            numX.Text = x.x.ToString();
            numY.Text = x.y.ToString();
            numZ.Text = x.z.ToString();

            numL.Text = l.l.ToString();
            numA.Text = l.a.ToString();
            numB.Text = l.b.ToString();

            paint(r);
        }

        private void trackBarHSL_Scroll(object sender, EventArgs e)
        {
            numHSL.Text = trackBarHSL.Value.ToString();
            HSL color;
            color.h = Convert.ToDouble(numH.Text);
            color.s = Convert.ToDouble(numS.Text);
            color.l = Convert.ToDouble(numHSL.Text);

            RGB r = htor(color);
            XYZ x = rtox(r);
            Lab l = xtol(x);

            numX.Text = x.x.ToString();
            numY.Text = x.y.ToString();
            numZ.Text = x.z.ToString();

            numL.Text = l.l.ToString();
            numA.Text = l.a.ToString();
            numB.Text = l.b.ToString();

            paint(r);
        }

        
    }
}
