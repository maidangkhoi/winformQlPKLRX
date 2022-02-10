
namespace Doan1
{
    partial class Danhsachtho
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmatho = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttentho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbTinhTrang = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.btncapnhat);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Location = new System.Drawing.Point(645, 165);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(171, 259);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(7, 165);
            this.btnthem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(153, 36);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(7, 103);
            this.btncapnhat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(153, 37);
            this.btncapnhat.TabIndex = 0;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(7, 47);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(153, 33);
            this.btnxoa.TabIndex = 0;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 165);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(624, 319);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 57);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 31);
            this.button1.TabIndex = 21;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(147, 57);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(163, 27);
            this.txttimkiem.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên thợ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(275, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Danh sách thợ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mã thợ :";
            // 
            // txtmatho
            // 
            this.txtmatho.Location = new System.Drawing.Point(88, 119);
            this.txtmatho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmatho.Name = "txtmatho";
            this.txtmatho.Size = new System.Drawing.Size(129, 27);
            this.txtmatho.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tên thợ :";
            // 
            // txttentho
            // 
            this.txttentho.Location = new System.Drawing.Point(304, 123);
            this.txttentho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttentho.Name = "txttentho";
            this.txttentho.Size = new System.Drawing.Size(129, 27);
            this.txttentho.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(439, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tình trạng :";
            // 
            // cbbTinhTrang
            // 
            this.cbbTinhTrang.FormattingEnabled = true;
            this.cbbTinhTrang.Items.AddRange(new object[] {
            "rảnh",
            "bận"});
            this.cbbTinhTrang.Location = new System.Drawing.Point(522, 122);
            this.cbbTinhTrang.Name = "cbbTinhTrang";
            this.cbbTinhTrang.Size = new System.Drawing.Size(151, 28);
            this.cbbTinhTrang.TabIndex = 27;
            // 
            // Danhsachtho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 531);
            this.Controls.Add(this.cbbTinhTrang);
            this.Controls.Add(this.txttentho);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmatho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Danhsachtho";
            this.Text = "Danhsachtho";
            this.Load += new System.EventHandler(this.Danhsachtho_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmatho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttentho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbTinhTrang;
    }
}