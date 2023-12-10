
namespace Tyuiu.IvanovJD.Sprint6.Task7.V29
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonOpenFile_IJD = new System.Windows.Forms.Button();
            this.buttonDone_IJD = new System.Windows.Forms.Button();
            this.buttonSaveFile_IJD = new System.Windows.Forms.Button();
            this.buttonHelp_IJD = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn_IJD = new System.Windows.Forms.DataGridView();
            this.dataGridViewOut_IJD = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_IJD = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_IJD = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_IJD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_IJD)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenFile_IJD
            // 
            this.buttonOpenFile_IJD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_IJD.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_IJD.Image")));
            this.buttonOpenFile_IJD.Location = new System.Drawing.Point(13, 13);
            this.buttonOpenFile_IJD.Name = "buttonOpenFile_IJD";
            this.buttonOpenFile_IJD.Size = new System.Drawing.Size(87, 80);
            this.buttonOpenFile_IJD.TabIndex = 0;
            this.buttonOpenFile_IJD.UseVisualStyleBackColor = true;
            this.buttonOpenFile_IJD.Click += new System.EventHandler(this.buttonOpenFile_IJD_Click);
            // 
            // buttonDone_IJD
            // 
            this.buttonDone_IJD.Enabled = false;
            this.buttonDone_IJD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_IJD.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_IJD.Image")));
            this.buttonDone_IJD.Location = new System.Drawing.Point(106, 13);
            this.buttonDone_IJD.Name = "buttonDone_IJD";
            this.buttonDone_IJD.Size = new System.Drawing.Size(87, 80);
            this.buttonDone_IJD.TabIndex = 1;
            this.buttonDone_IJD.UseVisualStyleBackColor = true;
            this.buttonDone_IJD.Click += new System.EventHandler(this.buttonDone_IJD_Click);
            // 
            // buttonSaveFile_IJD
            // 
            this.buttonSaveFile_IJD.Enabled = false;
            this.buttonSaveFile_IJD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile_IJD.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_IJD.Image")));
            this.buttonSaveFile_IJD.Location = new System.Drawing.Point(199, 13);
            this.buttonSaveFile_IJD.Name = "buttonSaveFile_IJD";
            this.buttonSaveFile_IJD.Size = new System.Drawing.Size(87, 80);
            this.buttonSaveFile_IJD.TabIndex = 2;
            this.buttonSaveFile_IJD.UseVisualStyleBackColor = true;
            this.buttonSaveFile_IJD.Click += new System.EventHandler(this.buttonSaveFile_IJD_Click);
            // 
            // buttonHelp_IJD
            // 
            this.buttonHelp_IJD.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_IJD.Image")));
            this.buttonHelp_IJD.Location = new System.Drawing.Point(923, 13);
            this.buttonHelp_IJD.Name = "buttonHelp_IJD";
            this.buttonHelp_IJD.Size = new System.Drawing.Size(87, 80);
            this.buttonHelp_IJD.TabIndex = 3;
            this.buttonHelp_IJD.UseVisualStyleBackColor = true;
            this.buttonHelp_IJD.Click += new System.EventHandler(this.buttonHelp_IJD_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1016, 77);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1012, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewIn_IJD);
            this.groupBox2.Location = new System.Drawing.Point(0, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 350);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ввод:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewOut_IJD);
            this.groupBox3.Location = new System.Drawing.Point(500, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(516, 350);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вывод:";
            // 
            // dataGridViewIn_IJD
            // 
            this.dataGridViewIn_IJD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_IJD.Location = new System.Drawing.Point(10, 22);
            this.dataGridViewIn_IJD.Name = "dataGridViewIn_IJD";
            this.dataGridViewIn_IJD.RowHeadersWidth = 51;
            this.dataGridViewIn_IJD.RowTemplate.Height = 24;
            this.dataGridViewIn_IJD.Size = new System.Drawing.Size(478, 328);
            this.dataGridViewIn_IJD.TabIndex = 0;
            // 
            // dataGridViewOut_IJD
            // 
            this.dataGridViewOut_IJD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_IJD.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewOut_IJD.Name = "dataGridViewOut_IJD";
            this.dataGridViewOut_IJD.RowHeadersWidth = 51;
            this.dataGridViewOut_IJD.RowTemplate.Height = 24;
            this.dataGridViewOut_IJD.Size = new System.Drawing.Size(504, 328);
            this.dataGridViewOut_IJD.TabIndex = 1;
            // 
            // openFileDialogTask_IJD
            // 
            this.openFileDialogTask_IJD.FileName = "openFileDialogTask";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 530);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonHelp_IJD);
            this.Controls.Add(this.buttonSaveFile_IJD);
            this.Controls.Add(this.buttonDone_IJD);
            this.Controls.Add(this.buttonOpenFile_IJD);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_IJD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_IJD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile_IJD;
        private System.Windows.Forms.Button buttonDone_IJD;
        private System.Windows.Forms.Button buttonSaveFile_IJD;
        private System.Windows.Forms.Button buttonHelp_IJD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewIn_IJD;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewOut_IJD;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_IJD;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_IJD;
    }
}

