using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PolyantsevEI.Sprint6.Task3.V6.Lib;

namespace Tyuiu.PolyantsevEI.Sprint6.Task3.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] mtrx = new int[5, 5]
        {
            {  -2, -10, -8, 11, 1 },
            {  -15, -9, -4, -15, 18 },
            { -15, 12, 7, 6, 9 },
            {  -14, -10, 10, 18, -5 },
            {  -1, 7, -19, -19, -4 }
        };

        private void buttonDone_PEI_Click(object sender, EventArgs e)
        {
            int[,] result = ds.Calculate(mtrx);

            int rows = result.GetLength(0);
            int columns = result.GetLength(1);

            dataGridViewOutPutMatrix_PEI.ColumnCount = columns;
            dataGridViewOutPutMatrix_PEI.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {

                dataGridViewOutPutMatrix_PEI.Columns[i].Width = 35;

            }

            for (int i = 0; i < rows; i++)
            {
                dataGridViewOutPutMatrix_PEI.Rows[i].Height = 35;
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutPutMatrix_PEI.Rows[i].Cells[j].Value = Convert.ToString(result[i, j]);
                }
            }

        }

        private void buttonHelp_PEI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы ИСТНб-23-1 Чепурных Софья Романовна", "Сообщение");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;


            dataGridViewInPutMatrix_PEI.ColumnCount = columns;
            dataGridViewInPutMatrix_PEI.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPutMatrix_PEI.Columns[i].Width = 35;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    dataGridViewInPutMatrix_PEI.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

    }
}
