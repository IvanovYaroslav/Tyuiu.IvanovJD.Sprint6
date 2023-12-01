using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.IvanovJD.Sprint6.Task1.V19.Lib;


namespace Tyuiu.IvanovJD.Sprint6.Task1.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_IJD_Click_Click(object sender, EventArgs e)
        {
            try
            {
                int startstep = Convert.ToInt32(textBoxStart_IJD.Text);
                int stopstep = Convert.ToInt32(textBoxFinish_IJD.Text);

                string strline;

                int len = ds.GetMassFunction(startstep, stopstep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startstep, stopstep);

                textBoxRes_IJD.Text = "";
                textBoxRes_IJD.AppendText("+----------+------------+" + Environment.NewLine);
                textBoxRes_IJD.AppendText("|    X     |    F(x)    |" + Environment.NewLine);
                textBoxRes_IJD.AppendText("+----------+------------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strline = String.Format("|{0,5:d}     |  {1, 6:f2}    | ", startstep, valueArray[i]);
                    textBoxRes_IJD.AppendText(strline + Environment.NewLine);
                    startstep++;
                }

                textBoxRes_IJD.AppendText("+----------+------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_IJD_Click_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ПКТб-23-2 Иванов Я.Д.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}