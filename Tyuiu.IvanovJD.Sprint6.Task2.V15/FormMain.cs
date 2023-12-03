using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.IvanovJD.Sprint6.Task2.V15.Lib;

namespace Tyuiu.IvanovJD.Sprint6.Task2.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonInfo_IJD_Click_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ПКТб-23-2 Иванов Я.Д.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_IJD_Click_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxVarA_IJD.Text);
                int stopStep = Convert.ToInt32(textBoxVarB_IJD.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartRes_IJD.Titles.Add("График функции cos(x)");
                this.chartRes_IJD.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartRes_IJD.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.DataGridViewRes_IJD.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartRes_IJD.Series[0].Points.AddXY(startStep, valueArray[i]); ;
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_IJD_Click_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_IJD_Click.BackColor = Color.Blue;
        }

        private void buttonDone_IJD_Click_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_IJD_Click.BackColor = Color.Green;
        }

        private void buttonDone_IJD_Click_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_IJD_Click.BackColor = Color.Red;
        }
    }
    
}
