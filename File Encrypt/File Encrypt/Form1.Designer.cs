namespace File_Encrypt
{
    partial class Form1
    { /// <summary>
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
            this.buttonThoat = new System.Windows.Forms.Button();
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.labelMatKhau = new System.Windows.Forms.Label();
            this.buttonMaHoa = new System.Windows.Forms.Button();
            this.buttonGiaiMa = new System.Windows.Forms.Button();
            this.buttonXemTep = new System.Windows.Forms.Button();
            this.labelChonTep = new System.Windows.Forms.Label();
            this.textBoxChonTep = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonThoat.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(655, 364);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(106, 57);
            this.buttonThoat.TabIndex = 0;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxMatKhau.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMatKhau.Location = new System.Drawing.Point(258, 55);
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.Size = new System.Drawing.Size(503, 42);
            this.textBoxMatKhau.TabIndex = 1;
            this.textBoxMatKhau.TextChanged += new System.EventHandler(this.textBoxMatKhau_TextChanged);
            // 
            // labelMatKhau
            // 
            this.labelMatKhau.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMatKhau.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatKhau.Location = new System.Drawing.Point(49, 55);
            this.labelMatKhau.Name = "labelMatKhau";
            this.labelMatKhau.Size = new System.Drawing.Size(172, 42);
            this.labelMatKhau.TabIndex = 2;
            this.labelMatKhau.Text = "Mật khẩu    :";
            this.labelMatKhau.Click += new System.EventHandler(this.labelMatKhau_Click);
            // 
            // buttonMaHoa
            // 
            this.buttonMaHoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonMaHoa.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMaHoa.Location = new System.Drawing.Point(49, 268);
            this.buttonMaHoa.Name = "buttonMaHoa";
            this.buttonMaHoa.Size = new System.Drawing.Size(160, 56);
            this.buttonMaHoa.TabIndex = 4;
            this.buttonMaHoa.Text = "Mã hóa";
            this.buttonMaHoa.UseVisualStyleBackColor = false;
            this.buttonMaHoa.Click += new System.EventHandler(this.buttonMaHoa_Click);
            // 
            // buttonGiaiMa
            // 
            this.buttonGiaiMa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGiaiMa.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGiaiMa.Location = new System.Drawing.Point(306, 266);
            this.buttonGiaiMa.Name = "buttonGiaiMa";
            this.buttonGiaiMa.Size = new System.Drawing.Size(166, 56);
            this.buttonGiaiMa.TabIndex = 5;
            this.buttonGiaiMa.Text = "Giải mã";
            this.buttonGiaiMa.UseVisualStyleBackColor = false;
            this.buttonGiaiMa.Click += new System.EventHandler(this.buttonGiaiMa_Click);
            // 
            // buttonXemTep
            // 
            this.buttonXemTep.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonXemTep.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXemTep.Location = new System.Drawing.Point(585, 266);
            this.buttonXemTep.Name = "buttonXemTep";
            this.buttonXemTep.Size = new System.Drawing.Size(176, 56);
            this.buttonXemTep.TabIndex = 6;
            this.buttonXemTep.Text = "Xem tệp";
            this.buttonXemTep.UseVisualStyleBackColor = false;
            this.buttonXemTep.Click += new System.EventHandler(this.buttonXemTep_Click);
            // 
            // labelChonTep
            // 
            this.labelChonTep.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelChonTep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelChonTep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelChonTep.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChonTep.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelChonTep.Location = new System.Drawing.Point(49, 167);
            this.labelChonTep.Name = "labelChonTep";
            this.labelChonTep.Size = new System.Drawing.Size(160, 42);
            this.labelChonTep.TabIndex = 7;
            this.labelChonTep.Text = "Chọn tệp";
            this.labelChonTep.Click += new System.EventHandler(this.labelChonTep_Click);
            // 
            // textBoxChonTep
            // 
            this.textBoxChonTep.AcceptsReturn = true;
            this.textBoxChonTep.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxChonTep.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChonTep.Location = new System.Drawing.Point(258, 167);
            this.textBoxChonTep.Name = "textBoxChonTep";
            this.textBoxChonTep.Size = new System.Drawing.Size(503, 42);
            this.textBoxChonTep.TabIndex = 8;
            this.textBoxChonTep.TextChanged += new System.EventHandler(this.textBoxChonTep_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxChonTep);
            this.Controls.Add(this.labelChonTep);
            this.Controls.Add(this.buttonXemTep);
            this.Controls.Add(this.buttonGiaiMa);
            this.Controls.Add(this.buttonMaHoa);
            this.Controls.Add(this.labelMatKhau);
            this.Controls.Add(this.textBoxMatKhau);
            this.Controls.Add(this.buttonThoat);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.Label labelMatKhau;
        private System.Windows.Forms.Button buttonMaHoa;
        private System.Windows.Forms.Button buttonGiaiMa;
        private System.Windows.Forms.Button buttonXemTep;
        private System.Windows.Forms.Label labelChonTep;
        private System.Windows.Forms.TextBox textBoxChonTep;
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
       

        #endregion
    }
}