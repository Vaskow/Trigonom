using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trigonom
{
    public partial class Form1 : Form
    {
        Bitmap rawCircle;
        Bitmap sinGraph;
        Bitmap cosGraph;
        Bitmap tanGraph;
        Bitmap cotGraph;

        const int mashX = 25;
        const int mashY = 100;
        const int mashXTan = 50;
        const int mashYTan = 75;
        Angle angle;
        public Form1()
        {
            InitializeComponent();
            rawCircle = new Bitmap(300, 300);
            Graphics gr = Graphics.FromImage(rawCircle);
            Pen myPen = new Pen(Color.DimGray, 5);
            gr.DrawEllipse(myPen, new Rectangle(10, 10, 280, 280));
            gr.DrawLine(myPen, new Point(150, 0), new Point(150, 300));
            gr.DrawLine(myPen, new Point(0, 150), new Point(300, 150));
            this.pbCircle.Image = rawCircle;

            this.lSin.Text = "";
            this.lCos.Text = "";
            this.lTan.Text = "";
            this.lCot.Text = "";

            /*  Рисуем синусы    */
            sinGraph = new Bitmap(502, 206);
            Graphics grSin = Graphics.FromImage(sinGraph);
            Angle forGraph = new Angle();
            for (int i = 0; i < 1440; i++)
            {
                forGraph.setDegree(i);
                grSin.DrawLine(myPen, new Point((int)(mashX * (forGraph.getRadians())), (103 + (int)(mashY * (Math.Sin(forGraph.getRadians()))))), new Point((int)(mashX * (forGraph.getRadians())) + 1, (103 + (int)(mashY * (Math.Sin(forGraph.getRadians()))))));
            }
            grSin.DrawLine(myPen, new Point(235, 0), new Point(235, 206));
            grSin.DrawLine(myPen, new Point(0, 103), new Point(502, 103));
            this.pbSin.Image = sinGraph;

            /*  Рисуем косинусы    */
            cosGraph = new Bitmap(502, 206);
            Graphics grCos = Graphics.FromImage(cosGraph);
            for (int i = 0; i < 1440; i++)
            {
                forGraph.setDegree(i);
                grCos.DrawLine(myPen, new Point((int)(mashX * (forGraph.getRadians())), (103 + (int)(mashY * (Math.Cos(forGraph.getRadians()))))), new Point((int)(mashX * (forGraph.getRadians())) + 1, (103 + (int)(mashY * (Math.Cos(forGraph.getRadians()))))));
            }
            grCos.DrawLine(myPen, new Point(235, 0), new Point(235, 206));
            grCos.DrawLine(myPen, new Point(0, 103), new Point(502, 103));
            this.pbCos.Image = cosGraph;

            /*  Рисуем тангенсы    */
            cotGraph = new Bitmap(502, 206);
            Graphics grCot = Graphics.FromImage(cotGraph);
            for (int i = 0; i < 1440; i++)
            {
                forGraph.setDegree(i);

                if (Math.Round(Math.Cos(forGraph.getRadians())) != 0)
                {
                    grCot.DrawLine(myPen, new Point((int)(mashXTan * (forGraph.getRadians())), (103 + (int)(mashYTan * (Math.Tan(forGraph.getRadians()))))), new Point((int)(mashXTan * (forGraph.getRadians())) + 1, (103 + (int)(mashYTan * (Math.Tan(forGraph.getRadians()))))));
                }
            }
            grCot.DrawLine(myPen, new Point(235, 0), new Point(235, 206));
            grCot.DrawLine(myPen, new Point(0, 103), new Point(502, 103));
            this.pbCot.Image = cotGraph;

            /*  Рисуем котангенсы    */

            tanGraph = new Bitmap(502, 206);
            Graphics grTan = Graphics.FromImage(tanGraph);
            for (int i = 0; i < 1440; i++)
            {
                forGraph.setDegree(i);

                if (Math.Round(Math.Sin(forGraph.getRadians())) != 0)
                {
                    grTan.DrawLine(myPen, new Point((int)(mashXTan * (forGraph.getRadians())), (103 + (int)(mashYTan * (1/Math.Tan(forGraph.getRadians()))))), new Point((int)(mashXTan * (forGraph.getRadians())) + 1, (103 + (int)(mashYTan * (1/Math.Tan(forGraph.getRadians()))))));
                }
            }
            grTan.DrawLine(myPen, new Point(235, 0), new Point(235, 206));
            grTan.DrawLine(myPen, new Point(0, 103), new Point(502, 103));
            this.pbTan.Image = tanGraph;


        }

        private void rbDegree_CheckedChanged(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Equals(""))
            {
                return;
            }

            angle = new Angle();
            
            if (rbDegree.Checked)
            {
                angle.setRadian(Double.Parse(this.textBox1.Text));
                this.textBox1.Text = angle.getDegree().ToString();
            }
            else
            {
                angle.setDegree(Double.Parse(this.textBox1.Text));
                this.textBox1.Text = angle.getRadians().ToString();
            }

            
        }

        private void pbCircle_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsDigit(number) == false)
            {
                e.Handled = true;
            }
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            angle = new Angle();
            if (rbDegree.Checked)
            {
                angle.setDegree(Double.Parse(this.textBox1.Text));
            }
            else
            {
                angle.setRadian(Double.Parse(this.textBox1.Text));
            }

            if (this.textBox1.Text.Equals(""))
            {
                return;
            }
            Point center = new Point(150, 150);
            Point notCenter = new Point((int)(150 + 145 * Math.Cos(angle.getRadians())), (int)(150 - 145 * Math.Sin(angle.getRadians())));

            Bitmap newLine = (Bitmap)rawCircle.Clone();
            Graphics gr = Graphics.FromImage(newLine);
            Pen myPen = new Pen(Color.Green, 3);
            gr.DrawLine(myPen, center, notCenter);
            this.pbCircle.Image = (Image) newLine;

            this.lSin.Text = Math.Round(Math.Sin(angle.getRadians()),8).ToString();
            this.lCos.Text = Math.Round(Math.Cos(angle.getRadians()),8).ToString();
            this.lTan.Text = (Math.Round(Math.Sin(angle.getRadians()),8) / Math.Round(Math.Cos(angle.getRadians()),8)).ToString();
            this.lCot.Text = Math.Round((1 / Math.Tan(angle.getRadians())),8).ToString();

            /*  Sin */
            Bitmap newSinLine = (Bitmap)sinGraph.Clone();
            Graphics grSin = Graphics.FromImage(newSinLine);
            Pen myPenSin = new Pen(Color.Green, 3);
            grSin.DrawLine(myPenSin, new Point(0, (int)(103+mashY * Math.Sin(angle.getRadians()))), new Point(502, (int)(103+mashY * Math.Sin(angle.getRadians()))));
            this.pbSin.Image = (Image)newSinLine;

            /*  Cos */
            Bitmap newCosLine = (Bitmap)cosGraph.Clone();
            Graphics grCos = Graphics.FromImage(newCosLine);
            grCos.DrawLine(myPenSin, new Point(0, (int)(103 + mashY * Math.Cos(angle.getRadians()))), new Point(502, (int)(103 + mashY * Math.Cos(angle.getRadians()))));
            this.pbCos.Image = (Image)newCosLine;

            /*  Tan */
            Bitmap newTanLine = (Bitmap)tanGraph.Clone();
            Graphics grTan = Graphics.FromImage(newTanLine);
            if (Math.Round(Math.Cos(angle.getRadians())) != 0)
            {
                grTan.DrawLine(myPenSin, new Point(0, (int)(103 + -mashYTan * Math.Tan(angle.getRadians()))), new Point(502, (int)(103 + -mashYTan * Math.Tan(angle.getRadians()))));
            }
            
            this.pbTan.Image = (Image)newTanLine;

            /*  Cot */
            Bitmap newCotLine = (Bitmap)cotGraph.Clone();
            Graphics grCot = Graphics.FromImage(newCotLine);
            if (Math.Round(Math.Sin(angle.getRadians())) != 0)
            {
                grCot.DrawLine(myPenSin, new Point(0, (int)(103 + -mashYTan * 1 / Math.Tan(angle.getRadians()))), new Point(502, (int)(103 + -mashYTan * 1 / Math.Tan(angle.getRadians()))));
            }

            this.pbCot.Image = (Image)newCotLine;
        }

        private void pbSin_Click(object sender, EventArgs e)
        {

        }
    }
}
