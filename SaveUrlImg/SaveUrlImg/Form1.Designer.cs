namespace SaveUrlImg
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_PopUp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ck_URL = new System.Windows.Forms.CheckBox();
            this.ck_Rename = new System.Windows.Forms.CheckBox();
            this.ck_SavePath = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_URL = new System.Windows.Forms.TextBox();
            this.txt_Rename = new System.Windows.Forms.TextBox();
            this.txt_SavePath = new System.Windows.Forms.TextBox();
            this.btn_DownLoad = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btn_Clear, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_PopUp, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_URL, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_Rename, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_SavePath, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_DownLoad, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(690, 134);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(531, 88);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 1;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_PopUp
            // 
            this.btn_PopUp.Location = new System.Drawing.Point(531, 59);
            this.btn_PopUp.Name = "btn_PopUp";
            this.btn_PopUp.Size = new System.Drawing.Size(75, 23);
            this.btn_PopUp.TabIndex = 2;
            this.btn_PopUp.Text = "...";
            this.btn_PopUp.UseVisualStyleBackColor = true;
            this.btn_PopUp.Click += new System.EventHandler(this.btn_PopUp_Click);
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 43);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 43);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clear Setting";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel2.Controls.Add(this.ck_URL, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ck_Rename, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ck_SavePath, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(516, 22);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // ck_URL
            // 
            this.ck_URL.AutoSize = true;
            this.ck_URL.Location = new System.Drawing.Point(3, 3);
            this.ck_URL.Name = "ck_URL";
            this.ck_URL.Size = new System.Drawing.Size(47, 16);
            this.ck_URL.TabIndex = 0;
            this.ck_URL.Text = "URL";
            this.ck_URL.UseVisualStyleBackColor = true;
            // 
            // ck_Rename
            // 
            this.ck_Rename.AutoSize = true;
            this.ck_Rename.Location = new System.Drawing.Point(207, 3);
            this.ck_Rename.Name = "ck_Rename";
            this.ck_Rename.Size = new System.Drawing.Size(62, 16);
            this.ck_Rename.TabIndex = 1;
            this.ck_Rename.Text = "Rename";
            this.ck_Rename.UseVisualStyleBackColor = true;
            // 
            // ck_SavePath
            // 
            this.ck_SavePath.AutoSize = true;
            this.ck_SavePath.Location = new System.Drawing.Point(411, 3);
            this.ck_SavePath.Name = "ck_SavePath";
            this.ck_SavePath.Size = new System.Drawing.Size(69, 16);
            this.ck_SavePath.TabIndex = 2;
            this.ck_SavePath.Text = "Save Path";
            this.ck_SavePath.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rename";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Save Path";
            // 
            // txt_URL
            // 
            this.txt_URL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_URL.Location = new System.Drawing.Point(59, 3);
            this.txt_URL.Name = "txt_URL";
            this.txt_URL.Size = new System.Drawing.Size(466, 22);
            this.txt_URL.TabIndex = 7;
            // 
            // txt_Rename
            // 
            this.txt_Rename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Rename.Location = new System.Drawing.Point(59, 31);
            this.txt_Rename.Name = "txt_Rename";
            this.txt_Rename.Size = new System.Drawing.Size(466, 22);
            this.txt_Rename.TabIndex = 8;
            // 
            // txt_SavePath
            // 
            this.txt_SavePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_SavePath.Location = new System.Drawing.Point(59, 59);
            this.txt_SavePath.Name = "txt_SavePath";
            this.txt_SavePath.Size = new System.Drawing.Size(466, 22);
            this.txt_SavePath.TabIndex = 9;
            // 
            // btn_DownLoad
            // 
            this.btn_DownLoad.Location = new System.Drawing.Point(612, 59);
            this.btn_DownLoad.Name = "btn_DownLoad";
            this.btn_DownLoad.Size = new System.Drawing.Size(75, 23);
            this.btn_DownLoad.TabIndex = 0;
            this.btn_DownLoad.Text = "DownLoad";
            this.btn_DownLoad.UseVisualStyleBackColor = true;
            this.btn_DownLoad.Click += new System.EventHandler(this.btn_DownLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 134);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Save Image ";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_DownLoad;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_PopUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox ck_URL;
        private System.Windows.Forms.CheckBox ck_Rename;
        private System.Windows.Forms.CheckBox ck_SavePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_URL;
        private System.Windows.Forms.TextBox txt_Rename;
        private System.Windows.Forms.TextBox txt_SavePath;
    }
}

