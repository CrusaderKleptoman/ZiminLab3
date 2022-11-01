namespace ZiminLab3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.textBoxCollorRed = new System.Windows.Forms.TextBox();
            this.textBoxCollorGreen = new System.Windows.Forms.TextBox();
            this.textBoxCollorBlue = new System.Windows.Forms.TextBox();
            this.textBoxCollorSaturation = new System.Windows.Forms.TextBox();
            this.textBoxCollorBrightness = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelHue = new System.Windows.Forms.Label();
            this.labelSaturation = new System.Windows.Forms.Label();
            this.labelBrightness = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelRed = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCollorHue = new System.Windows.Forms.TextBox();
            this.buttonAddRGBtoHSV = new System.Windows.Forms.Button();
            this.buttonRemoveRGBfromHSV = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCollorRed
            // 
            this.textBoxCollorRed.Location = new System.Drawing.Point(306, 27);
            this.textBoxCollorRed.Name = "textBoxCollorRed";
            this.textBoxCollorRed.Size = new System.Drawing.Size(41, 20);
            this.textBoxCollorRed.TabIndex = 1;
            // 
            // textBoxCollorGreen
            // 
            this.textBoxCollorGreen.Location = new System.Drawing.Point(306, 68);
            this.textBoxCollorGreen.Name = "textBoxCollorGreen";
            this.textBoxCollorGreen.Size = new System.Drawing.Size(41, 20);
            this.textBoxCollorGreen.TabIndex = 3;
            // 
            // textBoxCollorBlue
            // 
            this.textBoxCollorBlue.Location = new System.Drawing.Point(306, 111);
            this.textBoxCollorBlue.Name = "textBoxCollorBlue";
            this.textBoxCollorBlue.Size = new System.Drawing.Size(41, 20);
            this.textBoxCollorBlue.TabIndex = 5;
            // 
            // textBoxCollorSaturation
            // 
            this.textBoxCollorSaturation.Location = new System.Drawing.Point(28, 68);
            this.textBoxCollorSaturation.Name = "textBoxCollorSaturation";
            this.textBoxCollorSaturation.Size = new System.Drawing.Size(41, 20);
            this.textBoxCollorSaturation.TabIndex = 7;
            // 
            // textBoxCollorBrightness
            // 
            this.textBoxCollorBrightness.Location = new System.Drawing.Point(28, 111);
            this.textBoxCollorBrightness.Name = "textBoxCollorBrightness";
            this.textBoxCollorBrightness.Size = new System.Drawing.Size(41, 20);
            this.textBoxCollorBrightness.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Тон";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Насыщенность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Яркость";
            // 
            // labelHue
            // 
            this.labelHue.AutoSize = true;
            this.labelHue.Location = new System.Drawing.Point(605, 40);
            this.labelHue.Name = "labelHue";
            this.labelHue.Size = new System.Drawing.Size(13, 13);
            this.labelHue.TabIndex = 19;
            this.labelHue.Text = "0";
            // 
            // labelSaturation
            // 
            this.labelSaturation.AutoSize = true;
            this.labelSaturation.Location = new System.Drawing.Point(605, 65);
            this.labelSaturation.Name = "labelSaturation";
            this.labelSaturation.Size = new System.Drawing.Size(13, 13);
            this.labelSaturation.TabIndex = 20;
            this.labelSaturation.Text = "0";
            // 
            // labelBrightness
            // 
            this.labelBrightness.AutoSize = true;
            this.labelBrightness.Location = new System.Drawing.Point(605, 88);
            this.labelBrightness.Name = "labelBrightness";
            this.labelBrightness.Size = new System.Drawing.Size(13, 13);
            this.labelBrightness.TabIndex = 21;
            this.labelBrightness.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Красный";
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.Location = new System.Drawing.Point(502, 92);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(13, 13);
            this.labelBlue.TabIndex = 25;
            this.labelBlue.Text = "0";
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.Location = new System.Drawing.Point(502, 66);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(13, 13);
            this.labelGreen.TabIndex = 24;
            this.labelGreen.Text = "0";
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Location = new System.Drawing.Point(502, 40);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(13, 13);
            this.labelRed.TabIndex = 23;
            this.labelRed.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Зелёный";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(306, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Синий";
            // 
            // textBoxCollorHue
            // 
            this.textBoxCollorHue.Location = new System.Drawing.Point(28, 27);
            this.textBoxCollorHue.Name = "textBoxCollorHue";
            this.textBoxCollorHue.Size = new System.Drawing.Size(41, 20);
            this.textBoxCollorHue.TabIndex = 28;
            // 
            // buttonAddRGBtoHSV
            // 
            this.buttonAddRGBtoHSV.Location = new System.Drawing.Point(145, 27);
            this.buttonAddRGBtoHSV.Name = "buttonAddRGBtoHSV";
            this.buttonAddRGBtoHSV.Size = new System.Drawing.Size(75, 23);
            this.buttonAddRGBtoHSV.TabIndex = 29;
            this.buttonAddRGBtoHSV.Text = "HSV+RGB";
            this.buttonAddRGBtoHSV.UseVisualStyleBackColor = true;
            this.buttonAddRGBtoHSV.Click += new System.EventHandler(this.buttonAddRGBtoHSV_Click);
            // 
            // buttonRemoveRGBfromHSV
            // 
            this.buttonRemoveRGBfromHSV.Location = new System.Drawing.Point(145, 57);
            this.buttonRemoveRGBfromHSV.Name = "buttonRemoveRGBfromHSV";
            this.buttonRemoveRGBfromHSV.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveRGBfromHSV.TabIndex = 30;
            this.buttonRemoveRGBfromHSV.Text = "HSV-RGB";
            this.buttonRemoveRGBfromHSV.UseVisualStyleBackColor = true;
            this.buttonRemoveRGBfromHSV.Click += new System.EventHandler(this.buttonRemoveRGBfromHSV_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Смешивание цветов HSV и RGB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Тон";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(411, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Насыщенность";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(446, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Яркость";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(547, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Красный";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(547, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Зелёный";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(561, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Синий";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(479, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = " Итоговые параметры";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(476, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "В HSV";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(579, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "В RGB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 369);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonRemoveRGBfromHSV);
            this.Controls.Add(this.buttonAddRGBtoHSV);
            this.Controls.Add(this.textBoxCollorHue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelBlue);
            this.Controls.Add(this.labelGreen);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelBrightness);
            this.Controls.Add(this.labelSaturation);
            this.Controls.Add(this.labelHue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCollorBrightness);
            this.Controls.Add(this.textBoxCollorSaturation);
            this.Controls.Add(this.textBoxCollorBlue);
            this.Controls.Add(this.textBoxCollorGreen);
            this.Controls.Add(this.textBoxCollorRed);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TextBox textBoxCollorRed;
        private System.Windows.Forms.TextBox textBoxCollorGreen;
        private System.Windows.Forms.TextBox textBoxCollorBlue;
        private System.Windows.Forms.TextBox textBoxCollorSaturation;
        private System.Windows.Forms.TextBox textBoxCollorBrightness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelHue;
        private System.Windows.Forms.Label labelSaturation;
        private System.Windows.Forms.Label labelBrightness;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxCollorHue;
        private System.Windows.Forms.Button buttonAddRGBtoHSV;
        private System.Windows.Forms.Button buttonRemoveRGBfromHSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}

