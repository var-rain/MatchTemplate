using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchTemplate
{
    public partial class MainFrom : Form
    {
        private String source;
        private String template;
        public MainFrom()
        {
            InitializeComponent();
        }

        private void selectSourceBut_Click(object sender, EventArgs e)
        {
            String sourceFile = selectFile();
            if (sourceFile != null)
            {
                source = sourceFile;
            }
        }

        private String selectFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = "E:\\";
            dialog.Filter = "PNG|*.png|JPEG,JPG|*.jpg|所有文件|*.*";
            dialog.RestoreDirectory = true;
            dialog.Title = "选择图片";
            dialog.FilterIndex = 1;
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.FileName;
            }
            return null;
        }

        private void selectTemplateBut_Click(object sender, EventArgs e)
        {
            String templateFile = selectFile();
            if (templateFile != null)
            {
                template = templateFile;
            }
        }

        private void startBut_Click(object sender, EventArgs e)
        {
            /*
            if (source == null)
            {
                MessageBox.Show("请选择原始图片!");
                return;
            }
            if (template == null)
            {
                MessageBox.Show("请选择模板图片!");
                return;
            }*/

            NativeFunc.MatchResult result = new NativeFunc.MatchResult();
            if (NativeFunc.match(ref result) == 0)
            {
                resultText.Text = result.x + "_" + result.y + "_" + result.width + "_" + result.height + "_" + result.isMatch;
            }
        }
    }
}
