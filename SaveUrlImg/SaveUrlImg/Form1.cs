using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveUrlImg
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            lbl_Msg.Text = string.Empty;
            lbl_Msg.ForeColor = Color.Red;
            lbl_LgMsg.Text = string.Empty;
            lbl_LgMsg.ForeColor = Color.Red;
            lbl_LgMsg.ReadOnly = true;
            cb_FileType.Items.Add(".png");
            cb_FileType.Items.Add(".jpeg");
            if (cb_FileType.Items.Count > 0)
            {
                cb_FileType.SelectedIndex = 0;
            }

            cb_LgFileType.Items.Add(".png");
            cb_LgFileType.Items.Add(".jpeg");
            if (cb_LgFileType.Items.Count > 0)
            {
                cb_LgFileType.SelectedIndex = 0;
            }

            ck_SamePath.Checked = true;
             
        }
        #region 一般功能
        /// <summary>
        /// 範例資料
        /// URL : https://playfunca.com/wp-content/uploads/2021/05/362506d3088746f5bfe9fcd893ce2f27404-e1622975224923.jpg
        /// Rename : TestImg
        /// SavePath : D:\Coding\測試暫存
        /// </summary>
        #region 選擇儲存路徑
        private void btn_PopUp_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            txt_SavePath.Text = path.SelectedPath;
        }
        #endregion

        #region 執行下載圖片
        private void btn_DownLoad_Click(object sender, EventArgs e)
        {
            lbl_Msg.Text = string.Empty;

            //檢查要下載的路徑
            if (string.IsNullOrEmpty(txt_URL.Text))
            {
                lbl_Msg.Text = "URL不可為空";
                txt_URL.Focus();
                return;
            }
            //檢查要下載的路徑
            if (string.IsNullOrEmpty(txt_URL.Text))
            {
                lbl_Msg.Text = "Rename不可為空";
                txt_Rename.Focus();
                return;
            }
            //檢查下載的位置
            if (string.IsNullOrEmpty(txt_SavePath.Text))
            {
                lbl_Msg.Text = "SavePath不可為空";
                txt_SavePath.Focus();
                return;
            }
            else
            {
                //if (!File.Exists(txt_SavePath.Text))
                //{
                //    lbl_Msg.Text = "SavePath資料夾路徑不存在";
                //    txt_SavePath.Focus();
                //    File.GetAttributes(txt_SavePath.Text);
                //    return;
                //}

                try
                {
                    if (!File.GetAttributes(txt_SavePath.Text).Equals("Directory"))
                    {
                        lbl_Msg.Text = "SavePath非資料夾路徑";
                        txt_SavePath.Focus();
                        File.GetAttributes(txt_SavePath.Text);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    lbl_Msg.Text = ex.ToString();
                }

                //if (File.GetAttributes(txt_SavePath.Text) != )
                //{
                //    lbl_Msg.Text = "SavePath資料夾路徑不存在";
                //    txt_SavePath.Focus();
                //    return;
                //}


            }

            //讀取網址圖檔
            WebClient WebPath = new WebClient();
            string url = txt_URL.Text;    //圖片的url
            string NewFileName = txt_Rename.Text + cb_FileType.Text; //圖片存檔於您的電腦時的新名稱   ※需適時加副檔名          
            string FilePath = txt_SavePath.Text + @"\" + NewFileName;

            if (File.Exists(FilePath))  //判別檔案是否存在於對應的路徑
            {
                lbl_Msg.Text = "檔名重複";
                txt_Rename.Focus();
                return;
            }

            try
            {
                WebPath.DownloadFile(url, FilePath);
                lbl_Msg.Text = "下載完成";
                lbl_Msg.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                lbl_Msg.Text = "URL下載路徑有誤" + ex.ToString();
            }

        }
        #endregion
        #region 依照選擇清空的項目，清空TextBox
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Boolean isck_URL, isck_Rename, isck_SavePath;
            isck_URL = ck_URL.Checked;
            isck_Rename = ck_Rename.Checked;
            isck_SavePath = ck_SavePath.Checked;

            if (isck_URL)
            {
                txt_URL.Text = string.Empty;
            }
            if (isck_Rename)
            {
                txt_Rename.Text = string.Empty;
            }
            if (isck_SavePath)
            {
                txt_SavePath.Text = string.Empty;
            }
        }
        #endregion

        private void txt_TextChanged(object sender, EventArgs e)
        {
            lbl_Msg.Text = string.Empty;
            lbl_Msg.ForeColor = Color.Red;
            lbl_LgMsg.Text = string.Empty;
            lbl_LgMsg.ForeColor = Color.Red;
        }
        #endregion

        #region 批量

        #region 選擇存檔資料夾
        private void btn_LgFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            txt_LgSavePath.Text = path.SelectedPath;
        }
        #endregion

        #region 選擇Excel檔
        private void btn_LgPopUp_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//該值確定是否可以選擇多個檔案
            dialog.Title = "請選擇資料夾";
            dialog.Filter = "Excel Files|*.xlsx;*.ods;*.xlsm";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file = dialog.FileName;
                txt_LgURL.Text = file;
            }
        }
        #endregion

        #region 清除資料
        private void btn_LgClear_Click(object sender, EventArgs e)
        {
            txt_LgURL.Text = string.Empty;
            txt_LgSavePath.Text = string.Empty;
            lbl_LgMsg.Text = string.Empty;
            lbl_LgMsg.ForeColor = Color.Red;
        }
        #endregion

        #region 執行批量下載
        private void btn_LgDownLoad_Click(object sender, EventArgs e)
        {
            string file = "";
            //檢查要下載的路徑
            if (string.IsNullOrEmpty(txt_LgURL.Text))
            {
                lbl_LgMsg.Text = "請選擇匯入檔";
                btn_LgPopUp.Focus();
                return;
            }
            else
            {
                file = txt_LgURL.Text;
            }
            //檢查要下載的路徑
            if (ck_SamePath.Checked == true && string.IsNullOrEmpty(txt_LgSavePath.Text))
            {
                lbl_LgMsg.Text = "存檔路徑不可為空";
                btn_LgFolder.Focus();
                return;
            }

            #region NPOI
            if (!string.IsNullOrEmpty(file))
            {
                FileInfo f = new FileInfo(file);
                string basePath = f.FullName;
                //using (FileStream templateFile = new FileStream(basePath, FileMode.Open, FileAccess.Read))
                //{
                //    IWorkbook workbook;
                //    workbook = new XSSFWorkbook(templateFile);
                //    ISheet sheet = workbook.GetSheetAt(0);
                //}
                IWorkbook workbook = null;
                string extension = System.IO.Path.GetExtension(basePath);
                try
                {
                    FileStream fs = File.OpenRead(basePath);
                    if (extension.Equals(".xls"))
                    {
                        workbook = new HSSFWorkbook(fs);
                    }
                    else
                    {
                        workbook = new XSSFWorkbook(fs);
                    }
                    fs.Close();

                    //讀取當前表數據
                    ISheet sheet = workbook.GetSheetAt(0);
                    IRow row_default = null; //儲存第一列為檔案命名
                    IRow row = null;

                    string text = string.Empty;
                    for (int i = 0; i <= sheet.LastRowNum; i++)
                    {
                        row = sheet.GetRow(i);  //讀取當前行數據

                        if (row != null)
                        {
                            #region 確認檔案格式是否符合 & 暫存第一列
                            if (i == 0)
                            {
                                //第一列儲存為預設檔案名稱
                                row_default = row;
                                try
                                {
                                    if (row_default.GetCell(0).ToString() != "Path")
                                    {
                                        lbl_LgMsg.Text = "Excel 檔案格式錯誤， A1應為Path";
                                        return;
                                    }

                                    if (row_default.GetCell(1).ToString() != "資料夾名稱")
                                    {
                                        lbl_LgMsg.Text = "Excel 檔案格式錯誤， B1應為資料夾名稱";
                                        return;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    lbl_LgMsg.Text = "Excel 檔案格式錯誤， A1應為Path， B1應為資料夾名稱";
                                    return;
                                }
                            }
                            #endregion

                            else
                            {
                                //存檔位置 : samepath +  folder_path + folder_name
                                string folder_path = ""; 
                                string folder_name = "";
                              
                                //LastCellNum 是當前行的總列數
                                for (int j = 0; j < row.LastCellNum; j++)
                                {

                                    //第一個欄位[PATH]及第二個欄位[商品名稱]-->非URL
                                    #region 資料夾部分
                                    if (j == 0) //[folder]PATH
                                    {
                                        try
                                        {
                                            folder_path = row.GetCell(0).ToString();
                                        }
                                        catch (Exception ex)
                                        {
                                            folder_path = "";
                                        }


                                    }
                                    else if (j == 1) //[folder]商品名稱
                                    {
                                        try
                                        {
                                            folder_name = row.GetCell(1).ToString();
                                        }
                                        catch (Exception ex)
                                        {
                                            folder_name = "";
                                        }
                                    }
                                    #endregion

                                    #region 檔名部分
                                    else
                                    {
                                        string url = "";    //圖片的url
                                        string filetype = cb_LgFileType.Text;    //圖片的副檔名(.png / .jpeg)
                                        string newfilename = ""; //[file]//圖片存檔於您的電腦時的新名稱   ※需適時加副檔名          
                                        string FilePath = txt_LgSavePath.Text + @"\" + folder_path + @"\" + folder_name + @"\" ;

                                        //存檔位置 : samepath + folder_path + folder_name
                                        
                                        //若非空值
                                        if (row.GetCell(j) != null)
                                        {
                                            //取得欄位值
                                            string value = row.GetCell(j).ToString();
                                            if (string.IsNullOrEmpty(value))
                                            {
                                                continue;
                                            }

                                            //取得檔案名稱
                                            if (row_default.GetCell(j) != null)
                                            {
                                                newfilename = row_default.GetCell(j).ToString() + filetype;
                                            }
                                            else
                                            {
                                               
                                            }


                                            //判斷該欄位是否為URL
                                            string reg = @"^http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?$";
                                            Regex r = new Regex(reg);
                                            //给网址去所有空格
                                            string img_urlStr = value.Trim();
                                            //Match m = r.Match(img_urlStr);

                                            //判断是否带http://
                                            if (!Regex.IsMatch(img_urlStr, reg))
                                            {
                                                continue;
                                            }

                                            if (!System.IO.Directory.Exists(FilePath))
                                            {
                                                System.IO.Directory.CreateDirectory(FilePath);//不存在就建立目錄 
                                            }

                                            url = img_urlStr;
                                            FilePath = FilePath + newfilename;
                                            #region 下載圖檔
                                            WebClient WebPath = new WebClient();
                                            //if (File.Exists(FilePath))  //判別檔案是否存在於對應的路徑
                                            //{
                                            //    lbl_Msg.Text = "檔名重複";
                                            //    txt_Rename.Focus();
                                            //    return;
                                            //}

                                            try
                                            {
                                                WebPath.DownloadFile(url, FilePath);
                                            }
                                            catch (Exception ex)
                                            {
                                                lbl_LgMsg.Text = "URL下載路徑有誤" + ex.ToString();
                                            }
                                            #endregion
                                            
                                        }

                                    }
                                    #endregion
                                }
                            } 
                        } 
                    }
                    lbl_LgMsg.Text = "下載完成";
                    lbl_LgMsg.ForeColor = Color.Green;
                }
                catch (Exception ex)
                {
                    lbl_LgMsg.Text = ex.ToString();
                }
            }

            #endregion

        }
        #endregion

        #endregion
    }
}
