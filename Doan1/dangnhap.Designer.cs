
namespace Doan1
{
    partial class dangnhap
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
            this.label2 = new System.Windows.Forms.Label();
            this.txttaikhoan = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.btndoimatkhau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(129, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài khoản";
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.Location = new System.Drawing.Point(110, 63);
            this.txttaikhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(171, 27);
            this.txttaikhoan.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(14, 123);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(82, 22);
            this.label.TabIndex = 1;
            this.label.Text = "Mật khẩu";
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(110, 123);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(171, 27);
            this.txtmatkhau.TabIndex = 2;
            // 
            // btndangnhap
            // 
            this.btndangnhap.Location = new System.Drawing.Point(43, 207);
            this.btndangnhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(111, 43);
            this.btndangnhap.TabIndex = 3;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // btndoimatkhau
            // 
            this.btndoimatkhau.Location = new System.Drawing.Point(192, 207);
            this.btndoimatkhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btndoimatkhau.Name = "btndoimatkhau";
            this.btndoimatkhau.Size = new System.Drawing.Size(111, 43);
            this.btndoimatkhau.TabIndex = 3;
            this.btndoimatkhau.Text = "Đổi mật khẩu";
            this.btndoimatkhau.UseVisualStyleBackColor = true;
            this.btndoimatkhau.Click += new System.EventHandler(this.btndoimatkhau_Click);
            // 
            // dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 325);
            this.Controls.Add(this.btndoimatkhau);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txttaikhoan);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "dangnhap";
            this.Text = "dangnhap";
            this.Load += new System.EventHandler(this.dangnhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttaikhoan;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Button btndoimatkhau;
    }
}