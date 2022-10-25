using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZiminLab3
{
    public partial class Form1 : Form
    {
        ColorHSV colorHSV = new ColorHSV();
        public Form1()
        {
            InitializeComponent();
            textBoxCollorRed.Text = Properties.Settings.Default.textBoxColorRed.ToString();
            textBoxCollorGreen.Text = Properties.Settings.Default.textBoxColorGreen.ToString();
            textBoxCollorBlue.Text = Properties.Settings.Default.textBoxColorBlue.ToString();
            textBoxCollorSaturation.Text = Properties.Settings.Default.textBoxColorSaturation.ToString();
            textBoxCollorBrightness.Text = Properties.Settings.Default.textBoxColorBrightness.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonAddRed_Click(object sender, EventArgs e)
        {
            try
            {
                colorHSV.addColorRed(Convert.ToDouble(this.textBoxCollorRed.Text));
                DrawEllipse();
            }
            catch (Exception)
            {

                return;
            } 
        }
        private void buttonRemoveRed_Click(object sender, EventArgs e)
        {
            try
            { 
            colorHSV.RemoveColorRed(Convert.ToDouble(this.textBoxCollorRed.Text));
            DrawEllipse();
            }
            catch (Exception)
            {

                return;
            }
        }
        private void buttonAddGreen_Click(object sender, EventArgs e)
        {
            try
            {
                colorHSV.addColorGreen(Convert.ToDouble(this.textBoxCollorGreen.Text));
                DrawEllipse();
            }
            catch (Exception)
            {

                return;
            }
        }
        private void buttonRemoveGreen_Click(object sender, EventArgs e)
        {
            try
            {
                colorHSV.RemoveColorGreen(Convert.ToDouble(this.textBoxCollorGreen.Text));
                DrawEllipse();
            }
            catch (Exception)
            {

                return;
            }
        }
        private void buttonAddBlue_Click(object sender, EventArgs e)
        {
            try
            {
                colorHSV.addColorBlue(Convert.ToDouble(this.textBoxCollorBlue.Text));
                DrawEllipse();
            }
            catch (Exception)
            {

                return;
            }
        }
        private void buttonRemoveBlue_Click(object sender, EventArgs e)
        {
            try
            {
                colorHSV.RemoveColorBlue(Convert.ToDouble(this.textBoxCollorBlue.Text));
                DrawEllipse();
            }
            catch (Exception)
            {

                return;
            }
        }
        private void buttonAddSaturation_Click(object sender, EventArgs e)
        {
            try
            {
                colorHSV.addColorSaturation(Convert.ToDouble(this.textBoxCollorSaturation.Text));
                DrawEllipse();
            }
            catch (Exception)
            {

                return;
            }
        }
        private void buttonRemoveSaturation_Click(object sender, EventArgs e)
        {
            try
            {
                colorHSV.RemoveColorSaturation(Convert.ToDouble(this.textBoxCollorSaturation.Text));
                DrawEllipse();
            }
            catch (Exception)
            {

                return;
            }
        }
        private void buttonAddBrightness_Click(object sender, EventArgs e)
        {
            try
            {
                colorHSV.addColorBrightness(Convert.ToDouble(this.textBoxCollorBrightness.Text));
                DrawEllipse();
            }
            catch (Exception)
            {

                return;
            }
        }
        private void buttonRemoveBrightness_Click(object sender, EventArgs e)
        {
            try
            {
                colorHSV.RemoveColorBrightness(Convert.ToDouble(this.textBoxCollorBrightness.Text));
                DrawEllipse();
            }
            catch (Exception)
            {

                return;
            }
        }
        private void DrawEllipse()
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(colorHSV.ColorFromHSV());
            this.labelHue.Text = Math.Floor(colorHSV.getColorHue()).ToString();
            this.labelSaturation.Text = Math.Floor((colorHSV.getColorSaturation() * 100)).ToString();
            this.labelBrightness.Text = Math.Floor(colorHSV.getColorBrightness()).ToString();
            this.labelRed.Text = colorHSV.getColorRed().ToString();
            this.labelGreen.Text = colorHSV.getColorGreen().ToString();
            this.labelBlue.Text = colorHSV.getColorBlue().ToString();
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillEllipse(myBrush, new Rectangle(250, 150, 150, 150));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }

    
}
