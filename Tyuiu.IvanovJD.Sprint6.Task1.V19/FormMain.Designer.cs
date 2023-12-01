
namespace Tyuiu.IvanovJD.Sprint6.Task1.V19
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDdjl_IJD = new System.Windows.Forms.GroupBox();
            this.labelVVodkonec_IJD = new System.Windows.Forms.Label();
            this.LabelStart_IJD = new System.Windows.Forms.Label();
            this.textBoxFinish_IJD = new System.Windows.Forms.TextBox();
            this.textBoxStart_IJD = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRes_IJD = new System.Windows.Forms.TextBox();
            this.buttonInfo_IJD_Click = new System.Windows.Forms.Button();
            this.buttonDone_IJD_Click = new System.Windows.Forms.Button();
            this.groupBoxTask1.SuspendLayout();
            this.groupBoxDdjl_IJD.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask1
            // 
            this.groupBoxTask1.Controls.Add(this.label1);
            this.groupBoxTask1.Location = new System.Drawing.Point(12, 26);
            this.groupBoxTask1.Name = "groupBoxTask1";
            this.groupBoxTask1.Size = new System.Drawing.Size(594, 311);
            this.groupBoxTask1.TabIndex = 0;
            this.groupBoxTask1.TabStop = false;
            this.groupBoxTask1.Text = "Условие";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 136);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // groupBoxDdjl_IJD
            // 
            this.groupBoxDdjl_IJD.Controls.Add(this.labelVVodkonec_IJD);
            this.groupBoxDdjl_IJD.Controls.Add(this.LabelStart_IJD);
            this.groupBoxDdjl_IJD.Controls.Add(this.textBoxFinish_IJD);
            this.groupBoxDdjl_IJD.Controls.Add(this.textBoxStart_IJD);
            this.groupBoxDdjl_IJD.Location = new System.Drawing.Point(31, 344);
            this.groupBoxDdjl_IJD.Name = "groupBoxDdjl_IJD";
            this.groupBoxDdjl_IJD.Size = new System.Drawing.Size(366, 100);
            this.groupBoxDdjl_IJD.TabIndex = 1;
            this.groupBoxDdjl_IJD.TabStop = false;
            this.groupBoxDdjl_IJD.Text = "Ввод Данных:";
            // 
            // labelVVodkonec_IJD
            // 
            this.labelVVodkonec_IJD.AutoSize = true;
            this.labelVVodkonec_IJD.Location = new System.Drawing.Point(194, 35);
            this.labelVVodkonec_IJD.Name = "labelVVodkonec_IJD";
            this.labelVVodkonec_IJD.Size = new System.Drawing.Size(89, 17);
            this.labelVVodkonec_IJD.TabIndex = 3;
            this.labelVVodkonec_IJD.Text = "Конец шага:";
            // 
            // LabelStart_IJD
            // 
            this.LabelStart_IJD.AutoSize = true;
            this.LabelStart_IJD.Location = new System.Drawing.Point(21, 35);
            this.LabelStart_IJD.Name = "LabelStart_IJD";
            this.LabelStart_IJD.Size = new System.Drawing.Size(87, 17);
            this.LabelStart_IJD.TabIndex = 2;
            this.LabelStart_IJD.Text = "Старт шага:";
            // 
            // textBoxFinish_IJD
            // 
            this.textBoxFinish_IJD.Location = new System.Drawing.Point(197, 58);
            this.textBoxFinish_IJD.Name = "textBoxFinish_IJD";
            this.textBoxFinish_IJD.Size = new System.Drawing.Size(149, 22);
            this.textBoxFinish_IJD.TabIndex = 1;
            // 
            // textBoxStart_IJD
            // 
            this.textBoxStart_IJD.Location = new System.Drawing.Point(21, 58);
            this.textBoxStart_IJD.Name = "textBoxStart_IJD";
            this.textBoxStart_IJD.Size = new System.Drawing.Size(149, 22);
            this.textBoxStart_IJD.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxRes_IJD);
            this.groupBox1.Location = new System.Drawing.Point(612, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 412);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вывод данных:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Результаты:";
            // 
            // textBoxRes_IJD
            // 
            this.textBoxRes_IJD.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRes_IJD.Location = new System.Drawing.Point(7, 39);
            this.textBoxRes_IJD.Multiline = true;
            this.textBoxRes_IJD.Name = "textBoxRes_IJD";
            this.textBoxRes_IJD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRes_IJD.Size = new System.Drawing.Size(282, 359);
            this.textBoxRes_IJD.TabIndex = 0;
            // 
            // buttonInfo_IJD_Click
            // 
            this.buttonInfo_IJD_Click.Location = new System.Drawing.Point(404, 353);
            this.buttonInfo_IJD_Click.Name = "buttonInfo_IJD_Click";
            this.buttonInfo_IJD_Click.Size = new System.Drawing.Size(75, 91);
            this.buttonInfo_IJD_Click.TabIndex = 3;
            this.buttonInfo_IJD_Click.Text = "Справка";
            this.buttonInfo_IJD_Click.UseVisualStyleBackColor = true;
            this.buttonInfo_IJD_Click.Click += new System.EventHandler(this.buttonInfo_IJD_Click_Click);
            // 
            // buttonDone_IJD_Click
            // 
            this.buttonDone_IJD_Click.Location = new System.Drawing.Point(486, 353);
            this.buttonDone_IJD_Click.Name = "buttonDone_IJD_Click";
            this.buttonDone_IJD_Click.Size = new System.Drawing.Size(120, 91);
            this.buttonDone_IJD_Click.TabIndex = 4;
            this.buttonDone_IJD_Click.Text = "Выполнить";
            this.buttonDone_IJD_Click.UseVisualStyleBackColor = true;
            this.buttonDone_IJD_Click.Click += new System.EventHandler(this.buttonDone_IJD_Click_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 450);
            this.Controls.Add(this.buttonDone_IJD_Click);
            this.Controls.Add(this.buttonInfo_IJD_Click);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxDdjl_IJD);
            this.Controls.Add(this.groupBoxTask1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.groupBoxTask1.ResumeLayout(false);
            this.groupBoxTask1.PerformLayout();
            this.groupBoxDdjl_IJD.ResumeLayout(false);
            this.groupBoxDdjl_IJD.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxDdjl_IJD;
        private System.Windows.Forms.TextBox textBoxFinish_IJD;
        private System.Windows.Forms.TextBox textBoxStart_IJD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelVVodkonec_IJD;
        private System.Windows.Forms.Label LabelStart_IJD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRes_IJD;
        private System.Windows.Forms.Button buttonInfo_IJD_Click;
        private System.Windows.Forms.Button buttonDone_IJD_Click;
    }
}

