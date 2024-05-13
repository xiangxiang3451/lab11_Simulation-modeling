using System.Windows.Forms.DataVisualization.Charting;

namespace Lab8._3
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
            ChartArea chartArea2 = new ChartArea();
            Series series2 = new Series();
            panel1 = new Panel();
            intervalUpDawn = new NumericUpDown();
            label3 = new Label();
            errLabel = new Label();
            Varnput = new TextBox();
            Meaninput = new TextBox();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            chart = new Chart();
            label7 = new Label();
            label8 = new Label();
            Mean = new Label();
            Dispersion = new Label();
            label10 = new Label();
            label11 = new Label();
            ChiSquare = new Label();
            HypRes = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)intervalUpDawn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(intervalUpDawn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(errLabel);
            panel1.Controls.Add(Varnput);
            panel1.Controls.Add(Meaninput);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(55, 45);
            panel1.Margin = new Padding(5, 3, 5, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 254);
            panel1.TabIndex = 0;
            // 
            // intervalUpDawn
            // 
            intervalUpDawn.Location = new Point(185, 146);
            intervalUpDawn.Margin = new Padding(5, 3, 5, 3);
            intervalUpDawn.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            intervalUpDawn.Name = "intervalUpDawn";
            intervalUpDawn.Size = new Size(130, 30);
            intervalUpDawn.TabIndex = 15;
            intervalUpDawn.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 146);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 24);
            label3.TabIndex = 14;
            label3.Text = "Intervals";
            // 
            // errLabel
            // 
            errLabel.AutoSize = true;
            errLabel.ForeColor = Color.Red;
            errLabel.Location = new Point(16, 170);
            errLabel.Margin = new Padding(5, 0, 5, 0);
            errLabel.Name = "errLabel";
            errLabel.Size = new Size(28, 24);
            errLabel.TabIndex = 13;
            errLabel.Text = "es";
            errLabel.Visible = false;
            // 
            // Varnput
            // 
            Varnput.Location = new Point(105, 61);
            Varnput.Margin = new Padding(5, 3, 5, 3);
            Varnput.Name = "Varnput";
            Varnput.Size = new Size(86, 30);
            Varnput.TabIndex = 9;
            Varnput.Text = "1";
            Varnput.TextChanged += textBox_TextChanged;
            // 
            // Meaninput
            // 
            Meaninput.Location = new Point(105, 22);
            Meaninput.Margin = new Padding(5, 3, 5, 3);
            Meaninput.Name = "Meaninput";
            Meaninput.Size = new Size(86, 30);
            Meaninput.TabIndex = 8;
            Meaninput.Text = "0";
            Meaninput.TextChanged += textBox_TextChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(185, 104);
            numericUpDown1.Margin = new Padding(5, 3, 5, 3);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(130, 30);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.Value = new decimal(new int[] { 5000, 0, 0, 0 });
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.ForeColor = Color.IndianRed;
            button1.Location = new Point(105, 200);
            button1.Margin = new Padding(5, 3, 5, 3);
            button1.Name = "button1";
            button1.Size = new Size(129, 35);
            button1.TabIndex = 6;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 104);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(151, 24);
            label6.TabIndex = 5;
            label6.Text = "Number of trials";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 61);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 24);
            label2.TabIndex = 1;
            label2.Text = "Variance";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 22);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 24);
            label1.TabIndex = 0;
            label1.Text = "Mean";
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea2);
            chart.Location = new Point(464, 45);
            chart.Margin = new Padding(5, 3, 5, 3);
            chart.Name = "chart";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            chart.Series.Add(series2);
            chart.Size = new Size(597, 464);
            chart.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(75, 302);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(200, 24);
            label7.TabIndex = 14;
            label7.Text = "Выборочная средняя";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(75, 354);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(221, 24);
            label8.TabIndex = 16;
            label8.Text = "Выборочная дисперсия";
            // 
            // Mean
            // 
            Mean.AutoSize = true;
            Mean.Location = new Point(280, 302);
            Mean.Margin = new Padding(5, 0, 5, 0);
            Mean.Name = "Mean";
            Mean.Size = new Size(21, 24);
            Mean.TabIndex = 17;
            Mean.Text = "0";
            // 
            // Dispersion
            // 
            Dispersion.AutoSize = true;
            Dispersion.Location = new Point(280, 354);
            Dispersion.Margin = new Padding(5, 0, 5, 0);
            Dispersion.Name = "Dispersion";
            Dispersion.Size = new Size(21, 24);
            Dispersion.TabIndex = 18;
            Dispersion.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(75, 453);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(67, 24);
            label10.TabIndex = 20;
            label10.Text = "Вывод";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(75, 406);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(117, 24);
            label11.TabIndex = 21;
            label11.Text = "Кси квадрат";
            // 
            // ChiSquare
            // 
            ChiSquare.AutoSize = true;
            ChiSquare.Location = new Point(198, 406);
            ChiSquare.Margin = new Padding(5, 0, 5, 0);
            ChiSquare.Name = "ChiSquare";
            ChiSquare.Size = new Size(117, 24);
            ChiSquare.TabIndex = 22;
            ChiSquare.Text = "Кси квадрат";
            // 
            // HypRes
            // 
            HypRes.AutoSize = true;
            HypRes.Location = new Point(151, 453);
            HypRes.Margin = new Padding(5, 0, 5, 0);
            HypRes.Name = "HypRes";
            HypRes.Size = new Size(67, 24);
            HypRes.TabIndex = 27;
            HypRes.Text = "Вывод";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 530);
            Controls.Add(HypRes);
            Controls.Add(ChiSquare);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(Dispersion);
            Controls.Add(Mean);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(chart);
            Margin = new Padding(5, 3, 5, 3);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)intervalUpDawn).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox Varnput;
        private TextBox Meaninput;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Label label6;
        private Label errLabel;
        private Chart chart;
        private Label label7;
        private Label label8;
        private Label Mean;
        private Label Dispersion;
        private Label label10;
        private Label label11;
        private Label ChiSquare;
        private Label HypRes;
        private NumericUpDown intervalUpDawn;
        private Label label3;
    }
}