using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PolyantsevEI.Sprint6.Task0.V3.Lib;

namespace Tyuiu.PolyantsevEI.Sprint6.Task0.V3
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonResult_PEI_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxRezulting_PEI.Text = ds.Calculate(Convert.ToInt32(textBoxZnach_PEI.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxZnach_PEI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47) || (e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнил студент группы ИСТНб-23-1 Полянцев Е.И.", "Сообщение");
        }
    }
}
