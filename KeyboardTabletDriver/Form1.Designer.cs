namespace KeyboardTabletDriver
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AreaWidth = new NumericUpDown();
            label1 = new Label();
            AreaHeight = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            PositionY = new NumericUpDown();
            PositionX = new NumericUpDown();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)AreaWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AreaHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PositionY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PositionX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AreaWidth
            // 
            AreaWidth.Location = new Point(62, 27);
            AreaWidth.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            AreaWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            AreaWidth.Name = "AreaWidth";
            AreaWidth.Size = new Size(115, 23);
            AreaWidth.TabIndex = 1;
            AreaWidth.Value = new decimal(new int[] { 1920, 0, 0, 0 });
            AreaWidth.ValueChanged += AreaWidth_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 9);
            label1.Name = "label1";
            label1.Size = new Size(165, 15);
            label1.TabIndex = 1;
            label1.Text = "Width                              Height";
            // 
            // AreaHeight
            // 
            AreaHeight.Location = new Point(183, 27);
            AreaHeight.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            AreaHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            AreaHeight.Name = "AreaHeight";
            AreaHeight.Size = new Size(115, 23);
            AreaHeight.TabIndex = 2;
            AreaHeight.Value = new decimal(new int[] { 1080, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 3;
            label2.Text = "Position";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 29);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 4;
            label3.Text = "Area";
            // 
            // PositionY
            // 
            PositionY.Location = new Point(183, 53);
            PositionY.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            PositionY.Name = "PositionY";
            PositionY.Size = new Size(115, 23);
            PositionY.TabIndex = 4;
            // 
            // PositionX
            // 
            PositionX.Location = new Point(62, 53);
            PositionX.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            PositionX.Name = "PositionX";
            PositionX.Size = new Size(115, 23);
            PositionX.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 260);
            label4.Name = "label4";
            label4.Size = new Size(208, 15);
            label4.TabIndex = 7;
            label4.Text = "Only supports UK Compact ISO layout";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.keyBoard_Position;
            pictureBox1.Location = new Point(13, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(411, 151);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 287);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 9;
            label5.Text = "Key";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(325, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(328, 23);
            textBox1.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(430, 106);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(76, 19);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Activated";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(PositionY);
            Controls.Add(PositionX);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(AreaHeight);
            Controls.Add(label1);
            Controls.Add(AreaWidth);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)AreaWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)AreaHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)PositionY).EndInit();
            ((System.ComponentModel.ISupportInitialize)PositionX).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown AreaWidth;
        private Label label1;
        private NumericUpDown AreaHeight;
        private Label label2;
        private Label label3;
        private NumericUpDown PositionY;
        private NumericUpDown PositionX;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
        private TextBox textBox1;
        private CheckBox checkBox1;
    }
}
