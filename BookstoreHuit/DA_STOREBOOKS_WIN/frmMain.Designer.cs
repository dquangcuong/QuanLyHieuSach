
namespace DA_STOREBOOKS_WIN
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel_Left = new System.Windows.Forms.Panel();
            this.panel_Container = new System.Windows.Forms.Panel();
            this.btn_ControlSach = new System.Windows.Forms.Button();
            this.lblPhienDangNhap = new System.Windows.Forms.Label();
            this.btn_ControlKhach = new System.Windows.Forms.Button();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.btn_ControlNhanVien = new System.Windows.Forms.Button();
            this.btn_ControlThongKe = new System.Windows.Forms.Button();
            this.btn_ControlHoaDon = new System.Windows.Forms.Button();
            this.btn_ControlPhieuNhap = new System.Windows.Forms.Button();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.pictureBox_img = new System.Windows.Forms.PictureBox();
            this.panel_Left.SuspendLayout();
            this.panel_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.panel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_img)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.Color.Maroon;
            this.panel_Left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Left.Controls.Add(this.panel_Container);
            this.panel_Left.Controls.Add(this.pictureBox_logo);
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(274, 730);
            this.panel_Left.TabIndex = 0;
            // 
            // panel_Container
            // 
            this.panel_Container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Container.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_Container.Controls.Add(this.btn_ControlSach);
            this.panel_Container.Controls.Add(this.lblPhienDangNhap);
            this.panel_Container.Controls.Add(this.btn_ControlKhach);
            this.panel_Container.Controls.Add(this.btn_DangXuat);
            this.panel_Container.Controls.Add(this.btn_ControlNhanVien);
            this.panel_Container.Controls.Add(this.btn_ControlThongKe);
            this.panel_Container.Controls.Add(this.btn_ControlHoaDon);
            this.panel_Container.Controls.Add(this.btn_ControlPhieuNhap);
            this.panel_Container.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Container.Location = new System.Drawing.Point(-1, 182);
            this.panel_Container.Name = "panel_Container";
            this.panel_Container.Size = new System.Drawing.Size(274, 543);
            this.panel_Container.TabIndex = 4;
            this.panel_Container.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Container_Paint);
            // 
            // btn_ControlSach
            // 
            this.btn_ControlSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ControlSach.BackColor = System.Drawing.Color.Transparent;
            this.btn_ControlSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ControlSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ControlSach.ForeColor = System.Drawing.Color.Brown;
            this.btn_ControlSach.Image = global::DA_STOREBOOKS_WIN.Properties.Resources.MainSach;
            this.btn_ControlSach.Location = new System.Drawing.Point(0, 68);
            this.btn_ControlSach.Name = "btn_ControlSach";
            this.btn_ControlSach.Size = new System.Drawing.Size(274, 57);
            this.btn_ControlSach.TabIndex = 2;
            this.btn_ControlSach.UseVisualStyleBackColor = false;
            this.btn_ControlSach.Click += new System.EventHandler(this.btn_ControlSach_Click);
            // 
            // lblPhienDangNhap
            // 
            this.lblPhienDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhienDangNhap.AutoSize = true;
            this.lblPhienDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.lblPhienDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhienDangNhap.ForeColor = System.Drawing.Color.Plum;
            this.lblPhienDangNhap.Location = new System.Drawing.Point(3, 0);
            this.lblPhienDangNhap.Name = "lblPhienDangNhap";
            this.lblPhienDangNhap.Size = new System.Drawing.Size(123, 29);
            this.lblPhienDangNhap.TabIndex = 3;
            this.lblPhienDangNhap.Text = "TaiKhoan:";
            // 
            // btn_ControlKhach
            // 
            this.btn_ControlKhach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ControlKhach.BackColor = System.Drawing.Color.Transparent;
            this.btn_ControlKhach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ControlKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ControlKhach.ForeColor = System.Drawing.Color.Brown;
            this.btn_ControlKhach.Image = global::DA_STOREBOOKS_WIN.Properties.Resources.MainKhach;
            this.btn_ControlKhach.Location = new System.Drawing.Point(0, 125);
            this.btn_ControlKhach.Name = "btn_ControlKhach";
            this.btn_ControlKhach.Size = new System.Drawing.Size(274, 62);
            this.btn_ControlKhach.TabIndex = 2;
            this.btn_ControlKhach.UseVisualStyleBackColor = false;
            this.btn_ControlKhach.Click += new System.EventHandler(this.btn_ControlKhach_Click);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DangXuat.BackColor = System.Drawing.Color.Transparent;
            this.btn_DangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_DangXuat.Image = global::DA_STOREBOOKS_WIN.Properties.Resources.MainDX;
            this.btn_DangXuat.Location = new System.Drawing.Point(27, 452);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(212, 65);
            this.btn_DangXuat.TabIndex = 2;
            this.btn_DangXuat.UseVisualStyleBackColor = false;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // btn_ControlNhanVien
            // 
            this.btn_ControlNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ControlNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btn_ControlNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ControlNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ControlNhanVien.ForeColor = System.Drawing.Color.Brown;
            this.btn_ControlNhanVien.Image = global::DA_STOREBOOKS_WIN.Properties.Resources.MainNhanVien;
            this.btn_ControlNhanVien.Location = new System.Drawing.Point(0, 187);
            this.btn_ControlNhanVien.Name = "btn_ControlNhanVien";
            this.btn_ControlNhanVien.Size = new System.Drawing.Size(274, 62);
            this.btn_ControlNhanVien.TabIndex = 2;
            this.btn_ControlNhanVien.UseVisualStyleBackColor = false;
            this.btn_ControlNhanVien.Click += new System.EventHandler(this.btn_ControlNhanVien_Click);
            // 
            // btn_ControlThongKe
            // 
            this.btn_ControlThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ControlThongKe.BackColor = System.Drawing.Color.Transparent;
            this.btn_ControlThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ControlThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ControlThongKe.ForeColor = System.Drawing.Color.Brown;
            this.btn_ControlThongKe.Image = global::DA_STOREBOOKS_WIN.Properties.Resources.MainThongKe;
            this.btn_ControlThongKe.Location = new System.Drawing.Point(0, 373);
            this.btn_ControlThongKe.Name = "btn_ControlThongKe";
            this.btn_ControlThongKe.Size = new System.Drawing.Size(274, 62);
            this.btn_ControlThongKe.TabIndex = 2;
            this.btn_ControlThongKe.UseVisualStyleBackColor = false;
            this.btn_ControlThongKe.Click += new System.EventHandler(this.btn_ControlThongKe_Click);
            // 
            // btn_ControlHoaDon
            // 
            this.btn_ControlHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ControlHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.btn_ControlHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ControlHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ControlHoaDon.ForeColor = System.Drawing.Color.Brown;
            this.btn_ControlHoaDon.Image = global::DA_STOREBOOKS_WIN.Properties.Resources.MainHoaDon;
            this.btn_ControlHoaDon.Location = new System.Drawing.Point(0, 311);
            this.btn_ControlHoaDon.Name = "btn_ControlHoaDon";
            this.btn_ControlHoaDon.Size = new System.Drawing.Size(274, 62);
            this.btn_ControlHoaDon.TabIndex = 2;
            this.btn_ControlHoaDon.UseVisualStyleBackColor = false;
            this.btn_ControlHoaDon.Click += new System.EventHandler(this.btn_ControlHoaDon_Click);
            // 
            // btn_ControlPhieuNhap
            // 
            this.btn_ControlPhieuNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ControlPhieuNhap.BackColor = System.Drawing.Color.Transparent;
            this.btn_ControlPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ControlPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ControlPhieuNhap.ForeColor = System.Drawing.Color.Brown;
            this.btn_ControlPhieuNhap.Image = global::DA_STOREBOOKS_WIN.Properties.Resources.MainPhieuNhap;
            this.btn_ControlPhieuNhap.Location = new System.Drawing.Point(0, 249);
            this.btn_ControlPhieuNhap.Name = "btn_ControlPhieuNhap";
            this.btn_ControlPhieuNhap.Size = new System.Drawing.Size(274, 62);
            this.btn_ControlPhieuNhap.TabIndex = 2;
            this.btn_ControlPhieuNhap.UseVisualStyleBackColor = false;
            this.btn_ControlPhieuNhap.Click += new System.EventHandler(this.btn_ControlPhieuNhap_Click);
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(274, 185);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            this.pictureBox_logo.Click += new System.EventHandler(this.pictureBox_logo_Click);
            // 
            // panel_Main
            // 
            this.panel_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Main.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_Main.Controls.Add(this.pictureBox_img);
            this.panel_Main.Location = new System.Drawing.Point(280, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(1337, 730);
            this.panel_Main.TabIndex = 1;
            // 
            // pictureBox_img
            // 
            this.pictureBox_img.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_img.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_img.Image")));
            this.pictureBox_img.Location = new System.Drawing.Point(57, 52);
            this.pictureBox_img.Name = "pictureBox_img";
            this.pictureBox_img.Size = new System.Drawing.Size(1176, 639);
            this.pictureBox_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_img.TabIndex = 1;
            this.pictureBox_img.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1617, 730);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_Left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "frmHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel_Left.ResumeLayout(false);
            this.panel_Container.ResumeLayout(false);
            this.panel_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.panel_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.Button btn_ControlSach;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Button btn_DangXuat;
        private System.Windows.Forms.Button btn_ControlThongKe;
        private System.Windows.Forms.Button btn_ControlNhanVien;
        private System.Windows.Forms.Button btn_ControlPhieuNhap;
        private System.Windows.Forms.Button btn_ControlKhach;
        private System.Windows.Forms.Button btn_ControlHoaDon;
        private System.Windows.Forms.PictureBox pictureBox_img;
        private System.Windows.Forms.Label lblPhienDangNhap;
        private System.Windows.Forms.Panel panel_Container;
    }
}

