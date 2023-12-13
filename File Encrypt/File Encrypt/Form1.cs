using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Security.Cryptography;

namespace File_Encrypt
{
    public partial class Form1 : Form
    {
         Encrypt encrypt = new Encrypt();

        public Form1()
        {
            InitializeComponent();
        }
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMaHoa_Click(object sender, EventArgs e)
        {

            if (textBoxMatKhau.Text != "" && textBoxChonTep.Text != "")
            {
                encrypt.setPassword(textBoxMatKhau.Text)  ;
                encrypt.encryption(sender as Button, encrypt.getFilePath());
            }
            else if (textBoxChonTep.Text != "")
            {
                MessageBox.Show("Hãy nhập mật khẩu !");
            }
            else
            {
                MessageBox.Show("Hãy chọn file !");
            }
        }

        private void buttonGiaiMa_Click(object sender, EventArgs e)
        {
            if (textBoxMatKhau.Text != "" && textBoxChonTep.Text != "")
            {
                encrypt.setPassword(textBoxMatKhau.Text) ;
                encrypt.decryption(sender as Button, encrypt.getFilePath());
            }
            else if (textBoxChonTep.Text != "")
            {
                MessageBox.Show("Hãy nhập mật khẩu !");
            }
            else
            {
                MessageBox.Show("Hãy chọn file !");
            }
        }

        private void buttonXemTep_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (Path.GetFileName(encrypt.getFilePath()) == textBoxChonTep.Text)
                {
                    //MessageBox.Show(filePath);
                    if (File.Exists(encrypt.getFilePath()))
                    {
                        // Mở tệp tin bằng trình duyệt văn bản mặc định
                        var p = new Process();
                        p.StartInfo = new ProcessStartInfo(encrypt.getFilePath())
                        {
                            UseShellExecute = true
                        };
                        p.Start();

                    }
                    else
                    {
                        MessageBox.Show("Tệp tin không tồn tại.");
                    }
                }
                else
                {
                    MessageBox.Show($"Lỗi không đúng tên file");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void labelChonTep_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn một tệp tin";
            openFileDialog.Filter = "Tệp tin văn bản (*.txt)|*.txt|Tất cả các tệp tin (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                encrypt.setFilePath(openFileDialog.FileName)  ;
                try
                {
                    // Sử dụng Path.GetFileName để lấy tên tệp và Path.GetExtension để lấy đuôi tệp
                    string fileName = Path.GetFileName(encrypt.getFilePath());

                    // Hiển thị tên tệp và đuôi tệp trong MessageBox
                    //MessageBox.Show($"Bạn đã chọn tệp tin: {fileName}");

                    // Hiển thị tên tệp và đuôi tệp trong TextBox
                    textBoxChonTep.Text = $"{fileName}";
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }
        }

        private void textBoxChonTep_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelMatKhau_Click(object sender, EventArgs e)
        {

        }

    }
}