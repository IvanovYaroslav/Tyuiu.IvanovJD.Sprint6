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
using Tyuiu.IvanovJD.Sprint6.Task5.V8.Lib;
namespace Tyuiu.IvanovJD.Sprint6.Task5.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutFileTask5V8.txt";
        private void buttonDone_IJD_Click(object sender, EventArgs e)
        {
            dataGridViewNums_IJD.ColumnCount = 2;
            dataGridViewNums_IJD.Columns[0].Width = 20;
            dataGridViewNums_IJD.Columns[1].Width = 50;

            this.chartDiag_IJD.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_IJD.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_IJD.Series[0].Points.Clear();

            double[] numArray = new double[ds.len];
            numArray = ds.LoadFromDataFile(path);
            for (int i = 0; i < numArray.Length; i++)
            {
                dataGridViewNums_IJD.Rows.Add(Convert.ToString(i), Convert.ToString(numArray[i]));
                chartDiag_IJD.Series[0].Points.AddXY(i, numArray[i]);
            }
        }

        private void buttonInfo_IJD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ПКТб-23-2 Иванов Я.Д.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpen_IJD_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
