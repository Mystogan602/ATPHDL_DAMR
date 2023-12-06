using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Layout;
using iText.Layout.Element;

namespace FormMain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EmbedButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string pdfFilePath = openFileDialog.FileName;
                string inputText = DataToEmbedTextBox.Text;
                string outputFilePath = Path.Combine(Path.GetDirectoryName(pdfFilePath), "output.pdf");

                try
                {
                    EmbedTextInPDF(pdfFilePath, inputText, outputFilePath);
                    MessageBox.Show("Text embedded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error embedding text: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DecodeButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string pdfFilePath = openFileDialog.FileName;
                try
                {
                    string decodedText = DecodeTextFromPDF(pdfFilePath);
                    OutputTextBox.Text = decodedText;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error decoding text: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EmbedTextInPDF(string inputPdfPath, string textToEmbed, string outputPdfPath)
        {
            try
            {
                using (PdfReader reader = new PdfReader(inputPdfPath))
                {
                    using (PdfWriter writer = new PdfWriter(outputPdfPath))
                    {
                        using (PdfDocument pdf = new PdfDocument(reader, writer))
                        {
                            Document document = new Document(pdf);

                            // Embed the text in a hidden field
                            document.Add(new Paragraph(textToEmbed).SetFontColor(new iText.Kernel.Colors.DeviceRgb(255, 255, 255)).SetMargins(0, 0, 0, 0).SetFontSize(1));
                        }
                    }
                }
                MessageBox.Show("Text embedded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error embedding text: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string DecodeTextFromPDF(string pdfFilePath)
        {
            try
            {
                using (PdfReader reader = new PdfReader(pdfFilePath))
                {
                    using (PdfDocument pdf = new PdfDocument(reader))
                    {
                        StringBuilder decodedText = new StringBuilder();

                        for (int i = 1; i <= pdf.GetNumberOfPages(); i++)
                        {
                            ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                            string pageText = PdfTextExtractor.GetTextFromPage(pdf.GetPage(i), strategy);

                            decodedText.AppendLine(pageText.Trim());
                        }

                        return decodedText.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error decoding text: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

    }
}
