
namespace BaiThi.Net
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngNhânSựToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lươngNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênChínhThứcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênThửViệcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLhoso = new System.Windows.Forms.ToolStripMenuItem();
            this.khaiBáoHồSơToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hồSơNhânViênThôiViệcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLHthong = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.qLNSDataSet = new BaiThi.Net.QLNSDataSet();
            this.qLNSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhmuc,
            this.mnuQLhoso,
            this.mnuQLHthong,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1058, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mnuDanhmuc
            // 
            this.mnuDanhmuc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mnuDanhmuc.BackgroundImage")));
            this.mnuDanhmuc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mnuDanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phòngBanToolStripMenuItem,
            this.phòngNhânSựToolStripMenuItem,
            this.lươngNhânViênToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem});
            this.mnuDanhmuc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDanhmuc.ForeColor = System.Drawing.Color.Lime;
            this.mnuDanhmuc.Name = "mnuDanhmuc";
            this.mnuDanhmuc.Size = new System.Drawing.Size(92, 29);
            this.mnuDanhmuc.Text = "Quản lý";
            this.mnuDanhmuc.Click += new System.EventHandler(this.mnuDanhmuc_Click);
            // 
            // phòngBanToolStripMenuItem
            // 
            this.phòngBanToolStripMenuItem.Name = "phòngBanToolStripMenuItem";
            this.phòngBanToolStripMenuItem.Size = new System.Drawing.Size(235, 30);
            this.phòngBanToolStripMenuItem.Text = "Phòng ban";
            this.phòngBanToolStripMenuItem.Click += new System.EventHandler(this.phòngBanToolStripMenuItem_Click);
            // 
            // phòngNhânSựToolStripMenuItem
            // 
            this.phòngNhânSựToolStripMenuItem.Name = "phòngNhânSựToolStripMenuItem";
            this.phòngNhânSựToolStripMenuItem.Size = new System.Drawing.Size(235, 30);
            this.phòngNhânSựToolStripMenuItem.Text = "Phòng nhân sự";
            this.phòngNhânSựToolStripMenuItem.Click += new System.EventHandler(this.phòngNhânSựToolStripMenuItem_Click);
            // 
            // lươngNhânViênToolStripMenuItem
            // 
            this.lươngNhânViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânViênChínhThứcToolStripMenuItem,
            this.nhânViênThửViệcToolStripMenuItem});
            this.lươngNhânViênToolStripMenuItem.Name = "lươngNhânViênToolStripMenuItem";
            this.lươngNhânViênToolStripMenuItem.Size = new System.Drawing.Size(235, 30);
            this.lươngNhânViênToolStripMenuItem.Text = "Lương nhân viên";
            this.lươngNhânViênToolStripMenuItem.Click += new System.EventHandler(this.lươngNhânViênToolStripMenuItem_Click);
            // 
            // nhânViênChínhThứcToolStripMenuItem
            // 
            this.nhânViênChínhThứcToolStripMenuItem.Name = "nhânViênChínhThứcToolStripMenuItem";
            this.nhânViênChínhThứcToolStripMenuItem.Size = new System.Drawing.Size(272, 30);
            this.nhânViênChínhThứcToolStripMenuItem.Text = "Nhân viên chính thức";
            this.nhânViênChínhThứcToolStripMenuItem.Click += new System.EventHandler(this.nhânViênChínhThứcToolStripMenuItem_Click);
            // 
            // nhânViênThửViệcToolStripMenuItem
            // 
            this.nhânViênThửViệcToolStripMenuItem.Name = "nhânViênThửViệcToolStripMenuItem";
            this.nhânViênThửViệcToolStripMenuItem.Size = new System.Drawing.Size(272, 30);
            this.nhânViênThửViệcToolStripMenuItem.Text = "Nhân viên thử việc";
            this.nhânViênThửViệcToolStripMenuItem.Click += new System.EventHandler(this.nhânViênThửViệcToolStripMenuItem_Click);
            // 
            // mnuQLhoso
            // 
            this.mnuQLhoso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mnuQLhoso.BackgroundImage")));
            this.mnuQLhoso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mnuQLhoso.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khaiBáoHồSơToolStripMenuItem,
            this.hồSơNhânViênThôiViệcToolStripMenuItem});
            this.mnuQLhoso.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuQLhoso.ForeColor = System.Drawing.Color.Lime;
            this.mnuQLhoso.Name = "mnuQLhoso";
            this.mnuQLhoso.Size = new System.Drawing.Size(145, 29);
            this.mnuQLhoso.Text = "Quản lý hồ sơ";
            // 
            // khaiBáoHồSơToolStripMenuItem
            // 
            this.khaiBáoHồSơToolStripMenuItem.Name = "khaiBáoHồSơToolStripMenuItem";
            this.khaiBáoHồSơToolStripMenuItem.Size = new System.Drawing.Size(307, 30);
            this.khaiBáoHồSơToolStripMenuItem.Text = "Hồ sơ thử việc";
            this.khaiBáoHồSơToolStripMenuItem.Click += new System.EventHandler(this.khaiBáoHồSơToolStripMenuItem_Click);
            // 
            // hồSơNhânViênThôiViệcToolStripMenuItem
            // 
            this.hồSơNhânViênThôiViệcToolStripMenuItem.Name = "hồSơNhânViênThôiViệcToolStripMenuItem";
            this.hồSơNhânViênThôiViệcToolStripMenuItem.Size = new System.Drawing.Size(307, 30);
            this.hồSơNhânViênThôiViệcToolStripMenuItem.Text = "Hồ sơ nhân viên thôi việc";
            this.hồSơNhânViênThôiViệcToolStripMenuItem.Click += new System.EventHandler(this.hồSơNhânViênThôiViệcToolStripMenuItem_Click);
            // 
            // mnuQLHthong
            // 
            this.mnuQLHthong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mnuQLHthong.BackgroundImage")));
            this.mnuQLHthong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mnuQLHthong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýTàiKhoảnToolStripMenuItem});
            this.mnuQLHthong.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuQLHthong.ForeColor = System.Drawing.Color.Lime;
            this.mnuQLHthong.Name = "mnuQLHthong";
            this.mnuQLHthong.Size = new System.Drawing.Size(177, 29);
            this.mnuQLHthong.Text = "Quản lý hệ thống";
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.thêmMậtKhẩuToolStripMenuItem});
            this.quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            this.quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản";
            this.quảnLýTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýTàiKhoảnToolStripMenuItem_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(221, 30);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // thêmMậtKhẩuToolStripMenuItem
            // 
            this.thêmMậtKhẩuToolStripMenuItem.Name = "thêmMậtKhẩuToolStripMenuItem";
            this.thêmMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(221, 30);
            this.thêmMậtKhẩuToolStripMenuItem.Text = "Thêm tài khoản";
            this.thêmMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.thêmMậtKhẩuToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tìm Kiếm ";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Orange;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(452, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 34);
            this.button3.TabIndex = 12;
            this.button3.Text = "Tìm";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 29);
            this.textBox1.MaximumSize = new System.Drawing.Size(277, 20);
            this.textBox1.MinimumSize = new System.Drawing.Size(277, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(358, 55);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(101, 28);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "CMTND";
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Location = new System.Drawing.Point(222, 55);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(117, 28);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "Họ và tên";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Location = new System.Drawing.Point(52, 55);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(154, 28);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.Text = "Mã nhân viên";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(10, 96);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(875, 125);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(21, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(902, 236);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // qLNSDataSet
            // 
            this.qLNSDataSet.DataSetName = "QLNSDataSet";
            this.qLNSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLNSDataSetBindingSource
            // 
            this.qLNSDataSetBindingSource.DataSource = this.qLNSDataSet;
            this.qLNSDataSetBindingSource.Position = 0;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("đăngXuấtToolStripMenuItem.BackgroundImage")));
            this.đăngXuấtToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.đăngXuấtToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.đăngXuấtToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.đăngXuấtToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(101, 29);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(235, 30);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm Kiếm";
            this.tìmKiếmToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.CausesValidation = false;
            this.button1.Enabled = false;
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(556, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1058, 347);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhmuc;
        private System.Windows.Forms.ToolStripMenuItem phòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuQLhoso;
        private System.Windows.Forms.ToolStripMenuItem khaiBáoHồSơToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuQLHthong;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngNhânSựToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hồSơNhânViênThôiViệcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lươngNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênChínhThứcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênThửViệcToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private QLNSDataSet qLNSDataSet;
        private System.Windows.Forms.BindingSource qLNSDataSetBindingSource;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}