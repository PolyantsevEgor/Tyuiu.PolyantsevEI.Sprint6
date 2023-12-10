using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.PolyantsevEI.Sprint6.Task4.V25.Lib;

namespace Tyuiu.PolyantsevEI.Sprint6.Task4.V25
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
                int start = Convert.ToInt32(textBoxStartIn_PEI.Text);
                int stop = Convert.ToInt32(textBoxStopIn_PEI.Text);
                int len = stop - start + 1;
                double[] array = ds.GetMassFunction(start, stop);

                textBoxOutArr_PEI.Text = "";
                chartFunction_PEI.Series[0].Points.Clear();
                this.chartFunction_PEI.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_PEI.ChartAreas[0].AxisY.Title = "Ось y";

                for (int i = 0; i < len; i++)
                {
                    textBoxOutArr_PEI.AppendText(Convert.ToString(array[i]) + Environment.NewLine);
                    chartFunction_PEI.Series[0].Points.AddXY(start, array[i]);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_PEI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИСТНб-23-1 Полянцев Егор Ильич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_PEI_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V25.txt";
                File.WriteAllText(path, textBoxOutArr_PEI.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
