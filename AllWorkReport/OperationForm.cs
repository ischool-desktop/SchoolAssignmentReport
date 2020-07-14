using FISCA;
using FISCA.Presentation.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllWorkReport
{
    public partial class OperationForm : BaseForm
    {
        private string URL轉學證明書 = "ischool/國中系統/學生/報表/學籍/轉學證明書";
        private string URL轉學成績證明書 = "ischool/國中系統/學生/報表/成績/轉學證明書";

        private string URL期中轉學證明書 = "ischool/國中系統/學生/報表/成績/期中轉學證明書";

        private string URL學籍表 = "ischool/國中系統/學生/報表/成績/學籍表";

        private string URL學生幹部證明單 = "ischool/幹部系統/共用/學務/學生/報表/幹部證明單";//"ischool/幹部模組/學生/報表/學務/學生幹部證明單";

        private string URL學生訓導記錄表 = "ischool/國中系統/學生/報表/學務/學生訓導紀錄表";
        private string URL體適能證明單 = "ischool/國中系統/學生/報表/體適能/體適能證明單";

        private string URL社團參與證明單1 = "ischool/高雄專案/學生/報表/社團/社團參與證明單_高雄";
        private string URL社團參與證明單2 = "ischool/產品/學生/報表/社團/社團參與證明單";

        private string URL轉出回條 = "ischool/國中系統/學生/報表/學籍/轉出回條";

        public OperationForm()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                Features.Invoke(URL轉學證明書);
                checkBoxX1.Checked = true;
            }
            catch (Exception ex)
            {
                MsgBox.Show("啟動功能發生錯誤:\n" + ex.Message);
            }

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {
                Features.Invoke(URL期中轉學證明書);
                checkBoxX2.Checked = true;
            }
            catch (Exception ex)
            {
                MsgBox.Show("啟動功能發生錯誤:\n" + ex.Message);
            }
        }

        //學籍表
        private void buttonX3_Click(object sender, EventArgs e)
        {
            try
            {
                Features.Invoke(URL學籍表);
                checkBoxX3.Checked = true;
            }
            catch (Exception ex)
            {
                MsgBox.Show("啟動功能發生錯誤:\n" + ex.Message);
            }
        }

        //列印學生幹部證明單
        private void buttonX4_Click(object sender, EventArgs e)
        {
            try
            {
                Features.Invoke(URL學生幹部證明單);
                checkBoxX4.Checked = true;
            }
            catch (Exception ex)
            {
                MsgBox.Show("啟動功能發生錯誤:\n" + ex.Message);
            }
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            try
            {
                Features.Invoke(URL學生訓導記錄表);
                checkBoxX5.Checked = true;
            }
            catch (Exception ex)
            {
                MsgBox.Show("啟動功能發生錯誤:\n"+ex.Message);
            }
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            try
            {
                Features.Invoke(URL體適能證明單);
                checkBoxX6.Checked = true;
            }
            catch (Exception ex)
            {
                MsgBox.Show("啟動功能發生錯誤:\n" + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            try
            {
                //高雄
                Features.Invoke(URL社團參與證明單1);
                checkBoxX7.Checked = true;
            }
            catch
            {
                try
                {
                    //產品
                    Features.Invoke(URL社團參與證明單2);
                    checkBoxX7.Checked = true;
                }
                catch (Exception ex)
                {
                    MsgBox.Show("啟動功能發生錯誤:\n" + ex.Message);
                }
            }
        }

        private void buttonX8_Click(object sender, EventArgs e)
        {
            try
            {
                Features.Invoke(URL轉出回條);
                checkBoxX8.Checked = true;
            }
            catch (Exception ex)
            {
                MsgBox.Show("啟動功能發生錯誤:\n" + ex.Message);
            }
        }

        private void buttonX9_Click(object sender, EventArgs e)
        {
            try
            {
                Features.Invoke(URL轉學成績證明書);
                checkBoxX9.Checked = true;
            }
            catch (Exception ex)
            {
                MsgBox.Show("啟動功能發生錯誤:\n" + ex.Message);
            }
        }
    }
}
