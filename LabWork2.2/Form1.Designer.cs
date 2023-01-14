namespace LabWork2._2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.x1Numeric = new System.Windows.Forms.NumericUpDown();
            this.y1Numeric = new System.Windows.Forms.NumericUpDown();
            this.widthNumeric = new System.Windows.Forms.NumericUpDown();
            this.heightNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.colorsListBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rectanglesListBox = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.hasIntersectionCheckBox = new System.Windows.Forms.CheckBox();
            this.isRotatebleCheckBox = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(368, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "New rectangle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // x1Numeric
            // 
            this.x1Numeric.Location = new System.Drawing.Point(200, 40);
            this.x1Numeric.Maximum = new decimal(new int[] {
            420,
            0,
            0,
            0});
            this.x1Numeric.Name = "x1Numeric";
            this.x1Numeric.Size = new System.Drawing.Size(120, 20);
            this.x1Numeric.TabIndex = 2;
            this.x1Numeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.x1Numeric.ValueChanged += new System.EventHandler(this.x1Numeric_ValueChanged);
            // 
            // y1Numeric
            // 
            this.y1Numeric.Location = new System.Drawing.Point(200, 66);
            this.y1Numeric.Maximum = new decimal(new int[] {
            426,
            0,
            0,
            0});
            this.y1Numeric.Name = "y1Numeric";
            this.y1Numeric.Size = new System.Drawing.Size(120, 20);
            this.y1Numeric.TabIndex = 3;
            this.y1Numeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.y1Numeric.ValueChanged += new System.EventHandler(this.y1Numeric_ValueChanged);
            // 
            // widthNumeric
            // 
            this.widthNumeric.Location = new System.Drawing.Point(222, 153);
            this.widthNumeric.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.widthNumeric.Name = "widthNumeric";
            this.widthNumeric.Size = new System.Drawing.Size(120, 20);
            this.widthNumeric.TabIndex = 5;
            this.widthNumeric.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.widthNumeric.ValueChanged += new System.EventHandler(this.widthNumeric_ValueChanged);
            // 
            // heightNumeric
            // 
            this.heightNumeric.Location = new System.Drawing.Point(222, 179);
            this.heightNumeric.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.heightNumeric.Name = "heightNumeric";
            this.heightNumeric.Size = new System.Drawing.Size(120, 20);
            this.heightNumeric.TabIndex = 4;
            this.heightNumeric.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.heightNumeric.ValueChanged += new System.EventHandler(this.heightNumeric_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(184, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Move";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(181, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Resize";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "height";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Rectangles intersection";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // colorsListBox
            // 
            this.colorsListBox.FormattingEnabled = true;
            this.colorsListBox.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Black"});
            this.colorsListBox.Location = new System.Drawing.Point(8, 34);
            this.colorsListBox.Name = "colorsListBox";
            this.colorsListBox.Size = new System.Drawing.Size(120, 56);
            this.colorsListBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(5, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Colors";
            // 
            // rectanglesListBox
            // 
            this.rectanglesListBox.FormattingEnabled = true;
            this.rectanglesListBox.Location = new System.Drawing.Point(8, 133);
            this.rectanglesListBox.Name = "rectanglesListBox";
            this.rectanglesListBox.Size = new System.Drawing.Size(120, 95);
            this.rectanglesListBox.TabIndex = 15;
            this.rectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(5, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Rectangles";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Rectangles union";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(231, 217);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Rotate";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // hasIntersectionCheckBox
            // 
            this.hasIntersectionCheckBox.AutoSize = true;
            this.hasIntersectionCheckBox.Location = new System.Drawing.Point(13, 382);
            this.hasIntersectionCheckBox.Name = "hasIntersectionCheckBox";
            this.hasIntersectionCheckBox.Size = new System.Drawing.Size(102, 17);
            this.hasIntersectionCheckBox.TabIndex = 19;
            this.hasIntersectionCheckBox.Text = "Has intersection";
            this.hasIntersectionCheckBox.UseVisualStyleBackColor = true;
            // 
            // isRotatebleCheckBox
            // 
            this.isRotatebleCheckBox.AutoSize = true;
            this.isRotatebleCheckBox.Location = new System.Drawing.Point(136, 382);
            this.isRotatebleCheckBox.Name = "isRotatebleCheckBox";
            this.isRotatebleCheckBox.Size = new System.Drawing.Size(58, 17);
            this.isRotatebleCheckBox.TabIndex = 20;
            this.isRotatebleCheckBox.Text = "Rotate";
            this.isRotatebleCheckBox.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(187, 340);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "Debug rectangles union";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.isRotatebleCheckBox);
            this.Controls.Add(this.hasIntersectionCheckBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rectanglesListBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.colorsListBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.widthNumeric);
            this.Controls.Add(this.heightNumeric);
            this.Controls.Add(this.y1Numeric);
            this.Controls.Add(this.x1Numeric);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown x1Numeric;
        private System.Windows.Forms.NumericUpDown y1Numeric;
        private System.Windows.Forms.NumericUpDown widthNumeric;
        private System.Windows.Forms.NumericUpDown heightNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox colorsListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox rectanglesListBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox hasIntersectionCheckBox;
        private System.Windows.Forms.CheckBox isRotatebleCheckBox;
        private System.Windows.Forms.Button button5;
    }
}

