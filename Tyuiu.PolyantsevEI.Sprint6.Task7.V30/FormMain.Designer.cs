namespace Tyuiu.PolyantsevEI.Sprint6.Task7.V30
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonInfo_PEI = new System.Windows.Forms.Button();
            this.buttonDone_PEI = new System.Windows.Forms.Button();
            this.buttonSave_PEI = new System.Windows.Forms.Button();
            this.buttonOpenFile_PEI = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxTask_PEI = new System.Windows.Forms.GroupBox();
            this.textBoxTask_PEI = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBoxIn_PEI = new System.Windows.Forms.GroupBox();
            this.dataGridIn_PEI = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBoxOut_PEI = new System.Windows.Forms.GroupBox();
            this.dataGridOut_PEI = new System.Windows.Forms.DataGridView();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.openFileDialogTask_PEI = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_PEI = new System.Windows.Forms.SaveFileDialog();
            this.toolTipButton_PEI = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxTask_PEI.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBoxIn_PEI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIn_PEI)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBoxOut_PEI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOut_PEI)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonInfo_PEI);
            this.panel1.Controls.Add(this.buttonDone_PEI);
            this.panel1.Controls.Add(this.buttonSave_PEI);
            this.panel1.Controls.Add(this.buttonOpenFile_PEI);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 79);
            this.panel1.TabIndex = 0;
            // 
            // buttonInfo_PEI
            // 
            this.buttonInfo_PEI.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonInfo_PEI.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_PEI.Image")));
            this.buttonInfo_PEI.Location = new System.Drawing.Point(512, 3);
            this.buttonInfo_PEI.Name = "buttonInfo_PEI";
            this.buttonInfo_PEI.Size = new System.Drawing.Size(85, 71);
            this.buttonInfo_PEI.TabIndex = 3;
            this.toolTipButton_PEI.SetToolTip(this.buttonInfo_PEI, "buttonHelp_PEI_MouseEnter");
            this.buttonInfo_PEI.UseVisualStyleBackColor = false;
            this.buttonInfo_PEI.Click += new System.EventHandler(this.buttonHelp_PEI_Click);
            // 
            // buttonDone_PEI
            // 
            this.buttonDone_PEI.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonDone_PEI.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_PEI.Image")));
            this.buttonDone_PEI.Location = new System.Drawing.Point(94, 3);
            this.buttonDone_PEI.Name = "buttonDone_PEI";
            this.buttonDone_PEI.Size = new System.Drawing.Size(85, 71);
            this.buttonDone_PEI.TabIndex = 1;
            this.toolTipButton_PEI.SetToolTip(this.buttonDone_PEI, "Выполнить");
            this.buttonDone_PEI.UseVisualStyleBackColor = false;
            this.buttonDone_PEI.Click += new System.EventHandler(this.buttonDone_PEI_Click);
            // 
            // buttonSave_PEI
            // 
            this.buttonSave_PEI.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonSave_PEI.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_PEI.Image")));
            this.buttonSave_PEI.Location = new System.Drawing.Point(185, 3);
            this.buttonSave_PEI.Name = "buttonSave_PEI";
            this.buttonSave_PEI.Size = new System.Drawing.Size(85, 71);
            this.buttonSave_PEI.TabIndex = 2;
            this.toolTipButton_PEI.SetToolTip(this.buttonSave_PEI, "Сохранить файл");
            this.buttonSave_PEI.UseVisualStyleBackColor = false;
            this.buttonSave_PEI.Click += new System.EventHandler(this.buttonSave_PEI_Click);
            // 
            // buttonOpenFile_PEI
            // 
            this.buttonOpenFile_PEI.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonOpenFile_PEI.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_PEI.Image")));
            this.buttonOpenFile_PEI.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenFile_PEI.Name = "buttonOpenFile_PEI";
            this.buttonOpenFile_PEI.Size = new System.Drawing.Size(85, 71);
            this.buttonOpenFile_PEI.TabIndex = 0;
            this.toolTipButton_PEI.SetToolTip(this.buttonOpenFile_PEI, "Открыть файл\r\n");
            this.buttonOpenFile_PEI.UseVisualStyleBackColor = false;
            this.buttonOpenFile_PEI.Click += new System.EventHandler(this.buttonOpen_PEI_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxTask_PEI);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 79);
            this.panel2.TabIndex = 1;
            // 
            // groupBoxTask_PEI
            // 
            this.groupBoxTask_PEI.Controls.Add(this.textBoxTask_PEI);
            this.groupBoxTask_PEI.Location = new System.Drawing.Point(3, 5);
            this.groupBoxTask_PEI.Name = "groupBoxTask_PEI";
            this.groupBoxTask_PEI.Size = new System.Drawing.Size(594, 68);
            this.groupBoxTask_PEI.TabIndex = 2;
            this.groupBoxTask_PEI.TabStop = false;
            this.groupBoxTask_PEI.Text = "Условие";
            // 
            // textBoxTask_PEI
            // 
            this.textBoxTask_PEI.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxTask_PEI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_PEI.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_PEI.Multiline = true;
            this.textBoxTask_PEI.Name = "textBoxTask_PEI";
            this.textBoxTask_PEI.Size = new System.Drawing.Size(572, 43);
            this.textBoxTask_PEI.TabIndex = 0;
            this.textBoxTask_PEI.Text = resources.GetString("textBoxTask_PEI.Text");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBoxIn_PEI);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 158);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 208);
            this.panel3.TabIndex = 0;
            // 
            // groupBoxIn_PEI
            // 
            this.groupBoxIn_PEI.Controls.Add(this.dataGridIn_PEI);
            this.groupBoxIn_PEI.Location = new System.Drawing.Point(3, 0);
            this.groupBoxIn_PEI.Name = "groupBoxIn_PEI";
            this.groupBoxIn_PEI.Size = new System.Drawing.Size(300, 207);
            this.groupBoxIn_PEI.TabIndex = 0;
            this.groupBoxIn_PEI.TabStop = false;
            this.groupBoxIn_PEI.Text = "Ввод";
            // 
            // dataGridIn_PEI
            // 
            this.dataGridIn_PEI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridIn_PEI.Location = new System.Drawing.Point(6, 19);
            this.dataGridIn_PEI.Name = "dataGridIn_PEI";
            this.dataGridIn_PEI.Size = new System.Drawing.Size(288, 182);
            this.dataGridIn_PEI.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBoxOut_PEI);
            this.panel4.Controls.Add(this.splitter2);
            this.panel4.Controls.Add(this.splitter1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(304, 158);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(296, 208);
            this.panel4.TabIndex = 0;
            // 
            // groupBoxOut_PEI
            // 
            this.groupBoxOut_PEI.Controls.Add(this.dataGridOut_PEI);
            this.groupBoxOut_PEI.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOut_PEI.Name = "groupBoxOut_PEI";
            this.groupBoxOut_PEI.Size = new System.Drawing.Size(293, 206);
            this.groupBoxOut_PEI.TabIndex = 2;
            this.groupBoxOut_PEI.TabStop = false;
            this.groupBoxOut_PEI.Text = "Вывод";
            // 
            // dataGridOut_PEI
            // 
            this.dataGridOut_PEI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOut_PEI.Location = new System.Drawing.Point(6, 19);
            this.dataGridOut_PEI.Name = "dataGridOut_PEI";
            this.dataGridOut_PEI.Size = new System.Drawing.Size(278, 181);
            this.dataGridOut_PEI.TabIndex = 2;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(3, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 208);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 208);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // openFileDialogTask_PEI
            // 
            this.openFileDialogTask_PEI.FileName = "openFileDialog1";
            // 
            // toolTipButton_PEI
            // 
            this.toolTipButton_PEI.IsBalloon = true;
            this.toolTipButton_PEI.OwnerDraw = true;
            this.toolTipButton_PEI.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 7 | Вариант 30 | Полянцев Е.И.";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBoxTask_PEI.ResumeLayout(false);
            this.groupBoxTask_PEI.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBoxIn_PEI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIn_PEI)).EndInit();
            this.panel4.ResumeLayout(false);
            this.groupBoxOut_PEI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOut_PEI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button buttonSave_PEI;
        private System.Windows.Forms.Button buttonDone_PEI;
        private System.Windows.Forms.Button buttonOpenFile_PEI;
        private System.Windows.Forms.GroupBox groupBoxIn_PEI;
        private System.Windows.Forms.GroupBox groupBoxOut_PEI;
        private System.Windows.Forms.Button buttonInfo_PEI;
        private System.Windows.Forms.GroupBox groupBoxTask_PEI;
        private System.Windows.Forms.TextBox textBoxTask_PEI;
        private System.Windows.Forms.DataGridView dataGridIn_PEI;
        private System.Windows.Forms.DataGridView dataGridOut_PEI;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_PEI;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_PEI;
        private System.Windows.Forms.ToolTip toolTipButton_PEI;
    }
}

