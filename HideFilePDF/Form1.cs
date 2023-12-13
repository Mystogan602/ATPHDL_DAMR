using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HideFilePDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPath_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                //fileDialog.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*"; // Set the file filter to only show PDF files

                DialogResult result = fileDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fileDialog.FileName))
                {
                    string selectedFilePath = fileDialog.FileName;
                    textBoxPath.Text = selectedFilePath;
                }
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string data = textBoxString.Text;
            string path = textBoxPath.Text;
            dataHider.HideDataInPdf(path, data);
        }
    }
}
