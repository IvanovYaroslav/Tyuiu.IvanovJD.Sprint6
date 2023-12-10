using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.IvanovJD.Sprint6.Task7.V29.Lib;
using System.IO;

namespace Tyuiu.IvanovJD.Sprint6.Task7.V29
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        static string openFilePath;
        static int rows;
        static int colums;
        DataService ds = new DataService();

        private void buttonOpenFile_IJD_Click(object sender, EventArgs e)
        {
            openFileDialogTask_IJD.ShowDialog();
            openFilePath = openFileDialogTask_IJD.FileName;

            int[,] matrix = ds.GetMatrix(openFilePath);

            dataGridViewIn_IJD.RowCount = matrix.GetLength(0);
            dataGridViewIn_IJD.ColumnCount = matrix.GetLength(1);
            dataGridViewOut_IJD.RowCount = matrix.GetLength(0);
            dataGridViewOut_IJD.ColumnCount = matrix.GetLength(1);

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                dataGridViewIn_IJD.Columns[i].Width = 25;
                dataGridViewOut_IJD.Columns[i].Width = 25;
            }

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    dataGridViewIn_IJD.Rows[r].Cells[c].Value = matrix[r, c];
                }
            }
            buttonDone_IJD.Enabled = true;
        }

        private void buttonDone_IJD_Click(object sender, EventArgs e)
        {
            string path = @"C:\DataSprint6\InPutFileTask7V29.csv";
            int[,] matrix = ds.GetMatrix(path);

            for (int r = 0; r < dataGridViewOut_IJD.RowCount; r++)
            {
                for (int c = 0; c < dataGridViewOut_IJD.ColumnCount; c++)
                {
                    if ((r == 4) && (matrix[r, c] >= -5) && (matrix[r, c] <= 10))
                        dataGridViewOut_IJD.Rows[r].Cells[c].Value = 99;
                    else
                        dataGridViewOut_IJD.Rows[r].Cells[c].Value = matrix[r, c];
                }
            }
            buttonSaveFile_IJD.Enabled = true;
        }

        private void buttonSaveFile_IJD_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_IJD.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_IJD.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_IJD.ShowDialog();

            string path = saveFileDialogMatrix_IJD.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            if (fileExist)
                File.Delete(path);

            int rows = dataGridViewOut_IJD.RowCount;
            int columns = dataGridViewOut_IJD.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                        str += dataGridViewOut_IJD.Rows[i].Cells[j].Value + ";";
                    else
                        str += dataGridViewOut_IJD.Rows[i].Cells[j].Value;

                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonHelp_IJD_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
