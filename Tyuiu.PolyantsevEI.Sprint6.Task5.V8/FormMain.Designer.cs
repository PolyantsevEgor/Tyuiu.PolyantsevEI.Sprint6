namespace Tyuiu.PolyantsevEI.Sprint6.Task5.V8
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxOutput_PEI = new System.Windows.Forms.GroupBox();
            this.dataGrid_PEI = new System.Windows.Forms.DataGridView();
            this.groupBoxTask_PEI = new System.Windows.Forms.GroupBox();
            this.buttonDone_PEI = new System.Windows.Forms.Button();
            this.buttonOpen_PEI = new System.Windows.Forms.Button();
            this.buttonInfo_PEI = new System.Windows.Forms.Button();
            this.chartDiag_PEI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_PEI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_PEI)).BeginInit();
            this.groupBoxTask_PEI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_PEI)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOutput_PEI
            // 
            this.groupBoxOutput_PEI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxOutput_PEI.Controls.Add(this.dataGrid_PEI);
            this.groupBoxOutput_PEI.Location = new System.Drawing.Point(12, 134);
            this.groupBoxOutput_PEI.Name = "groupBoxOutput_PEI";
            this.groupBoxOutput_PEI.Size = new System.Drawing.Size(138, 379);
            this.groupBoxOutput_PEI.TabIndex = 1;
            this.groupBoxOutput_PEI.TabStop = false;
            this.groupBoxOutput_PEI.Text = "Вывод";
            // 
            // dataGrid_PEI
            // 
            this.dataGrid_PEI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGrid_PEI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_PEI.ColumnHeadersVisible = false;
            this.dataGrid_PEI.Location = new System.Drawing.Point(6, 21);
            this.dataGrid_PEI.Name = "dataGrid_PEI";
            this.dataGrid_PEI.RowHeadersVisible = false;
            this.dataGrid_PEI.RowHeadersWidth = 51;
            this.dataGrid_PEI.RowTemplate.Height = 24;
            this.dataGrid_PEI.Size = new System.Drawing.Size(126, 352);
            this.dataGrid_PEI.TabIndex = 6;
            // 
            // groupBoxTask_PEI
            // 
            this.groupBoxTask_PEI.Controls.Add(this.textBox1);
            this.groupBoxTask_PEI.Location = new System.Drawing.Point(12, 0);
            this.groupBoxTask_PEI.Name = "groupBoxTask_PEI";
            this.groupBoxTask_PEI.Size = new System.Drawing.Size(403, 123);
            this.groupBoxTask_PEI.TabIndex = 2;
            this.groupBoxTask_PEI.TabStop = false;
            this.groupBoxTask_PEI.Text = "Условие";
            // 
            // buttonDone_PEI
            // 
            this.buttonDone_PEI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDone_PEI.BackColor = System.Drawing.Color.Lime;
            this.buttonDone_PEI.Location = new System.Drawing.Point(421, 21);
            this.buttonDone_PEI.Name = "buttonDone_PEI";
            this.buttonDone_PEI.Size = new System.Drawing.Size(101, 81);
            this.buttonDone_PEI.TabIndex = 3;
            this.buttonDone_PEI.Text = "Выполнить";
            this.buttonDone_PEI.UseVisualStyleBackColor = false;
            this.buttonDone_PEI.Click += new System.EventHandler(this.buttonDone_PEI_Click);
            // 
            // buttonOpen_PEI
            // 
            this.buttonOpen_PEI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonOpen_PEI.BackColor = System.Drawing.Color.Plum;
            this.buttonOpen_PEI.Location = new System.Drawing.Point(528, 21);
            this.buttonOpen_PEI.Name = "buttonOpen_PEI";
            this.buttonOpen_PEI.Size = new System.Drawing.Size(101, 81);
            this.buttonOpen_PEI.TabIndex = 4;
            this.buttonOpen_PEI.Text = "Открыть файл";
            this.buttonOpen_PEI.UseVisualStyleBackColor = false;
            this.buttonOpen_PEI.Click += new System.EventHandler(this.buttonOpen_PEI_Click);
            // 
            // buttonInfo_PEI
            // 
            this.buttonInfo_PEI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_PEI.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonInfo_PEI.Location = new System.Drawing.Point(687, 21);
            this.buttonInfo_PEI.Name = "buttonInfo_PEI";
            this.buttonInfo_PEI.Size = new System.Drawing.Size(101, 81);
            this.buttonInfo_PEI.TabIndex = 5;
            this.buttonInfo_PEI.Text = "Справка";
            this.buttonInfo_PEI.UseVisualStyleBackColor = false;
            this.buttonInfo_PEI.Click += new System.EventHandler(this.buttonHelp_PEI_Click);
            // 
            // chartDiag_PEI
            // 
            this.chartDiag_PEI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chartDiag_PEI.BackColor = System.Drawing.SystemColors.Menu;
            chartArea3.Name = "ChartArea1";
            this.chartDiag_PEI.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartDiag_PEI.Legends.Add(legend3);
            this.chartDiag_PEI.Location = new System.Drawing.Point(156, 143);
            this.chartDiag_PEI.Name = "chartDiag_PEI";
            this.chartDiag_PEI.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartDiag_PEI.Series.Add(series3);
            this.chartDiag_PEI.Size = new System.Drawing.Size(632, 370);
            this.chartDiag_PEI.TabIndex = 6;
            this.chartDiag_PEI.Text = "chart1";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(6, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(391, 99);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Прочитать данные из файла. Вывести в dataGridView. Дан список из чисел. Вывести в" +
    "се числа, меньше 0. Построить диаграмму по этим значениям.\r\n";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.chartDiag_PEI);
            this.Controls.Add(this.buttonInfo_PEI);
            this.Controls.Add(this.buttonOpen_PEI);
            this.Controls.Add(this.buttonDone_PEI);
            this.Controls.Add(this.groupBoxTask_PEI);
            this.Controls.Add(this.groupBoxOutput_PEI);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 8 | Полянцев Е.И.";
            this.groupBoxOutput_PEI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_PEI)).EndInit();
            this.groupBoxTask_PEI.ResumeLayout(false);
            this.groupBoxTask_PEI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_PEI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxOutput_PEI;
        private System.Windows.Forms.GroupBox groupBoxTask_PEI;
        private System.Windows.Forms.Button buttonDone_PEI;
        private System.Windows.Forms.Button buttonOpen_PEI;
        private System.Windows.Forms.Button buttonInfo_PEI;
        private System.Windows.Forms.DataGridView dataGrid_PEI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_PEI;
        private System.Windows.Forms.TextBox textBox1;
    }
}

