
namespace Tyuiu.IvanovJD.Sprint6.Task0.V11
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
            this.buttonResult_JD = new System.Windows.Forms.Button();
            this.buttonHelp_JD = new System.Windows.Forms.Button();
            this.textBoxPress_JD = new System.Windows.Forms.TextBox();
            this.textBoxResult_JD = new System.Windows.Forms.TextBox();
            this.labelX_JD = new System.Windows.Forms.Label();
            this.labelRezult = new System.Windows.Forms.Label();
            this.labelFormula = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonResult_JD
            // 
            this.buttonResult_JD.Location = new System.Drawing.Point(652, 383);
            this.buttonResult_JD.Name = "buttonResult_JD";
            this.buttonResult_JD.Size = new System.Drawing.Size(136, 55);
            this.buttonResult_JD.TabIndex = 0;
            this.buttonResult_JD.Text = "Применить";
            this.buttonResult_JD.UseVisualStyleBackColor = true;
            this.buttonResult_JD.Click += new System.EventHandler(this.buttonResult_JD_Click);
            // 
            // buttonHelp_JD
            // 
            this.buttonHelp_JD.Location = new System.Drawing.Point(573, 383);
            this.buttonHelp_JD.Name = "buttonHelp_JD";
            this.buttonHelp_JD.Size = new System.Drawing.Size(75, 55);
            this.buttonHelp_JD.TabIndex = 1;
            this.buttonHelp_JD.Text = "?";
            this.buttonHelp_JD.UseVisualStyleBackColor = true;
            this.buttonHelp_JD.Click += new System.EventHandler(this.buttonHelp_JD_Click);
            // 
            // textBoxPress_JD
            // 
            this.textBoxPress_JD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPress_JD.Location = new System.Drawing.Point(45, 324);
            this.textBoxPress_JD.Name = "textBoxPress_JD";
            this.textBoxPress_JD.Size = new System.Drawing.Size(195, 32);
            this.textBoxPress_JD.TabIndex = 2;
            // 
            // textBoxResult_JD
            // 
            this.textBoxResult_JD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_JD.Location = new System.Drawing.Point(573, 324);
            this.textBoxResult_JD.Name = "textBoxResult_JD";
            this.textBoxResult_JD.ReadOnly = true;
            this.textBoxResult_JD.Size = new System.Drawing.Size(215, 32);
            this.textBoxResult_JD.TabIndex = 3;
            this.textBoxResult_JD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxResult_JD_KeyPress);
            // 
            // labelX_JD
            // 
            this.labelX_JD.AutoSize = true;
            this.labelX_JD.Location = new System.Drawing.Point(45, 288);
            this.labelX_JD.Name = "labelX_JD";
            this.labelX_JD.Size = new System.Drawing.Size(147, 17);
            this.labelX_JD.TabIndex = 4;
            this.labelX_JD.Text = "Введите значение Х:";
            // 
            // labelRezult
            // 
            this.labelRezult.AutoSize = true;
            this.labelRezult.Location = new System.Drawing.Point(570, 288);
            this.labelRezult.Name = "labelRezult";
            this.labelRezult.Size = new System.Drawing.Size(80, 17);
            this.labelRezult.TabIndex = 5;
            this.labelRezult.Text = "Результат:";
            // 
            // labelFormula
            // 
            this.labelFormula.AutoSize = true;
            this.labelFormula.Location = new System.Drawing.Point(42, 9);
            this.labelFormula.Name = "labelFormula";
            this.labelFormula.Size = new System.Drawing.Size(63, 17);
            this.labelFormula.TabIndex = 6;
            this.labelFormula.Text = "Условие";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Вычислить выражение по формуле :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(461, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 52);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFormula);
            this.Controls.Add(this.labelRezult);
            this.Controls.Add(this.labelX_JD);
            this.Controls.Add(this.textBoxResult_JD);
            this.Controls.Add(this.textBoxPress_JD);
            this.Controls.Add(this.buttonHelp_JD);
            this.Controls.Add(this.buttonResult_JD);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonResult_JD;
        private System.Windows.Forms.Button buttonHelp_JD;
        private System.Windows.Forms.TextBox textBoxPress_JD;
        private System.Windows.Forms.TextBox textBoxResult_JD;
        private System.Windows.Forms.Label labelX_JD;
        private System.Windows.Forms.Label labelRezult;
        private System.Windows.Forms.Label labelFormula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

