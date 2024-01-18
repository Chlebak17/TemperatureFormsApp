namespace PrevodTeplotyApp
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
            switchTemp = new Button();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            buttonPreved = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            ender = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // switchTemp
            // 
            switchTemp.Location = new Point(137, 186);
            switchTemp.Name = "switchTemp";
            switchTemp.Size = new Size(75, 23);
            switchTemp.TabIndex = 0;
            switchTemp.Text = "°F->°C";
            switchTemp.UseVisualStyleBackColor = true;
            switchTemp.Click += switchTemp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(380, 190);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 1;
            label1.Text = "°F =";
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 1;
            numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown1.Location = new Point(241, 188);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.MaximumSize = new Size(1000, 0);
            numericUpDown1.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown1.MinimumSize = new Size(-100, 0);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(535, 194);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 3;
            label2.Text = "°C =";
            // 
            // buttonPreved
            // 
            buttonPreved.Location = new Point(585, 190);
            buttonPreved.Name = "buttonPreved";
            buttonPreved.Size = new Size(75, 23);
            buttonPreved.TabIndex = 4;
            buttonPreved.Text = "Preved";
            buttonPreved.UseVisualStyleBackColor = true;
            buttonPreved.Click += buttonPreved_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(417, 190);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(68, 72);
            label3.Name = "label3";
            label3.Size = new Size(310, 32);
            label3.TabIndex = 6;
            label3.Text = "Převod teplot mezi °C a °F";
            // 
            // ender
            // 
            ender.Location = new Point(364, 321);
            ender.Name = "ender";
            ender.Size = new Size(75, 23);
            ender.TabIndex = 7;
            ender.Text = "Konec";
            ender.UseVisualStyleBackColor = true;
            ender.Click += ender_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ender);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(buttonPreved);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(switchTemp);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button switchTemp;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Button buttonPreved;
        private TextBox textBox1;
        private Label label3;
        private Button ender;
    }
}