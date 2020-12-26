
namespace LK_Winform
{
    partial class fThongKe
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
            this.dtgDisplayLinhKien = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtgDisplayLLK = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtTenLM3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMaLM3 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnLoadLM = new System.Windows.Forms.Button();
            this.btnSuaLM = new System.Windows.Forms.Button();
            this.btnXoaLM = new System.Windows.Forms.Button();
            this.btnThemLM = new System.Windows.Forms.Button();
            this.dtgDisplayLM = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnLoadNCC = new System.Windows.Forms.Button();
            this.btnSuaNCC = new System.Windows.Forms.Button();
            this.btnXoaNCC = new System.Windows.Forms.Button();
            this.btnThemNCC = new System.Windows.Forms.Button();
            this.dtgDisplayNCC = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisplayLinhKien)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisplayLLK)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisplayLM)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisplayNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDisplayLinhKien
            // 
            this.dtgDisplayLinhKien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDisplayLinhKien.Location = new System.Drawing.Point(6, 48);
            this.dtgDisplayLinhKien.Name = "dtgDisplayLinhKien";
            this.dtgDisplayLinhKien.Size = new System.Drawing.Size(787, 314);
            this.dtgDisplayLinhKien.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-3, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(807, 394);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.dtgDisplayLinhKien);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(799, 368);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Linh kiện";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtgDisplayLLK);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(799, 368);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Loại Linh Kiện";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgDisplayLLK
            // 
            this.dtgDisplayLLK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDisplayLLK.Location = new System.Drawing.Point(6, 52);
            this.dtgDisplayLLK.Name = "dtgDisplayLLK";
            this.dtgDisplayLLK.Size = new System.Drawing.Size(787, 310);
            this.dtgDisplayLLK.TabIndex = 23;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtTenLM3);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.txtMaLM3);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.btnLoadLM);
            this.tabPage3.Controls.Add(this.btnSuaLM);
            this.tabPage3.Controls.Add(this.btnXoaLM);
            this.tabPage3.Controls.Add(this.btnThemLM);
            this.tabPage3.Controls.Add(this.dtgDisplayLM);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(799, 368);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Loại máy";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtTenLM3
            // 
            this.txtTenLM3.Location = new System.Drawing.Point(691, 41);
            this.txtTenLM3.Name = "txtTenLM3";
            this.txtTenLM3.Size = new System.Drawing.Size(100, 20);
            this.txtTenLM3.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(590, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Tên loại máy";
            // 
            // txtMaLM3
            // 
            this.txtMaLM3.Location = new System.Drawing.Point(691, 15);
            this.txtMaLM3.Name = "txtMaLM3";
            this.txtMaLM3.ReadOnly = true;
            this.txtMaLM3.Size = new System.Drawing.Size(100, 20);
            this.txtMaLM3.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(590, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Mã loại máy";
            // 
            // btnLoadLM
            // 
            this.btnLoadLM.Location = new System.Drawing.Point(738, 310);
            this.btnLoadLM.Name = "btnLoadLM";
            this.btnLoadLM.Size = new System.Drawing.Size(55, 23);
            this.btnLoadLM.TabIndex = 36;
            this.btnLoadLM.Text = "Load lại";
            this.btnLoadLM.UseVisualStyleBackColor = true;
            // 
            // btnSuaLM
            // 
            this.btnSuaLM.Location = new System.Drawing.Point(661, 339);
            this.btnSuaLM.Name = "btnSuaLM";
            this.btnSuaLM.Size = new System.Drawing.Size(55, 23);
            this.btnSuaLM.TabIndex = 35;
            this.btnSuaLM.Text = "Sửa";
            this.btnSuaLM.UseVisualStyleBackColor = true;
            // 
            // btnXoaLM
            // 
            this.btnXoaLM.Location = new System.Drawing.Point(739, 339);
            this.btnXoaLM.Name = "btnXoaLM";
            this.btnXoaLM.Size = new System.Drawing.Size(54, 23);
            this.btnXoaLM.TabIndex = 34;
            this.btnXoaLM.Text = "Xóa";
            this.btnXoaLM.UseVisualStyleBackColor = true;
            // 
            // btnThemLM
            // 
            this.btnThemLM.Location = new System.Drawing.Point(584, 339);
            this.btnThemLM.Name = "btnThemLM";
            this.btnThemLM.Size = new System.Drawing.Size(59, 23);
            this.btnThemLM.TabIndex = 33;
            this.btnThemLM.Text = "Thêm";
            this.btnThemLM.UseVisualStyleBackColor = true;
            // 
            // dtgDisplayLM
            // 
            this.dtgDisplayLM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDisplayLM.Location = new System.Drawing.Point(6, 6);
            this.dtgDisplayLM.Name = "dtgDisplayLM";
            this.dtgDisplayLM.Size = new System.Drawing.Size(572, 356);
            this.dtgDisplayLM.TabIndex = 32;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtTenNCC);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.txtMaNCC);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.btnLoadNCC);
            this.tabPage4.Controls.Add(this.btnSuaNCC);
            this.tabPage4.Controls.Add(this.btnXoaNCC);
            this.tabPage4.Controls.Add(this.btnThemNCC);
            this.tabPage4.Controls.Add(this.dtgDisplayNCC);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(799, 368);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Nhà cung cấp";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(691, 41);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(100, 20);
            this.txtTenNCC.TabIndex = 40;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(590, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "Tên nhà cung cấp";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(691, 15);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.ReadOnly = true;
            this.txtMaNCC.Size = new System.Drawing.Size(100, 20);
            this.txtMaNCC.TabIndex = 38;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(590, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Mã nhà cung cấp";
            // 
            // btnLoadNCC
            // 
            this.btnLoadNCC.Location = new System.Drawing.Point(738, 310);
            this.btnLoadNCC.Name = "btnLoadNCC";
            this.btnLoadNCC.Size = new System.Drawing.Size(55, 23);
            this.btnLoadNCC.TabIndex = 36;
            this.btnLoadNCC.Text = "Load lại";
            this.btnLoadNCC.UseVisualStyleBackColor = true;
            // 
            // btnSuaNCC
            // 
            this.btnSuaNCC.Location = new System.Drawing.Point(661, 339);
            this.btnSuaNCC.Name = "btnSuaNCC";
            this.btnSuaNCC.Size = new System.Drawing.Size(55, 23);
            this.btnSuaNCC.TabIndex = 35;
            this.btnSuaNCC.Text = "Sửa";
            this.btnSuaNCC.UseVisualStyleBackColor = true;
            // 
            // btnXoaNCC
            // 
            this.btnXoaNCC.Location = new System.Drawing.Point(739, 339);
            this.btnXoaNCC.Name = "btnXoaNCC";
            this.btnXoaNCC.Size = new System.Drawing.Size(54, 23);
            this.btnXoaNCC.TabIndex = 34;
            this.btnXoaNCC.Text = "Xóa";
            this.btnXoaNCC.UseVisualStyleBackColor = true;
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.Location = new System.Drawing.Point(584, 339);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(59, 23);
            this.btnThemNCC.TabIndex = 33;
            this.btnThemNCC.Text = "Thêm";
            this.btnThemNCC.UseVisualStyleBackColor = true;
            // 
            // dtgDisplayNCC
            // 
            this.dtgDisplayNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDisplayNCC.Location = new System.Drawing.Point(6, 6);
            this.dtgDisplayNCC.Name = "dtgDisplayNCC";
            this.dtgDisplayNCC.Size = new System.Drawing.Size(572, 356);
            this.dtgDisplayNCC.TabIndex = 32;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(569, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(698, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // fThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 433);
            this.Controls.Add(this.tabControl1);
            this.Name = "fThongKe";
            this.Text = "fThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisplayLinhKien)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisplayLLK)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisplayLM)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisplayNCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDisplayLinhKien;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtgDisplayLLK;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtTenLM3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMaLM3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnLoadLM;
        private System.Windows.Forms.Button btnSuaLM;
        private System.Windows.Forms.Button btnXoaLM;
        private System.Windows.Forms.Button btnThemLM;
        private System.Windows.Forms.DataGridView dtgDisplayLM;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnLoadNCC;
        private System.Windows.Forms.Button btnSuaNCC;
        private System.Windows.Forms.Button btnXoaNCC;
        private System.Windows.Forms.Button btnThemNCC;
        private System.Windows.Forms.DataGridView dtgDisplayNCC;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}