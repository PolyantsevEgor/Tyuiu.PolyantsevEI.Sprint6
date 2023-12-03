namespace Tyuiu.PolyantsevEI.Sprint6.Task2.V9
{
    partial class FormMain
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonDone_PEI = new System.Windows.Forms.Button();
            this.buttonHelp_PEI = new System.Windows.Forms.Button();
            this.groupInput_PEI = new System.Windows.Forms.GroupBox();
            this.labelBoxStopStep_PEI = new System.Windows.Forms.Label();
            this.textBoxStopStep_PEI = new System.Windows.Forms.TextBox();
            this.labelBoxStartStep_PEI = new System.Windows.Forms.Label();
            this.textBoxStartStep_PEI = new System.Windows.Forms.TextBox();
            this.groupBoxResult_PEI = new System.Windows.Forms.GroupBox();
            this.chartFunction_PEI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction_PEI = new System.Windows.Forms.DataGridView();
            this.groupBoxTask_PEI = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie_PEI = new System.Windows.Forms.TextBox();
            this.ColumnXY_PEI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnX_PEI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupInput_PEI.SuspendLayout();
            this.groupBoxResult_PEI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PEI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_PEI)).BeginInit();
            this.groupBoxTask_PEI.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDone_PEI
            // 
            this.buttonDone_PEI.Location = new System.Drawing.Point(311, 298);
            this.buttonDone_PEI.Name = "buttonDone_PEI";
            this.buttonDone_PEI.Size = new System.Drawing.Size(87, 28);
            this.buttonDone_PEI.TabIndex = 0;
            this.buttonDone_PEI.Text = "Выполнить";
            this.buttonDone_PEI.UseVisualStyleBackColor = true;
            this.buttonDone_PEI.Click += new System.EventHandler(this.buttonDone_PEI_Click);
            this.buttonDone_PEI.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_PEI_MouseDown);
            this.buttonDone_PEI.MouseEnter += new System.EventHandler(this.buttonDone_PEI_MouseEnter);
            this.buttonDone_PEI.MouseLeave += new System.EventHandler(this.buttonDone_PEI_MouseLeave);
            // 
            // buttonHelp_PEI
            // 
            this.buttonHelp_PEI.Location = new System.Drawing.Point(238, 298);
            this.buttonHelp_PEI.Name = "buttonHelp_PEI";
            this.buttonHelp_PEI.Size = new System.Drawing.Size(67, 28);
            this.buttonHelp_PEI.TabIndex = 1;
            this.buttonHelp_PEI.Text = "Справка";
            this.buttonHelp_PEI.UseVisualStyleBackColor = true;
            this.buttonHelp_PEI.Click += new System.EventHandler(this.buttonHelp_PEI_Click);
            // 
            // groupInput_PEI
            // 
            this.groupInput_PEI.Controls.Add(this.labelBoxStopStep_PEI);
            this.groupInput_PEI.Controls.Add(this.textBoxStopStep_PEI);
            this.groupInput_PEI.Controls.Add(this.labelBoxStartStep_PEI);
            this.groupInput_PEI.Controls.Add(this.textBoxStartStep_PEI);
            this.groupInput_PEI.Location = new System.Drawing.Point(12, 266);
            this.groupInput_PEI.Name = "groupInput_PEI";
            this.groupInput_PEI.Size = new System.Drawing.Size(220, 60);
            this.groupInput_PEI.TabIndex = 2;
            this.groupInput_PEI.TabStop = false;
            this.groupInput_PEI.Text = "Ввод данных";
            // 
            // labelBoxStopStep_PEI
            // 
            this.labelBoxStopStep_PEI.AutoSize = true;
            this.labelBoxStopStep_PEI.Location = new System.Drawing.Point(109, 16);
            this.labelBoxStopStep_PEI.Name = "labelBoxStopStep_PEI";
            this.labelBoxStopStep_PEI.Size = new System.Drawing.Size(69, 13);
            this.labelBoxStopStep_PEI.TabIndex = 3;
            this.labelBoxStopStep_PEI.Text = "Конец шага:";
            // 
            // textBoxStopStep_PEI
            // 
            this.textBoxStopStep_PEI.Location = new System.Drawing.Point(112, 32);
            this.textBoxStopStep_PEI.Name = "textBoxStopStep_PEI";
            this.textBoxStopStep_PEI.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopStep_PEI.TabIndex = 2;
            // 
            // labelBoxStartStep_PEI
            // 
            this.labelBoxStartStep_PEI.AutoSize = true;
            this.labelBoxStartStep_PEI.Location = new System.Drawing.Point(6, 16);
            this.labelBoxStartStep_PEI.Name = "labelBoxStartStep_PEI";
            this.labelBoxStartStep_PEI.Size = new System.Drawing.Size(67, 13);
            this.labelBoxStartStep_PEI.TabIndex = 1;
            this.labelBoxStartStep_PEI.Text = "Старт шага:";
            // 
            // textBoxStartStep_PEI
            // 
            this.textBoxStartStep_PEI.Location = new System.Drawing.Point(6, 32);
            this.textBoxStartStep_PEI.Name = "textBoxStartStep_PEI";
            this.textBoxStartStep_PEI.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartStep_PEI.TabIndex = 0;
            // 
            // groupBoxResult_PEI
            // 
            this.groupBoxResult_PEI.Controls.Add(this.chartFunction_PEI);
            this.groupBoxResult_PEI.Controls.Add(this.dataGridViewFunction_PEI);
            this.groupBoxResult_PEI.Location = new System.Drawing.Point(404, 12);
            this.groupBoxResult_PEI.Name = "groupBoxResult_PEI";
            this.groupBoxResult_PEI.Size = new System.Drawing.Size(441, 314);
            this.groupBoxResult_PEI.TabIndex = 3;
            this.groupBoxResult_PEI.TabStop = false;
            this.groupBoxResult_PEI.Text = "Вывод данных";
            // 
            // chartFunction_PEI
            // 
            this.chartFunction_PEI.AccessibleName = "";
            chartArea1.Name = "ChartArea1";
            this.chartFunction_PEI.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_PEI.Legends.Add(legend1);
            this.chartFunction_PEI.Location = new System.Drawing.Point(115, 19);
            this.chartFunction_PEI.Name = "chartFunction_PEI";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_PEI.Series.Add(series1);
            this.chartFunction_PEI.Size = new System.Drawing.Size(320, 289);
            this.chartFunction_PEI.TabIndex = 5;
            this.chartFunction_PEI.Text = "chart1";
            // 
            // dataGridViewFunction_PEI
            // 
            this.dataGridViewFunction_PEI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_PEI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnXY_PEI,
            this.ColumnX_PEI});
            this.dataGridViewFunction_PEI.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewFunction_PEI.Name = "dataGridViewFunction_PEI";
            this.dataGridViewFunction_PEI.RowHeadersVisible = false;
            this.dataGridViewFunction_PEI.Size = new System.Drawing.Size(103, 289);
            this.dataGridViewFunction_PEI.TabIndex = 0;
            // 
            // groupBoxTask_PEI
            // 
            this.groupBoxTask_PEI.Controls.Add(this.textBoxUslovie_PEI);
            this.groupBoxTask_PEI.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_PEI.Name = "groupBoxTask_PEI";
            this.groupBoxTask_PEI.Size = new System.Drawing.Size(386, 248);
            this.groupBoxTask_PEI.TabIndex = 4;
            this.groupBoxTask_PEI.TabStop = false;
            this.groupBoxTask_PEI.Text = "Условие";
            // 
            // textBoxUslovie_PEI
            // 
            this.textBoxUslovie_PEI.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxUslovie_PEI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUslovie_PEI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxUslovie_PEI.Location = new System.Drawing.Point(6, 19);
            this.textBoxUslovie_PEI.Multiline = true;
            this.textBoxUslovie_PEI.Name = "textBoxUslovie_PEI";
            this.textBoxUslovie_PEI.Size = new System.Drawing.Size(374, 87);
            this.textBoxUslovie_PEI.TabIndex = 5;
            this.textBoxUslovie_PEI.Text = "Написать программу, которая выводит таблицу значений функции. Значения округлить " +
    "до двух знаков после запятой.\r\n\r\n";
            // 
            // ColumnXY_PEI
            // 
            this.ColumnXY_PEI.HeaderText = "x";
            this.ColumnXY_PEI.Name = "ColumnXY_PEI";
            this.ColumnXY_PEI.Width = 50;
            // 
            // ColumnX_PEI
            // 
            this.ColumnX_PEI.HeaderText = "f(x)";
            this.ColumnX_PEI.Name = "ColumnX_PEI";
            this.ColumnX_PEI.Width = 50;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 338);
            this.Controls.Add(this.groupBoxTask_PEI);
            this.Controls.Add(this.groupBoxResult_PEI);
            this.Controls.Add(this.groupInput_PEI);
            this.Controls.Add(this.buttonHelp_PEI);
            this.Controls.Add(this.buttonDone_PEI);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Спринт 6 | Таск 2 | Вариант 9 | Полянцев Е.И.";
            this.groupInput_PEI.ResumeLayout(false);
            this.groupInput_PEI.PerformLayout();
            this.groupBoxResult_PEI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PEI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_PEI)).EndInit();
            this.groupBoxTask_PEI.ResumeLayout(false);
            this.groupBoxTask_PEI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_PEI;
        private System.Windows.Forms.Button buttonHelp_PEI;
        private System.Windows.Forms.GroupBox groupInput_PEI;
        private System.Windows.Forms.TextBox textBoxStartStep_PEI;
        private System.Windows.Forms.Label labelBoxStartStep_PEI;
        private System.Windows.Forms.Label labelBoxStopStep_PEI;
        private System.Windows.Forms.TextBox textBoxStopStep_PEI;
        private System.Windows.Forms.GroupBox groupBoxResult_PEI;
        private System.Windows.Forms.GroupBox groupBoxTask_PEI;
        private System.Windows.Forms.DataGridView dataGridViewFunction_PEI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_PEI;
        private System.Windows.Forms.TextBox textBoxUslovie_PEI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnXY_PEI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX_PEI;
    }
}

