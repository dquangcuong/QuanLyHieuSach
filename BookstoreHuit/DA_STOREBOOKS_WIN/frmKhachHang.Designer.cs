
namespace DA_STOREBOOKS_WIN
{
    partial class frmKhachHang
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
            this.gbThaoTac = new System.Windows.Forms.GroupBox();
            this.btn_CapNhatKH = new System.Windows.Forms.Button();
            this.btn_ThemKH = new System.Windows.Forms.Button();
            this.btn_LamMoiKH = new System.Windows.Forms.Button();
            this.btn_XoaKH = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnGridThongTinKhachHang = new System.Windows.Forms.Panel();
            this.grid_KhachHang = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlThongTinKhachHang = new System.Windows.Forms.Panel();
            this.gbThongTinKhachHang = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_ThongBao = new System.Windows.Forms.Label();
            this.btn_TimKhachHang = new System.Windows.Forms.Button();
            this.dt_NgayTaoKH = new System.Windows.Forms.DateTimePicker();
            this.cb_TrangThaiKH = new System.Windows.Forms.ComboBox();
            this.txt_TimKH = new System.Windows.Forms.TextBox();
            this.txt_sdtKH = new System.Windows.Forms.TextBox();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbThaoTac.SuspendLayout();
            this.pnGridThongTinKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_KhachHang)).BeginInit();
            this.pnlThongTinKhachHang.SuspendLayout();
            this.gbThongTinKhachHang.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbThaoTac
            // 
            this.gbThaoTac.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbThaoTac.BackColor = System.Drawing.SystemColors.Control;
            this.gbThaoTac.Controls.Add(this.btn_CapNhatKH);
            this.gbThaoTac.Controls.Add(this.btn_ThemKH);
            this.gbThaoTac.Controls.Add(this.btn_LamMoiKH);
            this.gbThaoTac.Controls.Add(this.btn_XoaKH);
            this.gbThaoTac.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbThaoTac.Location = new System.Drawing.Point(209, 190);
            this.gbThaoTac.Margin = new System.Windows.Forms.Padding(4);
            this.gbThaoTac.Name = "gbThaoTac";
            this.gbThaoTac.Padding = new System.Windows.Forms.Padding(4);
            this.gbThaoTac.Size = new System.Drawing.Size(696, 80);
            this.gbThaoTac.TabIndex = 0;
            this.gbThaoTac.TabStop = false;
            this.gbThaoTac.Text = "Thao Tác";
            // 
            // btn_CapNhatKH
            // 
            this.btn_CapNhatKH.BackColor = System.Drawing.Color.Lavender;
            this.btn_CapNhatKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhatKH.ForeColor = System.Drawing.Color.Black;
            this.btn_CapNhatKH.Location = new System.Drawing.Point(227, 32);
            this.btn_CapNhatKH.Name = "btn_CapNhatKH";
            this.btn_CapNhatKH.Size = new System.Drawing.Size(136, 41);
            this.btn_CapNhatKH.TabIndex = 30;
            this.btn_CapNhatKH.Text = "Cập nhật";
            this.btn_CapNhatKH.UseVisualStyleBackColor = false;
            this.btn_CapNhatKH.Click += new System.EventHandler(this.btn_CapNhatKH_Click);
            // 
            // btn_ThemKH
            // 
            this.btn_ThemKH.BackColor = System.Drawing.Color.Lavender;
            this.btn_ThemKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemKH.ForeColor = System.Drawing.Color.Black;
            this.btn_ThemKH.Location = new System.Drawing.Point(72, 32);
            this.btn_ThemKH.Name = "btn_ThemKH";
            this.btn_ThemKH.Size = new System.Drawing.Size(136, 41);
            this.btn_ThemKH.TabIndex = 29;
            this.btn_ThemKH.Text = "Thêm";
            this.btn_ThemKH.UseVisualStyleBackColor = false;
            this.btn_ThemKH.Click += new System.EventHandler(this.btn_ThemKH_Click);
            // 
            // btn_LamMoiKH
            // 
            this.btn_LamMoiKH.BackColor = System.Drawing.Color.Lavender;
            this.btn_LamMoiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoiKH.ForeColor = System.Drawing.Color.Black;
            this.btn_LamMoiKH.Location = new System.Drawing.Point(537, 32);
            this.btn_LamMoiKH.Name = "btn_LamMoiKH";
            this.btn_LamMoiKH.Size = new System.Drawing.Size(136, 41);
            this.btn_LamMoiKH.TabIndex = 28;
            this.btn_LamMoiKH.Text = "Làm mới";
            this.btn_LamMoiKH.UseVisualStyleBackColor = false;
            this.btn_LamMoiKH.Click += new System.EventHandler(this.btn_LamMoiKH_Click);
            // 
            // btn_XoaKH
            // 
            this.btn_XoaKH.BackColor = System.Drawing.Color.Lavender;
            this.btn_XoaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaKH.ForeColor = System.Drawing.Color.Black;
            this.btn_XoaKH.Location = new System.Drawing.Point(382, 32);
            this.btn_XoaKH.Name = "btn_XoaKH";
            this.btn_XoaKH.Size = new System.Drawing.Size(136, 41);
            this.btn_XoaKH.TabIndex = 27;
            this.btn_XoaKH.Text = "Xóa";
            this.btn_XoaKH.UseVisualStyleBackColor = false;
            this.btn_XoaKH.Click += new System.EventHandler(this.btn_XoaKH_Click);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DIACHI";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tài khoản";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // pnGridThongTinKhachHang
            // 
            this.pnGridThongTinKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnGridThongTinKhachHang.Controls.Add(this.grid_KhachHang);
            this.pnGridThongTinKhachHang.Location = new System.Drawing.Point(70, 375);
            this.pnGridThongTinKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.pnGridThongTinKhachHang.Name = "pnGridThongTinKhachHang";
            this.pnGridThongTinKhachHang.Size = new System.Drawing.Size(1179, 295);
            this.pnGridThongTinKhachHang.TabIndex = 18;
            // 
            // grid_KhachHang
            // 
            this.grid_KhachHang.AllowUserToAddRows = false;
            this.grid_KhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_KhachHang.DefaultCellStyle = dataGridViewCellStyle1;
            this.grid_KhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_KhachHang.Location = new System.Drawing.Point(0, 0);
            this.grid_KhachHang.Name = "grid_KhachHang";
            this.grid_KhachHang.ReadOnly = true;
            this.grid_KhachHang.RowHeadersVisible = false;
            this.grid_KhachHang.RowHeadersWidth = 51;
            this.grid_KhachHang.RowTemplate.Height = 24;
            this.grid_KhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_KhachHang.Size = new System.Drawing.Size(1179, 295);
            this.grid_KhachHang.TabIndex = 0;
            this.grid_KhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_KhachHang_CellContentClick);
            this.grid_KhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_KhachHang_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MANV";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã KH";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HONV";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên khách hàng";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TENNV";
            this.dataGridViewTextBoxColumn3.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PHAI";
            this.dataGridViewTextBoxColumn4.HeaderText = "Điện thoại";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CHUCVU";
            this.dataGridViewTextBoxColumn5.HeaderText = "MS thuế";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DIENTHOAI";
            this.dataGridViewTextBoxColumn7.HeaderText = "Ghi chú";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quản lý khách hàng";
            // 
            // pnlThongTinKhachHang
            // 
            this.pnlThongTinKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlThongTinKhachHang.Controls.Add(this.gbThaoTac);
            this.pnlThongTinKhachHang.Controls.Add(this.gbThongTinKhachHang);
            this.pnlThongTinKhachHang.Location = new System.Drawing.Point(70, 84);
            this.pnlThongTinKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.pnlThongTinKhachHang.Name = "pnlThongTinKhachHang";
            this.pnlThongTinKhachHang.Size = new System.Drawing.Size(1179, 283);
            this.pnlThongTinKhachHang.TabIndex = 16;
            // 
            // gbThongTinKhachHang
            // 
            this.gbThongTinKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbThongTinKhachHang.Controls.Add(this.label9);
            this.gbThongTinKhachHang.Controls.Add(this.label7);
            this.gbThongTinKhachHang.Controls.Add(this.label10);
            this.gbThongTinKhachHang.Controls.Add(this.label3);
            this.gbThongTinKhachHang.Controls.Add(this.lbl_ThongBao);
            this.gbThongTinKhachHang.Controls.Add(this.btn_TimKhachHang);
            this.gbThongTinKhachHang.Controls.Add(this.dt_NgayTaoKH);
            this.gbThongTinKhachHang.Controls.Add(this.cb_TrangThaiKH);
            this.gbThongTinKhachHang.Controls.Add(this.txt_TimKH);
            this.gbThongTinKhachHang.Controls.Add(this.txt_sdtKH);
            this.gbThongTinKhachHang.Controls.Add(this.txt_TenKH);
            this.gbThongTinKhachHang.Controls.Add(this.txt_MaKH);
            this.gbThongTinKhachHang.Controls.Add(this.label8);
            this.gbThongTinKhachHang.Controls.Add(this.label6);
            this.gbThongTinKhachHang.Controls.Add(this.label5);
            this.gbThongTinKhachHang.Controls.Add(this.label4);
            this.gbThongTinKhachHang.Controls.Add(this.label2);
            this.gbThongTinKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTinKhachHang.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gbThongTinKhachHang.Location = new System.Drawing.Point(95, 4);
            this.gbThongTinKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.gbThongTinKhachHang.Name = "gbThongTinKhachHang";
            this.gbThongTinKhachHang.Padding = new System.Windows.Forms.Padding(4);
            this.gbThongTinKhachHang.Size = new System.Drawing.Size(1000, 178);
            this.gbThongTinKhachHang.TabIndex = 4;
            this.gbThongTinKhachHang.TabStop = false;
            this.gbThongTinKhachHang.Text = "Thông tin khách hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(465, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 18);
            this.label9.TabIndex = 44;
            this.label9.Text = "(*)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(466, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 18);
            this.label7.TabIndex = 44;
            this.label7.Text = "(*)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(939, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 18);
            this.label10.TabIndex = 44;
            this.label10.Text = "(*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(466, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 18);
            this.label3.TabIndex = 44;
            this.label3.Text = "(*)";
            // 
            // lbl_ThongBao
            // 
            this.lbl_ThongBao.AutoSize = true;
            this.lbl_ThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThongBao.ForeColor = System.Drawing.Color.Red;
            this.lbl_ThongBao.Location = new System.Drawing.Point(694, 31);
            this.lbl_ThongBao.Name = "lbl_ThongBao";
            this.lbl_ThongBao.Size = new System.Drawing.Size(0, 15);
            this.lbl_ThongBao.TabIndex = 43;
            // 
            // btn_TimKhachHang
            // 
            this.btn_TimKhachHang.Image = global::DA_STOREBOOKS_WIN.Properties.Resources.logocut;
            this.btn_TimKhachHang.Location = new System.Drawing.Point(611, 129);
            this.btn_TimKhachHang.Name = "btn_TimKhachHang";
            this.btn_TimKhachHang.Size = new System.Drawing.Size(41, 42);
            this.btn_TimKhachHang.TabIndex = 42;
            this.btn_TimKhachHang.UseVisualStyleBackColor = true;
            this.btn_TimKhachHang.Click += new System.EventHandler(this.btn_TimKhachHang_Click);
            // 
            // dt_NgayTaoKH
            // 
            this.dt_NgayTaoKH.CustomFormat = "dd/MM/yyyy";
            this.dt_NgayTaoKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_NgayTaoKH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_NgayTaoKH.Location = new System.Drawing.Point(686, 95);
            this.dt_NgayTaoKH.MaxDate = new System.DateTime(2024, 5, 15, 0, 0, 0, 0);
            this.dt_NgayTaoKH.Name = "dt_NgayTaoKH";
            this.dt_NgayTaoKH.Size = new System.Drawing.Size(255, 28);
            this.dt_NgayTaoKH.TabIndex = 38;
            this.dt_NgayTaoKH.Value = new System.DateTime(2024, 4, 24, 23, 59, 59, 0);
            // 
            // cb_TrangThaiKH
            // 
            this.cb_TrangThaiKH.FormattingEnabled = true;
            this.cb_TrangThaiKH.Items.AddRange(new object[] {
            "Active",
            "Disable"});
            this.cb_TrangThaiKH.Location = new System.Drawing.Point(204, 141);
            this.cb_TrangThaiKH.Name = "cb_TrangThaiKH";
            this.cb_TrangThaiKH.Size = new System.Drawing.Size(255, 30);
            this.cb_TrangThaiKH.TabIndex = 37;
            // 
            // txt_TimKH
            // 
            this.txt_TimKH.ForeColor = System.Drawing.Color.Black;
            this.txt_TimKH.Location = new System.Drawing.Point(686, 140);
            this.txt_TimKH.Name = "txt_TimKH";
            this.txt_TimKH.Size = new System.Drawing.Size(255, 28);
            this.txt_TimKH.TabIndex = 35;
            // 
            // txt_sdtKH
            // 
            this.txt_sdtKH.ForeColor = System.Drawing.Color.Black;
            this.txt_sdtKH.Location = new System.Drawing.Point(686, 50);
            this.txt_sdtKH.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sdtKH.Name = "txt_sdtKH";
            this.txt_sdtKH.Size = new System.Drawing.Size(255, 28);
            this.txt_sdtKH.TabIndex = 26;
            this.txt_sdtKH.TextChanged += new System.EventHandler(this.txt_sdtKH_TextChanged);
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.ForeColor = System.Drawing.Color.Black;
            this.txt_TenKH.Location = new System.Drawing.Point(204, 98);
            this.txt_TenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(255, 28);
            this.txt_TenKH.TabIndex = 23;
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.BackColor = System.Drawing.Color.Pink;
            this.txt_MaKH.Enabled = false;
            this.txt_MaKH.ForeColor = System.Drawing.Color.Black;
            this.txt_MaKH.Location = new System.Drawing.Point(204, 51);
            this.txt_MaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(255, 28);
            this.txt_MaKH.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(87, 147);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "Trạng thái:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(567, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày tạo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(567, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(38, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(57, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên khách:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1354, 74);
            this.panel1.TabIndex = 15;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1354, 683);
            this.Controls.Add(this.pnGridThongTinKhachHang);
            this.Controls.Add(this.pnlThongTinKhachHang);
            this.Controls.Add(this.panel1);
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.gbThaoTac.ResumeLayout(false);
            this.pnGridThongTinKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_KhachHang)).EndInit();
            this.pnlThongTinKhachHang.ResumeLayout(false);
            this.gbThongTinKhachHang.ResumeLayout(false);
            this.gbThongTinKhachHang.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbThaoTac;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Panel pnGridThongTinKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlThongTinKhachHang;
        private System.Windows.Forms.GroupBox gbThongTinKhachHang;
        private System.Windows.Forms.TextBox txt_sdtKH;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_TimKH;
        private System.Windows.Forms.Button btn_LamMoiKH;
        private System.Windows.Forms.Button btn_XoaKH;
        private System.Windows.Forms.Button btn_CapNhatKH;
        private System.Windows.Forms.Button btn_ThemKH;
        private System.Windows.Forms.ComboBox cb_TrangThaiKH;
        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.DataGridView grid_KhachHang;
        private System.Windows.Forms.DateTimePicker dt_NgayTaoKH;
        private System.Windows.Forms.Button btn_TimKhachHang;
        private System.Windows.Forms.Label lbl_ThongBao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
    }
}