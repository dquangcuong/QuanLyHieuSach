
namespace DA_STOREBOOKS_WIN.ThuNgan
{
    partial class frmTNhoadon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grid_CTHD = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.grid_HD = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.txt_Tim = new System.Windows.Forms.TextBox();
            this.btn_KhachMoi = new System.Windows.Forms.Button();
            this.txt_TongTienHD = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_SoLuongMax = new System.Windows.Forms.Label();
            this.num_GiaBan = new System.Windows.Forms.NumericUpDown();
            this.num_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.btn_TaoMoiCTHD = new System.Windows.Forms.Button();
            this.btn_XoaCTHD = new System.Windows.Forms.Button();
            this.btn_SuaCTHD = new System.Windows.Forms.Button();
            this.btn_ThemCTHD = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_Sach = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dt_NgayLapHD = new System.Windows.Forms.DateTimePicker();
            this.cb_MaKH = new System.Windows.Forms.ComboBox();
            this.cb_MaNV = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_InHD = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_CapNhatHD = new System.Windows.Forms.Button();
            this.btn_XoaHD = new System.Windows.Forms.Button();
            this.btn_ThemHD = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_CTHD)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_HD)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_GiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_SoLuong)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(16, 81);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "Giá bán:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grid_CTHD);
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(11, 6);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(1519, 187);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết hóa đơn";
            // 
            // grid_CTHD
            // 
            this.grid_CTHD.AllowUserToAddRows = false;
            this.grid_CTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_CTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_CTHD.DefaultCellStyle = dataGridViewCellStyle1;
            this.grid_CTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_CTHD.Location = new System.Drawing.Point(6, 27);
            this.grid_CTHD.Name = "grid_CTHD";
            this.grid_CTHD.ReadOnly = true;
            this.grid_CTHD.RowHeadersVisible = false;
            this.grid_CTHD.RowHeadersWidth = 51;
            this.grid_CTHD.RowTemplate.Height = 24;
            this.grid_CTHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_CTHD.Size = new System.Drawing.Size(1507, 154);
            this.grid_CTHD.TabIndex = 0;
            this.grid_CTHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CTHD_CellClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.grid_HD);
            this.groupBox5.ForeColor = System.Drawing.Color.Blue;
            this.groupBox5.Location = new System.Drawing.Point(11, 6);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox5.Size = new System.Drawing.Size(1090, 252);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hóa đơn";
            // 
            // grid_HD
            // 
            this.grid_HD.AllowUserToAddRows = false;
            this.grid_HD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_HD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_HD.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_HD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_HD.Location = new System.Drawing.Point(6, 27);
            this.grid_HD.Name = "grid_HD";
            this.grid_HD.ReadOnly = true;
            this.grid_HD.RowHeadersVisible = false;
            this.grid_HD.RowHeadersWidth = 51;
            this.grid_HD.RowTemplate.Height = 24;
            this.grid_HD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_HD.Size = new System.Drawing.Size(1078, 219);
            this.grid_HD.TabIndex = 0;
            this.grid_HD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_HD_CellClick);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(63, 547);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1536, 193);
            this.panel3.TabIndex = 19;
            // 
            // btn_Tim
            // 
            this.btn_Tim.Image = global::DA_STOREBOOKS_WIN.Properties.Resources.logocut;
            this.btn_Tim.Location = new System.Drawing.Point(975, 116);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(41, 32);
            this.btn_Tim.TabIndex = 43;
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // txt_Tim
            // 
            this.txt_Tim.ForeColor = System.Drawing.Color.Black;
            this.txt_Tim.Location = new System.Drawing.Point(777, 118);
            this.txt_Tim.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Tim.Name = "txt_Tim";
            this.txt_Tim.Size = new System.Drawing.Size(189, 28);
            this.txt_Tim.TabIndex = 34;
            // 
            // btn_KhachMoi
            // 
            this.btn_KhachMoi.BackColor = System.Drawing.Color.Lavender;
            this.btn_KhachMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KhachMoi.ForeColor = System.Drawing.Color.Black;
            this.btn_KhachMoi.Location = new System.Drawing.Point(461, 120);
            this.btn_KhachMoi.Name = "btn_KhachMoi";
            this.btn_KhachMoi.Size = new System.Drawing.Size(67, 30);
            this.btn_KhachMoi.TabIndex = 33;
            this.btn_KhachMoi.Text = "New";
            this.btn_KhachMoi.UseVisualStyleBackColor = false;
            this.btn_KhachMoi.Click += new System.EventHandler(this.btn_KhachMoi_Click);
            // 
            // txt_TongTienHD
            // 
            this.txt_TongTienHD.Location = new System.Drawing.Point(778, 75);
            this.txt_TongTienHD.Margin = new System.Windows.Forms.Padding(6);
            this.txt_TongTienHD.Name = "txt_TongTienHD";
            this.txt_TongTienHD.Size = new System.Drawing.Size(188, 28);
            this.txt_TongTienHD.TabIndex = 13;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_SoLuongMax);
            this.groupBox4.Controls.Add(this.num_GiaBan);
            this.groupBox4.Controls.Add(this.num_SoLuong);
            this.groupBox4.Controls.Add(this.btn_TaoMoiCTHD);
            this.groupBox4.Controls.Add(this.btn_XoaCTHD);
            this.groupBox4.Controls.Add(this.btn_SuaCTHD);
            this.groupBox4.Controls.Add(this.btn_ThemCTHD);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.cb_Sach);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(1132, 7);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox4.Size = new System.Drawing.Size(361, 251);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chọn sách";
            // 
            // lbl_SoLuongMax
            // 
            this.lbl_SoLuongMax.AutoSize = true;
            this.lbl_SoLuongMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLuongMax.ForeColor = System.Drawing.Color.Red;
            this.lbl_SoLuongMax.Location = new System.Drawing.Point(132, 146);
            this.lbl_SoLuongMax.Name = "lbl_SoLuongMax";
            this.lbl_SoLuongMax.Size = new System.Drawing.Size(31, 17);
            this.lbl_SoLuongMax.TabIndex = 12;
            this.lbl_SoLuongMax.Text = "abc";
            // 
            // num_GiaBan
            // 
            this.num_GiaBan.Location = new System.Drawing.Point(131, 74);
            this.num_GiaBan.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.num_GiaBan.Name = "num_GiaBan";
            this.num_GiaBan.Size = new System.Drawing.Size(168, 28);
            this.num_GiaBan.TabIndex = 11;
            // 
            // num_SoLuong
            // 
            this.num_SoLuong.Location = new System.Drawing.Point(131, 115);
            this.num_SoLuong.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.num_SoLuong.Name = "num_SoLuong";
            this.num_SoLuong.Size = new System.Drawing.Size(168, 28);
            this.num_SoLuong.TabIndex = 11;
            // 
            // btn_TaoMoiCTHD
            // 
            this.btn_TaoMoiCTHD.ForeColor = System.Drawing.Color.Black;
            this.btn_TaoMoiCTHD.Image = global::DA_STOREBOOKS_WIN.Properties.Resources.update;
            this.btn_TaoMoiCTHD.Location = new System.Drawing.Point(169, 194);
            this.btn_TaoMoiCTHD.Margin = new System.Windows.Forms.Padding(6);
            this.btn_TaoMoiCTHD.Name = "btn_TaoMoiCTHD";
            this.btn_TaoMoiCTHD.Size = new System.Drawing.Size(61, 43);
            this.btn_TaoMoiCTHD.TabIndex = 10;
            this.btn_TaoMoiCTHD.UseVisualStyleBackColor = true;
            this.btn_TaoMoiCTHD.Click += new System.EventHandler(this.btn_TaoMoiCTHD_Click);
            // 
            // btn_XoaCTHD
            // 
            this.btn_XoaCTHD.ForeColor = System.Drawing.Color.Black;
            this.btn_XoaCTHD.Image = global::DA_STOREBOOKS_WIN.Properties.Resources.del;
            this.btn_XoaCTHD.Location = new System.Drawing.Point(239, 194);
            this.btn_XoaCTHD.Margin = new System.Windows.Forms.Padding(6);
            this.btn_XoaCTHD.Name = "btn_XoaCTHD";
            this.btn_XoaCTHD.Size = new System.Drawing.Size(61, 43);
            this.btn_XoaCTHD.TabIndex = 10;
            this.btn_XoaCTHD.UseVisualStyleBackColor = true;
            this.btn_XoaCTHD.Click += new System.EventHandler(this.btn_XoaCTHD_Click);
            // 
            // btn_SuaCTHD
            // 
            this.btn_SuaCTHD.ForeColor = System.Drawing.Color.Black;
            this.btn_SuaCTHD.Image = global::DA_STOREBOOKS_WIN.Properties.Resources.edit;
            this.btn_SuaCTHD.Location = new System.Drawing.Point(98, 194);
            this.btn_SuaCTHD.Margin = new System.Windows.Forms.Padding(6);
            this.btn_SuaCTHD.Name = "btn_SuaCTHD";
            this.btn_SuaCTHD.Size = new System.Drawing.Size(62, 43);
            this.btn_SuaCTHD.TabIndex = 9;
            this.btn_SuaCTHD.UseVisualStyleBackColor = true;
            this.btn_SuaCTHD.Click += new System.EventHandler(this.btn_SuaCTHD_Click);
            // 
            // btn_ThemCTHD
            // 
            this.btn_ThemCTHD.ForeColor = System.Drawing.Color.Black;
            this.btn_ThemCTHD.Image = global::DA_STOREBOOKS_WIN.Properties.Resources.plus;
            this.btn_ThemCTHD.Location = new System.Drawing.Point(27, 194);
            this.btn_ThemCTHD.Margin = new System.Windows.Forms.Padding(6);
            this.btn_ThemCTHD.Name = "btn_ThemCTHD";
            this.btn_ThemCTHD.Size = new System.Drawing.Size(62, 43);
            this.btn_ThemCTHD.TabIndex = 8;
            this.btn_ThemCTHD.UseVisualStyleBackColor = true;
            this.btn_ThemCTHD.Click += new System.EventHandler(this.btn_ThemCTHD_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(17, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số lượng:";
            // 
            // cb_Sach
            // 
            this.cb_Sach.ForeColor = System.Drawing.Color.Black;
            this.cb_Sach.FormattingEnabled = true;
            this.cb_Sach.Items.AddRange(new object[] {
            "--Mã nhân vien--"});
            this.cb_Sach.Location = new System.Drawing.Point(133, 35);
            this.cb_Sach.Margin = new System.Windows.Forms.Padding(6);
            this.cb_Sach.Name = "cb_Sach";
            this.cb_Sach.Size = new System.Drawing.Size(168, 30);
            this.cb_Sach.TabIndex = 10;
            this.cb_Sach.SelectedValueChanged += new System.EventHandler(this.cb_Sach_SelectedValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(17, 41);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "Sách:";
            // 
            // dt_NgayLapHD
            // 
            this.dt_NgayLapHD.CustomFormat = "dd/MM/yyyy";
            this.dt_NgayLapHD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_NgayLapHD.Location = new System.Drawing.Point(777, 35);
            this.dt_NgayLapHD.Margin = new System.Windows.Forms.Padding(6);
            this.dt_NgayLapHD.Name = "dt_NgayLapHD";
            this.dt_NgayLapHD.Size = new System.Drawing.Size(188, 28);
            this.dt_NgayLapHD.TabIndex = 12;
            // 
            // cb_MaKH
            // 
            this.cb_MaKH.ForeColor = System.Drawing.Color.Black;
            this.cb_MaKH.FormattingEnabled = true;
            this.cb_MaKH.Items.AddRange(new object[] {
            "--Mã nhân vien--"});
            this.cb_MaKH.Location = new System.Drawing.Point(284, 120);
            this.cb_MaKH.Margin = new System.Windows.Forms.Padding(6);
            this.cb_MaKH.Name = "cb_MaKH";
            this.cb_MaKH.Size = new System.Drawing.Size(168, 30);
            this.cb_MaKH.TabIndex = 10;
            // 
            // cb_MaNV
            // 
            this.cb_MaNV.ForeColor = System.Drawing.Color.Black;
            this.cb_MaNV.FormattingEnabled = true;
            this.cb_MaNV.Items.AddRange(new object[] {
            "--Mã nhân vien--"});
            this.cb_MaNV.Location = new System.Drawing.Point(284, 75);
            this.cb_MaNV.Margin = new System.Windows.Forms.Padding(6);
            this.cb_MaNV.Name = "cb_MaNV";
            this.cb_MaNV.Size = new System.Drawing.Size(215, 30);
            this.cb_MaNV.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(649, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tổng tiền:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(649, 120);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tìm Kiếm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(656, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày tạo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(119, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã khách:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(591, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 39);
            this.label6.TabIndex = 20;
            this.label6.Text = "Hóa Đơn";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(63, 272);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1536, 263);
            this.panel2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(119, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã nhân viên:";
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.BackColor = System.Drawing.SystemColors.Info;
            this.txt_MaHD.Enabled = false;
            this.txt_MaHD.ForeColor = System.Drawing.Color.Black;
            this.txt_MaHD.Location = new System.Drawing.Point(284, 34);
            this.txt_MaHD.Margin = new System.Windows.Forms.Padding(6);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.Size = new System.Drawing.Size(215, 28);
            this.txt_MaHD.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(119, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Tim);
            this.groupBox1.Controls.Add(this.txt_Tim);
            this.groupBox1.Controls.Add(this.btn_KhachMoi);
            this.groupBox1.Controls.Add(this.txt_TongTienHD);
            this.groupBox1.Controls.Add(this.dt_NgayLapHD);
            this.groupBox1.Controls.Add(this.cb_MaKH);
            this.groupBox1.Controls.Add(this.cb_MaNV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_MaHD);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1090, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.Lavender;
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.Color.Black;
            this.btn_Luu.Location = new System.Drawing.Point(19, 118);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(151, 47);
            this.btn_Luu.TabIndex = 33;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_InHD
            // 
            this.btn_InHD.BackColor = System.Drawing.Color.Lavender;
            this.btn_InHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InHD.ForeColor = System.Drawing.Color.Black;
            this.btn_InHD.Location = new System.Drawing.Point(183, 118);
            this.btn_InHD.Name = "btn_InHD";
            this.btn_InHD.Size = new System.Drawing.Size(151, 47);
            this.btn_InHD.TabIndex = 32;
            this.btn_InHD.Text = "In";
            this.btn_InHD.UseVisualStyleBackColor = false;
            this.btn_InHD.Click += new System.EventHandler(this.btn_InHD_Click);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.BackColor = System.Drawing.Color.Lavender;
            this.btn_LamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoi.ForeColor = System.Drawing.Color.Black;
            this.btn_LamMoi.Location = new System.Drawing.Point(183, 71);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(151, 47);
            this.btn_LamMoi.TabIndex = 30;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.UseVisualStyleBackColor = false;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_CapNhatHD
            // 
            this.btn_CapNhatHD.BackColor = System.Drawing.Color.Lavender;
            this.btn_CapNhatHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhatHD.ForeColor = System.Drawing.Color.Black;
            this.btn_CapNhatHD.Location = new System.Drawing.Point(183, 24);
            this.btn_CapNhatHD.Name = "btn_CapNhatHD";
            this.btn_CapNhatHD.Size = new System.Drawing.Size(151, 47);
            this.btn_CapNhatHD.TabIndex = 29;
            this.btn_CapNhatHD.Text = "Cập nhật";
            this.btn_CapNhatHD.UseVisualStyleBackColor = false;
            this.btn_CapNhatHD.Click += new System.EventHandler(this.btn_CapNhatHD_Click);
            // 
            // btn_XoaHD
            // 
            this.btn_XoaHD.BackColor = System.Drawing.Color.Lavender;
            this.btn_XoaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaHD.ForeColor = System.Drawing.Color.Black;
            this.btn_XoaHD.Location = new System.Drawing.Point(19, 71);
            this.btn_XoaHD.Name = "btn_XoaHD";
            this.btn_XoaHD.Size = new System.Drawing.Size(151, 47);
            this.btn_XoaHD.TabIndex = 28;
            this.btn_XoaHD.Text = "Xóa";
            this.btn_XoaHD.UseVisualStyleBackColor = false;
            this.btn_XoaHD.Click += new System.EventHandler(this.btn_XoaHD_Click);
            // 
            // btn_ThemHD
            // 
            this.btn_ThemHD.BackColor = System.Drawing.Color.Lavender;
            this.btn_ThemHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemHD.ForeColor = System.Drawing.Color.Black;
            this.btn_ThemHD.Location = new System.Drawing.Point(19, 24);
            this.btn_ThemHD.Name = "btn_ThemHD";
            this.btn_ThemHD.Size = new System.Drawing.Size(151, 47);
            this.btn_ThemHD.TabIndex = 27;
            this.btn_ThemHD.Text = "Thêm";
            this.btn_ThemHD.UseVisualStyleBackColor = false;
            this.btn_ThemHD.Click += new System.EventHandler(this.btn_ThemHD_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Luu);
            this.groupBox2.Controls.Add(this.btn_InHD);
            this.groupBox2.Controls.Add(this.btn_LamMoi);
            this.groupBox2.Controls.Add(this.btn_CapNhatHD);
            this.groupBox2.Controls.Add(this.btn_XoaHD);
            this.groupBox2.Controls.Add(this.btn_ThemHD);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(1108, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(354, 171);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(68, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1537, 182);
            this.panel1.TabIndex = 17;
            // 
            // frmTNhoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 757);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmTNhoadon";
            this.Text = "frmTNhoadon";
            this.Load += new System.EventHandler(this.frmTNhoadon_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_CTHD)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_HD)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_GiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_SoLuong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView grid_CTHD;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView grid_HD;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.TextBox txt_Tim;
        private System.Windows.Forms.Button btn_KhachMoi;
        private System.Windows.Forms.TextBox txt_TongTienHD;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbl_SoLuongMax;
        private System.Windows.Forms.NumericUpDown num_GiaBan;
        private System.Windows.Forms.NumericUpDown num_SoLuong;
        private System.Windows.Forms.Button btn_TaoMoiCTHD;
        private System.Windows.Forms.Button btn_XoaCTHD;
        private System.Windows.Forms.Button btn_SuaCTHD;
        private System.Windows.Forms.Button btn_ThemCTHD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_Sach;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dt_NgayLapHD;
        private System.Windows.Forms.ComboBox cb_MaKH;
        private System.Windows.Forms.ComboBox cb_MaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_InHD;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_CapNhatHD;
        private System.Windows.Forms.Button btn_XoaHD;
        private System.Windows.Forms.Button btn_ThemHD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
    }
}