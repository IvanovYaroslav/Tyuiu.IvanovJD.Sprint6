using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.IvanovJD.Sprint6.Task6.V16.Lib;
using System.IO;

namespace Tyuiu.IvanovJD.Sprint6.Task6.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string openFilePath;



        private void buttonHelp_IJD_Click(object sender, EventArgs e)
        {
            FormAbout fromAbout = new FormAbout();
            fromAbout.ShowDialog();
        }

        private void buttonOpenFile_IJD_Click(object sender, EventArgs e)
        {
            openFileDialogTask_IJD.ShowDialog();
            openFilePath = openFileDialogTask_IJD.FileName;
            textBoxIn_IJD.Text = File.ReadAllText(openFilePath);
            groupBoxOut_IJD.Text = groupBoxOut_IJD.Text + " " + openFileDialogTask_IJD.FileName;
            buttonDone_IJD.Enabled = true;
        }

        private void buttonDone_IJD_Click(object sender, EventArgs e)
        {
            string str = "d";
            textBoxOut_IJD.Text = ds.CollectTextFromFile(str, openFilePath);
        }
    }
}
