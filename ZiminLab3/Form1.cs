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

            textBoxCollorHue.Text = Properties.Settings.Default.textBoxHue.ToString();
            textBoxCollorSaturation.Text = Properties.Settings.Default.textBoxSaturation.ToString();
            textBoxCollorBrightness.Text = Properties.Settings.Default.textBoxBrightness.ToString();
            textBoxCollorRed.Text = Properties.Settings.Default.textBoxRed.ToString();
            textBoxCollorGreen.Text = Properties.Settings.Default.textBoxGreen.ToString();
            textBoxCollorBlue.Text = Properties.Settings.Default.textBoxBlue.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void DrawEllipse()
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(colorHSV.ColorFromHSV());
            this.labelHue.Text = Math.Floor(colorHSV.getColorHue()).ToString();
            this.labelSaturation.Text = Math.Floor((colorHSV.getColorSaturation())).ToString();
            this.labelBrightness.Text = Math.Floor(colorHSV.getColorBrightness()).ToString();
            this.labelRed.Text = colorHSV.getColorRed().ToString();
            this.labelGreen.Text = colorHSV.getColorGreen().ToString();
            this.labelBlue.Text = colorHSV.getColorBlue().ToString();
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillEllipse(myBrush, new Rectangle(0, 200, 300, 300));
            myBrush.Dispose();
            formGraphics.Dispose();

            Properties.Settings.Default.textBoxHue = colorHSV.getColorHue();
            Properties.Settings.Default.textBoxSaturation = colorHSV.getColorSaturation();
            Properties.Settings.Default.textBoxBrightness = colorHSV.getColorBrightness();
            Properties.Settings.Default.textBoxRed = colorHSV.getColorRed();
            Properties.Settings.Default.textBoxGreen = colorHSV.getColorGreen();
            Properties.Settings.Default.textBoxBlue = colorHSV.getColorBlue();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddRGBtoHSV_Click(object sender, EventArgs e)
        {
            try
            {
                double red = double.Parse(this.textBoxCollorRed.Text);
                double green = double.Parse(this.textBoxCollorGreen.Text);
                double blue = double.Parse(this.textBoxCollorBlue.Text);
                colorHSV.addRGBparam(red, green, blue);

                double hue = double.Parse(this.textBoxCollorHue.Text);
                double saturation = double.Parse(this.textBoxCollorSaturation.Text);
                double brightness = double.Parse(this.textBoxCollorBrightness.Text);
                colorHSV.addHSVapam(hue, saturation, brightness);
            }
            catch (FormatException)
            {

                return;
            }
            

            colorHSV.addRGBToHSV();
            DrawEllipse();
        }

        private void buttonRemoveRGBfromHSV_Click(object sender, EventArgs e)
        {
            try
            {
                double red = double.Parse(this.textBoxCollorRed.Text);
                double green = double.Parse(this.textBoxCollorGreen.Text);
                double blue = double.Parse(this.textBoxCollorBlue.Text);
                colorHSV.addRGBparam(red, green, blue);

                double hue = double.Parse(this.textBoxCollorHue.Text);
                double saturation = double.Parse(this.textBoxCollorSaturation.Text);
                double brightness = double.Parse(this.textBoxCollorBrightness.Text);
                colorHSV.addHSVapam(hue, saturation, brightness);
            }
            catch (FormatException)
            {

                return;
            }
            

            colorHSV.removeRGBfromHSV();
            DrawEllipse();
        }
    }

    
}
