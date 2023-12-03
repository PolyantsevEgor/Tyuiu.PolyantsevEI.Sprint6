namespace Tyuiu.PolyantsevEI.Sprint6.Task3.V6
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
            this.buttonDone_PEI = new System.Windows.Forms.Button();
            this.groupBoxTask_PEI = new System.Windows.Forms.GroupBox();
            this.textBoxData_PEI = new System.Windows.Forms.TextBox();
            this.buttonHelp_PEI = new System.Windows.Forms.Button();
            this.groupBoxResult_PEI = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPutMatrix_PEI = new System.Windows.Forms.DataGridView();
            this.labelResult_PEI = new System.Windows.Forms.Label();
            this.dataGridViewInPutMatrix_PEI = new System.Windows.Forms.DataGridView();
            this.groupBoxTask_PEI.SuspendLayout();
            this.groupBoxResult_PEI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutMatrix_PEI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutMatrix_PEI)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone_PEI
            // 
            this.buttonDone_PEI.Location = new System.Drawing.Point(770, 275);
            this.buttonDone_PEI.Name = "buttonDone_PEI";
            this.buttonDone_PEI.Size = new System.Drawing.Size(89, 32);
            this.buttonDone_PEI.TabIndex = 0;
            this.buttonDone_PEI.Text = "Выполнить";
            this.buttonDone_PEI.UseVisualStyleBackColor = true;
            this.buttonDone_PEI.Click += new System.EventHandler(this.buttonDone_PEI_Click);
            // 
            // groupBoxTask_PEI
            // 
            this.groupBoxTask_PEI.Controls.Add(this.textBoxData_PEI);
            this.groupBoxTask_PEI.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_PEI.Name = "groupBoxTask_PEI";
            this.groupBoxTask_PEI.Size = new System.Drawing.Size(239, 295);
            this.groupBoxTask_PEI.TabIndex = 0;
            this.groupBoxTask_PEI.TabStop = false;
            this.groupBoxTask_PEI.Text = "Условие";
            // 
            // textBoxData_PEI
            // 
            this.textBoxData_PEI.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxData_PEI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxData_PEI.Location = new System.Drawing.Point(6, 19);
            this.textBoxData_PEI.Multiline = true;
            this.textBoxData_PEI.Name = "textBoxData_PEI";
            this.textBoxData_PEI.ReadOnly = true;
            this.textBoxData_PEI.Size = new System.Drawing.Size(226, 270);
            this.textBoxData_PEI.TabIndex = 0;
            this.textBoxData_PEI.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в третьей строке на 0.\r\n";
            // 
            // buttonHelp_PEI
            // 
            this.buttonHelp_PEI.Location = new System.Drawing.Point(730, 275);
            this.buttonHelp_PEI.Name = "buttonHelp_PEI";
            this.buttonHelp_PEI.Size = new System.Drawing.Size(34, 32);
            this.buttonHelp_PEI.TabIndex = 1;
            this.buttonHelp_PEI.Text = "?";
            this.buttonHelp_PEI.UseVisualStyleBackColor = true;
            this.buttonHelp_PEI.Click += new System.EventHandler(this.buttonHelp_PEI_Click);
            // 
            // groupBoxResult_PEI
            // 
            this.groupBoxResult_PEI.Controls.Add(this.dataGridViewOutPutMatrix_PEI);
            this.groupBoxResult_PEI.Controls.Add(this.labelResult_PEI);
            this.groupBoxResult_PEI.Location = new System.Drawing.Point(564, 12);
            this.groupBoxResult_PEI.Name = "groupBoxResult_PEI";
            this.groupBoxResult_PEI.Size = new System.Drawing.Size(295, 257);
            this.groupBoxResult_PEI.TabIndex = 2;
            this.groupBoxResult_PEI.TabStop = false;
            this.groupBoxResult_PEI.Text = "Вывод данных:";
            // 
            // dataGridViewOutPutMatrix_PEI
            // 
            this.dataGridViewOutPutMatrix_PEI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPutMatrix_PEI.Location = new System.Drawing.Point(6, 32);
            this.dataGridViewOutPutMatrix_PEI.Name = "dataGridViewOutPutMatrix_PEI";
            this.dataGridViewOutPutMatrix_PEI.Size = new System.Drawing.Size(280, 219);
            this.dataGridViewOutPutMatrix_PEI.TabIndex = 2;
            // 
            // labelResult_PEI
            // 
            this.labelResult_PEI.AutoSize = true;
            this.labelResult_PEI.Location = new System.Drawing.Point(6, 16);
            this.labelResult_PEI.Name = "labelResult_PEI";
            this.labelResult_PEI.Size = new System.Drawing.Size(59, 13);
            this.labelResult_PEI.TabIndex = 1;
            this.labelResult_PEI.Text = "Результат";
            // 
            // dataGridViewInPutMatrix_PEI
            // 
            this.dataGridViewInPutMatrix_PEI.Location = new System.Drawing.Point(257, 12);
            this.dataGridViewInPutMatrix_PEI.Name = "dataGridViewInPutMatrix_PEI";
            this.dataGridViewInPutMatrix_PEI.ReadOnly = true;
            this.dataGridViewInPutMatrix_PEI.Size = new System.Drawing.Size(299, 289);
            this.dataGridViewInPutMatrix_PEI.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 319);
            this.Controls.Add(this.dataGridViewInPutMatrix_PEI);
            this.Controls.Add(this.groupBoxResult_PEI);
            this.Controls.Add(this.buttonHelp_PEI);
            this.Controls.Add(this.groupBoxTask_PEI);
            this.Controls.Add(this.buttonDone_PEI);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 6 | Полянцев Е.И.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_PEI.ResumeLayout(false);
            this.groupBoxTask_PEI.PerformLayout();
            this.groupBoxResult_PEI.ResumeLayout(false);
            this.groupBoxResult_PEI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutMatrix_PEI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutMatrix_PEI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_PEI;
        private System.Windows.Forms.GroupBox groupBoxTask_PEI;
        private System.Windows.Forms.Button buttonHelp_PEI;
        private System.Windows.Forms.TextBox textBoxData_PEI;
        private System.Windows.Forms.GroupBox groupBoxResult_PEI;
        private System.Windows.Forms.DataGridView dataGridViewInPutMatrix_PEI;
        private System.Windows.Forms.Label labelResult_PEI;
        private System.Windows.Forms.DataGridView dataGridViewOutPutMatrix_PEI;
    }
}

