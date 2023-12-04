
namespace Tyuiu.IvanovJD.Sprint6.Task4.V20
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
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDone_IJD = new System.Windows.Forms.Button();
            this.buttonSave_IJD = new System.Windows.Forms.Button();
            this.buttonInfo_IJD = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxRezult_IJD = new System.Windows.Forms.TextBox();
            this.chartRezult_IJD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxVarA_IJD = new System.Windows.Forms.TextBox();
            this.textBoxVarB_IJD = new System.Windows.Forms.TextBox();
            this.labelStart_IJD = new System.Windows.Forms.Label();
            this.labelKonec_IJD = new System.Windows.Forms.Label();
            this.labelUslovie_IJD = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRezult_IJD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelUslovie_IJD);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelKonec_IJD);
            this.groupBox2.Controls.Add(this.labelStart_IJD);
            this.groupBox2.Controls.Add(this.textBoxVarB_IJD);
            this.groupBox2.Controls.Add(this.textBoxVarA_IJD);
            this.groupBox2.Location = new System.Drawing.Point(494, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ввод данных:";
            // 
            // buttonDone_IJD
            // 
            this.buttonDone_IJD.Location = new System.Drawing.Point(815, 25);
            this.buttonDone_IJD.Name = "buttonDone_IJD";
            this.buttonDone_IJD.Size = new System.Drawing.Size(111, 69);
            this.buttonDone_IJD.TabIndex = 2;
            this.buttonDone_IJD.Text = "Выполнить";
            this.buttonDone_IJD.UseVisualStyleBackColor = true;
            this.buttonDone_IJD.Click += new System.EventHandler(this.buttonDone_IJD_Click);
            // 
            // buttonSave_IJD
            // 
            this.buttonSave_IJD.Location = new System.Drawing.Point(932, 25);
            this.buttonSave_IJD.Name = "buttonSave_IJD";
            this.buttonSave_IJD.Size = new System.Drawing.Size(107, 69);
            this.buttonSave_IJD.TabIndex = 3;
            this.buttonSave_IJD.Text = "Сохранить";
            this.buttonSave_IJD.UseVisualStyleBackColor = true;
            this.buttonSave_IJD.Click += new System.EventHandler(this.buttonSave_IJD_Click);
            // 
            // buttonInfo_IJD
            // 
            this.buttonInfo_IJD.Location = new System.Drawing.Point(1046, 25);
            this.buttonInfo_IJD.Name = "buttonInfo_IJD";
            this.buttonInfo_IJD.Size = new System.Drawing.Size(104, 69);
            this.buttonInfo_IJD.TabIndex = 4;
            this.buttonInfo_IJD.Text = "Справка";
            this.buttonInfo_IJD.UseVisualStyleBackColor = true;
            this.buttonInfo_IJD.Click += new System.EventHandler(this.buttonInfo_IJD_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxRezult_IJD);
            this.groupBox3.Location = new System.Drawing.Point(13, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(332, 391);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вывод:";
            // 
            // textBoxRezult_IJD
            // 
            this.textBoxRezult_IJD.Location = new System.Drawing.Point(7, 21);
            this.textBoxRezult_IJD.Multiline = true;
            this.textBoxRezult_IJD.Name = "textBoxRezult_IJD";
            this.textBoxRezult_IJD.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxRezult_IJD.Size = new System.Drawing.Size(319, 364);
            this.textBoxRezult_IJD.TabIndex = 0;
            // 
            // chartRezult_IJD
            // 
            chartArea3.Name = "ChartArea1";
            this.chartRezult_IJD.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartRezult_IJD.Legends.Add(legend3);
            this.chartRezult_IJD.Location = new System.Drawing.Point(352, 101);
            this.chartRezult_IJD.Name = "chartRezult_IJD";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartRezult_IJD.Series.Add(series3);
            this.chartRezult_IJD.Size = new System.Drawing.Size(798, 391);
            this.chartRezult_IJD.TabIndex = 6;
            this.chartRezult_IJD.Text = "Грфик функции sin(x):";
            title3.Name = "Title1";
            title3.Text = "Грфик функции sin(x):";
            this.chartRezult_IJD.Titles.Add(title3);
            // 
            // textBoxVarA_IJD
            // 
            this.textBoxVarA_IJD.Location = new System.Drawing.Point(7, 53);
            this.textBoxVarA_IJD.Name = "textBoxVarA_IJD";
            this.textBoxVarA_IJD.Size = new System.Drawing.Size(144, 22);
            this.textBoxVarA_IJD.TabIndex = 0;
            // 
            // textBoxVarB_IJD
            // 
            this.textBoxVarB_IJD.Location = new System.Drawing.Point(164, 53);
            this.textBoxVarB_IJD.Name = "textBoxVarB_IJD";
            this.textBoxVarB_IJD.Size = new System.Drawing.Size(144, 22);
            this.textBoxVarB_IJD.TabIndex = 1;
            // 
            // labelStart_IJD
            // 
            this.labelStart_IJD.AutoSize = true;
            this.labelStart_IJD.Location = new System.Drawing.Point(7, 30);
            this.labelStart_IJD.Name = "labelStart_IJD";
            this.labelStart_IJD.Size = new System.Drawing.Size(95, 17);
            this.labelStart_IJD.TabIndex = 2;
            this.labelStart_IJD.Text = "Страрт шага:";
            // 
            // labelKonec_IJD
            // 
            this.labelKonec_IJD.AutoSize = true;
            this.labelKonec_IJD.Location = new System.Drawing.Point(164, 30);
            this.labelKonec_IJD.Name = "labelKonec_IJD";
            this.labelKonec_IJD.Size = new System.Drawing.Size(89, 17);
            this.labelKonec_IJD.TabIndex = 3;
            this.labelKonec_IJD.Text = "Конец шага:";
            // 
            // labelUslovie_IJD
            // 
            this.labelUslovie_IJD.AutoSize = true;
            this.labelUslovie_IJD.Location = new System.Drawing.Point(7, 22);
            this.labelUslovie_IJD.Name = "labelUslovie_IJD";
            this.labelUslovie_IJD.Size = new System.Drawing.Size(456, 51);
            this.labelUslovie_IJD.TabIndex = 0;
            this.labelUslovie_IJD.Text = "Написать программу, которая выводит таблицу значений функции:\r\nF(x) = sin(x)-2x +" +
    " sin(x) - 3x + 2\r\n              3x-1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 504);
            this.Controls.Add(this.chartRezult_IJD);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonInfo_IJD);
            this.Controls.Add(this.buttonSave_IJD);
            this.Controls.Add(this.buttonDone_IJD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRezult_IJD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelKonec_IJD;
        private System.Windows.Forms.Label labelStart_IJD;
        private System.Windows.Forms.TextBox textBoxVarB_IJD;
        private System.Windows.Forms.TextBox textBoxVarA_IJD;
        private System.Windows.Forms.Button buttonDone_IJD;
        private System.Windows.Forms.Button buttonSave_IJD;
        private System.Windows.Forms.Button buttonInfo_IJD;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxRezult_IJD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRezult_IJD;
        private System.Windows.Forms.Label labelUslovie_IJD;
    }
}

