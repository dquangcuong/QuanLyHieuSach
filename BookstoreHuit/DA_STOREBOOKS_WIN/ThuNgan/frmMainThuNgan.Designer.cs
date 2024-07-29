
namespace DA_STOREBOOKS_WIN.ThuNgan
{
    partial class frmMainThuNgan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainThuNgan));
            this.panel_Left = new System.Windows.Forms.Panel();
            this.panel_Container = new System.Windows.Forms.Panel();
            this.btn_ControlTraCuu = new System.Windows.Forms.Button();
            this.lblPhienDangNhap = new System.Windows.Forms.Label();
            this.btn_ControlKhach = new System.Windows.Forms.Button();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.btn_ControlHoaDon = new System.Windows.Forms.Button();
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
            this.panel_Left.Size = new System.Drawing.Size(298, 745);
            this.panel_Left.TabIndex = 2;
            // 
            // panel_Container
            // 
            this.panel_Container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Container.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_Container.Controls.Add(this.btn_ControlTraCuu);
            this.panel_Container.Controls.Add(this.lblPhienDangNhap);
            this.panel_Container.Controls.Add(this.btn_ControlKhach);
            this.panel_Container.Controls.Add(this.btn_DangXuat);
            this.panel_Container.Controls.Add(this.btn_ControlHoaDon);
            this.panel_Container.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Container.Location = new System.Drawing.Point(-1, 183);
            this.panel_Container.Name = "panel_Container";
            this.panel_Container.Size = new System.Drawing.Size(308, 557);
            this.panel_Container.TabIndex = 4;
            // 
            // btn_ControlTraCuu
            // 
            this.btn_ControlTraCuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ControlTraCuu.BackColor = System.Drawing.Color.Transparent;
            this.btn_ControlTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ControlTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ControlTraCuu.ForeColor = System.Drawing.Color.Brown;
            this.btn_ControlTraCuu.Image = global::DA_STOREBOOKS_WIN.Properties.Resources.TNtracuu;
            this.btn_ControlTraCuu.Location = new System.Drawing.Point(0, 96);
            this.btn_ControlTraCuu.Name = "btn_ControlTraCuu";
            this.btn_ControlTraCuu.Size = new System.Drawing.Size(308, 67);
            this.btn_ControlTraCuu.TabIndex = 2;
            this.btn_ControlTraCuu.UseVisualStyleBackColor = false;
            this.btn_ControlTraCuu.Click += new System.EventHandler(this.btn_ControlTraCuu_Click);
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
            this.btn_ControlKhach.Image = global::DA_STOREBOOKS_WIN.Properties.Resources.TNkhachhang;
            this.btn_ControlKhach.Location = new System.Drawing.Point(0, 186);
            this.btn_ControlKhach.Name = "btn_ControlKhach";
            this.btn_ControlKhach.Size = new System.Drawing.Size(308, 67);
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
            this.btn_DangXuat.Image = global::DA_STOREBOOKS_WIN.Properties.Resources.DangXuat;
            this.btn_DangXuat.Location = new System.Drawing.Point(39, 477);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(238, 59);
            this.btn_DangXuat.TabIndex = 2;
            this.btn_DangXuat.UseVisualStyleBackColor = false;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // btn_ControlHoaDon
            // 
            this.btn_ControlHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ControlHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.btn_ControlHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ControlHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ControlHoaDon.ForeColor = System.Drawing.Color.Brown;
            this.btn_ControlHoaDon.Image = global::DA_STOREBOOKS_WIN.Properties.Resources.TNhoadon;
            this.btn_ControlHoaDon.Location = new System.Drawing.Point(0, 271);
            this.btn_ControlHoaDon.Name = "btn_ControlHoaDon";
            this.btn_ControlHoaDon.Size = new System.Drawing.Size(308, 67);
            this.btn_ControlHoaDon.TabIndex = 2;
            this.btn_ControlHoaDon.UseVisualStyleBackColor = false;
            this.btn_ControlHoaDon.Click += new System.EventHandler(this.btn_ControlHoaDon_Click);
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(308, 186);
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
            this.panel_Main.BackColor = System.Drawing.Color.Transparent;
            this.panel_Main.Controls.Add(this.pictureBox_img);
            this.panel_Main.Location = new System.Drawing.Point(304, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(1306, 730);
            this.panel_Main.TabIndex = 3;
            // 
            // pictureBox_img
            // 
            this.pictureBox_img.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_img.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_img.Image")));
            this.pictureBox_img.Location = new System.Drawing.Point(85, 63);
            this.pictureBox_img.Name = "pictureBox_img";
            this.pictureBox_img.Size = new System.Drawing.Size(1145, 639);
            this.pictureBox_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_img.TabIndex = 1;
            this.pictureBox_img.TabStop = false;
            // 
            // frmMainThuNgan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1603, 745);
            this.Controls.Add(this.panel_Left);
            this.Controls.Add(this.panel_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainThuNgan";
            this.Text = "frmMainThuNgan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainThuNgan_FormClosing);
            this.Load += new System.EventHandler(this.frmMainThuNgan_Load);
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
        private System.Windows.Forms.Panel panel_Container;
        private System.Windows.Forms.Button btn_ControlTraCuu;
        private System.Windows.Forms.Label lblPhienDangNhap;
        private System.Windows.Forms.Button btn_ControlKhach;
        private System.Windows.Forms.Button btn_DangXuat;
        private System.Windows.Forms.Button btn_ControlHoaDon;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.PictureBox pictureBox_img;
    }
}