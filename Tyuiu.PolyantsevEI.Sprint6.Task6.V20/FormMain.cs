using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PolyantsevEI.Sprint6.Task6.V20.Lib;
using System.IO;

namespace Tyuiu.PolyantsevEI.Sprint6.Task6.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();
        private void buttonOpen_PEI_Click(object sender, EventArgs e)
        {
            openFileDialogTask_PEI.ShowDialog();
            openFilePath = openFileDialogTask_PEI.FileName;
            textBoxInPut_PEI.Text = File.ReadAllText(openFilePath);
            groupBoxOutPut_PEI.Text = groupBoxOutPut_PEI.Text + " " + openFileDialogTask_PEI.FileName;
            buttonDoIt_PEI.Enabled = true;
        }

        private void buttonDoIt_PEI_Click(object sender, EventArgs e)
        {
            textBoxOutPut_PEI.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_PEI_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void panelInPut_PEI_Paint(object sender, PaintEventArgs e)
        {
            //
        }

        private void groupBoxOutPut_PEI_Enter(object sender, EventArgs e)
        {

        }
    }
}
