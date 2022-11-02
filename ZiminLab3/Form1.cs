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

        private void DrawRectangle()
        {
            int red = int.Parse(this.textBoxCollorRed.Text);
            int green = int.Parse(this.textBoxCollorGreen.Text);
            int blue = int.Parse(this.textBoxCollorBlue.Text);
            System.Drawing.SolidBrush finalBrush = new System.Drawing.SolidBrush(colorHSV.ColorFromHSV());
            System.Drawing.SolidBrush RGBrectangleBrush = new System.Drawing.SolidBrush(Color.FromArgb(255, red, green, blue));

            this.labelHue.Text = Math.Floor(colorHSV.getColorHue()).ToString();
            this.labelSaturation.Text = Math.Floor((colorHSV.getColorSaturation())).ToString();
            this.labelBrightness.Text = Math.Floor(colorHSV.getColorBrightness()).ToString();
            this.labelRed.Text = finalBrush.Color.R.ToString();
            this.labelGreen.Text = finalBrush.Color.G.ToString();
            this.labelBlue.Text = finalBrush.Color.B.ToString();

            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(RGBrectangleBrush, new Rectangle(300, 175, 50, 50));
            formGraphics.FillRectangle(finalBrush, new Rectangle(125, 100, 112, 100));

            RGBrectangleBrush.Dispose();
            finalBrush.Dispose();
            formGraphics.Dispose();

            Properties.Settings.Default.textBoxHue = double.Parse(this.textBoxCollorHue.Text);
            Properties.Settings.Default.textBoxSaturation = double.Parse(this.textBoxCollorSaturation.Text);
            Properties.Settings.Default.textBoxBrightness = double.Parse(this.textBoxCollorBrightness.Text);
            Properties.Settings.Default.textBoxRed = double.Parse(this.textBoxCollorRed.Text);
            Properties.Settings.Default.textBoxGreen = double.Parse(this.textBoxCollorGreen.Text);
            Properties.Settings.Default.textBoxBlue = double.Parse(this.textBoxCollorBlue.Text);
            Properties.Settings.Default.Save();
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

            System.Drawing.SolidBrush HSVrectangleBrush = new System.Drawing.SolidBrush(colorHSV.ColorFromHSV());
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(HSVrectangleBrush, new Rectangle(20, 175, 50, 50));
            HSVrectangleBrush.Dispose();
            formGraphics.Dispose();

            colorHSV.addRGBToHSV();
            DrawRectangle();
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

            System.Drawing.SolidBrush HSVrectangleBrush = new System.Drawing.SolidBrush(colorHSV.ColorFromHSV());
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(HSVrectangleBrush, new Rectangle(20, 175, 50, 50));
            HSVrectangleBrush.Dispose();
            formGraphics.Dispose();

            colorHSV.removeRGBfromHSV();
            DrawRectangle();
        }
    }

    
}
