using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PolyantsevEI.Sprint6.Task1.V1.Lib;

namespace Tyuiu.PolyantsevEI.Sprint6.Task1.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_PEI_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int startStep = Convert.ToInt32(textBoxVarA_PEI.Text);
                int stopStep = Convert.ToInt32(textBoxVarB_PEI.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_PEI.Text = "";
                textBoxResult_PEI.AppendText("+----------+------------+" + Environment.NewLine);
                textBoxResult_PEI.AppendText("|    X     |     f(x)   |" + Environment.NewLine);
                textBoxResult_PEI.AppendText("+----------+------------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     | {1,7:f2}    |", startStep, valueArray[i]);
                    textBoxResult_PEI.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_PEI.AppendText("+----------+------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHelp_PEI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИСТНб-23-1 Полянцев Егор Ильич", "Сообщение");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}

