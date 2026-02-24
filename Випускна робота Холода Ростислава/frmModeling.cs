using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Випускна_робота_Холода_Ростислава
{
    public partial class frmModeling : Form
    {
        public frmModeling()
        {
            InitializeComponent();
        }

        Graphics gr;
        int gridSise = 10;
        double sise = 3;

        double delta;
        int n;
        double frequencyA;
        double frequencyB;
        int centerX;
        int centerY;
        double scale;
        double tStep;
        int pointsCount;
        int timerStep;
        PointF[] points;
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void system_koordinat()
        {
            // малюємо систему координат
            gr = pictureBox1.CreateGraphics();
            int x0 = pictureBox1.Width / 2;
            int y0 = pictureBox1.Width / 2;
            int stepX = x0 / (gridSise / 2);
            int stepY = y0 / (gridSise / 2);
            Pen pen_setka = new Pen(Brushes.LightBlue, 1);
            pen_setka.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            for (int i = 1; i <= gridSise / 2; i++)
            {
                gr.DrawLine(pen_setka, x0 + i * stepX, pictureBox1.Height, x0 + i * stepX, 0);
                gr.DrawLine(pen_setka, x0 - i * stepX, pictureBox1.Height, x0 - i * stepX, 0);
            }
            for (int i = 1; i <= gridSise / 2; i++)
            {
                gr.DrawLine(pen_setka, 0, y0 + i * stepY, pictureBox1.Width, y0 + i * stepY);
                gr.DrawLine(pen_setka, 0, y0 - i * stepY, pictureBox1.Width, y0 - i * stepY);
            }
            Pen pen_os = new Pen(Brushes.Blue, 1);
            pen_os.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            pen_os.StartCap = System.Drawing.Drawing2D.LineCap.Triangle;
            gr.DrawLine(pen_os, 0, pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height / 2);
            gr.DrawLine(pen_os, pictureBox1.Width / 2, pictureBox1.Height, pictureBox1.Width / 2, 0);

            Font MyFont = new Font("arial", 8, FontStyle.Regular);
            for (int i = 0; i <= gridSise / 2 - 1; i++)
            {
                int xi = i * pictureBox1.Width / gridSise;
                gr.DrawString(Convert.ToString(Math.Round(xi / scale, 2)), MyFont, Brushes.Blue, new Point(xi + pictureBox1.Width / 2, pictureBox1.Height / 2 + 5));
            }
            for (int i = 1; i <= gridSise / 2 - 1; i++)
            {
                int xi = - i * pictureBox1.Width / gridSise;
                gr.DrawString(Convert.ToString(Math.Round(xi / scale, 2)), MyFont, Brushes.Blue, new Point(xi + pictureBox1.Width / 2, pictureBox1.Height / 2 + 5));
            }
            for (int i = 1; i <= gridSise / 2 - 1; i++)
            {
                int yi = i * pictureBox1.Height / gridSise;
                gr.DrawString(Convert.ToString(Math.Round(yi / scale, 2)), MyFont, Brushes.Blue, new Point(pictureBox1.Width / 2 + 5, - yi + pictureBox1.Height / 2));
            }
            for (int i = 1; i <= gridSise / 2 - 1; i++)
            {
                int yi = - i * pictureBox1.Height / gridSise;
                gr.DrawString(Convert.ToString(Math.Round(yi / scale, 2)), MyFont, Brushes.Blue, new Point(pictureBox1.Width / 2 + 5, -yi + pictureBox1.Height / 2));
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                delta = Convert.ToDouble(textBox1.Text) * Math.PI / 180;
                frequencyA = Convert.ToDouble(textBox3.Text);
                frequencyB = Convert.ToDouble(textBox5.Text);

                pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);

                using (gr = Graphics.FromImage(pictureBox1.Image))
                {
                    gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    gr.Clear(Color.White);

                    int width = pictureBox1.Width;
                    int height = pictureBox1.Height;

                    centerX = width / 2;
                    centerY = height / 2;

                    scale = Math.Min(width, height) / sise;

                    tStep = 0.001;
                    pointsCount = (int)(2 * Math.PI / tStep);

                    points = new PointF[pointsCount];
                    
                    for (int i = 0; i < pointsCount; i++)
                    {
                        double t = i * tStep;
                        double x = Math.Sin(2 * Math.PI * frequencyA * t);
                        double y = Math.Sin(2 * Math.PI * frequencyB * t + delta);

                        points[i] = new PointF(
                            (float)(centerX + scale * x),
                            (float)(centerY - scale * y)
                        );
                    }

                    timerStep = 0;
                    timer1.Start();
                }

                pictureBox1.Refresh();
                system_koordinat();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerStep+=2;
            if (timerStep > pointsCount)
            {
                timerStep = pointsCount;
                timer1.Stop();
            }
            PointF[] subArray = new PointF[timerStep];
            Array.Copy(points, subArray, timerStep);
            
            gr.DrawLines(Pens.Blue, subArray);
         }

        private void button3_Click(object sender, EventArgs e)
        {
            gr = pictureBox1.CreateGraphics();
            gr.Clear(Color.White);
            if (gridSise < 50)
            {
                gridSise = gridSise + 2;
            }
            sise = Math.Round(sise * 1.5, 2);
            system_koordinat();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gr = pictureBox1.CreateGraphics();
            gr.Clear(Color.White);
            if (gridSise > 2)
            {
                gridSise = gridSise - 2;
            }
            sise = Math.Round(sise / 1.5, 2);
            system_koordinat();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
    }

