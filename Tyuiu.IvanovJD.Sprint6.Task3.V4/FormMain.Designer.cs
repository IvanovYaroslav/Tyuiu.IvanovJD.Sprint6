
namespace Tyuiu.IvanovJD.Sprint6.Task3.V4
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
            this.groupBoxUsl_IJD = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewUsl_IJD = new System.Windows.Forms.DataGridView();
            this.buttonInfo_IJD = new System.Windows.Forms.Button();
            this.buttonDone_IJD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2_IJD = new System.Windows.Forms.Label();
            this.dataGridViewRes_IJD = new System.Windows.Forms.DataGridView();
            this.groupBoxUsl_IJD.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsl_IJD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_IJD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUsl_IJD
            // 
            this.groupBoxUsl_IJD.Controls.Add(this.label2_IJD);
            this.groupBoxUsl_IJD.Controls.Add(this.dataGridViewUsl_IJD);
            this.groupBoxUsl_IJD.Location = new System.Drawing.Point(13, 13);
            this.groupBoxUsl_IJD.Name = "groupBoxUsl_IJD";
            this.groupBoxUsl_IJD.Size = new System.Drawing.Size(520, 277);
            this.groupBoxUsl_IJD.TabIndex = 0;
            this.groupBoxUsl_IJD.TabStop = false;
            this.groupBoxUsl_IJD.Text = "Условие:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewRes_IJD);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(539, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 248);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вывод данных:";
            // 
            // dataGridViewUsl_IJD
            // 
            this.dataGridViewUsl_IJD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsl_IJD.Location = new System.Drawing.Point(289, 38);
            this.dataGridViewUsl_IJD.Name = "dataGridViewUsl_IJD";
            this.dataGridViewUsl_IJD.RowHeadersWidth = 51;
            this.dataGridViewUsl_IJD.RowTemplate.Height = 24;
            this.dataGridViewUsl_IJD.Size = new System.Drawing.Size(225, 208);
            this.dataGridViewUsl_IJD.TabIndex = 0;
            // 
            // buttonInfo_IJD
            // 
            this.buttonInfo_IJD.Location = new System.Drawing.Point(584, 267);
            this.buttonInfo_IJD.Name = "buttonInfo_IJD";
            this.buttonInfo_IJD.Size = new System.Drawing.Size(22, 23);
            this.buttonInfo_IJD.TabIndex = 2;
            this.buttonInfo_IJD.Text = "?";
            this.buttonInfo_IJD.UseVisualStyleBackColor = true;
            this.buttonInfo_IJD.Click += new System.EventHandler(this.buttonInfo_IJD_Click);
            // 
            // buttonDone_IJD
            // 
            this.buttonDone_IJD.Location = new System.Drawing.Point(670, 266);
            this.buttonDone_IJD.Name = "buttonDone_IJD";
            this.buttonDone_IJD.Size = new System.Drawing.Size(113, 23);
            this.buttonDone_IJD.TabIndex = 3;
            this.buttonDone_IJD.Text = "Выполнить";
            this.buttonDone_IJD.UseVisualStyleBackColor = true;
            this.buttonDone_IJD.Click += new System.EventHandler(this.buttonDone_IJD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Результат:";
            // 
            // label2_IJD
            // 
            this.label2_IJD.AutoSize = true;
            this.label2_IJD.Location = new System.Drawing.Point(6, 18);
            this.label2_IJD.Name = "label2_IJD";
            this.label2_IJD.Size = new System.Drawing.Size(207, 85);
            this.label2_IJD.TabIndex = 1;
            this.label2_IJD.Text = "Дан массив 5 на 5 элементов.\r\n Заменить четные значения\r\n во второй строке на 0.\r" +
    "\n\r\n\r\n";
            // 
            // dataGridViewRes_IJD
            // 
            this.dataGridViewRes_IJD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_IJD.Location = new System.Drawing.Point(9, 38);
            this.dataGridViewRes_IJD.Name = "dataGridViewRes_IJD";
            this.dataGridViewRes_IJD.RowHeadersWidth = 51;
            this.dataGridViewRes_IJD.RowTemplate.Height = 24;
            this.dataGridViewRes_IJD.Size = new System.Drawing.Size(278, 208);
            this.dataGridViewRes_IJD.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.buttonDone_IJD);
            this.Controls.Add(this.buttonInfo_IJD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxUsl_IJD);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxUsl_IJD.ResumeLayout(false);
            this.groupBoxUsl_IJD.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsl_IJD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_IJD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUsl_IJD;
        private System.Windows.Forms.Label label2_IJD;
        private System.Windows.Forms.DataGridView dataGridViewUsl_IJD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInfo_IJD;
        private System.Windows.Forms.Button buttonDone_IJD;
        private System.Windows.Forms.DataGridView dataGridViewRes_IJD;
    }
}

