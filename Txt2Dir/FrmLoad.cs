using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Txt2Dir
{
    public partial class FrmLoad : Form
    {
        public FrmLoad()
        {
            InitializeComponent();
        }

        private string trgFileName = "out.txt";
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            dlgFindFile.FileName = txtLoadFile.Text;
            if (string.IsNullOrEmpty(dlgFindFile.FileName))
                txtLoadFile.Text = Directory.GetCurrentDirectory();
            if (dlgFindFile.ShowDialog() == DialogResult.OK)
            {
                txtLoadFile.Text = dlgFindFile.FileName;
            }
        }

        private void btnTrg_Click(object sender, EventArgs e)
        {
            string path = GetCurrPathFromFileName(txtTrg.Text);
            dlgFold.SelectedPath = path;

            if (string.IsNullOrEmpty(dlgFold.SelectedPath))
                dlgFold.SelectedPath = Directory.GetCurrentDirectory();

            if (dlgFold.ShowDialog() == DialogResult.OK)
            {
                txtTrg.Text = dlgFold.SelectedPath +@"\"+ trgFileName;
            }
        }

        private string GetCurrPathFromFileName(string path)
        {
            if (string.IsNullOrEmpty(path) == false)
            {
                int lastPos = path.LastIndexOf(@"\", StringComparison.Ordinal);

                trgFileName = path.Substring(lastPos + 1);
                if (path.Substring(lastPos).Contains(@"."))
                    path = path.Substring(0, lastPos);
            }
            return path;
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            if (IsValidFileName(txtTrg.Text,true) && IsValidFileName(txtLoadFile.Text))
            {
                ParseFile(txtLoadFile.Text, txtTrg.Text);
            }
        }

        private void ParseFile(string srcFileName, string trgFileName)
        {
            ParseStream ps = new ParseStream();
            ps.ParseFile(srcFileName, trgFileName);
        }

        private bool IsValidFileName(string fileName,bool checkPathOnly=false)
        {
            if (string.IsNullOrEmpty(fileName))
                return false;

            if (checkPathOnly)
            {
                return Directory.Exists(GetCurrPathFromFileName(fileName));
            }
            else
            {
                return File.Exists(fileName);
            }
        }
    }
}
