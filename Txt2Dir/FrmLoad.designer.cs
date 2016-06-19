namespace Txt2Dir
{
    partial class FrmLoad
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
            this.dlgFindFile = new System.Windows.Forms.OpenFileDialog();
            this.txtLoadFile = new System.Windows.Forms.TextBox();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTrg = new System.Windows.Forms.Button();
            this.txtTrg = new System.Windows.Forms.TextBox();
            this.dlgFold = new System.Windows.Forms.FolderBrowserDialog();
            this.btnParse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dlgFindFile
            // 
            this.dlgFindFile.FileName = "dlgFindFile";
            // 
            // txtLoadFile
            // 
            this.txtLoadFile.Location = new System.Drawing.Point(187, 48);
            this.txtLoadFile.Name = "txtLoadFile";
            this.txtLoadFile.Size = new System.Drawing.Size(431, 20);
            this.txtLoadFile.TabIndex = 0;
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(635, 48);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(39, 19);
            this.BtnLoad.TabIndex = 1;
            this.BtnLoad.Text = "...";
            this.BtnLoad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Target File";
            // 
            // btnTrg
            // 
            this.btnTrg.Location = new System.Drawing.Point(635, 121);
            this.btnTrg.Name = "btnTrg";
            this.btnTrg.Size = new System.Drawing.Size(39, 19);
            this.btnTrg.TabIndex = 4;
            this.btnTrg.Text = "...";
            this.btnTrg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTrg.UseVisualStyleBackColor = true;
            this.btnTrg.Click += new System.EventHandler(this.btnTrg_Click);
            // 
            // txtTrg
            // 
            this.txtTrg.Location = new System.Drawing.Point(187, 118);
            this.txtTrg.Name = "txtTrg";
            this.txtTrg.Size = new System.Drawing.Size(431, 20);
            this.txtTrg.TabIndex = 3;
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(326, 203);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(79, 41);
            this.btnParse.TabIndex = 6;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // FrmLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 262);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTrg);
            this.Controls.Add(this.txtTrg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.txtLoadFile);
            this.Name = "FrmLoad";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgFindFile;
        private System.Windows.Forms.TextBox txtLoadFile;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTrg;
        private System.Windows.Forms.TextBox txtTrg;
        private System.Windows.Forms.FolderBrowserDialog dlgFold;
        private System.Windows.Forms.Button btnParse;
    }
}