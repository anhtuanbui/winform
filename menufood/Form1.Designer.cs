namespace menufood
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.grbMonKhaiVi = new System.Windows.Forms.GroupBox();
            this.ckbAllKhaiVi = new System.Windows.Forms.CheckBox();
            this.ckbKhoaiTay = new System.Windows.Forms.CheckBox();
            this.ckbBanhMi = new System.Windows.Forms.CheckBox();
            this.ckbMyY = new System.Windows.Forms.CheckBox();
            this.grbMonChinh = new System.Windows.Forms.GroupBox();
            this.ckbAllMonChinh = new System.Windows.Forms.CheckBox();
            this.ckbNemChua = new System.Windows.Forms.CheckBox();
            this.ckbGioBo = new System.Windows.Forms.CheckBox();
            this.ckbCua = new System.Windows.Forms.CheckBox();
            this.grbTrangMieng = new System.Windows.Forms.GroupBox();
            this.ckbAllTrangMieng = new System.Windows.Forms.CheckBox();
            this.ckbDuaHau = new System.Windows.Forms.CheckBox();
            this.ckbKem = new System.Windows.Forms.CheckBox();
            this.ckbTao = new System.Windows.Forms.CheckBox();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.txbDanhSach = new System.Windows.Forms.TextBox();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.lblTinhTien = new System.Windows.Forms.Label();
            this.txbTinhTien = new System.Windows.Forms.TextBox();
            this.grbMonKhaiVi.SuspendLayout();
            this.grbMonChinh.SuspendLayout();
            this.grbTrangMieng.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(190, 23);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(98, 15);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menu Chọn Món";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(41, 56);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(58, 15);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ và tên";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(304, 56);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(35, 15);
            this.lblNgay.TabIndex = 0;
            this.lblNgay.Text = "Ngày";
            // 
            // grbMonKhaiVi
            // 
            this.grbMonKhaiVi.Controls.Add(this.ckbAllKhaiVi);
            this.grbMonKhaiVi.Controls.Add(this.ckbKhoaiTay);
            this.grbMonKhaiVi.Controls.Add(this.ckbBanhMi);
            this.grbMonKhaiVi.Controls.Add(this.ckbMyY);
            this.grbMonKhaiVi.Location = new System.Drawing.Point(41, 117);
            this.grbMonKhaiVi.Name = "grbMonKhaiVi";
            this.grbMonKhaiVi.Size = new System.Drawing.Size(200, 191);
            this.grbMonKhaiVi.TabIndex = 2;
            this.grbMonKhaiVi.TabStop = false;
            this.grbMonKhaiVi.Text = "Món Khai Vị";
            this.grbMonKhaiVi.Enter += new System.EventHandler(this.grbMonKhaiVi_Enter);
            // 
            // ckbAllKhaiVi
            // 
            this.ckbAllKhaiVi.AutoSize = true;
            this.ckbAllKhaiVi.Location = new System.Drawing.Point(19, 159);
            this.ckbAllKhaiVi.Name = "ckbAllKhaiVi";
            this.ckbAllKhaiVi.Size = new System.Drawing.Size(40, 19);
            this.ckbAllKhaiVi.TabIndex = 0;
            this.ckbAllKhaiVi.Text = "All";
            this.ckbAllKhaiVi.UseVisualStyleBackColor = true;
            this.ckbAllKhaiVi.CheckedChanged += new System.EventHandler(this.ckbAllKhaiVi_CheckedChanged);
            // 
            // ckbKhoaiTay
            // 
            this.ckbKhoaiTay.AutoSize = true;
            this.ckbKhoaiTay.Location = new System.Drawing.Point(19, 117);
            this.ckbKhoaiTay.Name = "ckbKhoaiTay";
            this.ckbKhoaiTay.Size = new System.Drawing.Size(110, 19);
            this.ckbKhoaiTay.TabIndex = 0;
            this.ckbKhoaiTay.Text = "Khoai Tây Chiên";
            this.ckbKhoaiTay.UseVisualStyleBackColor = true;
            // 
            // ckbBanhMi
            // 
            this.ckbBanhMi.AutoSize = true;
            this.ckbBanhMi.Location = new System.Drawing.Point(19, 75);
            this.ckbBanhMi.Name = "ckbBanhMi";
            this.ckbBanhMi.Size = new System.Drawing.Size(70, 19);
            this.ckbBanhMi.TabIndex = 0;
            this.ckbBanhMi.Text = "Bánh Mì";
            this.ckbBanhMi.UseVisualStyleBackColor = true;
            // 
            // ckbMyY
            // 
            this.ckbMyY.AutoSize = true;
            this.ckbMyY.Location = new System.Drawing.Point(19, 34);
            this.ckbMyY.Name = "ckbMyY";
            this.ckbMyY.Size = new System.Drawing.Size(53, 19);
            this.ckbMyY.TabIndex = 0;
            this.ckbMyY.Text = "Mỳ Ý";
            this.ckbMyY.UseVisualStyleBackColor = true;
            // 
            // grbMonChinh
            // 
            this.grbMonChinh.Controls.Add(this.ckbAllMonChinh);
            this.grbMonChinh.Controls.Add(this.ckbNemChua);
            this.grbMonChinh.Controls.Add(this.ckbGioBo);
            this.grbMonChinh.Controls.Add(this.ckbCua);
            this.grbMonChinh.Location = new System.Drawing.Point(304, 117);
            this.grbMonChinh.Name = "grbMonChinh";
            this.grbMonChinh.Size = new System.Drawing.Size(200, 191);
            this.grbMonChinh.TabIndex = 2;
            this.grbMonChinh.TabStop = false;
            this.grbMonChinh.Text = "  ";
            // 
            // ckbAllMonChinh
            // 
            this.ckbAllMonChinh.AutoSize = true;
            this.ckbAllMonChinh.Location = new System.Drawing.Point(31, 159);
            this.ckbAllMonChinh.Name = "ckbAllMonChinh";
            this.ckbAllMonChinh.Size = new System.Drawing.Size(40, 19);
            this.ckbAllMonChinh.TabIndex = 0;
            this.ckbAllMonChinh.Text = "All";
            this.ckbAllMonChinh.UseVisualStyleBackColor = true;
            this.ckbAllMonChinh.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // ckbNemChua
            // 
            this.ckbNemChua.AutoSize = true;
            this.ckbNemChua.Location = new System.Drawing.Point(31, 75);
            this.ckbNemChua.Name = "ckbNemChua";
            this.ckbNemChua.Size = new System.Drawing.Size(83, 19);
            this.ckbNemChua.TabIndex = 0;
            this.ckbNemChua.Text = "Nem Chua";
            this.ckbNemChua.UseVisualStyleBackColor = true;
            // 
            // ckbGioBo
            // 
            this.ckbGioBo.AutoSize = true;
            this.ckbGioBo.Location = new System.Drawing.Point(31, 117);
            this.ckbGioBo.Name = "ckbGioBo";
            this.ckbGioBo.Size = new System.Drawing.Size(61, 19);
            this.ckbGioBo.TabIndex = 0;
            this.ckbGioBo.Text = "Giò Bò";
            this.ckbGioBo.UseVisualStyleBackColor = true;
            // 
            // ckbCua
            // 
            this.ckbCua.AutoSize = true;
            this.ckbCua.Location = new System.Drawing.Point(31, 34);
            this.ckbCua.Name = "ckbCua";
            this.ckbCua.Size = new System.Drawing.Size(103, 19);
            this.ckbCua.TabIndex = 0;
            this.ckbCua.Text = "Cua Hoàng Đế";
            this.ckbCua.UseVisualStyleBackColor = true;
            // 
            // grbTrangMieng
            // 
            this.grbTrangMieng.Controls.Add(this.ckbAllTrangMieng);
            this.grbTrangMieng.Controls.Add(this.ckbDuaHau);
            this.grbTrangMieng.Controls.Add(this.ckbKem);
            this.grbTrangMieng.Controls.Add(this.ckbTao);
            this.grbTrangMieng.Location = new System.Drawing.Point(41, 338);
            this.grbTrangMieng.Name = "grbTrangMieng";
            this.grbTrangMieng.Size = new System.Drawing.Size(200, 214);
            this.grbTrangMieng.TabIndex = 2;
            this.grbTrangMieng.TabStop = false;
            this.grbTrangMieng.Text = "Món Tráng Miệng";
            // 
            // ckbAllTrangMieng
            // 
            this.ckbAllTrangMieng.AutoSize = true;
            this.ckbAllTrangMieng.Location = new System.Drawing.Point(19, 166);
            this.ckbAllTrangMieng.Name = "ckbAllTrangMieng";
            this.ckbAllTrangMieng.Size = new System.Drawing.Size(40, 19);
            this.ckbAllTrangMieng.TabIndex = 0;
            this.ckbAllTrangMieng.Text = "All";
            this.ckbAllTrangMieng.UseVisualStyleBackColor = true;
            // 
            // ckbDuaHau
            // 
            this.ckbDuaHau.AutoSize = true;
            this.ckbDuaHau.Location = new System.Drawing.Point(19, 82);
            this.ckbDuaHau.Name = "ckbDuaHau";
            this.ckbDuaHau.Size = new System.Drawing.Size(72, 19);
            this.ckbDuaHau.TabIndex = 0;
            this.ckbDuaHau.Text = "Dưa Hấu";
            this.ckbDuaHau.UseVisualStyleBackColor = true;
            this.ckbDuaHau.CheckedChanged += new System.EventHandler(this.checkBox11_CheckedChanged);
            // 
            // ckbKem
            // 
            this.ckbKem.AutoSize = true;
            this.ckbKem.Location = new System.Drawing.Point(19, 41);
            this.ckbKem.Name = "ckbKem";
            this.ckbKem.Size = new System.Drawing.Size(50, 19);
            this.ckbKem.TabIndex = 0;
            this.ckbKem.Text = "Kem";
            this.ckbKem.UseVisualStyleBackColor = true;
            // 
            // ckbTao
            // 
            this.ckbTao.AutoSize = true;
            this.ckbTao.Location = new System.Drawing.Point(19, 124);
            this.ckbTao.Name = "ckbTao";
            this.ckbTao.Size = new System.Drawing.Size(44, 19);
            this.ckbTao.TabIndex = 0;
            this.ckbTao.Text = "Táo";
            this.ckbTao.UseVisualStyleBackColor = true;
            // 
            // txbHoTen
            // 
            this.txbHoTen.Location = new System.Drawing.Point(41, 74);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(200, 23);
            this.txbHoTen.TabIndex = 3;
            this.txbHoTen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dtpNgay
            // 
            this.dtpNgay.Location = new System.Drawing.Point(304, 74);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(200, 23);
            this.dtpNgay.TabIndex = 4;
            // 
            // txbDanhSach
            // 
            this.txbDanhSach.Location = new System.Drawing.Point(247, 365);
            this.txbDanhSach.Multiline = true;
            this.txbDanhSach.Name = "txbDanhSach";
            this.txbDanhSach.Size = new System.Drawing.Size(171, 187);
            this.txbDanhSach.TabIndex = 5;
            // 
            // btnKetQua
            // 
            this.btnKetQua.Location = new System.Drawing.Point(429, 366);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(75, 43);
            this.btnKetQua.TabIndex = 6;
            this.btnKetQua.Text = "Kết Quả";
            this.btnKetQua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(429, 438);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 43);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(429, 509);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 43);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Location = new System.Drawing.Point(247, 347);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(81, 15);
            this.lblDanhSach.TabIndex = 0;
            this.lblDanhSach.Text = "Món Đã Chọn";
            // 
            // lblTinhTien
            // 
            this.lblTinhTien.AutoSize = true;
            this.lblTinhTien.Location = new System.Drawing.Point(41, 572);
            this.lblTinhTien.Name = "lblTinhTien";
            this.lblTinhTien.Size = new System.Drawing.Size(55, 15);
            this.lblTinhTien.TabIndex = 0;
            this.lblTinhTien.Text = "Tính Tiền";
            this.lblTinhTien.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbTinhTien
            // 
            this.txbTinhTien.Location = new System.Drawing.Point(41, 590);
            this.txbTinhTien.Multiline = true;
            this.txbTinhTien.Name = "txbTinhTien";
            this.txbTinhTien.Size = new System.Drawing.Size(463, 63);
            this.txbTinhTien.TabIndex = 3;
            this.txbTinhTien.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 670);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.txbDanhSach);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.txbTinhTien);
            this.Controls.Add(this.txbHoTen);
            this.Controls.Add(this.grbTrangMieng);
            this.Controls.Add(this.grbMonChinh);
            this.Controls.Add(this.grbMonKhaiVi);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.lblTinhTien);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbMonKhaiVi.ResumeLayout(false);
            this.grbMonKhaiVi.PerformLayout();
            this.grbMonChinh.ResumeLayout(false);
            this.grbMonChinh.PerformLayout();
            this.grbTrangMieng.ResumeLayout(false);
            this.grbTrangMieng.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMenu;
        private Label lblHoTen;
        private Label lblNgay;
        private GroupBox grbMonKhaiVi;
        private GroupBox grbMonChinh;
        private GroupBox grbTrangMieng;
        private TextBox txbHoTen;
        private CheckBox ckbAllKhaiVi;
        private CheckBox ckbKhoaiTay;
        private CheckBox ckbBanhMi;
        private CheckBox ckbMyY;
        private CheckBox ckbAllMonChinh;
        private CheckBox ckbNemChua;
        private CheckBox ckbGioBo;
        private CheckBox ckbCua;
        private CheckBox ckbAllTrangMieng;
        private CheckBox ckbDuaHau;
        private CheckBox ckbKem;
        private CheckBox ckbTao;
        private DateTimePicker dtpNgay;
        private TextBox txbDanhSach;
        private Button btnKetQua;
        private Button btnXoa;
        private Button btnThoat;
        private Label lblDanhSach;
        private Label lblTinhTien;
        private TextBox txbTinhTien;
    }
}