namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numOfSamples1P = new System.Windows.Forms.Label();
            this.NumOfSamples1 = new System.Windows.Forms.TextBox();
            this.meanP = new System.Windows.Forms.Label();
            this.Mean = new System.Windows.Forms.TextBox();
            this.sampleStdDevP = new System.Windows.Forms.Label();
            this.SampleStdDev = new System.Windows.Forms.TextBox();
            this.confLvl1P = new System.Windows.Forms.Label();
            this.ConfLvl1 = new System.Windows.Forms.TextBox();
            this.value1 = new System.Windows.Forms.Label();
            this.Calculate1 = new System.Windows.Forms.Button();
            this.Instances = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numOfSamples2P = new System.Windows.Forms.Label();
            this.Calculate2 = new System.Windows.Forms.Button();
            this.value2 = new System.Windows.Forms.Label();
            this.ConfLvl2 = new System.Windows.Forms.TextBox();
            this.NumOfSamples2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.error1 = new System.Windows.Forms.Label();
            this.error2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numOfSamples1P
            // 
            this.numOfSamples1P.AutoSize = true;
            this.numOfSamples1P.Location = new System.Drawing.Point(97, 72);
            this.numOfSamples1P.Name = "numOfSamples1P";
            this.numOfSamples1P.Size = new System.Drawing.Size(187, 25);
            this.numOfSamples1P.TabIndex = 6;
            this.numOfSamples1P.Text = "Number of Samples: ";
            // 
            // NumOfSamples1
            // 
            this.NumOfSamples1.BackColor = System.Drawing.SystemColors.Window;
            this.NumOfSamples1.Location = new System.Drawing.Point(292, 64);
            this.NumOfSamples1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.NumOfSamples1.Name = "NumOfSamples1";
            this.NumOfSamples1.Size = new System.Drawing.Size(185, 33);
            this.NumOfSamples1.TabIndex = 0;
            this.NumOfSamples1.GotFocus += new System.EventHandler(this.NumOfSamples1_GotFocus);
            // 
            // meanP
            // 
            this.meanP.AutoSize = true;
            this.meanP.Location = new System.Drawing.Point(187, 112);
            this.meanP.Name = "meanP";
            this.meanP.Size = new System.Drawing.Size(97, 25);
            this.meanP.TabIndex = 10;
            this.meanP.Text = "Mean (μ): ";
            // 
            // Mean
            // 
            this.Mean.Location = new System.Drawing.Point(292, 108);
            this.Mean.Name = "Mean";
            this.Mean.Size = new System.Drawing.Size(185, 33);
            this.Mean.TabIndex = 1;
            this.Mean.GotFocus += new System.EventHandler(this.Mean_GotFocus);
            // 
            // sampleStdDevP
            // 
            this.sampleStdDevP.AutoSize = true;
            this.sampleStdDevP.Location = new System.Drawing.Point(13, 156);
            this.sampleStdDevP.Name = "sampleStdDevP";
            this.sampleStdDevP.Size = new System.Drawing.Size(273, 25);
            this.sampleStdDevP.TabIndex = 7;
            this.sampleStdDevP.Text = "Sample standard deviation (σ): ";
            // 
            // SampleStdDev
            // 
            this.SampleStdDev.BackColor = System.Drawing.SystemColors.Window;
            this.SampleStdDev.Location = new System.Drawing.Point(292, 153);
            this.SampleStdDev.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SampleStdDev.Name = "SampleStdDev";
            this.SampleStdDev.Size = new System.Drawing.Size(185, 33);
            this.SampleStdDev.TabIndex = 2;
            this.SampleStdDev.GotFocus += new System.EventHandler(this.SampleStdDev_GotFocus);
            // 
            // confLvl1P
            // 
            this.confLvl1P.AutoSize = true;
            this.confLvl1P.Location = new System.Drawing.Point(90, 205);
            this.confLvl1P.Name = "confLvl1P";
            this.confLvl1P.Size = new System.Drawing.Size(194, 25);
            this.confLvl1P.TabIndex = 8;
            this.confLvl1P.Text = "Confidence level (%): ";
            // 
            // ConfLvl1
            // 
            this.ConfLvl1.BackColor = System.Drawing.SystemColors.Window;
            this.ConfLvl1.Location = new System.Drawing.Point(292, 197);
            this.ConfLvl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ConfLvl1.Name = "ConfLvl1";
            this.ConfLvl1.Size = new System.Drawing.Size(185, 33);
            this.ConfLvl1.TabIndex = 3;
            this.ConfLvl1.GotFocus += new System.EventHandler(this.ConfLvl1_GotFocus);
            // 
            // value1
            // 
            this.value1.AutoSize = true;
            this.value1.Location = new System.Drawing.Point(37, 260);
            this.value1.Name = "value1";
            this.value1.Size = new System.Drawing.Size(187, 25);
            this.value1.TabIndex = 3;
            this.value1.Text = "<waiting for values>";
            // 
            // Calculate1
            // 
            this.Calculate1.BackColor = System.Drawing.SystemColors.Control;
            this.Calculate1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calculate1.Location = new System.Drawing.Point(292, 252);
            this.Calculate1.Name = "Calculate1";
            this.Calculate1.Size = new System.Drawing.Size(185, 41);
            this.Calculate1.TabIndex = 4;
            this.Calculate1.Text = "Calculate";
            this.Calculate1.UseVisualStyleBackColor = false;
            this.Calculate1.Click += new System.EventHandler(this.Calculate1_Click);
            // 
            // Instances
            // 
            this.Instances.Location = new System.Drawing.Point(826, 104);
            this.Instances.Name = "Instances";
            this.Instances.Size = new System.Drawing.Size(185, 33);
            this.Instances.TabIndex = 12;
            this.Instances.GotFocus += new System.EventHandler(this.Instances_GotFocus);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(692, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Occurrences: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(624, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Confidence level (%): ";
            // 
            // numOfSamples2P
            // 
            this.numOfSamples2P.AutoSize = true;
            this.numOfSamples2P.Location = new System.Drawing.Point(631, 68);
            this.numOfSamples2P.Name = "numOfSamples2P";
            this.numOfSamples2P.Size = new System.Drawing.Size(187, 25);
            this.numOfSamples2P.TabIndex = 17;
            this.numOfSamples2P.Text = "Number of Samples: ";
            // 
            // Calculate2
            // 
            this.Calculate2.BackColor = System.Drawing.SystemColors.Control;
            this.Calculate2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calculate2.Location = new System.Drawing.Point(826, 204);
            this.Calculate2.Name = "Calculate2";
            this.Calculate2.Size = new System.Drawing.Size(185, 41);
            this.Calculate2.TabIndex = 16;
            this.Calculate2.Text = "Calculate";
            this.Calculate2.UseVisualStyleBackColor = false;
            this.Calculate2.Click += new System.EventHandler(this.Calculate2_Click);
            // 
            // value2
            // 
            this.value2.AutoSize = true;
            this.value2.Location = new System.Drawing.Point(581, 212);
            this.value2.Name = "value2";
            this.value2.Size = new System.Drawing.Size(187, 25);
            this.value2.TabIndex = 14;
            this.value2.Text = "<waiting for values>";
            // 
            // ConfLvl2
            // 
            this.ConfLvl2.BackColor = System.Drawing.SystemColors.Window;
            this.ConfLvl2.Location = new System.Drawing.Point(826, 149);
            this.ConfLvl2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ConfLvl2.Name = "ConfLvl2";
            this.ConfLvl2.Size = new System.Drawing.Size(185, 33);
            this.ConfLvl2.TabIndex = 15;
            this.ConfLvl2.GotFocus += new System.EventHandler(this.ConfLvl2_GotFocus);
            // 
            // NumOfSamples2
            // 
            this.NumOfSamples2.BackColor = System.Drawing.SystemColors.Window;
            this.NumOfSamples2.Location = new System.Drawing.Point(826, 60);
            this.NumOfSamples2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.NumOfSamples2.Name = "NumOfSamples2";
            this.NumOfSamples2.Size = new System.Drawing.Size(185, 33);
            this.NumOfSamples2.TabIndex = 11;
            this.NumOfSamples2.GotFocus += new System.EventHandler(this.NumOfSamples2_GotFocus);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(598, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(413, 37);
            this.label3.TabIndex = 21;
            this.label3.Text = "Population Proportion Estimation";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 37);
            this.label4.TabIndex = 22;
            this.label4.Text = "Population Mean Estimation";
            // 
            // error1
            // 
            this.error1.Location = new System.Drawing.Point(12, 296);
            this.error1.Name = "error1";
            this.error1.Size = new System.Drawing.Size(274, 35);
            this.error1.TabIndex = 23;
            this.error1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // error2
            // 
            this.error2.Location = new System.Drawing.Point(534, 260);
            this.error2.Name = "error2";
            this.error2.Size = new System.Drawing.Size(286, 33);
            this.error2.TabIndex = 24;
            this.error2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1071, 463);
            this.Controls.Add(this.error2);
            this.Controls.Add(this.error1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Instances);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numOfSamples2P);
            this.Controls.Add(this.Calculate2);
            this.Controls.Add(this.value2);
            this.Controls.Add(this.ConfLvl2);
            this.Controls.Add(this.NumOfSamples2);
            this.Controls.Add(this.Mean);
            this.Controls.Add(this.meanP);
            this.Controls.Add(this.confLvl1P);
            this.Controls.Add(this.sampleStdDevP);
            this.Controls.Add(this.numOfSamples1P);
            this.Controls.Add(this.Calculate1);
            this.Controls.Add(this.value1);
            this.Controls.Add(this.ConfLvl1);
            this.Controls.Add(this.SampleStdDev);
            this.Controls.Add(this.NumOfSamples1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Confidence Interval Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumOfSamples1;
        private System.Windows.Forms.TextBox SampleStdDev;
        private System.Windows.Forms.TextBox ConfLvl1;
        private System.Windows.Forms.Label value1;
        private System.Windows.Forms.Button Calculate1;
        private System.Windows.Forms.Label numOfSamples1P;
        private System.Windows.Forms.Label sampleStdDevP;
        private System.Windows.Forms.Label confLvl1P;
        private System.Windows.Forms.Label meanP;
        private System.Windows.Forms.TextBox Mean;
        private System.Windows.Forms.TextBox Instances;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numOfSamples2P;
        private System.Windows.Forms.Button Calculate2;
        private System.Windows.Forms.Label value2;
        private System.Windows.Forms.TextBox ConfLvl2;
        private System.Windows.Forms.TextBox NumOfSamples2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label error1;
        private System.Windows.Forms.Label error2;
    }
}

