
namespace BaiThi.Net
{
    partial class frmDSthoivc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSthoivc));
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tho = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMTNDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayThoiViecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lyDoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblNVThoiViecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNSDataSet = new BaiThi.Net.QLNSDataSet();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tblNVThoiViecTableAdapter = new BaiThi.Net.QLNSDataSetTableAdapters.TblNVThoiViecTableAdapter();
            this.tho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNVThoiViecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(108, 120);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(137, 22);
            this.dateTimePicker3.TabIndex = 21;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(328, 160);
            this.textBox19.Margin = new System.Windows.Forms.Padding(4);
            this.textBox19.Multiline = true;
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(386, 75);
            this.textBox19.TabIndex = 22;
            this.textBox19.TextChanged += new System.EventHandler(this.textBox19_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(108, 78);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(129, 22);
            this.textBox9.TabIndex = 20;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(108, 34);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(144, 22);
            this.textBox4.TabIndex = 19;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(251, 169);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 16);
            this.label19.TabIndex = 23;
            this.label19.Text = "Ghi chú";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(40, 124);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 16);
            this.label16.TabIndex = 24;
            this.label16.Text = "Ngày ký";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "CMTND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Họ tên";
            // 
            // tho
            // 
            this.tho.BackColor = System.Drawing.Color.Transparent;
            this.tho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tho.BackgroundImage")));
            this.tho.Controls.Add(this.dataGridView1);
            this.tho.Controls.Add(this.label19);
            this.tho.Controls.Add(this.textBox19);
            this.tho.Controls.Add(this.button5);
            this.tho.Controls.Add(this.textBox4);
            this.tho.Controls.Add(this.button3);
            this.tho.Controls.Add(this.label4);
            this.tho.Controls.Add(this.label16);
            this.tho.Controls.Add(this.textBox9);
            this.tho.Controls.Add(this.dateTimePicker3);
            this.tho.Controls.Add(this.label9);
            this.tho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tho.Location = new System.Drawing.Point(12, 23);
            this.tho.Name = "tho";
            this.tho.Size = new System.Drawing.Size(786, 277);
            this.tho.TabIndex = 27;
            this.tho.TabStop = false;
            this.tho.Text = "Danh sách nghỉ việc";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hoTenDataGridViewTextBoxColumn,
            this.cMTNDDataGridViewTextBoxColumn,
            this.ngayThoiViecDataGridViewTextBoxColumn,
            this.lyDoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblNVThoiViecBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(268, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 123);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            // 
            // cMTNDDataGridViewTextBoxColumn
            // 
            this.cMTNDDataGridViewTextBoxColumn.DataPropertyName = "CMTND";
            this.cMTNDDataGridViewTextBoxColumn.HeaderText = "CMTND";
            this.cMTNDDataGridViewTextBoxColumn.Name = "cMTNDDataGridViewTextBoxColumn";
            // 
            // ngayThoiViecDataGridViewTextBoxColumn
            // 
            this.ngayThoiViecDataGridViewTextBoxColumn.DataPropertyName = "NgayThoiViec";
            this.ngayThoiViecDataGridViewTextBoxColumn.HeaderText = "NgayThoiViec";
            this.ngayThoiViecDataGridViewTextBoxColumn.Name = "ngayThoiViecDataGridViewTextBoxColumn";
            // 
            // lyDoDataGridViewTextBoxColumn
            // 
            this.lyDoDataGridViewTextBoxColumn.DataPropertyName = "LyDo";
            this.lyDoDataGridViewTextBoxColumn.HeaderText = "LyDo";
            this.lyDoDataGridViewTextBoxColumn.Name = "lyDoDataGridViewTextBoxColumn";
            // 
            // tblNVThoiViecBindingSource
            // 
            this.tblNVThoiViecBindingSource.DataMember = "TblNVThoiViec";
            this.tblNVThoiViecBindingSource.DataSource = this.qLNSDataSetBindingSource;
            // 
            // qLNSDataSetBindingSource
            // 
            this.qLNSDataSetBindingSource.DataSource = this.qLNSDataSet;
            this.qLNSDataSetBindingSource.Position = 0;
            // 
            // qLNSDataSet
            // 
            this.qLNSDataSet.DataSetName = "QLNSDataSet";
            this.qLNSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(186, 200);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 35);
            this.button5.TabIndex = 29;
            this.button5.Text = "Thoát ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(55, 200);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 35);
            this.button3.TabIndex = 28;
            this.button3.Text = "Xóa   ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tblNVThoiViecTableAdapter
            // 
            this.tblNVThoiViecTableAdapter.ClearBeforeFill = true;
            // 
            // frmDSthoivc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(880, 366);
            this.Controls.Add(this.tho);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDSthoivc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDSthoivc";
            this.Load += new System.EventHandler(this.frmDSthoivc_Load);
            this.tho.ResumeLayout(false);
            this.tho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNVThoiViecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox tho;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource qLNSDataSetBindingSource;
        private QLNSDataSet qLNSDataSet;
        private System.Windows.Forms.BindingSource tblNVThoiViecBindingSource;
        private QLNSDataSetTableAdapters.TblNVThoiViecTableAdapter tblNVThoiViecTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMTNDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayThoiViecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lyDoDataGridViewTextBoxColumn;
    }
}