namespace Tyuiu.PolyantsevEI.Sprint6.Task6.V20
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
            this.groupBoxTask_PEI = new System.Windows.Forms.GroupBox();
            this.textBoxTask_PEI = new System.Windows.Forms.TextBox();
            this.panelInPut_PEI = new System.Windows.Forms.Panel();
            this.groupBoxInPut_PEI = new System.Windows.Forms.GroupBox();
            this.textBoxInPut_PEI = new System.Windows.Forms.TextBox();
            this.panelTask_PEI = new System.Windows.Forms.Panel();
            this.panelOutPut_PEI = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_PEI = new System.Windows.Forms.GroupBox();
            this.textBoxOutPut_PEI = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_PEI = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_PEI = new System.Windows.Forms.ToolTip(this.components);
            this.buttonHelp_PEI = new System.Windows.Forms.Button();
            this.buttonDoIt_PEI = new System.Windows.Forms.Button();
            this.buttonOpen_PEI = new System.Windows.Forms.Button();
            this.groupBoxTask_PEI.SuspendLayout();
            this.panelInPut_PEI.SuspendLayout();
            this.groupBoxInPut_PEI.SuspendLayout();
            this.panelTask_PEI.SuspendLayout();
            this.panelOutPut_PEI.SuspendLayout();
            this.groupBoxOutPut_PEI.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_PEI
            // 
            this.groupBoxTask_PEI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTask_PEI.Controls.Add(this.textBoxTask_PEI);
            this.groupBoxTask_PEI.Location = new System.Drawing.Point(16, 92);
            this.groupBoxTask_PEI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxTask_PEI.Name = "groupBoxTask_PEI";
            this.groupBoxTask_PEI.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxTask_PEI.Size = new System.Drawing.Size(1147, 102);
            this.groupBoxTask_PEI.TabIndex = 0;
            this.groupBoxTask_PEI.TabStop = false;
            this.groupBoxTask_PEI.Text = "Условие:";
            // 
            // textBoxTask_PEI
            // 
            this.textBoxTask_PEI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTask_PEI.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_PEI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_PEI.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTask_PEI.Location = new System.Drawing.Point(13, 25);
            this.textBoxTask_PEI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTask_PEI.Multiline = true;
            this.textBoxTask_PEI.Name = "textBoxTask_PEI";
            this.textBoxTask_PEI.ReadOnly = true;
            this.textBoxTask_PEI.Size = new System.Drawing.Size(1125, 70);
            this.textBoxTask_PEI.TabIndex = 0;
            this.textBoxTask_PEI.TabStop = false;
            this.textBoxTask_PEI.Text = "Дан файл, который может находится в любом месте на диске. Загрузить файл в textBo" +
    "xIn через openFileDialog. Вывести второе слово каждой строки в результирующею ст" +
    "року и вывести ее в textBoxOut.";
            // 
            // panelInPut_PEI
            // 
            this.panelInPut_PEI.Controls.Add(this.groupBoxInPut_PEI);
            this.panelInPut_PEI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInPut_PEI.Location = new System.Drawing.Point(0, 202);
            this.panelInPut_PEI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelInPut_PEI.Name = "panelInPut_PEI";
            this.panelInPut_PEI.Size = new System.Drawing.Size(1179, 427);
            this.panelInPut_PEI.TabIndex = 1;
            this.panelInPut_PEI.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInPut_PEI_Paint);
            // 
            // groupBoxInPut_PEI
            // 
            this.groupBoxInPut_PEI.Controls.Add(this.textBoxInPut_PEI);
            this.groupBoxInPut_PEI.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxInPut_PEI.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_PEI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxInPut_PEI.Name = "groupBoxInPut_PEI";
            this.groupBoxInPut_PEI.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxInPut_PEI.Size = new System.Drawing.Size(563, 427);
            this.groupBoxInPut_PEI.TabIndex = 0;
            this.groupBoxInPut_PEI.TabStop = false;
            this.groupBoxInPut_PEI.Text = "Ввод:";
            // 
            // textBoxInPut_PEI
            // 
            this.textBoxInPut_PEI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInPut_PEI.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxInPut_PEI.Location = new System.Drawing.Point(4, 19);
            this.textBoxInPut_PEI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxInPut_PEI.Multiline = true;
            this.textBoxInPut_PEI.Name = "textBoxInPut_PEI";
            this.textBoxInPut_PEI.ReadOnly = true;
            this.textBoxInPut_PEI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInPut_PEI.Size = new System.Drawing.Size(555, 404);
            this.textBoxInPut_PEI.TabIndex = 0;
            // 
            // panelTask_PEI
            // 
            this.panelTask_PEI.Controls.Add(this.buttonHelp_PEI);
            this.panelTask_PEI.Controls.Add(this.buttonDoIt_PEI);
            this.panelTask_PEI.Controls.Add(this.buttonOpen_PEI);
            this.panelTask_PEI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_PEI.Location = new System.Drawing.Point(0, 0);
            this.panelTask_PEI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTask_PEI.Name = "panelTask_PEI";
            this.panelTask_PEI.Size = new System.Drawing.Size(1179, 202);
            this.panelTask_PEI.TabIndex = 2;
            // 
            // panelOutPut_PEI
            // 
            this.panelOutPut_PEI.Controls.Add(this.groupBoxOutPut_PEI);
            this.panelOutPut_PEI.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelOutPut_PEI.Location = new System.Drawing.Point(576, 202);
            this.panelOutPut_PEI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelOutPut_PEI.Name = "panelOutPut_PEI";
            this.panelOutPut_PEI.Size = new System.Drawing.Size(603, 427);
            this.panelOutPut_PEI.TabIndex = 1;
            // 
            // groupBoxOutPut_PEI
            // 
            this.groupBoxOutPut_PEI.Controls.Add(this.textBoxOutPut_PEI);
            this.groupBoxOutPut_PEI.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxOutPut_PEI.Location = new System.Drawing.Point(4, 0);
            this.groupBoxOutPut_PEI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxOutPut_PEI.Name = "groupBoxOutPut_PEI";
            this.groupBoxOutPut_PEI.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxOutPut_PEI.Size = new System.Drawing.Size(599, 427);
            this.groupBoxOutPut_PEI.TabIndex = 0;
            this.groupBoxOutPut_PEI.TabStop = false;
            this.groupBoxOutPut_PEI.Text = "Вывод:";
            this.groupBoxOutPut_PEI.Enter += new System.EventHandler(this.groupBoxOutPut_PEI_Enter);
            // 
            // textBoxOutPut_PEI
            // 
            this.textBoxOutPut_PEI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutPut_PEI.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOutPut_PEI.Location = new System.Drawing.Point(4, 19);
            this.textBoxOutPut_PEI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxOutPut_PEI.Multiline = true;
            this.textBoxOutPut_PEI.Name = "textBoxOutPut_PEI";
            this.textBoxOutPut_PEI.ReadOnly = true;
            this.textBoxOutPut_PEI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPut_PEI.Size = new System.Drawing.Size(591, 404);
            this.textBoxOutPut_PEI.TabIndex = 0;
            // 
            // openFileDialogTask_PEI
            // 
            this.openFileDialogTask_PEI.FileName = "openFileDialogTask_PEI";
            // 
            // toolTip_PEI
            // 
            this.toolTip_PEI.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_PEI.ToolTipTitle = "Подсказда";
            // 
            // buttonHelp_PEI
            // 
            this.buttonHelp_PEI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_PEI.Image = global::Tyuiu.PolyantsevEI.Sprint6.Task6.V20.Properties.Resources.help;
            this.buttonHelp_PEI.Location = new System.Drawing.Point(1077, 15);
            this.buttonHelp_PEI.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHelp_PEI.Name = "buttonHelp_PEI";
            this.buttonHelp_PEI.Size = new System.Drawing.Size(97, 69);
            this.buttonHelp_PEI.TabIndex = 0;
            this.toolTip_PEI.SetToolTip(this.buttonHelp_PEI, "Сведения о программе");
            this.buttonHelp_PEI.UseVisualStyleBackColor = true;
            this.buttonHelp_PEI.Click += new System.EventHandler(this.buttonHelp_PEI_Click);
            // 
            // buttonDoIt_PEI
            // 
            this.buttonDoIt_PEI.Image = global::Tyuiu.PolyantsevEI.Sprint6.Task6.V20.Properties.Resources.page_go;
            this.buttonDoIt_PEI.Location = new System.Drawing.Point(121, 15);
            this.buttonDoIt_PEI.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDoIt_PEI.Name = "buttonDoIt_PEI";
            this.buttonDoIt_PEI.Size = new System.Drawing.Size(97, 69);
            this.buttonDoIt_PEI.TabIndex = 0;
            this.toolTip_PEI.SetToolTip(this.buttonDoIt_PEI, "Производит поиск и возвращает втророе слово каждой строки");
            this.buttonDoIt_PEI.UseVisualStyleBackColor = true;
            this.buttonDoIt_PEI.Click += new System.EventHandler(this.buttonDoIt_PEI_Click);
            // 
            // buttonOpen_PEI
            // 
            this.buttonOpen_PEI.Image = global::Tyuiu.PolyantsevEI.Sprint6.Task6.V20.Properties.Resources.folder_page;
            this.buttonOpen_PEI.Location = new System.Drawing.Point(16, 15);
            this.buttonOpen_PEI.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpen_PEI.Name = "buttonOpen_PEI";
            this.buttonOpen_PEI.Size = new System.Drawing.Size(97, 69);
            this.buttonOpen_PEI.TabIndex = 0;
            this.toolTip_PEI.SetToolTip(this.buttonOpen_PEI, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpen_PEI.UseVisualStyleBackColor = true;
            this.buttonOpen_PEI.Click += new System.EventHandler(this.buttonOpen_PEI_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 629);
            this.Controls.Add(this.panelOutPut_PEI);
            this.Controls.Add(this.panelInPut_PEI);
            this.Controls.Add(this.groupBoxTask_PEI);
            this.Controls.Add(this.panelTask_PEI);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1194, 666);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 20 | Полянцев Е.И.";
            this.groupBoxTask_PEI.ResumeLayout(false);
            this.groupBoxTask_PEI.PerformLayout();
            this.panelInPut_PEI.ResumeLayout(false);
            this.groupBoxInPut_PEI.ResumeLayout(false);
            this.groupBoxInPut_PEI.PerformLayout();
            this.panelTask_PEI.ResumeLayout(false);
            this.panelOutPut_PEI.ResumeLayout(false);
            this.groupBoxOutPut_PEI.ResumeLayout(false);
            this.groupBoxOutPut_PEI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_PEI;
        private System.Windows.Forms.TextBox textBoxTask_PEI;
        private System.Windows.Forms.Panel panelInPut_PEI;
        private System.Windows.Forms.GroupBox groupBoxInPut_PEI;
        private System.Windows.Forms.TextBox textBoxInPut_PEI;
        private System.Windows.Forms.Panel panelTask_PEI;
        private System.Windows.Forms.Button buttonHelp_PEI;
        private System.Windows.Forms.Button buttonDoIt_PEI;
        private System.Windows.Forms.Button buttonOpen_PEI;
        private System.Windows.Forms.Panel panelOutPut_PEI;
        private System.Windows.Forms.GroupBox groupBoxOutPut_PEI;
        private System.Windows.Forms.TextBox textBoxOutPut_PEI;
        private System.Windows.Forms.ToolTip toolTip_PEI;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_PEI;
    }
}

