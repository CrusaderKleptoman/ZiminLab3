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

        public void addColorRed(double colorRed) { this.colorRed += colorRed; if (this.colorRed > 255) this.colorRed = 255; }
        public void RemoveColorRed(double colorRed) { this.colorRed -= colorRed; if (this.colorRed < 0) this.colorRed = 0; }
        public void addColorGreen(double colorGreen) { this.colorGreen += colorGreen; if (this.colorGreen > 255) this.colorGreen = 255; }
        public void RemoveColorGreen(double colorGreen) { this.colorGreen -= colorGreen; if (this.colorGreen < 0) this.colorGreen = 0; }
        public void addColorBlue(double colorBlue) { this.colorBlue += colorBlue; if (this.colorBlue > 255) this.colorRed = 255; }
        public void RemoveColorBlue(double colorBlue) { this.colorBlue -= colorBlue; if (this.colorBlue < 0) this.colorBlue = 0; }
        public void addColorSaturation(double colorSaturation) { this.colorSaturation += colorSaturation; ; if (this.colorSaturation > 100) this.colorSaturation = 100; }
        public void RemoveColorSaturation(double colorSaturation) { this.colorSaturation -= colorSaturation; if (this.colorSaturation < 0) this.colorSaturation = 0; }
        public void addColorBrightness(double colorBrightness) { this.colorBrightness += colorBrightness; ; if (this.colorBrightness > 100) this.colorBrightness = 100; }
        public void RemoveColorBrightness(double colorBrightness) { this.colorBrightness -= colorBrightness; if (this.colorBrightness < 0) this.colorBrightness = 0; }
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

        private void getHSVcollor()
        {
            double max = maxPigment();
            double min = minPigment();
            double red = this.colorRed / 255;
            double green = this.colorGreen / 255;
            double blue = this.colorBlue / 255;
           
            if (max == colorRed && colorGreen >= colorBlue) { this.colorHue = 60 * ((green - blue) / ((max - min) / 255)); }
            if (max == colorRed && colorGreen < colorBlue) { this.colorHue = 60 * ((green - blue) / ((max - min) / 255)) + 360; }
            if (max == colorGreen) { this.colorHue = 60 * ((blue - red) / ((max - min) / 255)) + 120; }
            if (max == colorBlue) { this.colorHue = 60 * ((red - green) / ((max - min) / 255)) + 240; }
            if (max == min) { this.colorHue = 0; }
            if (this.colorHue > 360) { this.colorHue = 360; }
            if (this.colorHue < 0) { this.colorHue = 0; }

            if (max == 0) { this.colorSaturation = 0; }
            else { this.colorSaturation = (max - min) / max; }

            this.colorBrightness = max / 255 * 100;
        }

        public Color ColorFromHSV()
        {
            this.getHSVcollor();
            int hueI = Convert.ToInt32(Math.Floor(colorHue / 60)) % 6;
            double f = colorHue / 60 - Math.Floor(colorHue / 60);


            int brightness = Convert.ToInt32(colorBrightness * 255 / 100) ;
            int p = Convert.ToInt32(colorBrightness * (1 - colorSaturation) * 255 / 100);
            int q = Convert.ToInt32(colorBrightness * (1 - f * colorSaturation) * 255 / 100 );
            int t = Convert.ToInt32(colorBrightness * (1 - (1 - f) * colorSaturation) * 255 / 100);

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
