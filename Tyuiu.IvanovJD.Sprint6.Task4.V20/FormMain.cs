using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.IvanovJD.Sprint6.Task4.V20.Lib;
using System.IO;

namespace Tyuiu.IvanovJD.Sprint6.Task4.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_IJD_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxVarA_IJD.Text);
                int stopStep = Convert.ToInt32(textBoxVarB_IJD.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

               
                this.chartRezult_IJD.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartRezult_IJD.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxRezult_IJD.Text = "";

                chartRezult_IJD.Series[0].Points.Clear();

                for (int i = 0; i <= len - 1; i++)
                {
                    
                    this.chartRezult_IJD.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxRezult_IJD.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_IJD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ПКТб-23-2 Иванов Я.Д.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_IJD_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxRezult_IJD.Text);

                DialogResult dialogrezult = MessageBox.Show("Файл " + path + "сохранен успешно!\n Открыть его в блокноте?","Сщщищение", MessageBoxButtons.YesNo,MessageBoxIcon.Information);

                if (dialogrezult == DialogResult.Yes)
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
