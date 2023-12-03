
namespace Tyuiu.IvanovJD.Sprint6.Task2.V15
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxUslovie_IJD = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDone_IJD_Click = new System.Windows.Forms.Button();
            this.buttonInfo_IJD_Click = new System.Windows.Forms.Button();
            this.Vvod_IJD = new System.Windows.Forms.GroupBox();
            this.DataGridViewRes_IJD = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartRes_IJD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelUslovie_IJD = new System.Windows.Forms.Label();
            this.textBoxVarA_IJD = new System.Windows.Forms.TextBox();
            this.textBoxVarB_IJD = new System.Windows.Forms.TextBox();
            this.groupBoxUslovie_IJD.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Vvod_IJD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRes_IJD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRes_IJD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_IJD
            // 
            this.groupBoxUslovie_IJD.Controls.Add(this.labelUslovie_IJD);
            this.groupBoxUslovie_IJD.Location = new System.Drawing.Point(13, 13);
            this.groupBoxUslovie_IJD.Name = "groupBoxUslovie_IJD";
            this.groupBoxUslovie_IJD.Size = new System.Drawing.Size(557, 369);
            this.groupBoxUslovie_IJD.TabIndex = 0;
            this.groupBoxUslovie_IJD.TabStop = false;
            this.groupBoxUslovie_IJD.Text = "Условие";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chartRes_IJD);
            this.groupBox2.Controls.Add(this.DataGridViewRes_IJD);
            this.groupBox2.Location = new System.Drawing.Point(577, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(761, 433);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // buttonDone_IJD_Click
            // 
            this.buttonDone_IJD_Click.Location = new System.Drawing.Point(459, 389);
            this.buttonDone_IJD_Click.Name = "buttonDone_IJD_Click";
            this.buttonDone_IJD_Click.Size = new System.Drawing.Size(110, 57);
            this.buttonDone_IJD_Click.TabIndex = 2;
            this.buttonDone_IJD_Click.Text = "Выполнить";
            this.buttonDone_IJD_Click.UseVisualStyleBackColor = true;
            this.buttonDone_IJD_Click.Click += new System.EventHandler(this.buttonDone_IJD_Click_Click);
            this.buttonDone_IJD_Click.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_IJD_Click_MouseDown);
            this.buttonDone_IJD_Click.MouseEnter += new System.EventHandler(this.buttonDone_IJD_Click_MouseEnter);
            this.buttonDone_IJD_Click.MouseLeave += new System.EventHandler(this.buttonDone_IJD_Click_MouseLeave);
            // 
            // buttonInfo_IJD_Click
            // 
            this.buttonInfo_IJD_Click.Location = new System.Drawing.Point(378, 389);
            this.buttonInfo_IJD_Click.Name = "buttonInfo_IJD_Click";
            this.buttonInfo_IJD_Click.Size = new System.Drawing.Size(75, 57);
            this.buttonInfo_IJD_Click.TabIndex = 3;
            this.buttonInfo_IJD_Click.Text = "Cправка";
            this.buttonInfo_IJD_Click.UseVisualStyleBackColor = true;
            this.buttonInfo_IJD_Click.Click += new System.EventHandler(this.buttonInfo_IJD_Click_Click);
            // 
            // Vvod_IJD
            // 
            this.Vvod_IJD.Controls.Add(this.textBoxVarB_IJD);
            this.Vvod_IJD.Controls.Add(this.textBoxVarA_IJD);
            this.Vvod_IJD.Location = new System.Drawing.Point(13, 388);
            this.Vvod_IJD.Name = "Vvod_IJD";
            this.Vvod_IJD.Size = new System.Drawing.Size(359, 58);
            this.Vvod_IJD.TabIndex = 4;
            this.Vvod_IJD.TabStop = false;
            this.Vvod_IJD.Text = "Ввод данных:";
            // 
            // DataGridViewRes_IJD
            // 
            this.DataGridViewRes_IJD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewRes_IJD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.y});
            this.DataGridViewRes_IJD.Location = new System.Drawing.Point(6, 21);
            this.DataGridViewRes_IJD.Name = "DataGridViewRes_IJD";
            this.DataGridViewRes_IJD.RowHeadersVisible = false;
            this.DataGridViewRes_IJD.RowHeadersWidth = 51;
            this.DataGridViewRes_IJD.RowTemplate.Height = 24;
            this.DataGridViewRes_IJD.Size = new System.Drawing.Size(240, 403);
            this.DataGridViewRes_IJD.TabIndex = 0;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Width = 75;
            // 
            // y
            // 
            this.y.HeaderText = "F(X)";
            this.y.MinimumWidth = 6;
            this.y.Name = "y";
            this.y.Width = 75;
            // 
            // chartRes_IJD
            // 
            chartArea5.Name = "ChartArea1";
            this.chartRes_IJD.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartRes_IJD.Legends.Add(legend5);
            this.chartRes_IJD.Location = new System.Drawing.Point(253, 21);
            this.chartRes_IJD.Name = "chartRes_IJD";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.IsVisibleInLegend = false;
            series5.IsXValueIndexed = true;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartRes_IJD.Series.Add(series5);
            this.chartRes_IJD.Size = new System.Drawing.Size(492, 403);
            this.chartRes_IJD.TabIndex = 1;
            this.chartRes_IJD.Text = "chart1";
            // 
            // labelUslovie_IJD
            // 
            this.labelUslovie_IJD.AutoSize = true;
            this.labelUslovie_IJD.Location = new System.Drawing.Point(7, 22);
            this.labelUslovie_IJD.Name = "labelUslovie_IJD";
            this.labelUslovie_IJD.Size = new System.Drawing.Size(456, 136);
            this.labelUslovie_IJD.TabIndex = 0;
            this.labelUslovie_IJD.Text = resources.GetString("labelUslovie_IJD.Text");
            // 
            // textBoxVarA_IJD
            // 
            this.textBoxVarA_IJD.Location = new System.Drawing.Point(10, 26);
            this.textBoxVarA_IJD.Name = "textBoxVarA_IJD";
            this.textBoxVarA_IJD.Size = new System.Drawing.Size(169, 22);
            this.textBoxVarA_IJD.TabIndex = 0;
            // 
            // textBoxVarB_IJD
            // 
            this.textBoxVarB_IJD.Location = new System.Drawing.Point(184, 26);
            this.textBoxVarB_IJD.Name = "textBoxVarB_IJD";
            this.textBoxVarB_IJD.Size = new System.Drawing.Size(169, 22);
            this.textBoxVarB_IJD.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 450);
            this.Controls.Add(this.Vvod_IJD);
            this.Controls.Add(this.buttonInfo_IJD_Click);
            this.Controls.Add(this.buttonDone_IJD_Click);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxUslovie_IJD);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.groupBoxUslovie_IJD.ResumeLayout(false);
            this.groupBoxUslovie_IJD.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.Vvod_IJD.ResumeLayout(false);
            this.Vvod_IJD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRes_IJD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRes_IJD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_IJD;
        private System.Windows.Forms.Label labelUslovie_IJD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes_IJD;
        private System.Windows.Forms.DataGridView DataGridViewRes_IJD;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.Button buttonDone_IJD_Click;
        private System.Windows.Forms.Button buttonInfo_IJD_Click;
        private System.Windows.Forms.GroupBox Vvod_IJD;
        private System.Windows.Forms.TextBox textBoxVarB_IJD;
        private System.Windows.Forms.TextBox textBoxVarA_IJD;
    }
}

