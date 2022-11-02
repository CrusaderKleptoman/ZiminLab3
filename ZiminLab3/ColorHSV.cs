using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiminLab3
{
    public class ColorHSV
    {

        private double colorHue;
        private double colorRed;
        private double colorGreen;
        private double colorBlue;
        private double colorSaturation;
        private double colorBrightness;

        public ColorHSV()
        {
            this.colorHue = 0;
            this.colorRed = 0;
            this.colorGreen = 0;
            this.colorBlue = 0;
            this.colorSaturation = 0;
            this.colorBrightness = 0;
        }

        public void addHSVapam(double hue, double saturation, double brightness)
        {
            this.colorHue = hue;
            if (this.colorHue > 360) { this.colorHue = 360; }
            if (this.colorHue < 0) { this.colorHue = 0; }
            this.colorSaturation = saturation;
            if (this.colorSaturation > 100) { this.colorSaturation = 100; }
            if (this.colorSaturation < 0) { this.colorSaturation = 0; }
            this.colorBrightness = brightness;
            if (this.colorBrightness > 100) { this.colorBrightness = 100; }
            if (this.colorBrightness < 0) { this.colorBrightness = 0; }
        }

        public void addRGBparam(double red, double green, double blue)
        {
            this.colorRed = red;
            if (this.colorRed > 255) { this.colorRed = 255; }
            if (this.colorRed < 0) { this.colorRed = 0; }
            this.colorGreen = green;
            if (this.colorGreen > 255) { this.colorGreen = 255; }
            if (this.colorGreen < 0) { this.colorGreen = 0; }
            this.colorBlue = blue;
            if (this.colorBlue > 255) { this.colorBlue = 255; }
            if (this.colorBlue < 0) { this.colorBlue = 0; }
        }
        public void addRGBToHSV()
        {
            this.colorHue += getHueFromRGB();
            if (this.colorHue > 360) { this.colorHue = 360; }
            this.colorSaturation += getSaturationFromRGB();
            if (this.colorSaturation > 100) { this.colorSaturation = 100; }
            this.colorBrightness += getBrightnessFromRGB();
            if (this.colorBrightness > 100) { this.colorBrightness = 100; }
        }
        public void removeRGBfromHSV()
        {
            this.colorHue -= getHueFromRGB();
            if (this.colorHue < 0) { this.colorHue = 0; }
            this.colorSaturation -= getSaturationFromRGB();
            if (this.colorSaturation < 0) { this.colorSaturation = 0; }
            this.colorBrightness -= getBrightnessFromRGB();
            if (this.colorBrightness < 0) { this.colorBrightness = 0; }
        }
        public double getColorHue() { return this.colorHue; }
        public double getColorRed() { return this.colorRed; }
        public double getColorGreen() { return this.colorGreen; }
        public double getColorBlue() { return this.colorBlue; } 
        public double getColorSaturation() { return this.colorSaturation; }
        public double getColorBrightness() { return this.colorBrightness; }


        private double maxPigment()
        {
            double max = 0;
            if (colorRed >= colorGreen && colorRed >= colorBlue) max = colorRed;
            if (colorGreen > colorRed && colorGreen >= colorBlue) max = colorGreen;
            if (colorBlue > colorGreen && colorBlue > colorRed) max = colorBlue;

            return max;
        }

        private double minPigment()
        {
            double min = 0;
            if (colorRed < colorGreen && colorRed < colorBlue) min = colorRed;
            if (colorGreen <= colorRed && colorGreen < colorBlue) min = colorGreen;
            if (colorBlue <= colorGreen && colorBlue <= colorRed) min = colorBlue;

            return min;
        }

        private double getHueFromRGB()
        {
            double max = maxPigment();
            double min = minPigment();
            double hue = 0;
            double red = this.colorRed / 255;
            double green = this.colorGreen / 255;
            double blue = this.colorBlue / 255;
           
            if (max == colorRed && colorGreen >= colorBlue) { hue = 60 * ((green - blue) / ((max - min) / 255)); }
            if (max == colorRed && colorGreen < colorBlue) { hue = 60 * ((green - blue) / ((max - min) / 255)) + 360; }
            if (max == colorGreen) { hue = 60 * ((blue - red) / ((max - min) / 255)) + 120; }
            if (max == colorBlue) { hue = 60 * ((red - green) / ((max - min) / 255)) + 240; }
            if (max == min) { hue = 0; }
            if (hue > 360) { hue = 360; }
            if (hue < 0) { hue = 0; }

            return hue;
        }
        private double getSaturationFromRGB()
        {
            double max = maxPigment();
            double min = minPigment();
            double saturation;

            if (max == 0) { saturation = 0; }
            else { saturation = (max - min) / max; }

            return saturation * 100;
        }

        private double getBrightnessFromRGB()
        {
            double max = maxPigment();
            double brightness;

            brightness = max / 255;
            return brightness * 100;
        }

        public Color ColorFromHSV()
        {
            int hueI = Convert.ToInt32(Math.Floor(this.colorHue / 60)) % 6;
            double f = this.colorHue / 60 - Math.Floor(this.colorHue / 60);

            int brightness = Convert.ToInt32(this.colorBrightness * 255 / 100) ;
            int p = Convert.ToInt32(this.colorBrightness * (1 - this.colorSaturation / 100) * 255 / 100);
            int q = Convert.ToInt32(this.colorBrightness * (1 - f * this.colorSaturation / 100) * 255 / 100 );
            int t = Convert.ToInt32(this.colorBrightness * (1 - (1 - f) * this.colorSaturation / 100) * 255 / 100);

            if (hueI == 0)
                return Color.FromArgb(255, brightness, t, p);
            else if (hueI == 1)
                return Color.FromArgb(255, q, brightness, p);
            else if (hueI == 2)
                return Color.FromArgb(255, p, brightness, t);
            else if (hueI == 3)
                return Color.FromArgb(255, p, q, brightness);
            else if (hueI == 4)
                return Color.FromArgb(255, t, p, brightness);
            else
                return Color.FromArgb(255, brightness, p, q);           
        }
    }
}
