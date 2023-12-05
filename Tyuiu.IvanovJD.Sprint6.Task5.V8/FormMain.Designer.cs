
namespace Tyuiu.IvanovJD.Sprint6.Task5.V8
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonInfo_IJD = new System.Windows.Forms.Button();
            this.buttonDone_IJD = new System.Windows.Forms.Button();
            this.buttonOpen_IJD = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewNums_IJD = new System.Windows.Forms.DataGridView();
            this.chartDiag_IJD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_IJD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_IJD)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInfo_IJD
            // 
            this.buttonInfo_IJD.Location = new System.Drawing.Point(866, 13);
            this.buttonInfo_IJD.Name = "buttonInfo_IJD";
            this.buttonInfo_IJD.Size = new System.Drawing.Size(93, 69);
            this.buttonInfo_IJD.TabIndex = 0;
            this.buttonInfo_IJD.Text = "Справка";
            this.buttonInfo_IJD.UseVisualStyleBackColor = true;
            this.buttonInfo_IJD.Click += new System.EventHandler(this.buttonInfo_IJD_Click);
            // 
            // buttonDone_IJD
            // 
            this.buttonDone_IJD.Location = new System.Drawing.Point(668, 12);
            this.buttonDone_IJD.Name = "buttonDone_IJD";
            this.buttonDone_IJD.Size = new System.Drawing.Size(93, 70);
            this.buttonDone_IJD.TabIndex = 1;
            this.buttonDone_IJD.Text = "Выполнить";
            this.buttonDone_IJD.UseVisualStyleBackColor = true;
            this.buttonDone_IJD.Click += new System.EventHandler(this.buttonDone_IJD_Click);
            // 
            // buttonOpen_IJD
            // 
            this.buttonOpen_IJD.Location = new System.Drawing.Point(767, 12);
            this.buttonOpen_IJD.Name = "buttonOpen_IJD";
            this.buttonOpen_IJD.Size = new System.Drawing.Size(93, 69);
            this.buttonOpen_IJD.TabIndex = 2;
            this.buttonOpen_IJD.Text = "Открыть файл";
            this.buttonOpen_IJD.UseVisualStyleBackColor = true;
            this.buttonOpen_IJD.Click += new System.EventHandler(this.buttonOpen_IJD_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 81);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uslovie:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Прочитать данные из файла InPutFileTask5V8.txt. \r\nВывести в dataGridView. Дан спи" +
    "сок из чисел. Вывести все числа, меньше 0. \r\nУ вещественных значений округлить д" +
    "о трёх знаков после запятой.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewNums_IJD);
            this.groupBox2.Location = new System.Drawing.Point(13, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 377);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вывод данных:";
            // 
            // dataGridViewNums_IJD
            // 
            this.dataGridViewNums_IJD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums_IJD.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewNums_IJD.Name = "dataGridViewNums_IJD";
            this.dataGridViewNums_IJD.RowHeadersWidth = 51;
            this.dataGridViewNums_IJD.RowTemplate.Height = 24;
            this.dataGridViewNums_IJD.Size = new System.Drawing.Size(280, 349);
            this.dataGridViewNums_IJD.TabIndex = 0;
            // 
            // chartDiag_IJD
            // 
            chartArea3.Name = "ChartArea1";
            this.chartDiag_IJD.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chartDiag_IJD.Legends.Add(legend3);
            this.chartDiag_IJD.Location = new System.Drawing.Point(313, 88);
            this.chartDiag_IJD.Name = "chartDiag_IJD";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartDiag_IJD.Series.Add(series3);
            this.chartDiag_IJD.Size = new System.Drawing.Size(646, 377);
            this.chartDiag_IJD.TabIndex = 5;
            this.chartDiag_IJD.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 477);
            this.Controls.Add(this.chartDiag_IJD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonOpen_IJD);
            this.Controls.Add(this.buttonDone_IJD);
            this.Controls.Add(this.buttonInfo_IJD);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_IJD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_IJD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInfo_IJD;
        private System.Windows.Forms.Button buttonDone_IJD;
        private System.Windows.Forms.Button buttonOpen_IJD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewNums_IJD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_IJD;
    }
}

