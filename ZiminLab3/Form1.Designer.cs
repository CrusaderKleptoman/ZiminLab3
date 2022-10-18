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
            this.buttonAddGreen = new System.Windows.Forms.Button();
            this.textBoxCollorBlue = new System.Windows.Forms.TextBox();
            this.buttonAddBlue = new System.Windows.Forms.Button();
            this.textBoxCollorSaturation = new System.Windows.Forms.TextBox();
            this.buttonAddSaturation = new System.Windows.Forms.Button();
            this.textBoxCollorBrightness = new System.Windows.Forms.TextBox();
            this.buttonAddBrightness = new System.Windows.Forms.Button();
            this.buttonRemoveBrightness = new System.Windows.Forms.Button();
            this.buttonRemoveSaturation = new System.Windows.Forms.Button();
            this.buttonRemoveBlue = new System.Windows.Forms.Button();
            this.buttonRemoveGreen = new System.Windows.Forms.Button();
            this.buttonRemoveRed = new System.Windows.Forms.Button();
            this.buttonAddRed = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // textBoxCollorRed
            // 
            this.textBoxCollorRed.Location = new System.Drawing.Point(20, 12);
            this.textBoxCollorRed.Name = "textBoxCollorRed";
            this.textBoxCollorRed.Size = new System.Drawing.Size(41, 20);
            this.textBoxCollorRed.TabIndex = 1;
            // 
            // textBoxCollorGreen
            // 
            this.textBoxCollorGreen.Location = new System.Drawing.Point(20, 38);
            this.textBoxCollorGreen.Name = "textBoxCollorGreen";
            this.textBoxCollorGreen.Size = new System.Drawing.Size(41, 20);
            this.textBoxCollorGreen.TabIndex = 3;
            // 
            // buttonAddGreen
            // 
            this.buttonAddGreen.Location = new System.Drawing.Point(78, 38);
            this.buttonAddGreen.Name = "buttonAddGreen";
            this.buttonAddGreen.Size = new System.Drawing.Size(165, 20);
            this.buttonAddGreen.TabIndex = 2;
            this.buttonAddGreen.Text = "Добавить зелёный цвет";
            this.buttonAddGreen.UseVisualStyleBackColor = true;
            this.buttonAddGreen.Click += new System.EventHandler(this.buttonAddGreen_Click);
            // 
            // textBoxCollorBlue
            // 
            this.textBoxCollorBlue.Location = new System.Drawing.Point(20, 64);
            this.textBoxCollorBlue.Name = "textBoxCollorBlue";
            this.textBoxCollorBlue.Size = new System.Drawing.Size(41, 20);
            this.textBoxCollorBlue.TabIndex = 5;
            // 
            // buttonAddBlue
            // 
            this.buttonAddBlue.Location = new System.Drawing.Point(78, 64);
            this.buttonAddBlue.Name = "buttonAddBlue";
            this.buttonAddBlue.Size = new System.Drawing.Size(165, 20);
            this.buttonAddBlue.TabIndex = 4;
            this.buttonAddBlue.Text = "Добавить синий цвет";
            this.buttonAddBlue.UseVisualStyleBackColor = true;
            this.buttonAddBlue.Click += new System.EventHandler(this.buttonAddBlue_Click);
            // 
            // textBoxCollorSaturation
            // 
            this.textBoxCollorSaturation.Location = new System.Drawing.Point(20, 90);
            this.textBoxCollorSaturation.Name = "textBoxCollorSaturation";
            this.textBoxCollorSaturation.Size = new System.Drawing.Size(41, 20);
            this.textBoxCollorSaturation.TabIndex = 7;
            // 
            // buttonAddSaturation
            // 
            this.buttonAddSaturation.Location = new System.Drawing.Point(78, 90);
            this.buttonAddSaturation.Name = "buttonAddSaturation";
            this.buttonAddSaturation.Size = new System.Drawing.Size(165, 20);
            this.buttonAddSaturation.TabIndex = 6;
            this.buttonAddSaturation.Text = "Добавить насыщенность";
            this.buttonAddSaturation.UseVisualStyleBackColor = true;
            this.buttonAddSaturation.Click += new System.EventHandler(this.buttonAddSaturation_Click);
            // 
            // textBoxCollorBrightness
            // 
            this.textBoxCollorBrightness.Location = new System.Drawing.Point(20, 116);
            this.textBoxCollorBrightness.Name = "textBoxCollorBrightness";
            this.textBoxCollorBrightness.Size = new System.Drawing.Size(41, 20);
            this.textBoxCollorBrightness.TabIndex = 9;
            // 
            // buttonAddBrightness
            // 
            this.buttonAddBrightness.Location = new System.Drawing.Point(78, 116);
            this.buttonAddBrightness.Name = "buttonAddBrightness";
            this.buttonAddBrightness.Size = new System.Drawing.Size(165, 20);
            this.buttonAddBrightness.TabIndex = 8;
            this.buttonAddBrightness.Text = "Добавить яркость";
            this.buttonAddBrightness.UseVisualStyleBackColor = true;
            this.buttonAddBrightness.Click += new System.EventHandler(this.buttonAddBrightness_Click);
            // 
            // buttonRemoveBrightness
            // 
            this.buttonRemoveBrightness.Location = new System.Drawing.Point(249, 116);
            this.buttonRemoveBrightness.Name = "buttonRemoveBrightness";
            this.buttonRemoveBrightness.Size = new System.Drawing.Size(165, 20);
            this.buttonRemoveBrightness.TabIndex = 14;
            this.buttonRemoveBrightness.Text = "Вычесть яркость";
            this.buttonRemoveBrightness.UseVisualStyleBackColor = true;
            this.buttonRemoveBrightness.Click += new System.EventHandler(this.buttonRemoveBrightness_Click);
            // 
            // buttonRemoveSaturation
            // 
            this.buttonRemoveSaturation.Location = new System.Drawing.Point(249, 90);
            this.buttonRemoveSaturation.Name = "buttonRemoveSaturation";
            this.buttonRemoveSaturation.Size = new System.Drawing.Size(165, 20);
            this.buttonRemoveSaturation.TabIndex = 13;
            this.buttonRemoveSaturation.Text = "Вычесть насыщенность";
            this.buttonRemoveSaturation.UseVisualStyleBackColor = true;
            this.buttonRemoveSaturation.Click += new System.EventHandler(this.buttonRemoveSaturation_Click);
            // 
            // buttonRemoveBlue
            // 
            this.buttonRemoveBlue.Location = new System.Drawing.Point(249, 64);
            this.buttonRemoveBlue.Name = "buttonRemoveBlue";
            this.buttonRemoveBlue.Size = new System.Drawing.Size(165, 20);
            this.buttonRemoveBlue.TabIndex = 12;
            this.buttonRemoveBlue.Text = "Вычесть синий цвет";
            this.buttonRemoveBlue.UseVisualStyleBackColor = true;
            this.buttonRemoveBlue.Click += new System.EventHandler(this.buttonRemoveBlue_Click);
            // 
            // buttonRemoveGreen
            // 
            this.buttonRemoveGreen.Location = new System.Drawing.Point(249, 38);
            this.buttonRemoveGreen.Name = "buttonRemoveGreen";
            this.buttonRemoveGreen.Size = new System.Drawing.Size(165, 20);
            this.buttonRemoveGreen.TabIndex = 11;
            this.buttonRemoveGreen.Text = "Вычесть зелёный цвет";
            this.buttonRemoveGreen.UseVisualStyleBackColor = true;
            this.buttonRemoveGreen.Click += new System.EventHandler(this.buttonRemoveGreen_Click);
            // 
            // buttonRemoveRed
            // 
            this.buttonRemoveRed.Location = new System.Drawing.Point(249, 12);
            this.buttonRemoveRed.Name = "buttonRemoveRed";
            this.buttonRemoveRed.Size = new System.Drawing.Size(165, 20);
            this.buttonRemoveRed.TabIndex = 10;
            this.buttonRemoveRed.Text = "Вычесть красный цвет";
            this.buttonRemoveRed.UseVisualStyleBackColor = true;
            this.buttonRemoveRed.Click += new System.EventHandler(this.buttonRemoveRed_Click);
            // 
            // buttonAddRed
            // 
            this.buttonAddRed.Location = new System.Drawing.Point(78, 12);
            this.buttonAddRed.Name = "buttonAddRed";
            this.buttonAddRed.Size = new System.Drawing.Size(165, 20);
            this.buttonAddRed.TabIndex = 15;
            this.buttonAddRed.Text = "Добавить красный цвет";
            this.buttonAddRed.UseVisualStyleBackColor = true;
            this.buttonAddRed.Click += new System.EventHandler(this.buttonAddRed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Значение тона";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Значение насыщенности";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Значение яркости";
            // 
            // labelHue
            // 
            this.labelHue.AutoSize = true;
            this.labelHue.Location = new System.Drawing.Point(20, 155);
            this.labelHue.Name = "labelHue";
            this.labelHue.Size = new System.Drawing.Size(13, 13);
            this.labelHue.TabIndex = 19;
            this.labelHue.Text = "0";
            // 
            // labelSaturation
            // 
            this.labelSaturation.AutoSize = true;
            this.labelSaturation.Location = new System.Drawing.Point(20, 182);
            this.labelSaturation.Name = "labelSaturation";
            this.labelSaturation.Size = new System.Drawing.Size(13, 13);
            this.labelSaturation.TabIndex = 20;
            this.labelSaturation.Text = "0";
            // 
            // labelBrightness
            // 
            this.labelBrightness.AutoSize = true;
            this.labelBrightness.Location = new System.Drawing.Point(20, 212);
            this.labelBrightness.Name = "labelBrightness";
            this.labelBrightness.Size = new System.Drawing.Size(13, 13);
            this.labelBrightness.TabIndex = 21;
            this.labelBrightness.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Значение красного";
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.Location = new System.Drawing.Point(449, 64);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(13, 13);
            this.labelBlue.TabIndex = 25;
            this.labelBlue.Text = "0";
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.Location = new System.Drawing.Point(449, 38);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(13, 13);
            this.labelGreen.TabIndex = 24;
            this.labelGreen.Text = "0";
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Location = new System.Drawing.Point(449, 12);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(13, 13);
            this.labelRed.TabIndex = 23;
            this.labelRed.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(480, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Значение зелёного";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(480, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Значение синего";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 443);
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
            this.Controls.Add(this.buttonAddRed);
            this.Controls.Add(this.buttonRemoveBrightness);
            this.Controls.Add(this.buttonRemoveSaturation);
            this.Controls.Add(this.buttonRemoveBlue);
            this.Controls.Add(this.buttonRemoveGreen);
            this.Controls.Add(this.buttonRemoveRed);
            this.Controls.Add(this.textBoxCollorBrightness);
            this.Controls.Add(this.buttonAddBrightness);
            this.Controls.Add(this.textBoxCollorSaturation);
            this.Controls.Add(this.buttonAddSaturation);
            this.Controls.Add(this.textBoxCollorBlue);
            this.Controls.Add(this.buttonAddBlue);
            this.Controls.Add(this.textBoxCollorGreen);
            this.Controls.Add(this.buttonAddGreen);
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
        private System.Windows.Forms.Button buttonAddGreen;
        private System.Windows.Forms.TextBox textBoxCollorBlue;
        private System.Windows.Forms.Button buttonAddBlue;
        private System.Windows.Forms.TextBox textBoxCollorSaturation;
        private System.Windows.Forms.Button buttonAddSaturation;
        private System.Windows.Forms.TextBox textBoxCollorBrightness;
        private System.Windows.Forms.Button buttonAddBrightness;
        private System.Windows.Forms.Button buttonRemoveBrightness;
        private System.Windows.Forms.Button buttonRemoveSaturation;
        private System.Windows.Forms.Button buttonRemoveBlue;
        private System.Windows.Forms.Button buttonRemoveGreen;
        private System.Windows.Forms.Button buttonRemoveRed;
        private System.Windows.Forms.Button buttonAddRed;
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
    }
}

