using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Pdf.Canvas;

namespace HideFilePDF
{
    class dataHider
    {
        public static void HideDataInPdf(string filePath, string dataToHide)
        {
            try
            {
                string outputFilePath = Path.Combine(Path.GetDirectoryName(filePath), "output.pdf");

                // Đọc toàn bộ nội dung của file PDF thành một mảng byte
                byte[] pdfBytes = File.ReadAllBytes(filePath);

                // Xử lý byte theo nhu cầu của bạn, ví dụ, thêm dữ liệu vào cuối file
                byte[] newData = System.Text.Encoding.UTF8.GetBytes(dataToHide);
                byte[] newPdfBytes = new byte[pdfBytes.Length + newData.Length];
                Buffer.BlockCopy(pdfBytes, 0, newPdfBytes, 0, pdfBytes.Length);
                Buffer.BlockCopy(newData, 0, newPdfBytes, pdfBytes.Length, newData.Length);

                // Ghi byte đã xử lý vào file mới
                File.WriteAllBytes(outputFilePath, newPdfBytes);

                Console.WriteLine("Đã ẩn dữ liệu thành công!");
            }     
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }
    }
}
