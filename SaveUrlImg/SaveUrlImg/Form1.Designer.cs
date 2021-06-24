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
            this.btn_PopUp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Clear = new System.Windows.Forms.Button();
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
            this.lbl_Msg = new System.Windows.Forms.Label();
            this.cb_FileType = new System.Windows.Forms.ComboBox();
            this.tab_Function = new System.Windows.Forms.TabControl();
            this.tab_Normal = new System.Windows.Forms.TabPage();
            this.tab_Large = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_LgURL = new System.Windows.Forms.TextBox();
            this.btn_LgPopUp = new System.Windows.Forms.Button();
            this.ck_SamePath = new System.Windows.Forms.CheckBox();
            this.btn_LgFolder = new System.Windows.Forms.Button();
            this.btn_LgDownLoad = new System.Windows.Forms.Button();
            this.btn_LgClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_LgSavePath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_LgMsg = new System.Windows.Forms.TextBox();
            this.cb_LgFileType = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tab_Function.SuspendLayout();
            this.tab_Normal.SuspendLayout();
            this.tab_Large.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel1.Controls.Add(this.btn_PopUp, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_URL, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_Rename, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_SavePath, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_DownLoad, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Msg, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cb_FileType, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1020, 214);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_PopUp
            // 
            this.btn_PopUp.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_PopUp.Location = new System.Drawing.Point(906, 64);
            this.btn_PopUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_PopUp.Name = "btn_PopUp";
            this.btn_PopUp.Size = new System.Drawing.Size(41, 31);
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
            this.panel1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel1.Location = new System.Drawing.Point(3, 115);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 96);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(897, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clear Setting";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Clear, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.ck_URL, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ck_Rename, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ck_SavePath, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(891, 73);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Clear.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Clear.Location = new System.Drawing.Point(669, 4);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(219, 65);
            this.btn_Clear.TabIndex = 1;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // ck_URL
            // 
            this.ck_URL.AutoSize = true;
            this.ck_URL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ck_URL.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ck_URL.Location = new System.Drawing.Point(3, 4);
            this.ck_URL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ck_URL.Name = "ck_URL";
            this.ck_URL.Size = new System.Drawing.Size(216, 65);
            this.ck_URL.TabIndex = 0;
            this.ck_URL.Text = "URL";
            this.ck_URL.UseVisualStyleBackColor = true;
            // 
            // ck_Rename
            // 
            this.ck_Rename.AutoSize = true;
            this.ck_Rename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ck_Rename.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ck_Rename.Location = new System.Drawing.Point(225, 4);
            this.ck_Rename.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ck_Rename.Name = "ck_Rename";
            this.ck_Rename.Size = new System.Drawing.Size(216, 65);
            this.ck_Rename.TabIndex = 1;
            this.ck_Rename.Text = "Rename";
            this.ck_Rename.UseVisualStyleBackColor = true;
            // 
            // ck_SavePath
            // 
            this.ck_SavePath.AutoSize = true;
            this.ck_SavePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ck_SavePath.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ck_SavePath.Location = new System.Drawing.Point(447, 4);
            this.ck_SavePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ck_SavePath.Name = "ck_SavePath";
            this.ck_SavePath.Size = new System.Drawing.Size(216, 65);
            this.ck_SavePath.TabIndex = 2;
            this.ck_SavePath.Text = "Save Path";
            this.ck_SavePath.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rename";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Save Path";
            // 
            // txt_URL
            // 
            this.txt_URL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_URL.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_URL.Location = new System.Drawing.Point(59, 4);
            this.txt_URL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_URL.Name = "txt_URL";
            this.txt_URL.Size = new System.Drawing.Size(841, 22);
            this.txt_URL.TabIndex = 7;
            this.txt_URL.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txt_Rename
            // 
            this.txt_Rename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Rename.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Rename.Location = new System.Drawing.Point(59, 34);
            this.txt_Rename.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Rename.Name = "txt_Rename";
            this.txt_Rename.Size = new System.Drawing.Size(841, 22);
            this.txt_Rename.TabIndex = 8;
            this.txt_Rename.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txt_SavePath
            // 
            this.txt_SavePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_SavePath.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_SavePath.Location = new System.Drawing.Point(59, 64);
            this.txt_SavePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SavePath.Name = "txt_SavePath";
            this.txt_SavePath.Size = new System.Drawing.Size(841, 22);
            this.txt_SavePath.TabIndex = 9;
            this.txt_SavePath.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // btn_DownLoad
            // 
            this.btn_DownLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_DownLoad.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_DownLoad.Location = new System.Drawing.Point(906, 115);
            this.btn_DownLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_DownLoad.Name = "btn_DownLoad";
            this.btn_DownLoad.Size = new System.Drawing.Size(111, 96);
            this.btn_DownLoad.TabIndex = 0;
            this.btn_DownLoad.Text = "DownLoad";
            this.btn_DownLoad.UseVisualStyleBackColor = true;
            this.btn_DownLoad.Click += new System.EventHandler(this.btn_DownLoad_Click);
            // 
            // lbl_Msg
            // 
            this.lbl_Msg.AutoSize = true;
            this.lbl_Msg.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Msg.ForeColor = System.Drawing.Color.Red;
            this.lbl_Msg.Location = new System.Drawing.Point(59, 99);
            this.lbl_Msg.Name = "lbl_Msg";
            this.lbl_Msg.Size = new System.Drawing.Size(25, 12);
            this.lbl_Msg.TabIndex = 10;
            this.lbl_Msg.Text = "Msg";
            // 
            // cb_FileType
            // 
            this.cb_FileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_FileType.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_FileType.FormattingEnabled = true;
            this.cb_FileType.Location = new System.Drawing.Point(906, 34);
            this.cb_FileType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_FileType.Name = "cb_FileType";
            this.cb_FileType.Size = new System.Drawing.Size(109, 20);
            this.cb_FileType.TabIndex = 11;
            // 
            // tab_Function
            // 
            this.tab_Function.Controls.Add(this.tab_Normal);
            this.tab_Function.Controls.Add(this.tab_Large);
            this.tab_Function.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_Function.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tab_Function.Location = new System.Drawing.Point(0, 0);
            this.tab_Function.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_Function.Name = "tab_Function";
            this.tab_Function.SelectedIndex = 0;
            this.tab_Function.Size = new System.Drawing.Size(1034, 251);
            this.tab_Function.TabIndex = 1;
            // 
            // tab_Normal
            // 
            this.tab_Normal.BackColor = System.Drawing.Color.Transparent;
            this.tab_Normal.Controls.Add(this.tableLayoutPanel1);
            this.tab_Normal.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tab_Normal.Location = new System.Drawing.Point(4, 25);
            this.tab_Normal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_Normal.Name = "tab_Normal";
            this.tab_Normal.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_Normal.Size = new System.Drawing.Size(1026, 222);
            this.tab_Normal.TabIndex = 0;
            this.tab_Normal.Text = "一般";
            // 
            // tab_Large
            // 
            this.tab_Large.Controls.Add(this.tableLayoutPanel3);
            this.tab_Large.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tab_Large.Location = new System.Drawing.Point(4, 25);
            this.tab_Large.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_Large.Name = "tab_Large";
            this.tab_Large.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_Large.Size = new System.Drawing.Size(1026, 222);
            this.tab_Large.TabIndex = 1;
            this.tab_Large.Text = "批量下載";
            this.tab_Large.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_LgURL, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btn_LgPopUp, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.ck_SamePath, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btn_LgFolder, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.btn_LgDownLoad, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.btn_LgClear, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbl_LgMsg, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.cb_LgFileType, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1020, 214);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "選擇批量下載的檔案 (.xlsx)";
            // 
            // txt_LgURL
            // 
            this.txt_LgURL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_LgURL.Enabled = false;
            this.txt_LgURL.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_LgURL.Location = new System.Drawing.Point(3, 16);
            this.txt_LgURL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_LgURL.Name = "txt_LgURL";
            this.txt_LgURL.Size = new System.Drawing.Size(899, 22);
            this.txt_LgURL.TabIndex = 1;
            this.txt_LgURL.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // btn_LgPopUp
            // 
            this.btn_LgPopUp.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_LgPopUp.Location = new System.Drawing.Point(908, 16);
            this.btn_LgPopUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_LgPopUp.Name = "btn_LgPopUp";
            this.btn_LgPopUp.Size = new System.Drawing.Size(41, 31);
            this.btn_LgPopUp.TabIndex = 2;
            this.btn_LgPopUp.Text = "...";
            this.btn_LgPopUp.UseVisualStyleBackColor = true;
            this.btn_LgPopUp.Click += new System.EventHandler(this.btn_LgPopUp_Click);
            // 
            // ck_SamePath
            // 
            this.ck_SamePath.AutoSize = true;
            this.ck_SamePath.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ck_SamePath.Location = new System.Drawing.Point(3, 55);
            this.ck_SamePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ck_SamePath.Name = "ck_SamePath";
            this.ck_SamePath.Size = new System.Drawing.Size(156, 16);
            this.ck_SamePath.TabIndex = 3;
            this.ck_SamePath.Text = "使用相同存檔資料夾路徑";
            this.ck_SamePath.UseVisualStyleBackColor = true;
            // 
            // btn_LgFolder
            // 
            this.btn_LgFolder.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_LgFolder.Location = new System.Drawing.Point(908, 83);
            this.btn_LgFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_LgFolder.Name = "btn_LgFolder";
            this.btn_LgFolder.Size = new System.Drawing.Size(41, 31);
            this.btn_LgFolder.TabIndex = 5;
            this.btn_LgFolder.Text = "...";
            this.btn_LgFolder.UseVisualStyleBackColor = true;
            this.btn_LgFolder.Click += new System.EventHandler(this.btn_LgFolder_Click);
            // 
            // btn_LgDownLoad
            // 
            this.btn_LgDownLoad.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_LgDownLoad.Location = new System.Drawing.Point(908, 125);
            this.btn_LgDownLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_LgDownLoad.Name = "btn_LgDownLoad";
            this.btn_LgDownLoad.Size = new System.Drawing.Size(87, 31);
            this.btn_LgDownLoad.TabIndex = 6;
            this.btn_LgDownLoad.Text = "DownLoad";
            this.btn_LgDownLoad.UseVisualStyleBackColor = true;
            this.btn_LgDownLoad.Click += new System.EventHandler(this.btn_LgDownLoad_Click);
            // 
            // btn_LgClear
            // 
            this.btn_LgClear.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_LgClear.Location = new System.Drawing.Point(908, 164);
            this.btn_LgClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_LgClear.Name = "btn_LgClear";
            this.btn_LgClear.Size = new System.Drawing.Size(87, 28);
            this.btn_LgClear.TabIndex = 7;
            this.btn_LgClear.Text = "Clear";
            this.btn_LgClear.UseVisualStyleBackColor = true;
            this.btn_LgClear.Click += new System.EventHandler(this.btn_LgClear_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.txt_LgSavePath, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 82);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(899, 36);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // txt_LgSavePath
            // 
            this.txt_LgSavePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_LgSavePath.Enabled = false;
            this.txt_LgSavePath.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_LgSavePath.Location = new System.Drawing.Point(3, 4);
            this.txt_LgSavePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_LgSavePath.Name = "txt_LgSavePath";
            this.txt_LgSavePath.Size = new System.Drawing.Size(784, 22);
            this.txt_LgSavePath.TabIndex = 4;
            this.txt_LgSavePath.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(793, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "\\Path\\商品資料夾";
            // 
            // lbl_LgMsg
            // 
            this.lbl_LgMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_LgMsg.ForeColor = System.Drawing.Color.Red;
            this.lbl_LgMsg.Location = new System.Drawing.Point(3, 163);
            this.lbl_LgMsg.Multiline = true;
            this.lbl_LgMsg.Name = "lbl_LgMsg";
            this.lbl_LgMsg.Size = new System.Drawing.Size(899, 48);
            this.lbl_LgMsg.TabIndex = 10;
            this.lbl_LgMsg.Text = "123";
            // 
            // cb_LgFileType
            // 
            this.cb_LgFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_LgFileType.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_LgFileType.FormattingEnabled = true;
            this.cb_LgFileType.Location = new System.Drawing.Point(908, 55);
            this.cb_LgFileType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_LgFileType.Name = "cb_LgFileType";
            this.cb_LgFileType.Size = new System.Drawing.Size(109, 20);
            this.cb_LgFileType.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 251);
            this.Controls.Add(this.tab_Function);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Save Image ";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tab_Function.ResumeLayout(false);
            this.tab_Normal.ResumeLayout(false);
            this.tab_Large.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
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
        private System.Windows.Forms.Label lbl_Msg;
        private System.Windows.Forms.ComboBox cb_FileType;
        private System.Windows.Forms.TabControl tab_Function;
        private System.Windows.Forms.TabPage tab_Normal;
        private System.Windows.Forms.TabPage tab_Large;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_LgURL;
        private System.Windows.Forms.Button btn_LgPopUp;
        private System.Windows.Forms.CheckBox ck_SamePath;
        private System.Windows.Forms.TextBox txt_LgSavePath;
        private System.Windows.Forms.Button btn_LgFolder;
        private System.Windows.Forms.Button btn_LgDownLoad;
        private System.Windows.Forms.Button btn_LgClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lbl_LgMsg;
        private System.Windows.Forms.ComboBox cb_LgFileType;
    }
}

