namespace Tyuiu.PolyantsevEI.Sprint6.Task4.V25
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartFunction_PEI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxOutArr_PEI = new System.Windows.Forms.GroupBox();
            this.groupBoxTask_PEI = new System.Windows.Forms.GroupBox();
            this.groupBoxInput_PEI = new System.Windows.Forms.GroupBox();
            this.buttonDone_PEI = new System.Windows.Forms.Button();
            this.buttonSave_PEI = new System.Windows.Forms.Button();
            this.buttonHelp_PEI = new System.Windows.Forms.Button();
            this.textBoxTask_PEI = new System.Windows.Forms.TextBox();
            this.textBoxStartIn_PEI = new System.Windows.Forms.TextBox();
            this.textBoxStopIn_PEI = new System.Windows.Forms.TextBox();
            this.textBoxStartOut_PEI = new System.Windows.Forms.TextBox();
            this.textBoxStopOut_PEI = new System.Windows.Forms.TextBox();
            this.textBoxOutArr_PEI = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PEI)).BeginInit();
            this.groupBoxOutArr_PEI.SuspendLayout();
            this.groupBoxTask_PEI.SuspendLayout();
            this.groupBoxInput_PEI.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartFunction_PEI
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_PEI.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction_PEI.Legends.Add(legend2);
            this.chartFunction_PEI.Location = new System.Drawing.Point(285, 124);
            this.chartFunction_PEI.Name = "chartFunction_PEI";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_PEI.Series.Add(series2);
            this.chartFunction_PEI.Size = new System.Drawing.Size(788, 464);
            this.chartFunction_PEI.TabIndex = 0;
            this.chartFunction_PEI.Text = "chart1";
            // 
            // groupBoxOutArr_PEI
            // 
            this.groupBoxOutArr_PEI.Controls.Add(this.textBoxOutArr_PEI);
            this.groupBoxOutArr_PEI.Location = new System.Drawing.Point(12, 118);
            this.groupBoxOutArr_PEI.Name = "groupBoxOutArr_PEI";
            this.groupBoxOutArr_PEI.Size = new System.Drawing.Size(267, 470);
            this.groupBoxOutArr_PEI.TabIndex = 1;
            this.groupBoxOutArr_PEI.TabStop = false;
            this.groupBoxOutArr_PEI.Text = "Вывод";
            // 
            // groupBoxTask_PEI
            // 
            this.groupBoxTask_PEI.Controls.Add(this.textBoxTask_PEI);
            this.groupBoxTask_PEI.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_PEI.Name = "groupBoxTask_PEI";
            this.groupBoxTask_PEI.Size = new System.Drawing.Size(457, 100);
            this.groupBoxTask_PEI.TabIndex = 2;
            this.groupBoxTask_PEI.TabStop = false;
            this.groupBoxTask_PEI.Text = "Условие";
            // 
            // groupBoxInput_PEI
            // 
            this.groupBoxInput_PEI.Controls.Add(this.textBoxStopOut_PEI);
            this.groupBoxInput_PEI.Controls.Add(this.textBoxStartOut_PEI);
            this.groupBoxInput_PEI.Controls.Add(this.textBoxStopIn_PEI);
            this.groupBoxInput_PEI.Controls.Add(this.textBoxStartIn_PEI);
            this.groupBoxInput_PEI.Location = new System.Drawing.Point(475, 12);
            this.groupBoxInput_PEI.Name = "groupBoxInput_PEI";
            this.groupBoxInput_PEI.Size = new System.Drawing.Size(253, 100);
            this.groupBoxInput_PEI.TabIndex = 0;
            this.groupBoxInput_PEI.TabStop = false;
            this.groupBoxInput_PEI.Text = "Ввод данных";
            // 
            // buttonDone_PEI
            // 
            this.buttonDone_PEI.BackColor = System.Drawing.Color.Lime;
            this.buttonDone_PEI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.buttonDone_PEI.Location = new System.Drawing.Point(734, 17);
            this.buttonDone_PEI.Name = "buttonDone_PEI";
            this.buttonDone_PEI.Size = new System.Drawing.Size(109, 95);
            this.buttonDone_PEI.TabIndex = 0;
            this.buttonDone_PEI.Text = "Выполнить";
            this.buttonDone_PEI.UseVisualStyleBackColor = false;
            this.buttonDone_PEI.Click += new System.EventHandler(this.buttonDone_PEI_Click);
            // 
            // buttonSave_PEI
            // 
            this.buttonSave_PEI.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSave_PEI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.buttonSave_PEI.Location = new System.Drawing.Point(849, 17);
            this.buttonSave_PEI.Name = "buttonSave_PEI";
            this.buttonSave_PEI.Size = new System.Drawing.Size(109, 95);
            this.buttonSave_PEI.TabIndex = 3;
            this.buttonSave_PEI.Text = "Сохранить";
            this.buttonSave_PEI.UseVisualStyleBackColor = false;
            this.buttonSave_PEI.Click += new System.EventHandler(this.buttonSave_PEI_Click);
            // 
            // buttonHelp_PEI
            // 
            this.buttonHelp_PEI.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonHelp_PEI.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonHelp_PEI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.buttonHelp_PEI.Location = new System.Drawing.Point(964, 17);
            this.buttonHelp_PEI.Name = "buttonHelp_PEI";
            this.buttonHelp_PEI.Size = new System.Drawing.Size(109, 95);
            this.buttonHelp_PEI.TabIndex = 4;
            this.buttonHelp_PEI.Text = "Справка";
            this.buttonHelp_PEI.UseVisualStyleBackColor = false;
            this.buttonHelp_PEI.Click += new System.EventHandler(this.buttonHelp_PEI_Click);
            // 
            // textBoxTask_PEI
            // 
            this.textBoxTask_PEI.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxTask_PEI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_PEI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F);
            this.textBoxTask_PEI.Location = new System.Drawing.Point(6, 21);
            this.textBoxTask_PEI.Multiline = true;
            this.textBoxTask_PEI.Name = "textBoxTask_PEI";
            this.textBoxTask_PEI.ReadOnly = true;
            this.textBoxTask_PEI.Size = new System.Drawing.Size(445, 73);
            this.textBoxTask_PEI.TabIndex = 5;
            this.textBoxTask_PEI.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5. Результат вывести в tex" +
    "tBox. Построить график функции и сохранитъ в файл OutPutFileTask4 по нажатию кно" +
    "пки.";
            // 
            // textBoxStartIn_PEI
            // 
            this.textBoxStartIn_PEI.Location = new System.Drawing.Point(6, 56);
            this.textBoxStartIn_PEI.Name = "textBoxStartIn_PEI";
            this.textBoxStartIn_PEI.Size = new System.Drawing.Size(114, 22);
            this.textBoxStartIn_PEI.TabIndex = 5;
            // 
            // textBoxStopIn_PEI
            // 
            this.textBoxStopIn_PEI.Location = new System.Drawing.Point(133, 56);
            this.textBoxStopIn_PEI.Name = "textBoxStopIn_PEI";
            this.textBoxStopIn_PEI.Size = new System.Drawing.Size(114, 22);
            this.textBoxStopIn_PEI.TabIndex = 6;
            // 
            // textBoxStartOut_PEI
            // 
            this.textBoxStartOut_PEI.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxStartOut_PEI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStartOut_PEI.Location = new System.Drawing.Point(6, 35);
            this.textBoxStartOut_PEI.Name = "textBoxStartOut_PEI";
            this.textBoxStartOut_PEI.ReadOnly = true;
            this.textBoxStartOut_PEI.Size = new System.Drawing.Size(114, 15);
            this.textBoxStartOut_PEI.TabIndex = 7;
            this.textBoxStartOut_PEI.Text = "Старт шага:";
            // 
            // textBoxStopOut_PEI
            // 
            this.textBoxStopOut_PEI.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxStopOut_PEI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStopOut_PEI.Location = new System.Drawing.Point(133, 35);
            this.textBoxStopOut_PEI.Name = "textBoxStopOut_PEI";
            this.textBoxStopOut_PEI.ReadOnly = true;
            this.textBoxStopOut_PEI.Size = new System.Drawing.Size(114, 15);
            this.textBoxStopOut_PEI.TabIndex = 8;
            this.textBoxStopOut_PEI.Text = "Конец шага:";
            // 
            // textBoxOutArr_PEI
            // 
            this.textBoxOutArr_PEI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxOutArr_PEI.Location = new System.Drawing.Point(3, 18);
            this.textBoxOutArr_PEI.Multiline = true;
            this.textBoxOutArr_PEI.Name = "textBoxOutArr_PEI";
            this.textBoxOutArr_PEI.ReadOnly = true;
            this.textBoxOutArr_PEI.Size = new System.Drawing.Size(258, 446);
            this.textBoxOutArr_PEI.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 600);
            this.Controls.Add(this.groupBoxInput_PEI);
            this.Controls.Add(this.buttonHelp_PEI);
            this.Controls.Add(this.buttonSave_PEI);
            this.Controls.Add(this.buttonDone_PEI);
            this.Controls.Add(this.groupBoxTask_PEI);
            this.Controls.Add(this.groupBoxOutArr_PEI);
            this.Controls.Add(this.chartFunction_PEI);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 4 | Вариант 25 | Полянцев Е.И.";
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PEI)).EndInit();
            this.groupBoxOutArr_PEI.ResumeLayout(false);
            this.groupBoxOutArr_PEI.PerformLayout();
            this.groupBoxTask_PEI.ResumeLayout(false);
            this.groupBoxTask_PEI.PerformLayout();
            this.groupBoxInput_PEI.ResumeLayout(false);
            this.groupBoxInput_PEI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_PEI;
        private System.Windows.Forms.GroupBox groupBoxOutArr_PEI;
        private System.Windows.Forms.GroupBox groupBoxTask_PEI;
        private System.Windows.Forms.GroupBox groupBoxInput_PEI;
        private System.Windows.Forms.Button buttonDone_PEI;
        private System.Windows.Forms.Button buttonSave_PEI;
        private System.Windows.Forms.Button buttonHelp_PEI;
        private System.Windows.Forms.TextBox textBoxTask_PEI;
        private System.Windows.Forms.TextBox textBoxStopIn_PEI;
        private System.Windows.Forms.TextBox textBoxStartIn_PEI;
        private System.Windows.Forms.TextBox textBoxStopOut_PEI;
        private System.Windows.Forms.TextBox textBoxStartOut_PEI;
        private System.Windows.Forms.TextBox textBoxOutArr_PEI;
    }
}

