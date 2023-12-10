using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PolyantsevEI.Sprint6.Task7.V30.Lib;
using System.IO;

namespace Tyuiu.PolyantsevEI.Sprint6.Task7.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridIn_PEI.ColumnCount = 50;
            dataGridOut_PEI.ColumnCount = 50;

            dataGridIn_PEI.RowCount = 50;
            dataGridOut_PEI.RowCount = 50;
        }

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonOpen_PEI_Click(object sender, EventArgs e)
        {
            openFileDialogTask_PEI.ShowDialog();
            openFilePath = openFileDialogTask_PEI.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridIn_PEI.ColumnCount = columns;
            dataGridIn_PEI.RowCount = rows;
            dataGridOut_PEI.RowCount = rows;
            dataGridOut_PEI.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridIn_PEI.Columns[i].Width = 25;
                dataGridOut_PEI.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridIn_PEI.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_PEI.Enabled = true;
        }

        private void buttonDone_PEI_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridOut_PEI.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_PEI.Enabled = true;

        }

        private void buttonSave_PEI_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_PEI.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_PEI.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_PEI.ShowDialog();

            string path = saveFileDialogMatrix_PEI.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridOut_PEI.RowCount;
            int columns = dataGridOut_PEI.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridOut_PEI.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridOut_PEI.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpen_PEI_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_PEI.ToolTipTitle = "Открыть файл";
        }

        private void buttonDoIt_PEI_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_PEI.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_PEI_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_PEI.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_PEI_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonHelp_PEI_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_PEI.ToolTipTitle = "Справка";
        }

    }
}
