namespace Colors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.numY = new System.Windows.Forms.NumericUpDown();
            this.numZ = new System.Windows.Forms.NumericUpDown();
            this.numB = new System.Windows.Forms.NumericUpDown();
            this.numA = new System.Windows.Forms.NumericUpDown();
            this.numL = new System.Windows.Forms.NumericUpDown();
            this.numHSL = new System.Windows.Forms.NumericUpDown();
            this.numS = new System.Windows.Forms.NumericUpDown();
            this.numH = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.trackBarH = new System.Windows.Forms.TrackBar();
            this.trackBarS = new System.Windows.Forms.TrackBar();
            this.trackBarHSL = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHSL)).BeginInit();
            this.SuspendLayout();
            // 
            // numX
            // 
            this.numX.Location = new System.Drawing.Point(75, 221);
            this.numX.Maximum = new decimal(new int[] {
            95,
            0,
            0,
            0});
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(120, 26);
            this.numX.TabIndex = 0;
            // 
            // numY
            // 
            this.numY.Location = new System.Drawing.Point(75, 283);
            this.numY.Name = "numY";
            this.numY.Size = new System.Drawing.Size(120, 26);
            this.numY.TabIndex = 1;
            // 
            // numZ
            // 
            this.numZ.Location = new System.Drawing.Point(75, 346);
            this.numZ.Maximum = new decimal(new int[] {
            108,
            0,
            0,
            0});
            this.numZ.Name = "numZ";
            this.numZ.Size = new System.Drawing.Size(120, 26);
            this.numZ.TabIndex = 2;
            // 
            // numB
            // 
            this.numB.Location = new System.Drawing.Point(303, 346);
            this.numB.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numB.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(120, 26);
            this.numB.TabIndex = 5;
            // 
            // numA
            // 
            this.numA.Location = new System.Drawing.Point(303, 283);
            this.numA.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numA.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.numA.Name = "numA";
            this.numA.Size = new System.Drawing.Size(120, 26);
            this.numA.TabIndex = 4;
            // 
            // numL
            // 
            this.numL.Location = new System.Drawing.Point(303, 221);
            this.numL.Name = "numL";
            this.numL.Size = new System.Drawing.Size(120, 26);
            this.numL.TabIndex = 3;
            // 
            // numHSL
            // 
            this.numHSL.Location = new System.Drawing.Point(552, 344);
            this.numHSL.Name = "numHSL";
            this.numHSL.Size = new System.Drawing.Size(120, 26);
            this.numHSL.TabIndex = 8;
            // 
            // numS
            // 
            this.numS.Location = new System.Drawing.Point(552, 281);
            this.numS.Name = "numS";
            this.numS.Size = new System.Drawing.Size(120, 26);
            this.numS.TabIndex = 7;
            // 
            // numH
            // 
            this.numH.Location = new System.Drawing.Point(552, 219);
            this.numH.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numH.Name = "numH";
            this.numH.Size = new System.Drawing.Size(120, 26);
            this.numH.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(155, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(739, 128);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "b";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "a";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "L";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(527, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "L";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(526, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "S";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(526, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "H";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(53, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 56);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 20;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(322, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 35);
            this.button3.TabIndex = 21;
            this.button3.Text = "Submit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(572, 391);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 35);
            this.button4.TabIndex = 22;
            this.button4.Text = "Submit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // trackBarH
            // 
            this.trackBarH.Location = new System.Drawing.Point(695, 219);
            this.trackBarH.Maximum = 360;
            this.trackBarH.Name = "trackBarH";
            this.trackBarH.Size = new System.Drawing.Size(199, 69);
            this.trackBarH.TabIndex = 23;
            this.trackBarH.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBarS
            // 
            this.trackBarS.Location = new System.Drawing.Point(695, 283);
            this.trackBarS.Maximum = 100;
            this.trackBarS.Name = "trackBarS";
            this.trackBarS.Size = new System.Drawing.Size(199, 69);
            this.trackBarS.TabIndex = 27;
            this.trackBarS.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarS.Scroll += new System.EventHandler(this.trackBarS_Scroll);
            // 
            // trackBarHSL
            // 
            this.trackBarHSL.Location = new System.Drawing.Point(695, 342);
            this.trackBarHSL.Maximum = 100;
            this.trackBarHSL.Name = "trackBarHSL";
            this.trackBarHSL.Size = new System.Drawing.Size(199, 69);
            this.trackBarHSL.TabIndex = 28;
            this.trackBarHSL.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarHSL.Scroll += new System.EventHandler(this.trackBarHSL_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 450);
            this.Controls.Add(this.trackBarHSL);
            this.Controls.Add(this.trackBarS);
            this.Controls.Add(this.trackBarH);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numHSL);
            this.Controls.Add(this.numS);
            this.Controls.Add(this.numH);
            this.Controls.Add(this.numB);
            this.Controls.Add(this.numA);
            this.Controls.Add(this.numL);
            this.Controls.Add(this.numZ);
            this.Controls.Add(this.numY);
            this.Controls.Add(this.numX);
            this.Name = "Form1";
            this.Text = "Colors Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHSL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numX;
        private System.Windows.Forms.NumericUpDown numY;
        private System.Windows.Forms.NumericUpDown numZ;
        private System.Windows.Forms.NumericUpDown numB;
        private System.Windows.Forms.NumericUpDown numA;
        private System.Windows.Forms.NumericUpDown numL;
        private System.Windows.Forms.NumericUpDown numHSL;
        private System.Windows.Forms.NumericUpDown numS;
        private System.Windows.Forms.NumericUpDown numH;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TrackBar trackBarH;
        private System.Windows.Forms.TrackBar trackBarS;
        private System.Windows.Forms.TrackBar trackBarHSL;
    }
}

