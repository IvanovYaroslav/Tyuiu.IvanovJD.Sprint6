
namespace Tyuiu.IvanovJD.Sprint6.Task6.V16
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
            this.buttonHelp_IJD = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxUsl_IJD = new System.Windows.Forms.GroupBox();
            this.textBoxIn_IJD = new System.Windows.Forms.TextBox();
            this.groupBoxOut_IJD = new System.Windows.Forms.GroupBox();
            this.textBoxOut_IJD = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_IJD = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonOpenFile_IJD = new System.Windows.Forms.Button();
            this.buttonDone_IJD = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxUsl_IJD.SuspendLayout();
            this.groupBoxOut_IJD.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonHelp_IJD
            // 
            this.buttonHelp_IJD.Location = new System.Drawing.Point(795, 3);
            this.buttonHelp_IJD.Name = "buttonHelp_IJD";
            this.buttonHelp_IJD.Size = new System.Drawing.Size(100, 91);
            this.buttonHelp_IJD.TabIndex = 2;
            this.buttonHelp_IJD.Text = "Help";
            this.toolTip1.SetToolTip(this.buttonHelp_IJD, "Podskazka");
            this.buttonHelp_IJD.UseVisualStyleBackColor = true;
            this.buttonHelp_IJD.Click += new System.EventHandler(this.buttonHelp_IJD_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(882, 77);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(628, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // groupBoxUsl_IJD
            // 
            this.groupBoxUsl_IJD.Controls.Add(this.textBoxIn_IJD);
            this.groupBoxUsl_IJD.Location = new System.Drawing.Point(13, 178);
            this.groupBoxUsl_IJD.Name = "groupBoxUsl_IJD";
            this.groupBoxUsl_IJD.Size = new System.Drawing.Size(434, 325);
            this.groupBoxUsl_IJD.TabIndex = 4;
            this.groupBoxUsl_IJD.TabStop = false;
            this.groupBoxUsl_IJD.Text = "Vvod:";
            // 
            // textBoxIn_IJD
            // 
            this.textBoxIn_IJD.Location = new System.Drawing.Point(7, 22);
            this.textBoxIn_IJD.Multiline = true;
            this.textBoxIn_IJD.Name = "textBoxIn_IJD";
            this.textBoxIn_IJD.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxIn_IJD.Size = new System.Drawing.Size(421, 297);
            this.textBoxIn_IJD.TabIndex = 0;
            // 
            // groupBoxOut_IJD
            // 
            this.groupBoxOut_IJD.Controls.Add(this.textBoxOut_IJD);
            this.groupBoxOut_IJD.Location = new System.Drawing.Point(453, 178);
            this.groupBoxOut_IJD.Name = "groupBoxOut_IJD";
            this.groupBoxOut_IJD.Size = new System.Drawing.Size(442, 325);
            this.groupBoxOut_IJD.TabIndex = 5;
            this.groupBoxOut_IJD.TabStop = false;
            this.groupBoxOut_IJD.Text = "Viod:";
            // 
            // textBoxOut_IJD
            // 
            this.textBoxOut_IJD.Location = new System.Drawing.Point(6, 22);
            this.textBoxOut_IJD.Multiline = true;
            this.textBoxOut_IJD.Name = "textBoxOut_IJD";
            this.textBoxOut_IJD.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxOut_IJD.Size = new System.Drawing.Size(430, 297);
            this.textBoxOut_IJD.TabIndex = 1;
            // 
            // openFileDialogTask_IJD
            // 
            this.openFileDialogTask_IJD.FileName = "openFileDialogTask_IJD";
            // 
            // buttonOpenFile_IJD
            // 
            this.buttonOpenFile_IJD.Location = new System.Drawing.Point(23, 3);
            this.buttonOpenFile_IJD.Name = "buttonOpenFile_IJD";
            this.buttonOpenFile_IJD.Size = new System.Drawing.Size(100, 91);
            this.buttonOpenFile_IJD.TabIndex = 6;
            this.buttonOpenFile_IJD.Text = "Открыть файл";
            this.toolTip1.SetToolTip(this.buttonOpenFile_IJD, "Podskazka");
            this.buttonOpenFile_IJD.UseVisualStyleBackColor = true;
            this.buttonOpenFile_IJD.Click += new System.EventHandler(this.buttonOpenFile_IJD_Click);
            // 
            // buttonDone_IJD
            // 
            this.buttonDone_IJD.Location = new System.Drawing.Point(129, 3);
            this.buttonDone_IJD.Name = "buttonDone_IJD";
            this.buttonDone_IJD.Size = new System.Drawing.Size(100, 91);
            this.buttonDone_IJD.TabIndex = 7;
            this.buttonDone_IJD.Text = "Submit";
            this.toolTip1.SetToolTip(this.buttonDone_IJD, "Podskazka");
            this.buttonDone_IJD.UseVisualStyleBackColor = true;
            this.buttonDone_IJD.Click += new System.EventHandler(this.buttonDone_IJD_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 506);
            this.Controls.Add(this.buttonDone_IJD);
            this.Controls.Add(this.buttonOpenFile_IJD);
            this.Controls.Add(this.groupBoxOut_IJD);
            this.Controls.Add(this.groupBoxUsl_IJD);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonHelp_IJD);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxUsl_IJD.ResumeLayout(false);
            this.groupBoxUsl_IJD.PerformLayout();
            this.groupBoxOut_IJD.ResumeLayout(false);
            this.groupBoxOut_IJD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonHelp_IJD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxUsl_IJD;
        private System.Windows.Forms.GroupBox groupBoxOut_IJD;
        private System.Windows.Forms.TextBox textBoxIn_IJD;
        private System.Windows.Forms.TextBox textBoxOut_IJD;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_IJD;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonOpenFile_IJD;
        private System.Windows.Forms.Button buttonDone_IJD;
    }
}

