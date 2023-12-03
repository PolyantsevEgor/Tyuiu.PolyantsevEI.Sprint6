using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PolyantsevEI.Sprint6.Task2.V9.Lib;

namespace Tyuiu.PolyantsevEI.Sprint6.Task2.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_PEI_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_PEI.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_PEI.Text);



                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_PEI.Titles.Add("График функции");
                this.chartFunction_PEI.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_PEI.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_PEI.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_PEI.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_PEI_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_PEI.BackColor = Color.Red;
        }

        private void buttonDone_PEI_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_PEI.BackColor = Color.Green;
        }

        private void buttonDone_PEI_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_PEI.BackColor = Color.Blue;
        }

        private void buttonHelp_PEI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИСТНб-23-1 Полянцев Егор Ильич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
