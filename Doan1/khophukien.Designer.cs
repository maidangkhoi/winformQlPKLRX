
namespace Doan1
{
    partial class khophukien
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnquayve = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnnhaphang = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMPK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTPK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.cbbLPK = new System.Windows.Forms.ComboBox();
            this.cbbNCC = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(323, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kho phụ kiện";
            // 
            // btnquayve
            // 
            this.btnquayve.Location = new System.Drawing.Point(14, 13);
            this.btnquayve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnquayve.Name = "btnquayve";
            this.btnquayve.Size = new System.Drawing.Size(86, 31);
            this.btnquayve.TabIndex = 2;
            this.btnquayve.Text = "quay về";
            this.btnquayve.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên phụ kiện";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(323, 53);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(163, 27);
            this.txttimkiem.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 53);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 209);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(693, 325);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnnhaphang);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Location = new System.Drawing.Point(713, 209);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(179, 160);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnnhaphang
            // 
            this.btnnhaphang.Location = new System.Drawing.Point(6, 114);
            this.btnnhaphang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnnhaphang.Name = "btnnhaphang";
            this.btnnhaphang.Size = new System.Drawing.Size(153, 36);
            this.btnnhaphang.TabIndex = 0;
            this.btnnhaphang.Text = "Nhập hàng";
            this.btnnhaphang.UseVisualStyleBackColor = true;
            this.btnnhaphang.Click += new System.EventHandler(this.btnnhaphang_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(8, 69);
            this.btnsua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(153, 37);
            this.btnsua.TabIndex = 0;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(8, 28);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(153, 33);
            this.btnxoa.TabIndex = 0;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(827, 13);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(54, 31);
            this.btnthoat.TabIndex = 8;
            this.btnthoat.Text = "X";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã phụ kiện";
            // 
            // txtMPK
            // 
            this.txtMPK.Location = new System.Drawing.Point(106, 124);
            this.txtMPK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMPK.Name = "txtMPK";
            this.txtMPK.Size = new System.Drawing.Size(163, 27);
            this.txtMPK.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên phụ kiện";
            // 
            // txtTPK
            // 
            this.txtTPK.Location = new System.Drawing.Point(384, 124);
            this.txtTPK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTPK.Name = "txtTPK";
            this.txtTPK.Size = new System.Drawing.Size(163, 27);
            this.txtTPK.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(566, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Loại phụ kiện";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nhà cung cấp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Số lượng";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(384, 171);
            this.txtSL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(163, 27);
            this.txtSL.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(566, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Đơn vị tính";
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(658, 174);
            this.txtDVT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(163, 27);
            this.txtDVT.TabIndex = 4;
            // 
            // cbbLPK
            // 
            this.cbbLPK.FormattingEnabled = true;
            this.cbbLPK.Location = new System.Drawing.Point(658, 123);
            this.cbbLPK.Name = "cbbLPK";
            this.cbbLPK.Size = new System.Drawing.Size(151, 28);
            this.cbbLPK.TabIndex = 9;
            // 
            // cbbNCC
            // 
            this.cbbNCC.FormattingEnabled = true;
            this.cbbNCC.Location = new System.Drawing.Point(118, 171);
            this.cbbNCC.Name = "cbbNCC";
            this.cbbNCC.Size = new System.Drawing.Size(151, 28);
            this.cbbNCC.TabIndex = 9;
            // 
            // khophukien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 556);
            this.Controls.Add(this.cbbNCC);
            this.Controls.Add(this.cbbLPK);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMPK);
            this.Controls.Add(this.txtDVT);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtTPK);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnquayve);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "khophukien";
            this.Text = "khuphukien";
            this.Load += new System.EventHandler(this.khophukien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnquayve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnnhaphang;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMPK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTPK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.ComboBox cbbLPK;
        private System.Windows.Forms.ComboBox cbbNCC;
    }
}