using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Framework.Interface.Workbench
{
    public partial class Frmpeiban : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data);
        public CreateModuleHandle CreateModuleIntance;
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private object @class;
        private System.Collections.ArrayList templateList;
        
        public Frmpeiban(Framework.Entity.Chapter chapter, object type)
        {
            InitializeComponent();
            @class = type;
            templateList = contentService.GetContentTemplateByTitle(chapter.Title);
            
        }
        public Frmpeiban()
        {

            InitializeComponent();
        }
        private void checkBoxX3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked==true)
            { 
                checkBoxX4.Enabled = false;
            }
            
        }

        private void checkBoxX4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBoxX3.Enabled = false;
            }
        }

        private void checkBoxX5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {

                checkBoxX6.Enabled = false;
            }
        }

        private void checkBoxX6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {

                checkBoxX5.Enabled = false;
            }
        }

        private void checkBoxX8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {

                checkBoxX7.Enabled = false;
            }
        }

        private void checkBoxX7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                checkBoxX8.Enabled = false;
            }
        }

        private void checkBoxX10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                checkBoxX9.Enabled = false;
            }
        }

        private void checkBoxX9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                checkBoxX10.Enabled = false;
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            //PMCC:平模尺寸长 PMCK:平模尺寸宽 MBCC：木板铺设尺寸长LL MBCK：木板铺设尺寸宽BB  YMCC：阳角膜尺寸 NMCC;阴角膜尺寸 n1,n2,n3,n4:角膜个数  MBCCC:模板尺寸l6  MNCCK;模板尺寸b5
            int PMCC = 0, MBCC = 0, YMCC = 0, PMCK = 0, MBCK = 0, NMCC = 0, n1 = 0, n2 = 0, n3 = 0, n4 = 0, n5 = 0, a5 = 0, n6 = 0, a6 = 0, MBCCC = 0, MBCCK = 0;
            //计算过程参数
            int N1 = 0, M1 = 0, A1 = 0;
            int N2 = 0, M2 = 0, A2 = 0;
            int N3 = 0, M3 = 0, A3 = 0;
            int N4 = 0, M4 = 0, A4 = 0;
            //情况一计算参数有
            #region 
            int n6L1 = 0, a6L1 = 0, nL16L1 = 0, aL16L1 = 0, mL16L1 = 0;
            int nBb = 0, aBb = 0, mBb = 0, n6B1 = 0, a6B1 = 0;
            int nLb = 0, aLb = 0, mLb = 0;
            int nB16B1 = 0, aB16B1 = 0, mB16B1 = 0, na6b = 0, aa6b = 0, ma6b = 0;
            int na6B1 = 0, aa6B1 = 0, ma6B1 = 0;
            int na6L1 = 0, aa6L1 = 0, ma6L1 = 0;
            #endregion
            //情况二计算参数
            #region 
            int n5L1 = 0, a5L1 = 0, n7 = 0, a7 = 0, nL15L1 = 0, aL15L1 = 0, mL15L1 = 0;
            int n5B1 = 0, a5B1 = 0, nB15B1 = 0, aB15B1 = 0, mB15B1 = 0;
            int na5b = 0, aa5b = 0, ma5b = 0;
            int na5L1 = 0, aa5L1 = 0, ma5L1 = 0;
            int na5B1 = 0, aa5B1 = 0, ma5B1 = 0;
            #endregion
            
            FemSelect fm = new FemSelect();

            MBCC = integerInput1.Value;
            MBCK =int.Parse(this.textBox2.Text);
            if(comboBoxEx2.SelectedIndex==0||comboBoxEx4.SelectedIndex==0||comboBoxEx7.SelectedIndex==0||comboBoxEx5.SelectedIndex==0)
            {
                YMCC = 50;
            }
            else if (comboBoxEx2.SelectedIndex ==1||comboBoxEx4.SelectedIndex == 1||comboBoxEx7.SelectedIndex == 1||comboBoxEx5.SelectedIndex == 1)
            {
                YMCC = 100;
            }
            if(comboBoxEx1.SelectedIndex==0||comboBoxEx3.SelectedIndex==0||comboBoxEx6.SelectedIndex==0||comboBoxEx8.SelectedIndex==0)
            {
                NMCC = 150;
            }
            else if (comboBoxEx1.SelectedIndex == 1 || comboBoxEx3.SelectedIndex == 1 || comboBoxEx6.SelectedIndex == 1 || comboBoxEx8.SelectedIndex == 1)
            {
                NMCC = 100;
            }
            #region 判断N
            if (checkBoxX5.Checked || checkBoxX10.Checked)
            {
                n1 = 1;
            }
            else if (checkBoxX5.Checked && checkBoxX10.Checked)
            {
                n1 = 2;
            }
            else
                n1 = 0;
            if (checkBoxX6.Checked || checkBoxX9.Checked)
            {
                n2 = 1;
            }
            else if (checkBoxX6.Checked && checkBoxX9.Checked)
            {
                n2 = 2;
            }
            else
                n2 = 0;
            if (checkBoxX3.Checked || checkBoxX8.Checked)
            {
                n3 = 1;
            }
            else if (checkBoxX3.Checked && checkBoxX8.Checked)
            {
                n3 = 2;
            }
            else
                n3 = 0;
            if (checkBoxX4.Checked || checkBoxX7.Checked)
            {
                n4 = 1;
            }
            else if (checkBoxX4.Checked && checkBoxX7.Checked)
            {
                n4 = 2;
            }
            else
                n4 = 0;
            #endregion
            #region 平模铺设尺寸长L 平模铺设尺寸宽B
            PMCC = MBCC - n1 * NMCC - n2 * YMCC;
            PMCK = MBCK - n3 * NMCC - n4 * YMCC;
            #endregion
            #region 情况一
            if (checkBox11.Checked && checkBox6.Checked)
            {
                //全部横向排列
                if (this.comboBoxEx9.SelectedIndex == 0)
                {
                    #region  全部横向排列
                    MBCCC = 1500;
                    mL16L1 = 1;
                    n6L1 = (int)(PMCC / MBCCC);
                    a6L1 = PMCC - n6L1 * MBCCC;
                    nL16L1 = n6L1; aL16L1 = a6L1;
                    #region 长度方向
                    if (1350 <= a6L1 && a6L1 < 1500)
                    {
                        n6 = n6L1 + 2; a6 = a6L1 - 900 - 450;
                        #region 此过程进行横竖混合计算
                        if (100 <= a6 && a6 < 150)
                        {

                            n6 = 2; a6 = a6 - 100;
                            na6b = n6;
                            aa6b = a6;
                            ma6b = 1;
                            #region 横竖混合排列 宽度方向
                            nBb = (int)(PMCK / 300);
                            aBb = PMCK - nBb * 300;
                            mBb = 1;
                            n6B1 = (int)(PMCK / 1500);
                            a6B1 = PMCK - n6B1 * 1500;
                            if (1350 <= a6B1 && a6B1 < 1500)
                            {
                                n6 = n6B1 + 2; a6 = a6B1 - 900 - 450;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                            }

                            else if (1200 <= a6B1 && a6B1 < 1350)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 1200;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (1050 <= a6B1 && a6B1 < 1200)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 1050;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                            }
                            else if (900 <= a6B1 && a6B1 < 1050)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 900;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (750 <= a6B1 && a6B1 < 900)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 750;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (600 <= a6B1 && a6B1 < 750)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 600;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (450 <= a6B1 && a6B1 < 600)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 450;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (a6B1 < 450)
                            {
                                na6B1 = n6B1; aa6B1 = a6B1; ma6B1 = 1;

                            }
                            #endregion
                            #region  计算过程
                            N3 = nL16L1 * nBb + na6b * na6B1; M3 = mL16L1 * mBb + ma6b * ma6B1; A3 = aBb * PMCC + aa6b * (PMCC - aBb);
                            fm.A1 = N3;
                            fm.A2 = M3;
                            fm.A3 = A3;
                            #endregion
                        }
                        #endregion
                        else if (a6 < 100)
                        {
                            nL16L1 = n6; aL16L1 = a6; mL16L1 = 3;
                            #region 宽度方向
                            MBCCK = 300;
                            n5 = (int)(PMCK / MBCCK);
                            a5 = PMCK - n5 * MBCCK;
                            if (a5 < 100)
                            {
                                nBb = n5; aBb = a5; mBb = 1;
                            }
                            else if (a5 >= 100 && a5 < 150)
                            {
                                nBb = n5 + 1; aBb = a5 - 100; mBb = 2;
                            }
                            else if (a5 >= 150 && a5 < 200)
                            {
                                nBb = n5 + 1; aBb = a5 - 150; mBb = 2;
                            }
                            else if (a5 >= 200 && a5 < 250)
                            {
                                nBb = n5 + 1; aBb = a5 - 200; mBb = 2;
                            }
                            else if (a5 >= 250 && a5 < 300)
                            {
                                nBb = n5 + 1; aBb = a5 - 250; mBb = 2;
                            }

                            #endregion
                            #region 计算过程
                            N1 = nL16L1 * nBb; M1 = mL16L1 * mBb; A1 = aL16L1 * PMCK + aBb * (PMCC - aL16L1);
                            fm.A1 = N1;
                            fm.A2 = M1;
                            fm.A3 = A1;
                            #endregion

                        }
                    }

                    else if (1200 <= a6L1 && a6L1 < 1350)
                    {
                        n6 = n6L1 + 1; a6 = a6L1 - 1200;
                        #region 此过程进行横竖混合计算
                        if (100 <= a6 && a6 < 150)
                        {
                            n6 = 2; a6 = a6 - 100;
                            na6b = n6;
                            aa6b = a6;
                            ma6b = 1;
                            #region 横竖混合排列 宽度方向
                            nBb = (int)(PMCK / 300);
                            aBb = PMCK - nBb * 300;
                            mBb = 1;
                            n6B1 = (int)(PMCK / 1500);
                            a6B1 = PMCK - n6B1 * 1500;
                            if (1350 <= a6B1 && a6B1 < 1500)
                            {
                                n6 = n6B1 + 2; a6 = a6B1 - 900 - 450;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                            }

                            else if (1200 <= a6B1 && a6B1 < 1350)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 1200;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (1050 <= a6B1 && a6B1 < 1200)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 1050;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                            }
                            else if (900 <= a6B1 && a6B1 < 1050)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 900;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (750 <= a6B1 && a6B1 < 900)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 750;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (600 <= a6B1 && a6B1 < 750)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 600;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (450 <= a6B1 && a6B1 < 600)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 450;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (a6B1 < 450)
                            {
                                na6B1 = n6B1; aa6B1 = a6B1; ma6B1 = 1;

                            }
                            #endregion
                            #region  计算过程
                            N3 = nL16L1 * nBb + na6b * na6B1; M3 = mL16L1 * mBb + ma6b * ma6B1; A3 = aBb * PMCC + aa6b * (PMCC - aBb);
                            fm.A1 = N3;
                            fm.A2 = M3;
                            fm.A3 = A3;
                            #endregion
                        }
                        #endregion
                        else if (a6 < 100)
                        {
                            nL16L1 = n6; aL16L1 = a6; mL16L1 = 2;
                            #region 宽度方向
                            MBCCK = 300;
                            n5 = (int)(PMCK / MBCCK);
                            a5 = PMCK - n5 * MBCCK;
                            if (a5 < 100)
                            {
                                nBb = n5; aBb = a5; mBb = 1;
                            }
                            else if (a5 >= 100 && a5 < 150)
                            {
                                nBb = n5 + 1; aBb = a5 - 100; mBb = 2;
                            }
                            else if (a5 >= 150 && a5 < 200)
                            {
                                nBb = n5 + 1; aBb = a5 - 150; mBb = 2;
                            }
                            else if (a5 >= 200 && a5 < 250)
                            {
                                nBb = n5 + 1; aBb = a5 - 200; mBb = 2;
                            }
                            else if (a5 >= 250 && a5 < 300)
                            {
                                nBb = n5 + 1; aBb = a5 - 250; mBb = 2;
                            }

                            #endregion
                            #region 计算过程
                            N1 = nL16L1 * nBb; M1 = mL16L1 * mBb; A1 = aL16L1 * PMCK + aBb * (PMCC - aL16L1);
                            fm.A1 = N1;
                            fm.A2 = M1;
                            fm.A3 = A1;
                            #endregion
                        }
                    }
                    else if (1050 <= a6L1 && a6L1 < 1200)
                    {
                        n6 = n6L1 + 1; a6 = a6L1 - 600 - 450;
                        #region 此过程进行横竖混合计算
                        if (100 <= a6 && a6 < 150)
                        {

                            n6 = 2; a6 = a6 - 100;
                            na6b = n6;
                            aa6b = a6;
                            ma6b = 1;
                            #region 横竖混合排列 宽度方向
                            nBb = (int)(PMCK / 300);
                            aBb = PMCK - nBb * 300;
                            mBb = 1;
                            n6B1 = (int)(PMCK / 1500);
                            a6B1 = PMCK - n6B1 * 1500;
                            if (1350 <= a6B1 && a6B1 < 1500)
                            {
                                n6 = n6B1 + 2; a6 = a6B1 - 900 - 450;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                            }

                            else if (1200 <= a6B1 && a6B1 < 1350)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 1200;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (1050 <= a6B1 && a6B1 < 1200)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 1050;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                            }
                            else if (900 <= a6B1 && a6B1 < 1050)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 900;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (750 <= a6B1 && a6B1 < 900)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 750;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (600 <= a6B1 && a6B1 < 750)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 600;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (450 <= a6B1 && a6B1 < 600)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 450;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (a6B1 < 450)
                            {
                                na6B1 = n6B1; aa6B1 = a6B1; ma6B1 = 1;

                            }
                            #endregion
                            #region  计算过程
                            N3 = nL16L1 * nBb + na6b * na6B1; M3 = mL16L1 * mBb + ma6b * ma6B1; A3 = aBb * PMCC + aa6b * (PMCC - aBb);
                            fm.A1 = N3;
                            fm.A2 = M3;
                            fm.A3 = A3;
                            #endregion
                        }
                        #endregion
                        else if (a6 < 100)
                        {
                            nL16L1 = n6; aL16L1 = a6; mL16L1 = 3;
                            #region 宽度方向
                            MBCCK = 300;
                            n5 = (int)(PMCK / MBCCK);
                            a5 = PMCK - n5 * MBCCK;
                            if (a5 < 100)
                            {
                                nBb = n5; aBb = a5; mBb = 1;
                            }
                            else if (a5 >= 100 && a5 < 150)
                            {
                                nBb = n5 + 1; aBb = a5 - 100; mBb = 2;
                            }
                            else if (a5 >= 150 && a5 < 200)
                            {
                                nBb = n5 + 1; aBb = a5 - 150; mBb = 2;
                            }
                            else if (a5 >= 200 && a5 < 250)
                            {
                                nBb = n5 + 1; aBb = a5 - 200; mBb = 2;
                            }
                            else if (a5 >= 250 && a5 < 300)
                            {
                                nBb = n5 + 1; aBb = a5 - 250; mBb = 2;
                            }

                            #endregion
                            #region 计算过程
                            N1 = nL16L1 * nBb; M1 = mL16L1 * mBb; A1 = aL16L1 * PMCK + aBb * (PMCC - aL16L1);
                            fm.A1 = N1;
                            fm.A2 = M1;
                            fm.A3 = A1;
                            #endregion
                        }
                    }
                    else if (900 <= a6L1 && a6L1 < 1050)
                    {
                        n6 = n6L1 + 1; a6 = a6L1 - 900;
                        #region 此过程进行横竖混合计算
                        if (100 <= a6 && a6 < 150)
                        {

                            n6 = 2; a6 = a6 - 100;
                            na6b = n6;
                            aa6b = a6;
                            ma6b = 1;
                            #region 横竖混合排列 宽度方向
                            nBb = (int)(PMCK / 300);
                            aBb = PMCK - nBb * 300;
                            mBb = 1;
                            n6B1 = (int)(PMCK / 1500);
                            a6B1 = PMCK - n6B1 * 1500;
                            if (1350 <= a6B1 && a6B1 < 1500)
                            {
                                n6 = n6B1 + 2; a6 = a6B1 - 900 - 450;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                            }

                            else if (1200 <= a6B1 && a6B1 < 1350)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 1200;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (1050 <= a6B1 && a6B1 < 1200)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 1050;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                            }
                            else if (900 <= a6B1 && a6B1 < 1050)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 900;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (750 <= a6B1 && a6B1 < 900)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 750;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (600 <= a6B1 && a6B1 < 750)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 600;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (450 <= a6B1 && a6B1 < 600)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 450;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (a6B1 < 450)
                            {
                                na6B1 = n6B1; aa6B1 = a6B1; ma6B1 = 1;

                            }
                            #endregion
                            #region  计算过程
                            N3 = nL16L1 * nBb + na6b * na6B1; M3 = mL16L1 * mBb + ma6b * ma6B1; A3 = aBb * PMCC + aa6b * (PMCC - aBb);
                            fm.A1 = N3;
                            fm.A2 = M3;
                            fm.A3 = A3;
                            #endregion
                        }
                        #endregion
                        else if (a6 < 100)
                        {
                            nL16L1 = n6; aL16L1 = a6; mL16L1 = 2;
                            #region 宽度方向
                            MBCCK = 300;
                            n5 = (int)(PMCK / MBCCK);
                            a5 = PMCK - n5 * MBCCK;
                            if (a5 < 100)
                            {
                                nBb = n5; aBb = a5; mBb = 1;
                            }
                            else if (a5 >= 100 && a5 < 150)
                            {
                                nBb = n5 + 1; aBb = a5 - 100; mBb = 2;
                            }
                            else if (a5 >= 150 && a5 < 200)
                            {
                                nBb = n5 + 1; aBb = a5 - 150; mBb = 2;
                            }
                            else if (a5 >= 200 && a5 < 250)
                            {
                                nBb = n5 + 1; aBb = a5 - 200; mBb = 2;
                            }
                            else if (a5 >= 250 && a5 < 300)
                            {
                                nBb = n5 + 1; aBb = a5 - 250; mBb = 2;
                            }

                            #endregion
                            #region 计算过程
                            N1 = nL16L1 * nBb; M1 = mL16L1 * mBb; A1 = aL16L1 * PMCK + aBb * (PMCC - aL16L1);
                            fm.A1 = N1;
                            fm.A2 = M1;
                            fm.A3 = A1;
                            #endregion
                        }
                    }
                    else if (750 <= a6L1 && a6L1 < 900)
                    {
                        n6 = n6L1 + 1; a6 = a6L1 - 750;
                        #region 此过程进行横竖混合计算
                        if (100 <= a6 && a6 < 150)
                        {

                            n6 = 2; a6 = a6 - 100;
                            na6b = n6;
                            aa6b = a6;
                            ma6b = 1;
                            #region 横竖混合排列 宽度方向
                            nBb = (int)(PMCK / 300);
                            aBb = PMCK - nBb * 300;
                            mBb = 1;
                            n6B1 = (int)(PMCK / 1500);
                            a6B1 = PMCK - n6B1 * 1500;
                            if (1350 <= a6B1 && a6B1 < 1500)
                            {
                                n6 = n6B1 + 2; a6 = a6B1 - 900 - 450;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                            }

                            else if (1200 <= a6B1 && a6B1 < 1350)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 1200;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (1050 <= a6B1 && a6B1 < 1200)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 1050;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                            }
                            else if (900 <= a6B1 && a6B1 < 1050)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 900;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (750 <= a6B1 && a6B1 < 900)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 750;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (600 <= a6B1 && a6B1 < 750)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 600;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (450 <= a6B1 && a6B1 < 600)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 450;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (a6B1 < 450)
                            {
                                na6B1 = n6B1; aa6B1 = a6B1; ma6B1 = 1;

                            }
                            #endregion
                            #region  计算过程
                            N3 = nL16L1 * nBb + na6b * na6B1; M3 = mL16L1 * mBb + ma6b * ma6B1; A3 = aBb * PMCC + aa6b * (PMCC - aBb);
                            fm.A1 = N3;
                            fm.A2 = M3;
                            fm.A3 = A3;
                            #endregion
                        }
                        #endregion
                        else if (a6 < 100)
                        {
                            nL16L1 = n6; aL16L1 = a6; mL16L1 = 2;
                            #region 宽度方向
                            MBCCK = 300;
                            n5 = (int)(PMCK / MBCCK);
                            a5 = PMCK - n5 * MBCCK;
                            if (a5 < 100)
                            {
                                nBb = n5; aBb = a5; mBb = 1;
                            }
                            else if (a5 >= 100 && a5 < 150)
                            {
                                nBb = n5 + 1; aBb = a5 - 100; mBb = 2;
                            }
                            else if (a5 >= 150 && a5 < 200)
                            {
                                nBb = n5 + 1; aBb = a5 - 150; mBb = 2;
                            }
                            else if (a5 >= 200 && a5 < 250)
                            {
                                nBb = n5 + 1; aBb = a5 - 200; mBb = 2;
                            }
                            else if (a5 >= 250 && a5 < 300)
                            {
                                nBb = n5 + 1; aBb = a5 - 250; mBb = 2;
                            }

                            #endregion
                            #region 计算过程
                            N1 = nL16L1 * nBb; M1 = mL16L1 * mBb; A1 = aL16L1 * PMCK + aBb * (PMCC - aL16L1);
                            fm.A1 = N1;
                            fm.A2 = M1;
                            fm.A3 = A1;
                            #endregion
                        }
                    }
                    else if (600 <= a6L1 && a6L1 < 750)
                    {
                        n6 = n6L1 + 1; a6 = a6L1 - 600;
                        #region 此过程进行横竖混合计算
                        if (100 <= a6 && a6 < 150)
                        {

                            n6 = 2; a6 = a6 - 100;
                            na6b = n6;
                            aa6b = a6;
                            ma6b = 1;
                            #region 横竖混合排列 宽度方向
                            nBb = (int)(PMCK / 300);
                            aBb = PMCK - nBb * 300;
                            mBb = 1;
                            n6B1 = (int)(PMCK / 1500);
                            a6B1 = PMCK - n6B1 * 1500;
                            if (1350 <= a6B1 && a6B1 < 1500)
                            {
                                n6 = n6B1 + 2; a6 = a6B1 - 900 - 450;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                            }

                            else if (1200 <= a6B1 && a6B1 < 1350)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 1200;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (1050 <= a6B1 && a6B1 < 1200)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 1050;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                            }
                            else if (900 <= a6B1 && a6B1 < 1050)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 900;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (750 <= a6B1 && a6B1 < 900)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 750;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (600 <= a6B1 && a6B1 < 750)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 600;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (450 <= a6B1 && a6B1 < 600)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 450;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (a6B1 < 450)
                            {
                                na6B1 = n6B1; aa6B1 = a6B1; ma6B1 = 1;

                            }
                            #endregion
                            #region  计算过程
                            N3 = nL16L1 * nBb + na6b * na6B1; M3 = mL16L1 * mBb + ma6b * ma6B1; A3 = aBb * PMCC + aa6b * (PMCC - aBb);
                            fm.A1 = N3;
                            fm.A2 = M3;
                            fm.A3 = A3;
                            #endregion
                        }
                        #endregion
                        else if (a6 < 100)
                        {
                            nL16L1 = n6; aL16L1 = a6; mL16L1 = 2;
                            #region 宽度方向
                            MBCCK = 300;
                            n5 = (int)(PMCK / MBCCK);
                            a5 = PMCK - n5 * MBCCK;
                            if (a5 < 100)
                            {
                                nBb = n5; aBb = a5; mBb = 1;
                            }
                            else if (a5 >= 100 && a5 < 150)
                            {
                                nBb = n5 + 1; aBb = a5 - 100; mBb = 2;
                            }
                            else if (a5 >= 150 && a5 < 200)
                            {
                                nBb = n5 + 1; aBb = a5 - 150; mBb = 2;
                            }
                            else if (a5 >= 200 && a5 < 250)
                            {
                                nBb = n5 + 1; aBb = a5 - 200; mBb = 2;
                            }
                            else if (a5 >= 250 && a5 < 300)
                            {
                                nBb = n5 + 1; aBb = a5 - 250; mBb = 2;
                            }

                            #endregion
                            #region 计算过程
                            N1 = nL16L1 * nBb; M1 = mL16L1 * mBb; A1 = aL16L1 * PMCK + aBb * (PMCC - aL16L1);
                            fm.A1 = N1;
                            fm.A2 = M1;
                            fm.A3 = A1;
                            #endregion
                        }
                    }
                    else if (450 <= a6L1 && a6L1 < 600)
                    {
                        n6 = n6L1 + 1; a6 = a6L1 - 450;
                        #region 此过程进行横竖混合计算
                        if (100 <= a6 && a6 < 150)
                        {

                            n6 = 2; a6 = a6 - 100;
                            na6b = n6;
                            aa6b = a6;
                            ma6b = 1;
                            #region 横竖混合排列 宽度方向
                            nBb = (int)(PMCK / 300);
                            aBb = PMCK - nBb * 300;
                            mBb = 1;
                            n6B1 = (int)(PMCK / 1500);
                            a6B1 = PMCK - n6B1 * 1500;
                            if (1350 <= a6B1 && a6B1 < 1500)
                            {
                                n6 = n6B1 + 2; a6 = a6B1 - 900 - 450;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                            }

                            else if (1200 <= a6B1 && a6B1 < 1350)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 1200;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (1050 <= a6B1 && a6B1 < 1200)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 1050;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                            }
                            else if (900 <= a6B1 && a6B1 < 1050)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 900;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (750 <= a6B1 && a6B1 < 900)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 750;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (600 <= a6B1 && a6B1 < 750)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 600;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (450 <= a6B1 && a6B1 < 600)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 450;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (a6B1 < 450)
                            {
                                na6B1 = n6B1; aa6B1 = a6B1; ma6B1 = 1;

                            }
                            #endregion
                            #region  计算过程
                            N3 = nL16L1 * nBb + na6b * na6B1; M3 = mL16L1 * mBb + ma6b * ma6B1; A3 = aBb * PMCC + aa6b * (PMCC - aBb);
                            fm.A1 = N3;
                            fm.A2 = M3;
                            fm.A3 = A3;
                            #endregion
                        }
                        #endregion
                        else if (a6 < 100)
                        {
                            nL16L1 = n6; aL16L1 = a6; mL16L1 = 2;
                            #region 宽度方向
                            MBCCK = 300;
                            n5 = (int)(PMCK / MBCCK);
                            a5 = PMCK - n5 * MBCCK;
                            if (a5 < 100)
                            {
                                nBb = n5; aBb = a5; mBb = 1;
                            }
                            else if (a5 >= 100 && a5 < 150)
                            {
                                nBb = n5 + 1; aBb = a5 - 100; mBb = 2;
                            }
                            else if (a5 >= 150 && a5 < 200)
                            {
                                nBb = n5 + 1; aBb = a5 - 150; mBb = 2;
                            }
                            else if (a5 >= 200 && a5 < 250)
                            {
                                nBb = n5 + 1; aBb = a5 - 200; mBb = 2;
                            }
                            else if (a5 >= 250 && a5 < 300)
                            {
                                nBb = n5 + 1; aBb = a5 - 250; mBb = 2;
                            }

                            #endregion
                            #region 计算过程
                            N1 = nL16L1 * nBb; M1 = mL16L1 * mBb; A1 = aL16L1 * PMCK + aBb * (PMCC - aL16L1);
                            fm.A1 = N1;
                            fm.A2 = M1;
                            fm.A3 = A1;
                            #endregion
                        }
                    }
                    else if (100 <= a6L1 && a6L1 < 450)
                    {
                        #region 此按横竖混合计算
                        if (400 <= a6L1 && a6L1 < 450)
                        {
                            n6 = 2; a6 = a6L1 - n6 * 200;
                            na6b = n6;
                            aa6b = a6;
                            ma6b = 1;
                        }
                        else if (350 <= a6L1 && a6L1 < 400)
                        {
                            n6 = 2; a6 = a6L1 - 350;
                            na6b = n6;
                            aa6b = a6;
                            ma6b = 2;
                        }
                        else if (300 <= a6L1 && a6L1 < 350)
                        {
                            n6 = 2; a6 = a6L1 - 300;
                            na6b = n6;
                            aa6b = a6;
                            ma6b = 1;
                        }

                        else if (250 <= a6L1 && a6L1 < 300)
                        {
                            n6 = 2; a6 = a6L1 - 250;
                            na6b = n6;
                            aa6b = a6;
                            ma6b = 1;
                        }
                        else if (200 <= a6L1 && a6L1 < 250)
                        {
                            n6 = 2; a6 = a6L1 - 200;
                            na6b = n6;
                            aa6b = a6;
                            ma6b = 1;
                        }
                        else if (150 <= a6L1 && a6L1 < 200)
                        {
                            n6 = 2; a6 = a6L1 - 150;
                            na6b = n6;
                            aa6b = a6;
                            ma6b = 1;
                        }
                        else if (100 <= a6L1 && a6L1 < 150)
                        {
                            n6 = 2; a6 = a6L1 - 100;
                            na6b = n6;
                            aa6b = a6;
                            ma6b = 1;
                        }
                        #endregion
                        #region 横竖混合排列 宽度方向
                        nBb = (int)(PMCK / 300);
                        aBb = PMCK - nBb * 300;
                        mBb = 1;
                        n6B1 = (int)(PMCK / 1500);
                        a6B1 = PMCK - n6B1 * 1500;
                        if (1350 <= a6B1 && a6B1 < 1500)
                        {
                            n6 = n6B1 + 2; a6 = a6B1 - 900 - 450;
                            na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                        }

                        else if (1200 <= a6B1 && a6B1 < 1350)
                        {
                            n6 = n6B1 + 1; a6 = a6B1 - 1200;
                            na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                        }
                        else if (1050 <= a6B1 && a6B1 < 1200)
                        {
                            n6 = n6B1 + 1; a6 = a6B1 - 1050;
                            na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                        }
                        else if (900 <= a6B1 && a6B1 < 1050)
                        {
                            n6 = n6B1 + 1; a6 = a6B1 - 900;
                            na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                        }
                        else if (750 <= a6B1 && a6B1 < 900)
                        {
                            n6 = n6B1 + 1; a6 = a6B1 - 750;
                            na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                        }
                        else if (600 <= a6B1 && a6B1 < 750)
                        {
                            n6 = n6B1 + 1; a6 = a6B1 - 600;
                            na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                        }
                        else if (450 <= a6B1 && a6B1 < 600)
                        {
                            n6 = n6B1 + 1; a6 = a6B1 - 450;
                            na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                        }
                        else if (a6B1 < 450)
                        {
                            na6B1 = n6B1; aa6B1 = a6B1; ma6B1 = 1;

                        }
                        #endregion
                        #region  计算过程
                        N3 = nL16L1 * nBb + na6b * na6B1; M3 = mL16L1 * mBb + ma6b * ma6B1; A3 = aBb * PMCC + aa6b * (PMCC - aBb);
                        fm.A1 = N3;
                        fm.A2 = M3;
                        fm.A3 = A3;
                        #endregion
                    }
                    else if (a6L1 < 100)
                    {

                        nL16L1 = n6L1; aL16L1 = a6L1; mL16L1 = 2;
                        #region 宽度方向
                        MBCCK = 300;
                        n5 = (int)(PMCK / MBCCK);
                        a5 = PMCK - n5 * MBCCK;
                        if (a5 < 100)
                        {
                            nBb = n5; aBb = a5; mBb = 1;
                        }
                        else if (a5 >= 100 && a5 < 150)
                        {
                            nBb = n5 + 1; aBb = a5 - 100; mBb = 2;
                        }
                        else if (a5 >= 150 && a5 < 200)
                        {
                            nBb = n5 + 1; aBb = a5 - 150; mBb = 2;
                        }
                        else if (a5 >= 200 && a5 < 250)
                        {
                            nBb = n5 + 1; aBb = a5 - 200; mBb = 2;
                        }
                        else if (a5 >= 250 && a5 < 300)
                        {
                            nBb = n5 + 1; aBb = a5 - 250; mBb = 2;
                        }

                        #endregion
                        #region 计算过程
                        N1 = nL16L1 * nBb; M1 = mL16L1 * mBb; A1 = aL16L1 * PMCK + aBb * (PMCC - aL16L1);
                        fm.A1 = N1;
                        fm.A2 = M1;
                        fm.A3 = A1;
                        #endregion
                    }

                    #endregion

                    #endregion
                    fm.PailieMode = 0;
                }
                //纵向排列
                else  if(this.comboBoxEx9.SelectedIndex==1)
                {
                    #region 全部纵向 
                n6B1 = (int)(PMCK / 1500);
                a6B1 = PMCK - n6B1 * 1500;
                if (a6B1>=1350 && a6B1 < 1500)
                {
                    n6 = n6B1 + 2; a6 = a6B1 - 900 - 450;
                    #region 此过程按竖横混合计算
                    if (a6<=100 && a6 < 150)
                    {
                       
                        n6 = 2; a6 = a6 - 100;
                        na6b = n6; aa6b = a6; ma6b = 1;
                        #region 竖横混合 长度方向
                        nLb = (int)(PMCK / 300);
                        aLb = PMCK - nLb * 300;
                        mLb = 1;
                        n6L1 = (int)(PMCK / 1500);
                        a6L1 = PMCK - n6L1 * 1500;
                        if (1350 <= a6L1 && a6L1 < 1500)
                        {
                            n6 = n6L1 + 2; a6 = a6L1 - 900 - 450;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                        }

                        else if (1200 <= a6L1 && a6L1 < 1350)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 1200;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }


                        else if (1050 <= a6L1 && a6L1 < 1200)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 1050;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                        }
                        else if (900 <= a6L1 && a6L1 < 1050)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 900;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }
                        else if (750 <= a6L1 && a6L1 < 900)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 750;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }
                        else if (600 <= a6L1 && a6L1 < 750)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 600;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }
                        else if (450 <= a6L1 && a6L1 < 600)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 450;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }
                        else if (a6L1 < 450)
                        {
                            na6L1 = n6L1; aa6L1 = a6L1; ma6L1 = 1;
                        }
                        #endregion
                        #region 计算过程
                        N4 = nB16B1 * nLb + na6b * na6L1;
                        M4 = mB16B1 * mLb + ma6L1 * ma6b;
                        A4 = aa6b * PMCC + aLb * (PMCK - aB16B1);
                        fm.B1 = N4;
                        fm.B2 = M4;
                        fm.B3 = A4;
                        #endregion

                    }
                    #endregion
                    if (a6 < 100)
                    {
                        nB16B1 = n6; aB16B1 = a6; mB16B1 = 3;
                        #region 长度方向
                        n5 = (int)(PMCC / 300);
                        a5 = PMCC - n5 * 300;
                        if (a5 < 100)
                        {
                            nLb = n5; aLb = a5; mLb = 1;
                        }
                        else if (100 <= a5 && a5 < 150)
                        {
                            nLb = n5 + 1; aLb = a5 - 100; mLb = 2;
                        }
                        else if (150 <= a5 && a5 < 200)
                        {
                            nLb = n5 + 1; aLb = a5 - 150; mLb = 2;
                        }
                        else if (200 <= a5 && a5 < 250)
                        {
                            nLb = n5 + 1; aLb = a5 - 200; mLb = 2;
                        }
                        else if (250 <= a5 && a5 < 300)
                        {
                            nLb = n5 + 1; aLb = a5 - 250; mLb = 2;
                        }

                        #endregion
                        #region  计算过程
                        N2 = nB16B1 * nLb; M2 = mB16B1 * mLb; A2 = aB16B1 * PMCK + aLb * (PMCC - aB16B1);
                        fm.B1 = N2;
                        fm.B2 = M2;
                        fm.B3 = A2;
                        #endregion
                    }
                }
                else if (a6B1>=1200 && a6B1 < 1350)
                {
                    n6 = n6B1 + 1; a6 = a6B1 - 1200;
                    #region 此过程按竖横混合计算
                    if (a6 <= 100 && a6 < 150)
                    {

                        n6 = 2; a6 = a6 - 100;
                        na6b = n6; aa6b = a6; ma6b = 1;
                        #region 竖横混合 长度方向
                        nLb = (int)(PMCK / 300);
                        aLb = PMCK - nLb * 300;
                        mLb = 1;
                        n6L1 = (int)(PMCK / 1500);
                        a6L1 = PMCK - n6L1 * 1500;
                        if (1350 <= a6L1 && a6L1 < 1500)
                        {
                            n6 = n6L1 + 2; a6 = a6L1 - 900 - 450;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                        }

                        else if (1200 <= a6L1 && a6L1 < 1350)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 1200;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }


                        else if (1050 <= a6L1 && a6L1 < 1200)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 1050;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                        }
                        else if (900 <= a6L1 && a6L1 < 1050)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 900;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }
                        else if (750 <= a6L1 && a6L1 < 900)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 750;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }
                        else if (600 <= a6L1 && a6L1 < 750)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 600;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }
                        else if (450 <= a6L1 && a6L1 < 600)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 450;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }
                        else if (a6L1 < 450)
                        {
                            na6L1 = n6L1; aa6L1 = a6L1; ma6L1 = 1;
                        }
                        #endregion
                        #region 计算过程
                        N4 = nB16B1 * nLb + na6b * na6L1;
                        M4 = mB16B1 * mLb + ma6L1 * ma6b;
                        A4 = aa6b * PMCC + aLb * (PMCK - aB16B1);
                        fm.B1 = N4;
                        fm.B2 = M4;
                        fm.B3 = A4;
                        #endregion

                    }
                    #endregion
                    if (a6 < 100)
                    {
                        nB16B1 = n6; aB16B1 = a6; mB16B1 = 2;
                        #region 长度方向
                        n5 = (int)(PMCC / 300);
                        a5 = PMCC - n5 * 300;
                        if (a5 < 100)
                        {
                            nLb = n5; aLb = a5; mLb = 1;
                        }
                        else if (100 <= a5 && a5 < 150)
                        {
                            nLb = n5 + 1; aLb = a5 - 100; mLb = 2;
                        }
                        else if (150 <= a5 && a5 < 200)
                        {
                            nLb = n5 + 1; aLb = a5 - 150; mLb = 2;
                        }
                        else if (200 <= a5 && a5 < 250)
                        {
                            nLb = n5 + 1; aLb = a5 - 200; mLb = 2;
                        }
                        else if (250 <= a5 && a5 < 300)
                        {
                            nLb = n5 + 1; aLb = a5 - 250; mLb = 2;
                        }

                        #endregion
                        #region  计算过程
                        N2 = nB16B1 * nLb; M2 = mB16B1 * mLb; A2 = aB16B1 * PMCK + aLb * (PMCC - aB16B1);
                        fm.B1 = N2;
                        fm.B2 = M2;
                        fm.B3 = A2;
                        #endregion
                    }

                }
                else if (1050 <= a6B1 && a6B1 < 1200)
                {
                    n6 = n6B1 + 1; a6 = a6B1 - 600 - 450;
                    #region 此过程按竖横混合计算
                    if (a6 <= 100 && a6 < 150)
                    {

                        n6 = 2; a6 = a6 - 100;
                        na6b = n6; aa6b = a6; ma6b = 1;
                        #region 竖横混合 长度方向
                        nLb = (int)(PMCK / 300);
                        aLb = PMCK - nLb * 300;
                        mLb = 1;
                        n6L1 = (int)(PMCK / 1500);
                        a6L1 = PMCK - n6L1 * 1500;
                        if (1350 <= a6L1 && a6L1 < 1500)
                        {
                            n6 = n6L1 + 2; a6 = a6L1 - 900 - 450;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                        }

                        else if (1200 <= a6L1 && a6L1 < 1350)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 1200;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }


                        else if (1050 <= a6L1 && a6L1 < 1200)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 1050;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                        }
                        else if (900 <= a6L1 && a6L1 < 1050)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 900;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }
                        else if (750 <= a6L1 && a6L1 < 900)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 750;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }
                        else if (600 <= a6L1 && a6L1 < 750)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 600;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }
                        else if (450 <= a6L1 && a6L1 < 600)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 450;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }
                        else if (a6L1 < 450)
                        {
                            na6L1 = n6L1; aa6L1 = a6L1; ma6L1 = 1;
                        }
                        #endregion
                        #region 计算过程
                        N4 = nB16B1 * nLb + na6b * na6L1;
                        M4 = mB16B1 * mLb + ma6L1 * ma6b;
                        A4 = aa6b * PMCC + aLb * (PMCK - aB16B1);
                        fm.B1 = N4;
                        fm.B2 = M4;
                        fm.B3 = A4;
                        #endregion

                    }
                    #endregion
                    if (a6 < 100)
                    {
                        nB16B1 = n6; aB16B1 = a6; mB16B1 = 3;
                        #region 长度方向
                        n5 = (int)(PMCC / 300);
                        a5 = PMCC - n5 * 300;
                        if (a5 < 100)
                        {
                            nLb = n5; aLb = a5; mLb = 1;
                        }
                        else if (100 <= a5 && a5 < 150)
                        {
                            nLb = n5 + 1; aLb = a5 - 100; mLb = 2;
                        }
                        else if (150 <= a5 && a5 < 200)
                        {
                            nLb = n5 + 1; aLb = a5 - 150; mLb = 2;
                        }
                        else if (200 <= a5 && a5 < 250)
                        {
                            nLb = n5 + 1; aLb = a5 - 200; mLb = 2;
                        }
                        else if (250 <= a5 && a5 < 300)
                        {
                            nLb = n5 + 1; aLb = a5 - 250; mLb = 2;
                        }

                        #endregion
                        #region  计算过程
                        N2 = nB16B1 * nLb; M2 = mB16B1 * mLb; A2 = aB16B1 * PMCK + aLb * (PMCC - aB16B1);
                        fm.B1 = N2;
                        fm.B2 = M2;
                        fm.B3 = A2;
                        #endregion
                    }

                }
                else if (900 <= a6B1 && a6B1 < 1050)
                {
                    n6 = n6B1 + 1; a6 = a6B1 - 900;
                    #region 此过程按竖横混合计算
                    if (a6 <= 100 && a6 < 150)
                    {

                        n6 = 2; a6 = a6 - 100;
                        na6b = n6; aa6b = a6; ma6b = 1;
                        #region 竖横混合 长度方向
                        nLb = (int)(PMCK / 300);
                        aLb = PMCK - nLb * 300;
                        mLb = 1;
                        n6L1 = (int)(PMCK / 1500);
                        a6L1 = PMCK - n6L1 * 1500;
                        if (1350 <= a6L1 && a6L1 < 1500)
                        {
                            n6 = n6L1 + 2; a6 = a6L1 - 900 - 450;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                        }

                        else if (1200 <= a6L1 && a6L1 < 1350)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 1200;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }


                        else if (1050 <= a6L1 && a6L1 < 1200)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 1050;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                        }
                        else if (900 <= a6L1 && a6L1 < 1050)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 900;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }
                        else if (750 <= a6L1 && a6L1 < 900)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 750;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }
                        else if (600 <= a6L1 && a6L1 < 750)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 600;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }
                        else if (450 <= a6L1 && a6L1 < 600)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 450;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }
                        else if (a6L1 < 450)
                        {
                            na6L1 = n6L1; aa6L1 = a6L1; ma6L1 = 1;
                        }
                        #endregion
                        #region 计算过程
                        N4 = nB16B1 * nLb + na6b * na6L1;
                        M4 = mB16B1 * mLb + ma6L1 * ma6b;
                        A4 = aa6b * PMCC + aLb * (PMCK - aB16B1);
                        fm.B1 = N4;
                        fm.B2 = M4;
                        fm.B3 = A4;
                        #endregion

                    }
                    #endregion
                    if (a6 < 100)
                    {
                        nB16B1 = n6; aB16B1 = a6; mB16B1 = 2;
                        #region 长度方向
                        n5 = (int)(PMCC / 300);
                        a5 = PMCC - n5 * 300;
                        if (a5 < 100)
                        {
                            nLb = n5; aLb = a5; mLb = 1;
                        }
                        else if (100 <= a5 && a5 < 150)
                        {
                            nLb = n5 + 1; aLb = a5 - 100; mLb = 2;
                        }
                        else if (150 <= a5 && a5 < 200)
                        {
                            nLb = n5 + 1; aLb = a5 - 150; mLb = 2;
                        }
                        else if (200 <= a5 && a5 < 250)
                        {
                            nLb = n5 + 1; aLb = a5 - 200; mLb = 2;
                        }
                        else if (250 <= a5 && a5 < 300)
                        {
                            nLb = n5 + 1; aLb = a5 - 250; mLb = 2;
                        }

                        #endregion
                        #region  计算过程
                        N2 = nB16B1 * nLb; M2 = mB16B1 * mLb; A2 = aB16B1 * PMCK + aLb * (PMCC - aB16B1);
                        fm.B1 = N2;
                        fm.B2 = M2;
                        fm.B3 = A2;
                        #endregion
                    }

                }
                else if (750 <= a6B1 && a6B1 < 900)
                {
                    n6 = n6B1 + 1; a6 = a6B1 - 750;
                    #region 此过程按竖横混合计算
                    if (a6 <= 100 && a6 < 150)
                    {

                        n6 = 2; a6 = a6 - 100;
                        na6b = n6; aa6b = a6; ma6b = 1;
                        #region 竖横混合 长度方向
                        nLb = (int)(PMCK / 300);
                        aLb = PMCK - nLb * 300;
                        mLb = 1;
                        n6L1 = (int)(PMCK / 1500);
                        a6L1 = PMCK - n6L1 * 1500;
                        if (1350 <= a6L1 && a6L1 < 1500)
                        {
                            n6 = n6L1 + 2; a6 = a6L1 - 900 - 450;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                        }

                        else if (1200 <= a6L1 && a6L1 < 1350)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 1200;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }


                        else if (1050 <= a6L1 && a6L1 < 1200)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 1050;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                        }
                        else if (900 <= a6L1 && a6L1 < 1050)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 900;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }
                        else if (750 <= a6L1 && a6L1 < 900)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 750;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }
                        else if (600 <= a6L1 && a6L1 < 750)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 600;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }
                        else if (450 <= a6L1 && a6L1 < 600)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 450;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }
                        else if (a6L1 < 450)
                        {
                            na6L1 = n6L1; aa6L1 = a6L1; ma6L1 = 1;
                        }
                        #endregion
                        #region 计算过程
                        N4 = nB16B1 * nLb + na6b * na6L1;
                        M4 = mB16B1 * mLb + ma6L1 * ma6b;
                        A4 = aa6b * PMCC + aLb * (PMCK - aB16B1);
                        fm.B1 = N4;
                        fm.B2 = M4;
                        fm.B3 = A4;
                        #endregion

                    }
                    #endregion
                    if (a6 < 100)
                    {
                        nB16B1 = n6; aB16B1 = a6; mB16B1 = 2;
                        #region 长度方向
                        n5 = (int)(PMCC / 300);
                        a5 = PMCC - n5 * 300;
                        if (a5 < 100)
                        {
                            nLb = n5; aLb = a5; mLb = 1;
                        }
                        else if (100 <= a5 && a5 < 150)
                        {
                            nLb = n5 + 1; aLb = a5 - 100; mLb = 2;
                        }
                        else if (150 <= a5 && a5 < 200)
                        {
                            nLb = n5 + 1; aLb = a5 - 150; mLb = 2;
                        }
                        else if (200 <= a5 && a5 < 250)
                        {
                            nLb = n5 + 1; aLb = a5 - 200; mLb = 2;
                        }
                        else if (250 <= a5 && a5 < 300)
                        {
                            nLb = n5 + 1; aLb = a5 - 250; mLb = 2;
                        }

                        #endregion
                        #region  计算过程
                        N2 = nB16B1 * nLb; M2 = mB16B1 * mLb; A2 = aB16B1 * PMCK + aLb * (PMCC - aB16B1);
                        fm.B1 = N2;
                        fm.B2 = M2;
                        fm.B3 = A2;
                        #endregion
                    }

                }
                else if (600 <= a6B1 && a6B1 < 750)
                {
                    n6 = n6B1 + 1; a6 = a6B1 - 600;
                    #region 此过程按竖横混合计算
                    if (a6 <= 100 && a6 < 150)
                    {

                        n6 = 2; a6 = a6 - 100;
                        na6b = n6; aa6b = a6; ma6b = 1;
                        #region 竖横混合 长度方向
                        nLb = (int)(PMCK / 300);
                        aLb = PMCK - nLb * 300;
                        mLb = 1;
                        n6L1 = (int)(PMCK / 1500);
                        a6L1 = PMCK - n6L1 * 1500;
                        if (1350 <= a6L1 && a6L1 < 1500)
                        {
                            n6 = n6L1 + 2; a6 = a6L1 - 900 - 450;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                        }

                        else if (1200 <= a6L1 && a6L1 < 1350)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 1200;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }


                        else if (1050 <= a6L1 && a6L1 < 1200)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 1050;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                        }
                        else if (900 <= a6L1 && a6L1 < 1050)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 900;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }
                        else if (750 <= a6L1 && a6L1 < 900)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 750;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }
                        else if (600 <= a6L1 && a6L1 < 750)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 600;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }
                        else if (450 <= a6L1 && a6L1 < 600)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 450;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }
                        else if (a6L1 < 450)
                        {
                            na6L1 = n6L1; aa6L1 = a6L1; ma6L1 = 1;
                        }
                        #endregion
                        #region 计算过程
                        N4 = nB16B1 * nLb + na6b * na6L1;
                        M4 = mB16B1 * mLb + ma6L1 * ma6b;
                        A4 = aa6b * PMCC + aLb * (PMCK - aB16B1);
                        fm.B1 = N4;
                        fm.B2 = M4;
                        fm.B3 = A4;
                        #endregion

                    }
                    #endregion
                    if (a6 < 100)
                    {
                        nB16B1 = n6; aB16B1 = a6; mB16B1 = 2;
                        #region 长度方向
                        n5 = (int)(PMCC / 300);
                        a5 = PMCC - n5 * 300;
                        if (a5 < 100)
                        {
                            nLb = n5; aLb = a5; mLb = 1;
                        }
                        else if (100 <= a5 && a5 < 150)
                        {
                            nLb = n5 + 1; aLb = a5 - 100; mLb = 2;
                        }
                        else if (150 <= a5 && a5 < 200)
                        {
                            nLb = n5 + 1; aLb = a5 - 150; mLb = 2;
                        }
                        else if (200 <= a5 && a5 < 250)
                        {
                            nLb = n5 + 1; aLb = a5 - 200; mLb = 2;
                        }
                        else if (250 <= a5 && a5 < 300)
                        {
                            nLb = n5 + 1; aLb = a5 - 250; mLb = 2;
                        }

                        #endregion
                        #region  计算过程
                        N2 = nB16B1 * nLb; M2 = mB16B1 * mLb; A2 = aB16B1 * PMCK + aLb * (PMCC - aB16B1);
                        fm.B1 = N2;
                        fm.B2 = M2;
                        fm.B3 = A2;
                        #endregion
                    }

                }
                else if (450 <= a6B1 && a6B1 < 600)
                {
                    n6 = n6B1 + 1; a6 = a6B1 - 450;
                    #region 此过程按竖横混合计算
                    if (a6 <= 100 && a6 < 150)
                    {

                        n6 = 2; a6 = a6 - 100;
                        na6b = n6; aa6b = a6; ma6b = 1;
                        #region 竖横混合 长度方向
                        nLb = (int)(PMCK / 300);
                        aLb = PMCK - nLb * 300;
                        mLb = 1;
                        n6L1 = (int)(PMCK / 1500);
                        a6L1 = PMCK - n6L1 * 1500;
                        if (1350 <= a6L1 && a6L1 < 1500)
                        {
                            n6 = n6L1 + 2; a6 = a6L1 - 900 - 450;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                        }

                        else if (1200 <= a6L1 && a6L1 < 1350)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 1200;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }


                        else if (1050 <= a6L1 && a6L1 < 1200)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 1050;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                        }
                        else if (900 <= a6L1 && a6L1 < 1050)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 900;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }
                        else if (750 <= a6L1 && a6L1 < 900)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 750;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }
                        else if (600 <= a6L1 && a6L1 < 750)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 600;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }
                        else if (450 <= a6L1 && a6L1 < 600)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 450;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }
                        else if (a6L1 < 450)
                        {
                            na6L1 = n6L1; aa6L1 = a6L1; ma6L1 = 1;
                        }
                        #endregion
                        #region 计算过程
                        N4 = nB16B1 * nLb + na6b * na6L1;
                        M4 = mB16B1 * mLb + ma6L1 * ma6b;
                        A4 = aa6b * PMCC + aLb * (PMCK - aB16B1);
                        fm.B1 = N4;
                        fm.B2 = M4;
                        fm.B3= A4;
                        #endregion

                    }
                    #endregion
                    if (a6 < 100)
                    {
                        nB16B1 = n6; aB16B1 = a6; mB16B1 = 2;
                        #region 长度方向
                        n5 = (int)(PMCC / 300);
                        a5 = PMCC - n5 * 300;
                        if (a5 < 100)
                        {
                            nLb = n5; aLb = a5; mLb = 1;
                        }
                        else if (100 <= a5 && a5 < 150)
                        {
                            nLb = n5 + 1; aLb = a5 - 100; mLb = 2;
                        }
                        else if (150 <= a5 && a5 < 200)
                        {
                            nLb = n5 + 1; aLb = a5 - 150; mLb = 2;
                        }
                        else if (200 <= a5 && a5 < 250)
                        {
                            nLb = n5 + 1; aLb = a5 - 200; mLb = 2;
                        }
                        else if (250 <= a5 && a5 < 300)
                        {
                            nLb = n5 + 1; aLb = a5 - 250; mLb = 2;
                        }

                        #endregion
                        #region  计算过程
                        N2 = nB16B1 * nLb; M2 = mB16B1 * mLb; A2 = aB16B1 * PMCK + aLb * (PMCC - aB16B1);
                        fm.B1 = N2;
                        fm.B2 = M2;
                        fm.B3 = A2;
                        #endregion
                    }

                }
                else if (100 <= a6B1 && a6B1 < 450)
                {
                    #region 此按竖横混合计算
                    if (400 <= a6B1 && a6B1 < 450)
                    {
                        n6 = 2; a6 = a6B1 - n6 * 200;
                        na6b = n6; aa6b = a6; ma6b = 1;
                    }

                    else if (350 <= a6B1 && a6B1 < 400)
                    {
                        n6 = 2; a6 = a6B1 - 350;
                        na6b = n6; aa6b = a6; ma6b = 2;
                    }
                    else if (300 <= a6B1 && a6B1 < 350)
                    {
                        n6 = 2; a6 = a6B1 - 300;
                        na6b = n6; aa6b = a6; ma6b = 1;
                    }

                    else if (250 <= a6B1 && a6B1 < 300)
                    {
                        n6 = 2; a6 = a6B1 - 250;
                        na6b = n6; aa6b = a6; ma6b = 1;
                    }

                    else if (200 <= a6B1 && a6B1 < 250)
                    {
                        n6 = 2; a6 = a6B1 - 200;
                        na6b = n6; aa6b = a6; ma6b = 1;
                    }

                    else if (150 <= a6B1 && a6B1 < 200)
                    {
                        n6 = 2; a6 = a6B1 - 150;
                        na6b = n6; aa6b = a6; ma6b = 1;
                    }

                    else if (100 <= a6B1 && a6B1 < 150)
                    {
                        n6 = 2; a6 = a6B1 - 100;
                        na6b = n6; aa6b = a6; ma6b = 1;
                    }
                    #region 竖横混合 长度方向
                    nLb = (int)(PMCK / 300);
                    aLb = PMCK - nLb * 300;
                    mLb = 1;
                    n6L1 = (int)(PMCK / 1500);
                    a6L1 = PMCK - n6L1 * 1500;
                    if (1350 <= a6L1 && a6L1 < 1500)
                    {
                        n6 = n6L1 + 2; a6 = a6L1 - 900 - 450;
                        na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                    }

                    else if (1200 <= a6L1 && a6L1 < 1350)
                    {
                        n6 = n6L1 + 1; a6 = a6L1 - 1200;
                        na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                    }


                    else if (1050 <= a6L1 && a6L1 < 1200)
                    {
                        n6 = n6L1 + 1; a6 = a6L1 - 1050;
                        na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                    }
                    else if (900 <= a6L1 && a6L1 < 1050)
                    {
                        n6 = n6L1 + 1; a6 = a6L1 - 900;
                        na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                    }
                    else if (750 <= a6L1 && a6L1 < 900)
                    {
                        n6 = n6L1 + 1; a6 = a6L1 - 750;
                        na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                    }
                    else if (600 <= a6L1 && a6L1 < 750)
                    {
                        n6 = n6L1 + 1; a6 = a6L1 - 600;
                        na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                    }
                    else if (450 <= a6L1 && a6L1 < 600)
                    {
                        n6 = n6L1 + 1; a6 = a6L1 - 450;
                        na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                    }
                    else if (a6L1 < 450)
                    {
                        na6L1 = n6L1; aa6L1 = a6L1; ma6L1 = 1;
                    }
                    #endregion
                    #region 计算过程
                    N4 = nB16B1 * nLb + na6b * na6L1;
                    M4 = mB16B1 * mLb + ma6L1 * ma6b;
                    A4 = aa6b * PMCC + aLb * (PMCK - aB16B1);
                    fm.B1 = N4;
                    fm.B2 = M4;
                    fm.B3 = A4;
                    #endregion
                    #endregion
                }
                if (a6B1 < 100)
                {
                    nB16B1 = n6B1; aB16B1 = a6B1; mB16B1 = 1;
                    #region 长度方向
                    n5 = (int)(PMCC / 300);
                    a5 = PMCC - n5 * 300;
                    if (a5 < 100)
                    {
                        nLb = n5; aLb = a5; mLb = 1;
                    }
                    else if (100 <= a5 && a5 < 150)
                    {
                        nLb = n5 + 1; aLb = a5 - 100; mLb = 2;
                    }
                    else if (150 <= a5 && a5 < 200)
                    {
                        nLb = n5 + 1; aLb = a5 - 150; mLb = 2;
                    }
                    else if (200 <= a5 && a5 < 250)
                    {
                        nLb = n5 + 1; aLb = a5 - 200; mLb = 2;
                    }
                    else if (250 <= a5 && a5 < 300)
                    {
                        nLb = n5 + 1; aLb = a5 - 250; mLb = 2;
                    }

                    #endregion
                    #region  计算过程
                    N2 = nB16B1 * nLb; M2 = mB16B1 * mLb; A2 = aB16B1 * PMCK + aLb * (PMCC - aB16B1);
                    fm.B1 = N2;
                    fm.B2 = M2;
                    fm.B3 = A2;
                    #endregion
                }
                #endregion
                   fm.PailieMode = 1;
                }
                //横竖混合排列
                else   if(this.comboBoxEx9.SelectedIndex==2)
               {
                   #region 横竖混合排列 长度方向
                MBCCC = 1500;
                n6L1 = (int)(PMCC / MBCCC);
                a6L1 = PMCC - n6L1 * MBCCC;
                nL16L1 = n6L1; aL16L1 = a6L1; mL16L1 = 1;
                if (1350 <= a6L1 && a6L1 < 1500)
                {
                    n6 = n6L1 + 2; a6 = a6L1 - 900 - 450;
                    if (100 <= a6 && a6 < 150)
                    {

                        n6 = 2; a6 = a6 - 100;
                        na6b = n6;
                        aa6b = a6;
                        ma6b = 1;
                    }
                    else
                    {
                       
                        na6b = n6;
                        aa6b = a6;
                        ma6b = 1;
                    }
                }
                else if (1200 <= a6L1 && a6L1 < 1350)
                {
                    n6 = n6L1 + 1; a6 = a6L1 - 1200;
                    if (100 <= a6 && a6 < 150)
                    {

                        n6 = 2; a6 = a6 - 100;
                        na6b = n6;
                        aa6b = a6;
                        ma6b = 1;
                    }
                    else
                    {
                        na6b = n6;
                        aa6b = a6;
                        ma6b = 1;
                    }
                }

                else if (1050 <= a6L1 && a6L1 < 1200)
                {
                    n6 = 2; a6 = a6L1 - 100;
                    na6b = n6;
                    aa6b = a6;
                    ma6b = 1;
                }
                else if (900 <= a6L1 && a6L1 < 1050)
                {
                    n6 = 2; a6 = a6L1 - 100;
                    na6b = n6;
                    aa6b = a6;
                    ma6b = 1;
                }
                else if (750 <= a6L1 && a6L1 < 900)
                {
                    n6 = 2; a6 = a6L1 - 100;
                    na6b = n6;
                    aa6b = a6;
                    ma6b = 1;
                }
                else if (600 <= a6L1 && a6L1 < 750)
                {
                    n6 = 2; a6 = a6L1 - 100;
                    na6b = n6;
                    aa6b = a6;
                    ma6b = 1;
                }
                else if (450 <= a6L1 && a6L1 < 600)
                {
                    n6 = 2; a6 = a6L1 - 100;
                    na6b = n6;
                    aa6b = a6;
                    ma6b = 1;
                }
                else if (400 <= a6L1 && a6L1 < 450)
                {
                    n6 = 2; a6 = a6L1 - n6 * 200;
                    na6b = n6;
                    aa6b = a6;
                    ma6b = 1;
                }
                else if (350 <= a6L1 && a6L1 < 400)
                {
                    n6 = 2; a6 = a6L1 - 350;
                    na6b = n6;
                    aa6b = a6;
                    ma6b = 2;
                }
                else if (300 <= a6L1 && a6L1 < 350)
                {
                    n6 = 2; a6 = a6L1 - 300;
                    na6b = n6;
                    aa6b = a6;
                    ma6b = 1;
                }

                else if (250 <= a6L1 && a6L1 < 300)
                {
                    n6 = 2; a6 = a6L1 - 250;
                    na6b = n6;
                    aa6b = a6;
                    ma6b = 1;
                }
                else if (200 <= a6L1 && a6L1 < 250)
                {
                    n6 = 2; a6 = a6L1 - 200;
                    na6b = n6;
                    aa6b = a6;
                    ma6b = 1;
                }
                else if (150 <= a6L1 && a6L1 < 200)
                {
                    n6 = 2; a6 = a6L1 - 150;
                    na6b = n6;
                    aa6b = a6;
                    ma6b = 1;
                }
                else if (100 <= a6L1 && a6L1 < 150)
                {
                    n6 = 2; a6 = a6L1 - 100;
                    na6b = n6;
                    aa6b = a6;
                    ma6b = 1;
                }
                #endregion
                   #region 横竖混合排列 宽度方向              
                nBb = (int)(PMCK / 300);
                aBb = PMCK - nBb * 300;
                mBb = 1;
                n6B1 = (int)(PMCK / 1500);
                a6B1 = PMCK - n6B1 * 1500;
                if (1350 <= a6B1 && a6B1 < 1500)
                {
                    n6 = n6B1 + 2; a6 = a6B1 - 900 - 450;
                    na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                }

                else if (1200 <= a6B1 && a6B1 < 1350)
                {
                    n6 = n6B1 + 1; a6 = a6B1 - 1200;
                    na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                }
                else if (1050 <= a6B1 && a6B1 < 1200)
                {
                    n6 = n6B1 + 1; a6 = a6B1 - 1050;
                    na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                }
                else if (900 <= a6B1 && a6B1 < 1050)
                {
                    n6 = n6B1 + 1; a6 = a6B1 - 900;
                    na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                }
                else if (750 <= a6B1 && a6B1 < 900)
                {
                    n6 = n6B1 + 1; a6 = a6B1 - 750;
                    na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                }
                else if (600 <= a6B1 && a6B1 < 750)
                {
                    n6 = n6B1 + 1; a6 = a6B1 - 600;
                    na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                }
                else if (450 <= a6B1 && a6B1 < 600)
                {
                    n6 = n6B1 + 1; a6 = a6B1 - 450;
                    na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                }
                else if (a6B1 < 450)
                {
                    na6B1 = n6B1; aa6B1 = a6B1; ma6B1 = 1;

                }
                #endregion
                   #region  计算过程
                   N3 = nL16L1 * nBb+na6b*na6B1; M3 = mL16L1 * mBb+ma6b*ma6B1; A3 = aBb * PMCC + aa6b * (PMCC - aBb);
                   fm.C1 = N3;
                   fm.C2 = M3;
                   fm.C3 = A3;
                   #endregion
                   fm.PailieMode = 2;
                }
                //不固定排列
                else  if(this.comboBoxEx9.SelectedIndex==3)
                {
                    #region  全部横向排列
                    MBCCC = 1500;
                    mL16L1 = 1;
                    n6L1 = (int)(PMCC / MBCCC);
                    a6L1 = PMCC - n6L1 * MBCCC;
                    nL16L1 = n6L1; aL16L1 = a6L1;
                    #region 长度方向
                    if (1350 <= a6L1 && a6L1 < 1500)
                    {
                        n6 = n6L1 + 2; a6 = a6L1 - 900 - 450;
                        #region 此过程进行横竖混合计算
                        if (100 <= a6 && a6 < 150)
                        {

                            n6 = 2; a6 = a6 - 100;
                            na6b = n6;
                            aa6b = a6;
                            ma6b = 1;
                            #region 横竖混合排列 宽度方向
                            nBb = (int)(PMCK / 300);
                            aBb = PMCK - nBb * 300;
                            mBb = 1;
                            n6B1 = (int)(PMCK / 1500);
                            a6B1 = PMCK - n6B1 * 1500;
                            if (1350 <= a6B1 && a6B1 < 1500)
                            {
                                n6 = n6B1 + 2; a6 = a6B1 - 900 - 450;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                            }

                            else if (1200 <= a6B1 && a6B1 < 1350)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 1200;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (1050 <= a6B1 && a6B1 < 1200)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 1050;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                            }
                            else if (900 <= a6B1 && a6B1 < 1050)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 900;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (750 <= a6B1 && a6B1 < 900)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 750;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (600 <= a6B1 && a6B1 < 750)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 600;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (450 <= a6B1 && a6B1 < 600)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 450;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (a6B1 < 450)
                            {
                                na6B1 = n6B1; aa6B1 = a6B1; ma6B1 = 1;

                            }
                            #endregion
                            #region  计算过程
                            N3 = nL16L1 * nBb + na6b * na6B1; M3 = mL16L1 * mBb + ma6b * ma6B1; A3 = aBb * PMCC + aa6b * (PMCC - aBb);
                            fm.A1 = N3;
                            fm.A2 = M3;
                            fm.A3 = A3;
                            #endregion
                        }
                        #endregion
                        else if (a6 < 100)
                        {
                            nL16L1 = n6; aL16L1 = a6; mL16L1 = 3;
                            #region 宽度方向
                            MBCCK = 300;
                            n5 = (int)(PMCK / MBCCK);
                            a5 = PMCK - n5 * MBCCK;
                            if (a5 < 100)
                            {
                                nBb = n5; aBb = a5; mBb = 1;
                            }
                            else if (a5 >= 100 && a5 < 150)
                            {
                                nBb = n5 + 1; aBb = a5 - 100; mBb = 2;
                            }
                            else if (a5 >= 150 && a5 < 200)
                            {
                                nBb = n5 + 1; aBb = a5 - 150; mBb = 2;
                            }
                            else if (a5 >= 200 && a5 < 250)
                            {
                                nBb = n5 + 1; aBb = a5 - 200; mBb = 2;
                            }
                            else if (a5 >= 250 && a5 < 300)
                            {
                                nBb = n5 + 1; aBb = a5 - 250; mBb = 2;
                            }

                            #endregion
                            #region 计算过程
                            N1 = nL16L1 * nBb; M1 = mL16L1 * mBb; A1 = aL16L1 * PMCK + aBb * (PMCC - aL16L1);
                            fm.A1 = N1;
                            fm.A2 = M1;
                            fm.A3 = A1;
                            #endregion

                        }
                    }

                    else if (1200 <= a6L1 && a6L1 < 1350)
                    {
                        n6 = n6L1 + 1; a6 = a6L1 - 1200;
                        #region 此过程进行横竖混合计算
                        if (100 <= a6 && a6 < 150)
                        {
                            n6 = 2; a6 = a6 - 100;
                            na6b = n6;
                            aa6b = a6;
                            ma6b = 1;
                            #region 横竖混合排列 宽度方向
                            nBb = (int)(PMCK / 300);
                            aBb = PMCK - nBb * 300;
                            mBb = 1;
                            n6B1 = (int)(PMCK / 1500);
                            a6B1 = PMCK - n6B1 * 1500;
                            if (1350 <= a6B1 && a6B1 < 1500)
                            {
                                n6 = n6B1 + 2; a6 = a6B1 - 900 - 450;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                            }

                            else if (1200 <= a6B1 && a6B1 < 1350)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 1200;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (1050 <= a6B1 && a6B1 < 1200)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 1050;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                            }
                            else if (900 <= a6B1 && a6B1 < 1050)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 900;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (750 <= a6B1 && a6B1 < 900)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 750;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (600 <= a6B1 && a6B1 < 750)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 600;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (450 <= a6B1 && a6B1 < 600)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 450;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (a6B1 < 450)
                            {
                                na6B1 = n6B1; aa6B1 = a6B1; ma6B1 = 1;

                            }
                            #endregion
                            #region  计算过程
                            N3 = nL16L1 * nBb + na6b * na6B1; M3 = mL16L1 * mBb + ma6b * ma6B1; A3 = aBb * PMCC + aa6b * (PMCC - aBb);
                            fm.A1 = N3;
                            fm.A2 = M3;
                            fm.A3 = A3;
                            #endregion
                        }
                        #endregion
                        else if (a6 < 100)
                        {
                            nL16L1 = n6; aL16L1 = a6; mL16L1 = 2;
                            #region 宽度方向
                            MBCCK = 300;
                            n5 = (int)(PMCK / MBCCK);
                            a5 = PMCK - n5 * MBCCK;
                            if (a5 < 100)
                            {
                                nBb = n5; aBb = a5; mBb = 1;
                            }
                            else if (a5 >= 100 && a5 < 150)
                            {
                                nBb = n5 + 1; aBb = a5 - 100; mBb = 2;
                            }
                            else if (a5 >= 150 && a5 < 200)
                            {
                                nBb = n5 + 1; aBb = a5 - 150; mBb = 2;
                            }
                            else if (a5 >= 200 && a5 < 250)
                            {
                                nBb = n5 + 1; aBb = a5 - 200; mBb = 2;
                            }
                            else if (a5 >= 250 && a5 < 300)
                            {
                                nBb = n5 + 1; aBb = a5 - 250; mBb = 2;
                            }

                            #endregion
                            #region 计算过程
                            N1 = nL16L1 * nBb; M1 = mL16L1 * mBb; A1 = aL16L1 * PMCK + aBb * (PMCC - aL16L1);
                            fm.A1 = N1;
                            fm.A2 = M1;
                            fm.A3 = A1;
                            #endregion
                        }
                    }
                    else if (1050 <= a6L1 && a6L1 < 1200)
                    {
                        n6 = n6L1 + 1; a6 = a6L1 - 600 - 450;
                        #region 此过程进行横竖混合计算
                        if (100 <= a6 && a6 < 150)
                        {

                            n6 = 2; a6 = a6 - 100;
                            na6b = n6;
                            aa6b = a6;
                            ma6b = 1;
                            #region 横竖混合排列 宽度方向
                            nBb = (int)(PMCK / 300);
                            aBb = PMCK - nBb * 300;
                            mBb = 1;
                            n6B1 = (int)(PMCK / 1500);
                            a6B1 = PMCK - n6B1 * 1500;
                            if (1350 <= a6B1 && a6B1 < 1500)
                            {
                                n6 = n6B1 + 2; a6 = a6B1 - 900 - 450;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                            }

                            else if (1200 <= a6B1 && a6B1 < 1350)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 1200;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (1050 <= a6B1 && a6B1 < 1200)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 1050;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                            }
                            else if (900 <= a6B1 && a6B1 < 1050)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 900;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (750 <= a6B1 && a6B1 < 900)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 750;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (600 <= a6B1 && a6B1 < 750)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 600;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (450 <= a6B1 && a6B1 < 600)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 450;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (a6B1 < 450)
                            {
                                na6B1 = n6B1; aa6B1 = a6B1; ma6B1 = 1;

                            }
                            #endregion
                            #region  计算过程
                            N3 = nL16L1 * nBb + na6b * na6B1; M3 = mL16L1 * mBb + ma6b * ma6B1; A3 = aBb * PMCC + aa6b * (PMCC - aBb);
                            fm.A1 = N3;
                            fm.A2 = M3;
                            fm.A3 = A3;
                            #endregion
                        }
                        #endregion
                        else if (a6 < 100)
                        {
                            nL16L1 = n6; aL16L1 = a6; mL16L1 = 3;
                            #region 宽度方向
                            MBCCK = 300;
                            n5 = (int)(PMCK / MBCCK);
                            a5 = PMCK - n5 * MBCCK;
                            if (a5 < 100)
                            {
                                nBb = n5; aBb = a5; mBb = 1;
                            }
                            else if (a5 >= 100 && a5 < 150)
                            {
                                nBb = n5 + 1; aBb = a5 - 100; mBb = 2;
                            }
                            else if (a5 >= 150 && a5 < 200)
                            {
                                nBb = n5 + 1; aBb = a5 - 150; mBb = 2;
                            }
                            else if (a5 >= 200 && a5 < 250)
                            {
                                nBb = n5 + 1; aBb = a5 - 200; mBb = 2;
                            }
                            else if (a5 >= 250 && a5 < 300)
                            {
                                nBb = n5 + 1; aBb = a5 - 250; mBb = 2;
                            }

                            #endregion
                            #region 计算过程
                            N1 = nL16L1 * nBb; M1 = mL16L1 * mBb; A1 = aL16L1 * PMCK + aBb * (PMCC - aL16L1);
                            fm.A1 = N1;
                            fm.A2 = M1;
                            fm.A3 = A1;
                            #endregion
                        }
                    }
                    else if (900 <= a6L1 && a6L1 < 1050)
                    {
                        n6 = n6L1 + 1; a6 = a6L1 - 900;
                        #region 此过程进行横竖混合计算
                        if (100 <= a6 && a6 < 150)
                        {

                            n6 = 2; a6 = a6 - 100;
                            na6b = n6;
                            aa6b = a6;
                            ma6b = 1;
                            #region 横竖混合排列 宽度方向
                            nBb = (int)(PMCK / 300);
                            aBb = PMCK - nBb * 300;
                            mBb = 1;
                            n6B1 = (int)(PMCK / 1500);
                            a6B1 = PMCK - n6B1 * 1500;
                            if (1350 <= a6B1 && a6B1 < 1500)
                            {
                                n6 = n6B1 + 2; a6 = a6B1 - 900 - 450;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                            }

                            else if (1200 <= a6B1 && a6B1 < 1350)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 1200;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (1050 <= a6B1 && a6B1 < 1200)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 1050;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                            }
                            else if (900 <= a6B1 && a6B1 < 1050)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 900;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (750 <= a6B1 && a6B1 < 900)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 750;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (600 <= a6B1 && a6B1 < 750)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 600;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (450 <= a6B1 && a6B1 < 600)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 450;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (a6B1 < 450)
                            {
                                na6B1 = n6B1; aa6B1 = a6B1; ma6B1 = 1;

                            }
                            #endregion
                            #region  计算过程
                            N3 = nL16L1 * nBb + na6b * na6B1; M3 = mL16L1 * mBb + ma6b * ma6B1; A3 = aBb * PMCC + aa6b * (PMCC - aBb);
                            fm.A1 = N3;
                            fm.A2 = M3;
                            fm.A3 = A3;
                            #endregion
                        }
                        #endregion
                        else if (a6 < 100)
                        {
                            nL16L1 = n6; aL16L1 = a6; mL16L1 = 2;
                            #region 宽度方向
                            MBCCK = 300;
                            n5 = (int)(PMCK / MBCCK);
                            a5 = PMCK - n5 * MBCCK;
                            if (a5 < 100)
                            {
                                nBb = n5; aBb = a5; mBb = 1;
                            }
                            else if (a5 >= 100 && a5 < 150)
                            {
                                nBb = n5 + 1; aBb = a5 - 100; mBb = 2;
                            }
                            else if (a5 >= 150 && a5 < 200)
                            {
                                nBb = n5 + 1; aBb = a5 - 150; mBb = 2;
                            }
                            else if (a5 >= 200 && a5 < 250)
                            {
                                nBb = n5 + 1; aBb = a5 - 200; mBb = 2;
                            }
                            else if (a5 >= 250 && a5 < 300)
                            {
                                nBb = n5 + 1; aBb = a5 - 250; mBb = 2;
                            }

                            #endregion
                            #region 计算过程
                            N1 = nL16L1 * nBb; M1 = mL16L1 * mBb; A1 = aL16L1 * PMCK + aBb * (PMCC - aL16L1);
                            fm.A1 = N1;
                            fm.A2 = M1;
                            fm.A3 = A1;
                            #endregion
                        }
                    }
                    else if (750 <= a6L1 && a6L1 < 900)
                    {
                        n6 = n6L1 + 1; a6 = a6L1 - 750;
                        #region 此过程进行横竖混合计算
                        if (100 <= a6 && a6 < 150)
                        {

                            n6 = 2; a6 = a6 - 100;
                            na6b = n6;
                            aa6b = a6;
                            ma6b = 1;
                            #region 横竖混合排列 宽度方向
                            nBb = (int)(PMCK / 300);
                            aBb = PMCK - nBb * 300;
                            mBb = 1;
                            n6B1 = (int)(PMCK / 1500);
                            a6B1 = PMCK - n6B1 * 1500;
                            if (1350 <= a6B1 && a6B1 < 1500)
                            {
                                n6 = n6B1 + 2; a6 = a6B1 - 900 - 450;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                            }

                            else if (1200 <= a6B1 && a6B1 < 1350)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 1200;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (1050 <= a6B1 && a6B1 < 1200)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 1050;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                            }
                            else if (900 <= a6B1 && a6B1 < 1050)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 900;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (750 <= a6B1 && a6B1 < 900)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 750;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (600 <= a6B1 && a6B1 < 750)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 600;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (450 <= a6B1 && a6B1 < 600)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 450;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (a6B1 < 450)
                            {
                                na6B1 = n6B1; aa6B1 = a6B1; ma6B1 = 1;

                            }
                            #endregion
                            #region  计算过程
                            N3 = nL16L1 * nBb + na6b * na6B1; M3 = mL16L1 * mBb + ma6b * ma6B1; A3 = aBb * PMCC + aa6b * (PMCC - aBb);
                            fm.A1 = N3;
                            fm.A2 = M3;
                            fm.A3 = A3;
                            #endregion
                        }
                        #endregion
                        else if (a6 < 100)
                        {
                            nL16L1 = n6; aL16L1 = a6; mL16L1 = 2;
                            #region 宽度方向
                            MBCCK = 300;
                            n5 = (int)(PMCK / MBCCK);
                            a5 = PMCK - n5 * MBCCK;
                            if (a5 < 100)
                            {
                                nBb = n5; aBb = a5; mBb = 1;
                            }
                            else if (a5 >= 100 && a5 < 150)
                            {
                                nBb = n5 + 1; aBb = a5 - 100; mBb = 2;
                            }
                            else if (a5 >= 150 && a5 < 200)
                            {
                                nBb = n5 + 1; aBb = a5 - 150; mBb = 2;
                            }
                            else if (a5 >= 200 && a5 < 250)
                            {
                                nBb = n5 + 1; aBb = a5 - 200; mBb = 2;
                            }
                            else if (a5 >= 250 && a5 < 300)
                            {
                                nBb = n5 + 1; aBb = a5 - 250; mBb = 2;
                            }

                            #endregion
                            #region 计算过程
                            N1 = nL16L1 * nBb; M1 = mL16L1 * mBb; A1 = aL16L1 * PMCK + aBb * (PMCC - aL16L1);
                            fm.A1 = N1;
                            fm.A2 = M1;
                            fm.A3 = A1;
                            #endregion
                        }
                    }
                    else if (600 <= a6L1 && a6L1 < 750)
                    {
                        n6 = n6L1 + 1; a6 = a6L1 - 600;
                        #region 此过程进行横竖混合计算
                        if (100 <= a6 && a6 < 150)
                        {

                            n6 = 2; a6 = a6 - 100;
                            na6b = n6;
                            aa6b = a6;
                            ma6b = 1;
                            #region 横竖混合排列 宽度方向
                            nBb = (int)(PMCK / 300);
                            aBb = PMCK - nBb * 300;
                            mBb = 1;
                            n6B1 = (int)(PMCK / 1500);
                            a6B1 = PMCK - n6B1 * 1500;
                            if (1350 <= a6B1 && a6B1 < 1500)
                            {
                                n6 = n6B1 + 2; a6 = a6B1 - 900 - 450;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                            }

                            else if (1200 <= a6B1 && a6B1 < 1350)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 1200;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (1050 <= a6B1 && a6B1 < 1200)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 1050;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                            }
                            else if (900 <= a6B1 && a6B1 < 1050)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 900;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (750 <= a6B1 && a6B1 < 900)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 750;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (600 <= a6B1 && a6B1 < 750)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 600;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (450 <= a6B1 && a6B1 < 600)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 450;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (a6B1 < 450)
                            {
                                na6B1 = n6B1; aa6B1 = a6B1; ma6B1 = 1;

                            }
                            #endregion
                            #region  计算过程
                            N3 = nL16L1 * nBb + na6b * na6B1; M3 = mL16L1 * mBb + ma6b * ma6B1; A3 = aBb * PMCC + aa6b * (PMCC - aBb);
                            fm.A1 = N3;
                            fm.A2 = M3;
                            fm.A3 = A3;
                            #endregion
                        }
                        #endregion
                        else if (a6 < 100)
                        {
                            nL16L1 = n6; aL16L1 = a6; mL16L1 = 2;
                            #region 宽度方向
                            MBCCK = 300;
                            n5 = (int)(PMCK / MBCCK);
                            a5 = PMCK - n5 * MBCCK;
                            if (a5 < 100)
                            {
                                nBb = n5; aBb = a5; mBb = 1;
                            }
                            else if (a5 >= 100 && a5 < 150)
                            {
                                nBb = n5 + 1; aBb = a5 - 100; mBb = 2;
                            }
                            else if (a5 >= 150 && a5 < 200)
                            {
                                nBb = n5 + 1; aBb = a5 - 150; mBb = 2;
                            }
                            else if (a5 >= 200 && a5 < 250)
                            {
                                nBb = n5 + 1; aBb = a5 - 200; mBb = 2;
                            }
                            else if (a5 >= 250 && a5 < 300)
                            {
                                nBb = n5 + 1; aBb = a5 - 250; mBb = 2;
                            }

                            #endregion
                            #region 计算过程
                            N1 = nL16L1 * nBb; M1 = mL16L1 * mBb; A1 = aL16L1 * PMCK + aBb * (PMCC - aL16L1);
                            fm.A1 = N1;
                            fm.A2 = M1;
                            fm.A3 = A1;
                            #endregion
                        }
                    }
                    else if (450 <= a6L1 && a6L1 < 600)
                    {
                        n6 = n6L1 + 1; a6 = a6L1 - 450;
                        #region 此过程进行横竖混合计算
                        if (100 <= a6 && a6 < 150)
                        {

                            n6 = 2; a6 = a6 - 100;
                            na6b = n6;
                            aa6b = a6;
                            ma6b = 1;
                            #region 横竖混合排列 宽度方向
                            nBb = (int)(PMCK / 300);
                            aBb = PMCK - nBb * 300;
                            mBb = 1;
                            n6B1 = (int)(PMCK / 1500);
                            a6B1 = PMCK - n6B1 * 1500;
                            if (1350 <= a6B1 && a6B1 < 1500)
                            {
                                n6 = n6B1 + 2; a6 = a6B1 - 900 - 450;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                            }

                            else if (1200 <= a6B1 && a6B1 < 1350)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 1200;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (1050 <= a6B1 && a6B1 < 1200)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 1050;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                            }
                            else if (900 <= a6B1 && a6B1 < 1050)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 900;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (750 <= a6B1 && a6B1 < 900)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 750;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (600 <= a6B1 && a6B1 < 750)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 600;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (450 <= a6B1 && a6B1 < 600)
                            {
                                n6 = n6B1 + 1; a6 = a6B1 - 450;
                                na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                            }
                            else if (a6B1 < 450)
                            {
                                na6B1 = n6B1; aa6B1 = a6B1; ma6B1 = 1;

                            }
                            #endregion
                            #region  计算过程
                            N3 = nL16L1 * nBb + na6b * na6B1; M3 = mL16L1 * mBb + ma6b * ma6B1; A3 = aBb * PMCC + aa6b * (PMCC - aBb);
                            fm.A1 = N3;
                            fm.A2 = M3;
                            fm.A3 = A3;
                            #endregion
                        }
                        #endregion
                        else if (a6 < 100)
                        {
                            nL16L1 = n6; aL16L1 = a6; mL16L1 = 2;
                            #region 宽度方向
                            MBCCK = 300;
                            n5 = (int)(PMCK / MBCCK);
                            a5 = PMCK - n5 * MBCCK;
                            if (a5 < 100)
                            {
                                nBb = n5; aBb = a5; mBb = 1;
                            }
                            else if (a5 >= 100 && a5 < 150)
                            {
                                nBb = n5 + 1; aBb = a5 - 100; mBb = 2;
                            }
                            else if (a5 >= 150 && a5 < 200)
                            {
                                nBb = n5 + 1; aBb = a5 - 150; mBb = 2;
                            }
                            else if (a5 >= 200 && a5 < 250)
                            {
                                nBb = n5 + 1; aBb = a5 - 200; mBb = 2;
                            }
                            else if (a5 >= 250 && a5 < 300)
                            {
                                nBb = n5 + 1; aBb = a5 - 250; mBb = 2;
                            }

                            #endregion
                            #region 计算过程
                            N1 = nL16L1 * nBb; M1 = mL16L1 * mBb; A1 = aL16L1 * PMCK + aBb * (PMCC - aL16L1);
                            fm.A1 = N1;
                            fm.A2 = M1;
                            fm.A3 = A1;
                            #endregion
                        }
                    }
                    else if (100 <= a6L1 && a6L1 < 450)
                    {
                        #region 此按横竖混合计算
                        if (400 <= a6L1 && a6L1 < 450)
                        {
                            n6 = 2; a6 = a6L1 - n6 * 200;
                            na6b = n6;
                            aa6b = a6;
                            ma6b = 1;
                        }
                        else if (350 <= a6L1 && a6L1 < 400)
                        {
                            n6 = 2; a6 = a6L1 - 350;
                            na6b = n6;
                            aa6b = a6;
                            ma6b = 2;
                        }
                        else if (300 <= a6L1 && a6L1 < 350)
                        {
                            n6 = 2; a6 = a6L1 - 300;
                            na6b = n6;
                            aa6b = a6;
                            ma6b = 1;
                        }

                        else if (250 <= a6L1 && a6L1 < 300)
                        {
                            n6 = 2; a6 = a6L1 - 250;
                            na6b = n6;
                            aa6b = a6;
                            ma6b = 1;
                        }
                        else if (200 <= a6L1 && a6L1 < 250)
                        {
                            n6 = 2; a6 = a6L1 - 200;
                            na6b = n6;
                            aa6b = a6;
                            ma6b = 1;
                        }
                        else if (150 <= a6L1 && a6L1 < 200)
                        {
                            n6 = 2; a6 = a6L1 - 150;
                            na6b = n6;
                            aa6b = a6;
                            ma6b = 1;
                        }
                        else if (100 <= a6L1 && a6L1 < 150)
                        {
                            n6 = 2; a6 = a6L1 - 100;
                            na6b = n6;
                            aa6b = a6;
                            ma6b = 1;
                        }
                        #endregion
                        #region 横竖混合排列 宽度方向
                        nBb = (int)(PMCK / 300);
                        aBb = PMCK - nBb * 300;
                        mBb = 1;
                        n6B1 = (int)(PMCK / 1500);
                        a6B1 = PMCK - n6B1 * 1500;
                        if (1350 <= a6B1 && a6B1 < 1500)
                        {
                            n6 = n6B1 + 2; a6 = a6B1 - 900 - 450;
                            na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                        }

                        else if (1200 <= a6B1 && a6B1 < 1350)
                        {
                            n6 = n6B1 + 1; a6 = a6B1 - 1200;
                            na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                        }
                        else if (1050 <= a6B1 && a6B1 < 1200)
                        {
                            n6 = n6B1 + 1; a6 = a6B1 - 1050;
                            na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                        }
                        else if (900 <= a6B1 && a6B1 < 1050)
                        {
                            n6 = n6B1 + 1; a6 = a6B1 - 900;
                            na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                        }
                        else if (750 <= a6B1 && a6B1 < 900)
                        {
                            n6 = n6B1 + 1; a6 = a6B1 - 750;
                            na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                        }
                        else if (600 <= a6B1 && a6B1 < 750)
                        {
                            n6 = n6B1 + 1; a6 = a6B1 - 600;
                            na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                        }
                        else if (450 <= a6B1 && a6B1 < 600)
                        {
                            n6 = n6B1 + 1; a6 = a6B1 - 450;
                            na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                        }
                        else if (a6B1 < 450)
                        {
                            na6B1 = n6B1; aa6B1 = a6B1; ma6B1 = 1;

                        }
                        #endregion
                        #region  计算过程
                        N3 = nL16L1 * nBb + na6b * na6B1; M3 = mL16L1 * mBb + ma6b * ma6B1; A3 = aBb * PMCC + aa6b * (PMCC - aBb);
                        fm.A1 = N3;
                        fm.A2 = M3;
                        fm.A3 = A3;
                        #endregion
                    }
                    else if (a6L1 < 100)
                    {

                        nL16L1 = n6L1; aL16L1 = a6L1; mL16L1 = 2;
                        #region 宽度方向
                        MBCCK = 300;
                        n5 = (int)(PMCK / MBCCK);
                        a5 = PMCK - n5 * MBCCK;
                        if (a5 < 100)
                        {
                            nBb = n5; aBb = a5; mBb = 1;
                        }
                        else if (a5 >= 100 && a5 < 150)
                        {
                            nBb = n5 + 1; aBb = a5 - 100; mBb = 2;
                        }
                        else if (a5 >= 150 && a5 < 200)
                        {
                            nBb = n5 + 1; aBb = a5 - 150; mBb = 2;
                        }
                        else if (a5 >= 200 && a5 < 250)
                        {
                            nBb = n5 + 1; aBb = a5 - 200; mBb = 2;
                        }
                        else if (a5 >= 250 && a5 < 300)
                        {
                            nBb = n5 + 1; aBb = a5 - 250; mBb = 2;
                        }

                        #endregion
                        #region 计算过程
                        N1 = nL16L1 * nBb; M1 = mL16L1 * mBb; A1 = aL16L1 * PMCK + aBb * (PMCC - aL16L1);
                        fm.A1 = N1;
                        fm.A2 = M1;
                        fm.A3 = A1;
                        #endregion
                    }

                    #endregion

                    #endregion
                    #region 全部纵向
                    n6B1 = (int)(PMCK / 1500);
                    a6B1 = PMCK - n6B1 * 1500;
                    if (a6B1 >= 1350 && a6B1 < 1500)
                    {
                        n6 = n6B1 + 2; a6 = a6B1 - 900 - 450;
                        #region 此过程按竖横混合计算
                        if (a6 <= 100 && a6 < 150)
                        {

                            n6 = 2; a6 = a6 - 100;
                            na6b = n6; aa6b = a6; ma6b = 1;
                            #region 竖横混合 长度方向
                            nLb = (int)(PMCK / 300);
                            aLb = PMCK - nLb * 300;
                            mLb = 1;
                            n6L1 = (int)(PMCK / 1500);
                            a6L1 = PMCK - n6L1 * 1500;
                            if (1350 <= a6L1 && a6L1 < 1500)
                            {
                                n6 = n6L1 + 2; a6 = a6L1 - 900 - 450;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                            }

                            else if (1200 <= a6L1 && a6L1 < 1350)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 1200;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }


                            else if (1050 <= a6L1 && a6L1 < 1200)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 1050;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                            }
                            else if (900 <= a6L1 && a6L1 < 1050)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 900;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }
                            else if (750 <= a6L1 && a6L1 < 900)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 750;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }
                            else if (600 <= a6L1 && a6L1 < 750)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 600;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }
                            else if (450 <= a6L1 && a6L1 < 600)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 450;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }
                            else if (a6L1 < 450)
                            {
                                na6L1 = n6L1; aa6L1 = a6L1; ma6L1 = 1;
                            }
                            #endregion
                            #region 计算过程
                            N4 = nB16B1 * nLb + na6b * na6L1;
                            M4 = mB16B1 * mLb + ma6L1 * ma6b;
                            A4 = aa6b * PMCC + aLb * (PMCK - aB16B1);
                            fm.B1 = N4;
                            fm.B2 = M4;
                            fm.B3 = A4;
                            #endregion

                        }
                        #endregion
                        if (a6 < 100)
                        {
                            nB16B1 = n6; aB16B1 = a6; mB16B1 = 3;
                            #region 长度方向
                            n5 = (int)(PMCC / 300);
                            a5 = PMCC - n5 * 300;
                            if (a5 < 100)
                            {
                                nLb = n5; aLb = a5; mLb = 1;
                            }
                            else if (100 <= a5 && a5 < 150)
                            {
                                nLb = n5 + 1; aLb = a5 - 100; mLb = 2;
                            }
                            else if (150 <= a5 && a5 < 200)
                            {
                                nLb = n5 + 1; aLb = a5 - 150; mLb = 2;
                            }
                            else if (200 <= a5 && a5 < 250)
                            {
                                nLb = n5 + 1; aLb = a5 - 200; mLb = 2;
                            }
                            else if (250 <= a5 && a5 < 300)
                            {
                                nLb = n5 + 1; aLb = a5 - 250; mLb = 2;
                            }

                            #endregion
                            #region  计算过程
                            N2 = nB16B1 * nLb; M2 = mB16B1 * mLb; A2 = aB16B1 * PMCK + aLb * (PMCC - aB16B1);
                            fm.B1 = N2;
                            fm.B2 = M2;
                            fm.B3 = A2;
                            #endregion
                        }
                    }
                    else if (a6B1 >= 1200 && a6B1 < 1350)
                    {
                        n6 = n6B1 + 1; a6 = a6B1 - 1200;
                        #region 此过程按竖横混合计算
                        if (a6 <= 100 && a6 < 150)
                        {

                            n6 = 2; a6 = a6 - 100;
                            na6b = n6; aa6b = a6; ma6b = 1;
                            #region 竖横混合 长度方向
                            nLb = (int)(PMCK / 300);
                            aLb = PMCK - nLb * 300;
                            mLb = 1;
                            n6L1 = (int)(PMCK / 1500);
                            a6L1 = PMCK - n6L1 * 1500;
                            if (1350 <= a6L1 && a6L1 < 1500)
                            {
                                n6 = n6L1 + 2; a6 = a6L1 - 900 - 450;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                            }

                            else if (1200 <= a6L1 && a6L1 < 1350)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 1200;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }


                            else if (1050 <= a6L1 && a6L1 < 1200)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 1050;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                            }
                            else if (900 <= a6L1 && a6L1 < 1050)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 900;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }
                            else if (750 <= a6L1 && a6L1 < 900)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 750;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }
                            else if (600 <= a6L1 && a6L1 < 750)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 600;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }
                            else if (450 <= a6L1 && a6L1 < 600)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 450;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }
                            else if (a6L1 < 450)
                            {
                                na6L1 = n6L1; aa6L1 = a6L1; ma6L1 = 1;
                            }
                            #endregion
                            #region 计算过程
                            N4 = nB16B1 * nLb + na6b * na6L1;
                            M4 = mB16B1 * mLb + ma6L1 * ma6b;
                            A4 = aa6b * PMCC + aLb * (PMCK - aB16B1);
                            fm.B1 = N4;
                            fm.B2 = M4;
                            fm.B3 = A4;
                            #endregion

                        }
                        #endregion
                        if (a6 < 100)
                        {
                            nB16B1 = n6; aB16B1 = a6; mB16B1 = 2;
                            #region 长度方向
                            n5 = (int)(PMCC / 300);
                            a5 = PMCC - n5 * 300;
                            if (a5 < 100)
                            {
                                nLb = n5; aLb = a5; mLb = 1;
                            }
                            else if (100 <= a5 && a5 < 150)
                            {
                                nLb = n5 + 1; aLb = a5 - 100; mLb = 2;
                            }
                            else if (150 <= a5 && a5 < 200)
                            {
                                nLb = n5 + 1; aLb = a5 - 150; mLb = 2;
                            }
                            else if (200 <= a5 && a5 < 250)
                            {
                                nLb = n5 + 1; aLb = a5 - 200; mLb = 2;
                            }
                            else if (250 <= a5 && a5 < 300)
                            {
                                nLb = n5 + 1; aLb = a5 - 250; mLb = 2;
                            }

                            #endregion
                            #region  计算过程
                            N2 = nB16B1 * nLb; M2 = mB16B1 * mLb; A2 = aB16B1 * PMCK + aLb * (PMCC - aB16B1);
                            fm.B1 = N2;
                            fm.B2 = M2;
                            fm.B3 = A2;
                            #endregion
                        }

                    }
                    else if (1050 <= a6B1 && a6B1 < 1200)
                    {
                        n6 = n6B1 + 1; a6 = a6B1 - 600 - 450;
                        #region 此过程按竖横混合计算
                        if (a6 <= 100 && a6 < 150)
                        {

                            n6 = 2; a6 = a6 - 100;
                            na6b = n6; aa6b = a6; ma6b = 1;
                            #region 竖横混合 长度方向
                            nLb = (int)(PMCK / 300);
                            aLb = PMCK - nLb * 300;
                            mLb = 1;
                            n6L1 = (int)(PMCK / 1500);
                            a6L1 = PMCK - n6L1 * 1500;
                            if (1350 <= a6L1 && a6L1 < 1500)
                            {
                                n6 = n6L1 + 2; a6 = a6L1 - 900 - 450;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                            }

                            else if (1200 <= a6L1 && a6L1 < 1350)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 1200;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }


                            else if (1050 <= a6L1 && a6L1 < 1200)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 1050;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                            }
                            else if (900 <= a6L1 && a6L1 < 1050)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 900;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }
                            else if (750 <= a6L1 && a6L1 < 900)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 750;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }
                            else if (600 <= a6L1 && a6L1 < 750)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 600;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }
                            else if (450 <= a6L1 && a6L1 < 600)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 450;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }
                            else if (a6L1 < 450)
                            {
                                na6L1 = n6L1; aa6L1 = a6L1; ma6L1 = 1;
                            }
                            #endregion
                            #region 计算过程
                            N4 = nB16B1 * nLb + na6b * na6L1;
                            M4 = mB16B1 * mLb + ma6L1 * ma6b;
                            A4 = aa6b * PMCC + aLb * (PMCK - aB16B1);
                            fm.B1 = N4;
                            fm.B2 = M4;
                            fm.B3 = A4;
                            #endregion

                        }
                        #endregion
                        if (a6 < 100)
                        {
                            nB16B1 = n6; aB16B1 = a6; mB16B1 = 3;
                            #region 长度方向
                            n5 = (int)(PMCC / 300);
                            a5 = PMCC - n5 * 300;
                            if (a5 < 100)
                            {
                                nLb = n5; aLb = a5; mLb = 1;
                            }
                            else if (100 <= a5 && a5 < 150)
                            {
                                nLb = n5 + 1; aLb = a5 - 100; mLb = 2;
                            }
                            else if (150 <= a5 && a5 < 200)
                            {
                                nLb = n5 + 1; aLb = a5 - 150; mLb = 2;
                            }
                            else if (200 <= a5 && a5 < 250)
                            {
                                nLb = n5 + 1; aLb = a5 - 200; mLb = 2;
                            }
                            else if (250 <= a5 && a5 < 300)
                            {
                                nLb = n5 + 1; aLb = a5 - 250; mLb = 2;
                            }

                            #endregion
                            #region  计算过程
                            N2 = nB16B1 * nLb; M2 = mB16B1 * mLb; A2 = aB16B1 * PMCK + aLb * (PMCC - aB16B1);
                            fm.B1 = N2;
                            fm.B2 = M2;
                            fm.B3 = A2;
                            #endregion
                        }

                    }
                    else if (900 <= a6B1 && a6B1 < 1050)
                    {
                        n6 = n6B1 + 1; a6 = a6B1 - 900;
                        #region 此过程按竖横混合计算
                        if (a6 <= 100 && a6 < 150)
                        {

                            n6 = 2; a6 = a6 - 100;
                            na6b = n6; aa6b = a6; ma6b = 1;
                            #region 竖横混合 长度方向
                            nLb = (int)(PMCK / 300);
                            aLb = PMCK - nLb * 300;
                            mLb = 1;
                            n6L1 = (int)(PMCK / 1500);
                            a6L1 = PMCK - n6L1 * 1500;
                            if (1350 <= a6L1 && a6L1 < 1500)
                            {
                                n6 = n6L1 + 2; a6 = a6L1 - 900 - 450;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                            }

                            else if (1200 <= a6L1 && a6L1 < 1350)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 1200;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }


                            else if (1050 <= a6L1 && a6L1 < 1200)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 1050;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                            }
                            else if (900 <= a6L1 && a6L1 < 1050)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 900;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }
                            else if (750 <= a6L1 && a6L1 < 900)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 750;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }
                            else if (600 <= a6L1 && a6L1 < 750)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 600;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }
                            else if (450 <= a6L1 && a6L1 < 600)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 450;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }
                            else if (a6L1 < 450)
                            {
                                na6L1 = n6L1; aa6L1 = a6L1; ma6L1 = 1;
                            }
                            #endregion
                            #region 计算过程
                            N4 = nB16B1 * nLb + na6b * na6L1;
                            M4 = mB16B1 * mLb + ma6L1 * ma6b;
                            A4 = aa6b * PMCC + aLb * (PMCK - aB16B1);
                            fm.B1 = N4;
                            fm.B2 = M4;
                            fm.B3 = A4;
                            #endregion

                        }
                        #endregion
                        if (a6 < 100)
                        {
                            nB16B1 = n6; aB16B1 = a6; mB16B1 = 2;
                            #region 长度方向
                            n5 = (int)(PMCC / 300);
                            a5 = PMCC - n5 * 300;
                            if (a5 < 100)
                            {
                                nLb = n5; aLb = a5; mLb = 1;
                            }
                            else if (100 <= a5 && a5 < 150)
                            {
                                nLb = n5 + 1; aLb = a5 - 100; mLb = 2;
                            }
                            else if (150 <= a5 && a5 < 200)
                            {
                                nLb = n5 + 1; aLb = a5 - 150; mLb = 2;
                            }
                            else if (200 <= a5 && a5 < 250)
                            {
                                nLb = n5 + 1; aLb = a5 - 200; mLb = 2;
                            }
                            else if (250 <= a5 && a5 < 300)
                            {
                                nLb = n5 + 1; aLb = a5 - 250; mLb = 2;
                            }

                            #endregion
                            #region  计算过程
                            N2 = nB16B1 * nLb; M2 = mB16B1 * mLb; A2 = aB16B1 * PMCK + aLb * (PMCC - aB16B1);
                            fm.B1 = N2;
                            fm.B2 = M2;
                            fm.B3 = A2;
                            #endregion
                        }

                    }
                    else if (750 <= a6B1 && a6B1 < 900)
                    {
                        n6 = n6B1 + 1; a6 = a6B1 - 750;
                        #region 此过程按竖横混合计算
                        if (a6 <= 100 && a6 < 150)
                        {

                            n6 = 2; a6 = a6 - 100;
                            na6b = n6; aa6b = a6; ma6b = 1;
                            #region 竖横混合 长度方向
                            nLb = (int)(PMCK / 300);
                            aLb = PMCK - nLb * 300;
                            mLb = 1;
                            n6L1 = (int)(PMCK / 1500);
                            a6L1 = PMCK - n6L1 * 1500;
                            if (1350 <= a6L1 && a6L1 < 1500)
                            {
                                n6 = n6L1 + 2; a6 = a6L1 - 900 - 450;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                            }

                            else if (1200 <= a6L1 && a6L1 < 1350)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 1200;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }


                            else if (1050 <= a6L1 && a6L1 < 1200)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 1050;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                            }
                            else if (900 <= a6L1 && a6L1 < 1050)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 900;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }
                            else if (750 <= a6L1 && a6L1 < 900)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 750;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }
                            else if (600 <= a6L1 && a6L1 < 750)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 600;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }
                            else if (450 <= a6L1 && a6L1 < 600)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 450;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }
                            else if (a6L1 < 450)
                            {
                                na6L1 = n6L1; aa6L1 = a6L1; ma6L1 = 1;
                            }
                            #endregion
                            #region 计算过程
                            N4 = nB16B1 * nLb + na6b * na6L1;
                            M4 = mB16B1 * mLb + ma6L1 * ma6b;
                            A4 = aa6b * PMCC + aLb * (PMCK - aB16B1);
                            fm.B1 = N4;
                            fm.B2 = M4;
                            fm.B3 = A4;
                            #endregion

                        }
                        #endregion
                        if (a6 < 100)
                        {
                            nB16B1 = n6; aB16B1 = a6; mB16B1 = 2;
                            #region 长度方向
                            n5 = (int)(PMCC / 300);
                            a5 = PMCC - n5 * 300;
                            if (a5 < 100)
                            {
                                nLb = n5; aLb = a5; mLb = 1;
                            }
                            else if (100 <= a5 && a5 < 150)
                            {
                                nLb = n5 + 1; aLb = a5 - 100; mLb = 2;
                            }
                            else if (150 <= a5 && a5 < 200)
                            {
                                nLb = n5 + 1; aLb = a5 - 150; mLb = 2;
                            }
                            else if (200 <= a5 && a5 < 250)
                            {
                                nLb = n5 + 1; aLb = a5 - 200; mLb = 2;
                            }
                            else if (250 <= a5 && a5 < 300)
                            {
                                nLb = n5 + 1; aLb = a5 - 250; mLb = 2;
                            }

                            #endregion
                            #region  计算过程
                            N2 = nB16B1 * nLb; M2 = mB16B1 * mLb; A2 = aB16B1 * PMCK + aLb * (PMCC - aB16B1);
                            fm.B1 = N2;
                            fm.B2 = M2;
                            fm.B3 = A2;
                            #endregion
                        }

                    }
                    else if (600 <= a6B1 && a6B1 < 750)
                    {
                        n6 = n6B1 + 1; a6 = a6B1 - 600;
                        #region 此过程按竖横混合计算
                        if (a6 <= 100 && a6 < 150)
                        {

                            n6 = 2; a6 = a6 - 100;
                            na6b = n6; aa6b = a6; ma6b = 1;
                            #region 竖横混合 长度方向
                            nLb = (int)(PMCK / 300);
                            aLb = PMCK - nLb * 300;
                            mLb = 1;
                            n6L1 = (int)(PMCK / 1500);
                            a6L1 = PMCK - n6L1 * 1500;
                            if (1350 <= a6L1 && a6L1 < 1500)
                            {
                                n6 = n6L1 + 2; a6 = a6L1 - 900 - 450;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                            }

                            else if (1200 <= a6L1 && a6L1 < 1350)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 1200;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }


                            else if (1050 <= a6L1 && a6L1 < 1200)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 1050;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                            }
                            else if (900 <= a6L1 && a6L1 < 1050)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 900;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }
                            else if (750 <= a6L1 && a6L1 < 900)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 750;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }
                            else if (600 <= a6L1 && a6L1 < 750)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 600;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }
                            else if (450 <= a6L1 && a6L1 < 600)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 450;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }
                            else if (a6L1 < 450)
                            {
                                na6L1 = n6L1; aa6L1 = a6L1; ma6L1 = 1;
                            }
                            #endregion
                            #region 计算过程
                            N4 = nB16B1 * nLb + na6b * na6L1;
                            M4 = mB16B1 * mLb + ma6L1 * ma6b;
                            A4 = aa6b * PMCC + aLb * (PMCK - aB16B1);
                            fm.B1 = N4;
                            fm.B2 = M4;
                            fm.B3 = A4;
                            #endregion

                        }
                        #endregion
                        if (a6 < 100)
                        {
                            nB16B1 = n6; aB16B1 = a6; mB16B1 = 2;
                            #region 长度方向
                            n5 = (int)(PMCC / 300);
                            a5 = PMCC - n5 * 300;
                            if (a5 < 100)
                            {
                                nLb = n5; aLb = a5; mLb = 1;
                            }
                            else if (100 <= a5 && a5 < 150)
                            {
                                nLb = n5 + 1; aLb = a5 - 100; mLb = 2;
                            }
                            else if (150 <= a5 && a5 < 200)
                            {
                                nLb = n5 + 1; aLb = a5 - 150; mLb = 2;
                            }
                            else if (200 <= a5 && a5 < 250)
                            {
                                nLb = n5 + 1; aLb = a5 - 200; mLb = 2;
                            }
                            else if (250 <= a5 && a5 < 300)
                            {
                                nLb = n5 + 1; aLb = a5 - 250; mLb = 2;
                            }

                            #endregion
                            #region  计算过程
                            N2 = nB16B1 * nLb; M2 = mB16B1 * mLb; A2 = aB16B1 * PMCK + aLb * (PMCC - aB16B1);
                            fm.B1 = N2;
                            fm.B2 = M2;
                            fm.B3 = A2;
                            #endregion
                        }

                    }
                    else if (450 <= a6B1 && a6B1 < 600)
                    {
                        n6 = n6B1 + 1; a6 = a6B1 - 450;
                        #region 此过程按竖横混合计算
                        if (a6 <= 100 && a6 < 150)
                        {

                            n6 = 2; a6 = a6 - 100;
                            na6b = n6; aa6b = a6; ma6b = 1;
                            #region 竖横混合 长度方向
                            nLb = (int)(PMCK / 300);
                            aLb = PMCK - nLb * 300;
                            mLb = 1;
                            n6L1 = (int)(PMCK / 1500);
                            a6L1 = PMCK - n6L1 * 1500;
                            if (1350 <= a6L1 && a6L1 < 1500)
                            {
                                n6 = n6L1 + 2; a6 = a6L1 - 900 - 450;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                            }

                            else if (1200 <= a6L1 && a6L1 < 1350)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 1200;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }


                            else if (1050 <= a6L1 && a6L1 < 1200)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 1050;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                            }
                            else if (900 <= a6L1 && a6L1 < 1050)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 900;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }
                            else if (750 <= a6L1 && a6L1 < 900)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 750;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }
                            else if (600 <= a6L1 && a6L1 < 750)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 600;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }
                            else if (450 <= a6L1 && a6L1 < 600)
                            {
                                n6 = n6L1 + 1; a6 = a6L1 - 450;
                                na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                            }
                            else if (a6L1 < 450)
                            {
                                na6L1 = n6L1; aa6L1 = a6L1; ma6L1 = 1;
                            }
                            #endregion
                            #region 计算过程
                            N4 = nB16B1 * nLb + na6b * na6L1;
                            M4 = mB16B1 * mLb + ma6L1 * ma6b;
                            A4 = aa6b * PMCC + aLb * (PMCK - aB16B1);
                            fm.B1 = N4;
                            fm.B2 = M4;
                            fm.B3 = A4;
                            #endregion

                        }
                        #endregion
                        if (a6 < 100)
                        {
                            nB16B1 = n6; aB16B1 = a6; mB16B1 = 2;
                            #region 长度方向
                            n5 = (int)(PMCC / 300);
                            a5 = PMCC - n5 * 300;
                            if (a5 < 100)
                            {
                                nLb = n5; aLb = a5; mLb = 1;
                            }
                            else if (100 <= a5 && a5 < 150)
                            {
                                nLb = n5 + 1; aLb = a5 - 100; mLb = 2;
                            }
                            else if (150 <= a5 && a5 < 200)
                            {
                                nLb = n5 + 1; aLb = a5 - 150; mLb = 2;
                            }
                            else if (200 <= a5 && a5 < 250)
                            {
                                nLb = n5 + 1; aLb = a5 - 200; mLb = 2;
                            }
                            else if (250 <= a5 && a5 < 300)
                            {
                                nLb = n5 + 1; aLb = a5 - 250; mLb = 2;
                            }

                            #endregion
                            #region  计算过程
                            N2 = nB16B1 * nLb; M2 = mB16B1 * mLb; A2 = aB16B1 * PMCK + aLb * (PMCC - aB16B1);
                            fm.B1 = N2;
                            fm.B2 = M2;
                            fm.B3 = A2;
                            #endregion
                        }

                    }
                    else if (100 <= a6B1 && a6B1 < 450)
                    {
                        #region 此按竖横混合计算
                        if (400 <= a6B1 && a6B1 < 450)
                        {
                            n6 = 2; a6 = a6B1 - n6 * 200;
                            na6b = n6; aa6b = a6; ma6b = 1;
                        }

                        else if (350 <= a6B1 && a6B1 < 400)
                        {
                            n6 = 2; a6 = a6B1 - 350;
                            na6b = n6; aa6b = a6; ma6b = 2;
                        }
                        else if (300 <= a6B1 && a6B1 < 350)
                        {
                            n6 = 2; a6 = a6B1 - 300;
                            na6b = n6; aa6b = a6; ma6b = 1;
                        }

                        else if (250 <= a6B1 && a6B1 < 300)
                        {
                            n6 = 2; a6 = a6B1 - 250;
                            na6b = n6; aa6b = a6; ma6b = 1;
                        }

                        else if (200 <= a6B1 && a6B1 < 250)
                        {
                            n6 = 2; a6 = a6B1 - 200;
                            na6b = n6; aa6b = a6; ma6b = 1;
                        }

                        else if (150 <= a6B1 && a6B1 < 200)
                        {
                            n6 = 2; a6 = a6B1 - 150;
                            na6b = n6; aa6b = a6; ma6b = 1;
                        }

                        else if (100 <= a6B1 && a6B1 < 150)
                        {
                            n6 = 2; a6 = a6B1 - 100;
                            na6b = n6; aa6b = a6; ma6b = 1;
                        }
                        #region 竖横混合 长度方向
                        nLb = (int)(PMCK / 300);
                        aLb = PMCK - nLb * 300;
                        mLb = 1;
                        n6L1 = (int)(PMCK / 1500);
                        a6L1 = PMCK - n6L1 * 1500;
                        if (1350 <= a6L1 && a6L1 < 1500)
                        {
                            n6 = n6L1 + 2; a6 = a6L1 - 900 - 450;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                        }

                        else if (1200 <= a6L1 && a6L1 < 1350)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 1200;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }


                        else if (1050 <= a6L1 && a6L1 < 1200)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 1050;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                        }
                        else if (900 <= a6L1 && a6L1 < 1050)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 900;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }
                        else if (750 <= a6L1 && a6L1 < 900)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 750;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }
                        else if (600 <= a6L1 && a6L1 < 750)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 600;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }
                        else if (450 <= a6L1 && a6L1 < 600)
                        {
                            n6 = n6L1 + 1; a6 = a6L1 - 450;
                            na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                        }
                        else if (a6L1 < 450)
                        {
                            na6L1 = n6L1; aa6L1 = a6L1; ma6L1 = 1;
                        }
                        #endregion
                        #region 计算过程
                        N4 = nB16B1 * nLb + na6b * na6L1;
                        M4 = mB16B1 * mLb + ma6L1 * ma6b;
                        A4 = aa6b * PMCC + aLb * (PMCK - aB16B1);
                        fm.B1 = N4;
                        fm.B2 = M4;
                        fm.B3 = A4;
                        #endregion
                        #endregion
                    }
                    if (a6B1 < 100)
                    {
                        nB16B1 = n6B1; aB16B1 = a6B1; mB16B1 = 1;
                        #region 长度方向
                        n5 = (int)(PMCC / 300);
                        a5 = PMCC - n5 * 300;
                        if (a5 < 100)
                        {
                            nLb = n5; aLb = a5; mLb = 1;
                        }
                        else if (100 <= a5 && a5 < 150)
                        {
                            nLb = n5 + 1; aLb = a5 - 100; mLb = 2;
                        }
                        else if (150 <= a5 && a5 < 200)
                        {
                            nLb = n5 + 1; aLb = a5 - 150; mLb = 2;
                        }
                        else if (200 <= a5 && a5 < 250)
                        {
                            nLb = n5 + 1; aLb = a5 - 200; mLb = 2;
                        }
                        else if (250 <= a5 && a5 < 300)
                        {
                            nLb = n5 + 1; aLb = a5 - 250; mLb = 2;
                        }

                        #endregion
                        #region  计算过程
                        N2 = nB16B1 * nLb; M2 = mB16B1 * mLb; A2 = aB16B1 * PMCK + aLb * (PMCC - aB16B1);
                        fm.B1 = N2;
                        fm.B2 = M2;
                        fm.B3 = A2;
                        #endregion
                    }
                    #endregion

                    #region 横竖混合排列 长度方向
                    MBCCC = 1500;
                    n6L1 = (int)(PMCC / MBCCC);
                    a6L1 = PMCC - n6L1 * MBCCC;
                    nL16L1 = n6L1; aL16L1 = a6L1; mL16L1 = 1;
                    if (1350 <= a6L1 && a6L1 < 1500)
                    {
                        n6 = n6L1 + 2; a6 = a6L1 - 900 - 450;
                        if (100 <= a6 && a6 < 150)
                        {

                            n6 = 2; a6 = a6 - 100;
                            na6b = n6;
                            aa6b = a6;
                            ma6b = 1;
                        }
                        else
                        {
                           
                            na6b = n6;
                            aa6b = a6;
                            ma6b = 1;
                        }
                    }
                    else if (1200 <= a6L1 && a6L1 < 1350)
                    {
                        n6 = n6L1 + 1; a6 = a6L1 - 1200;
                        if (100 <= a6 && a6 < 150)
                        {

                            n6 = 2; a6 = a6 - 100;
                            na6b = n6;
                            aa6b = a6;
                            ma6b = 1;
                        }
                        else
                        {
                           
                            na6b = n6;
                            aa6b = a6;
                            ma6b = 1;
                        }
                    }
                    else if (1050 <= a6L1 && a6L1 < 1200)
                    {
                        n6 = 2; a6 = a6L1 - 100;
                        na6b = n6;
                        aa6b = a6;
                        ma6b = 1;
                    }
                    else if (900 <= a6L1 && a6L1 < 1050)
                    {
                        n6 = 2; a6 = a6L1 - 100;
                        na6b = n6;
                        aa6b = a6;
                        ma6b = 1;
                    }
                    else if (750 <= a6L1 && a6L1 < 900)
                    {
                        n6 = 2; a6 = a6L1 - 100;
                        na6b = n6;
                        aa6b = a6;
                        ma6b = 1;
                    }
                    else if (600 <= a6L1 && a6L1 < 750)
                    {
                        n6 = 2; a6 = a6L1 - 100;
                        na6b = n6;
                        aa6b = a6;
                        ma6b = 1;
                    }
                    else if (450 <= a6L1 && a6L1 < 600)
                    {
                        n6 = 2; a6 = a6L1 - 100;
                        na6b = n6;
                        aa6b = a6;
                        ma6b = 1;
                    }
                    else if (400 <= a6L1 && a6L1 < 450)
                    {
                        n6 = 2; a6 = a6L1 - 2 * 200;
                        na6b = n6;
                        aa6b = a6;
                        ma6b = 1;
                    }
                    else if (350 <= a6L1 && a6L1 < 400)
                    {
                        n6 = 2; a6 = a6L1 - 350;
                        na6b = n6;
                        aa6b = a6;
                        ma6b = 2;
                    }
                    else if (300 <= a6L1 && a6L1 < 350)
                    {
                        n6 = 2; a6 = a6L1 - 300;
                        na6b = n6;
                        aa6b = a6;
                        ma6b = 1;
                    }

                    else if (250 <= a6L1 && a6L1 < 300)
                    {
                        n6 = 2; a6 = a6L1 - 250;
                        na6b = n6;
                        aa6b = a6;
                        ma6b = 1;
                    }
                    else if (200 <= a6L1 && a6L1 < 250)
                    {
                        n6 = 2; a6 = a6L1 - 200;
                        na6b = n6;
                        aa6b = a6;
                        ma6b = 1;
                    }
                    else if (150 <= a6L1 && a6L1 < 200)
                    {
                        n6 = 2; a6 = a6L1 - 150;
                        na6b = n6;
                        aa6b = a6;
                        ma6b = 1;
                    }
                    else if (100 <= a6L1 && a6L1 < 150)
                    {
                        n6 = 2; a6 = a6L1 - 100;
                        na6b = n6;
                        aa6b = a6;
                        ma6b = 1;
                    }
                    #endregion
                    #region 横竖混合排列 宽度方向
                    nBb = (int)(PMCK / 300);
                    aBb = PMCK - nBb * 300;
                    mBb = 1;
                    n6B1 = (int)(PMCK / 1500);
                    a6B1 = PMCK - n6B1 * 1500;
                    if (1350 <= a6B1 && a6B1 < 1500)
                    {
                        n6 = n6B1 + 2; a6 = a6B1 - 900 - 450;
                        na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                    }

                    else if (1200 <= a6B1 && a6B1 < 1350)
                    {
                        n6 = n6B1 + 1; a6 = a6B1 - 1200;
                        na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                    }
                    else if (1050 <= a6B1 && a6B1 < 1200)
                    {
                        n6 = n6B1 + 1; a6 = a6B1 - 1050;
                        na6B1 = n6; aa6B1 = a6; ma6B1 = 3;

                    }
                    else if (900 <= a6B1 && a6B1 < 1050)
                    {
                        n6 = n6B1 + 1; a6 = a6B1 - 900;
                        na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                    }
                    else if (750 <= a6B1 && a6B1 < 900)
                    {
                        n6 = n6B1 + 1; a6 = a6B1 - 750;
                        na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                    }
                    else if (600 <= a6B1 && a6B1 < 750)
                    {
                        n6 = n6B1 + 1; a6 = a6B1 - 600;
                        na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                    }
                    else if (450 <= a6B1 && a6B1 < 600)
                    {
                        n6 = n6B1 + 1; a6 = a6B1 - 450;
                        na6B1 = n6; aa6B1 = a6; ma6B1 = 2;

                    }
                    else if (a6B1 < 450)
                    {
                        na6B1 = n6B1; aa6B1 = a6B1; ma6B1 = 1;

                    }
                    #endregion
                    #region  计算过程
                    N3 = nL16L1 * nBb + na6b * na6B1; M3 = mL16L1 * mBb + ma6b * ma6B1; A3 = aBb * PMCC + aa6b * (PMCC - aBb);
                    fm.C1 = N3;
                    fm.C2 = M3;
                    fm.C3 = A3;
                    #endregion
                   #region  竖横混合排列  宽度方向
                MBCCC = 1500;
                n6B1 = (int)(PMCC / MBCCC);
                a6B1 = PMCC - n6B1 * MBCCC;
                nB16B1 = n6B1; aB16B1 = a6B1; mB16B1 = 1; 
                if (1350 <= a6B1 && a6B1 < 1500)
                {
                    n6 = n6B1 + 2; a6 = a6B1 - 900 - 450;
                    if (100 <= a6 && a6 < 150)
                    {

                        n6 = 2; a6 = a6 - 100;
                        na6b = n6;
                        aa6b = a6;
                        ma6b = 1;
                    }
                }
                else if (1200 <= a6B1 && a6B1 < 1350)
                {
                    n6 = n6B1 + 1; a6 = a6B1 - 1200;
                    if (100 <= a6 && a6 < 150)
                    {

                        n6 = 2; a6 = a6 - 100;
                        na6b = n6;
                        aa6b = a6;
                        ma6b = 1;
                    }
                }
                else if (1050 <= a6B1 && a6B1 < 1200)
                {
                    n6 = 2; a6 = a6B1 - 100;
                    na6b = n6;
                    aa6b = a6;
                    ma6b = 1;
                }
                else if (900 <= a6B1 && a6B1 < 1050)
                {
                    n6 = 2; a6 = a6B1 - 100;
                    na6b = n6;
                    aa6b = a6;
                    ma6b = 1;
                }
                else if (750 <= a6B1 && a6B1 < 900)
                {
                    n6 = 2; a6 = a6B1 - 100;
                    na6b = n6;
                    aa6b = a6;
                    ma6b = 1;
                }
                else if (600 <= a6B1 && a6B1 < 750)
                {
                    n6 = 2; a6 = a6B1 - 100;
                    na6b = n6;
                    aa6b = a6;
                    ma6b = 1;
                }
                else if (450 <= a6B1 && a6B1 < 600)
                {
                    n6 = 2; a6 = a6B1 - 100;
                    na6b = n6;
                    aa6b = a6;
                    ma6b = 1;
                }
                else  if (400 <= a6B1 && a6B1 < 450)
                {
                    n6 = 2; a6 = a6B1 - n6 * 200;
                    na6b = n6; aa6b = a6; ma6b = 1;
                }

                else if (350 <= a6B1 && a6B1 < 400)
                {
                    n6 = 2; a6 = a6B1 - 350;
                    na6b = n6; aa6b = a6; ma6b = 2;
                }
                else if (300 <= a6B1 && a6B1 < 350)
                {
                    n6 = 2; a6 = a6B1 - 300;
                    na6b = n6; aa6b = a6; ma6b = 1;
                }

                else if (250 <= a6B1 && a6B1 < 300)
                {
                    n6 = 2; a6 = a6B1 - 250;
                    na6b = n6; aa6b = a6; ma6b = 1;
                }

                else if (200 <= a6B1 && a6B1 < 250)
                {
                    n6 = 2; a6 = a6B1 - 200;
                    na6b = n6; aa6b = a6; ma6b = 1;
                }

                else if (150 <= a6B1 && a6B1 < 200)
                {
                    n6 = 2; a6 = a6B1 - 150;
                    na6b = n6; aa6b = a6; ma6b = 1;
                }

                else if (100 <= a6B1 && a6B1 < 150)
                {
                    n6 = 2; a6 = a6B1 - 100;
                    na6b = n6; aa6b = a6; ma6b = 1;
                }
                else if(a6B1<100)
                {
                    n6 = 2; a6 = a6B1;
                    na6b = n6; aa6b = a6; ma6b = 1;
                }
                #endregion
                   #region 竖横混合 长度方向
                nLb = (int)(PMCK / 300);
                aLb = PMCK - nLb * 300;
                mLb = 1;
                n6L1 = (int)(PMCK / 1500);
                a6L1 = PMCK - n6L1 * 1500;
                if (1350 <= a6L1 && a6L1 < 1500)
                {
                    n6 = n6L1 + 2; a6 = a6L1 - 900 - 450;
                    na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                }

                else if (1200 <= a6L1 && a6L1 < 1350)
                {
                    n6 = n6L1 + 1; a6 = a6L1 - 1200;
                    na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                }


                else if (1050 <= a6L1 && a6L1 < 1200)
                {
                    n6 = n6L1 + 1; a6 = a6L1 - 1050;
                    na6L1 = n6; aa6L1 = a6; ma6L1 = 3;
                }
                else if (900 <= a6L1 && a6L1 < 1050)
                {
                    n6 = n6L1 + 1; a6 = a6L1 - 900;
                    na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                }
                else if (750 <= a6L1 && a6L1 < 900)
                {
                    n6 = n6L1 + 1; a6 = a6L1 - 750;
                    na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                }
                else if (600 <= a6L1 && a6L1 < 750)
                {
                    n6 = n6L1 + 1; a6 = a6L1 - 600;
                    na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                }
                else if (450 <= a6L1 && a6L1 < 600)
                {
                    n6 = n6L1 + 1; a6 = a6L1 - 450;
                    na6L1 = n6; aa6L1 = a6; ma6L1 = 2;
                }
                else if (a6L1 < 450)
                {
                    na6L1 = n6L1; aa6L1 = a6L1; ma6L1 = 1;
                }
                #endregion
                   #region 计算过程
               
                N4 = nB16B1 * nLb + na6b * na6L1;
                M4 = mB16B1 * mLb + ma6L1 * ma6b;
                A4 = aa6b * PMCC + aLb * (PMCK - aB16B1);
                fm.D1 = N4;
                fm.D2 = M4;
                fm.D3 = A4;
                #endregion
                  fm.PailieMode = 3;
                }
                fm.IsOneOrTwo = 0;
                fm.ShowDialog();

            }
            #endregion
            #region 情况二
            else if(checkBox5.Checked&&checkBox11.Checked)
            {
                if(this.comboBoxEx9.SelectedIndex==0)
                {
                   #region 全部横向排列 
                MBCCC = 1200;
                n5L1 = (int)(PMCC / MBCCC);
                a5L1 = PMCC - n5L1 * MBCCC;
                nL15L1 = n5L1; aL15L1 = a5L1;
                if(a5L1>=1050&&a5L1<1200)
                {
                    n7 = n5L1 + 1;
                    a7 = a5L1 - 600 - 450;
                    #region 此情况按横竖混合计算
                    if (a7>=100&&a7<150)
                    {
                        n7 = 2; a7 = a7 - 100;
                        na5b = n7;
                        aa5b = a7;
                        ma5b = 1;
                        #region 宽度方向
                        nBb = (int)(PMCK / 300);
                        aBb = PMCK - nBb * 300;
                        mBb = 1;
                        n5B1 = (int)(PMCK / 1200);
                        a5B1 = PMCK - n5B1 * 1200;

                        if (1050 <= a5B1 && a5B1 < 1200)
                        {
                            n7 = n5B1 + 1; a7 = a5B1 - 1050;
                            na5B1 = n6; aa5B1 = a6; ma5B1 = 3;

                        }
                        else if (900 <= a5B1 && a5B1 < 1050)
                        {
                            n7 = n5B1 + 1; a7 = a5B1 - 900;
                            na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                        }
                        else if (750 <= a5B1 && a5B1 < 900)
                        {
                            n7 = n5B1 + 1; a7 = a5B1 - 750;
                            na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                        }
                        else if (600 <= a5B1 && a5B1 < 750)
                        {
                            n7 = n5B1 + 1; a7 = a5B1 - 600;
                            na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                        }
                        else if (450 <= a5B1 && a5B1 < 600)
                        {
                            n7 = n5B1 + 1; a7 = a5B1 - 450;
                            na5B1 = n7; aa5B1 = a6; ma5B1 = 2;

                        }
                        else if (a5B1 < 450)
                        {
                            na5B1 = n5B1; aa5B1 = a5B1; ma5B1 = 1;

                        }
                        #endregion
                        #region  计算过程

                        N3 = nL15L1 * nBb + na5b * na5B1; M3 = mL15L1 * mBb + ma5B1 * ma5b; A3 = aBb * PMCC + aa5b * (PMCC - aBb);
                        fm.A1 = N3;
                        fm.A2 = M3;
                        fm.A3 = A3;
                        #endregion

                    }
                    #endregion
                    else if(a7<100)
                    {
                        nL15L1 = n7; aL15L1 = a7; mL15L1 = 3;
                        #region  宽度方向
                        MBCCK = 300;
                        n5 = (int)(PMCK / MBCCK);
                        a5 = PMCK - n5 * MBCCK;

                        if (a5 < 100)
                        {
                            nBb = n5; aBb = a5; mBb = 1;
                        }
                        else if (100 <= a5 && a5 < 150)
                        {
                            nBb = n5 + 1; aBb = a5 - 100; mBb = 2;
                        }
                        else if (150 <= a5 && a5 < 200)
                        {
                            nBb = n5 + 1; aBb = a5 - 150; mBb = 2;
                        }
                        else if (200 <= a5 && a5 < 250)
                        {
                            nBb = n5 + 1; aBb = a5 - 200; mBb = 2;
                        }
                        else if (250 <= a5 && a5 < 300)
                        {
                            nBb = n5 + 1; aBb = a5 - 250; mBb = 2;
                        }
                        #endregion
                        #region 计算过程
                        N1 = nL15L1 * nBb; M1 = mL15L1 * mBb; A1 = aL15L1 * PMCK + aBb * (PMCC - aL15L1);
                        fm.A1 = N1;
                        fm.A2 = M1;
                        fm.A3 = A1;
                        #endregion
                    }
                }
                else if (a5L1 >= 900 && a5L1 < 1050)
                {
                    n7 = n5L1 + 1;
                    a7 = a5L1 - 900;
                    
                    #region 此情况按横竖混合计算
                    if (a7 >= 100 && a7 < 150)
                    {
                        n7 = 2; a7 = a7 - 100;
                        na5b = n7;
                        aa5b = a7;
                        ma5b = 1;
                        #region 宽度方向
                        nBb = (int)(PMCK / 300);
                        aBb = PMCK - nBb * 300;
                        mBb = 1;
                        n5B1 = (int)(PMCK / 1200);
                        a5B1 = PMCK - n5B1 * 1200;

                        if (1050 <= a5B1 && a5B1 < 1200)
                        {
                            n7 = n5B1 + 1; a7 = a5B1 - 1050;
                            na5B1 = n6; aa5B1 = a6; ma5B1 = 3;

                        }
                        else if (900 <= a5B1 && a5B1 < 1050)
                        {
                            n7 = n5B1 + 1; a7 = a5B1 - 900;
                            na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                        }
                        else if (750 <= a5B1 && a5B1 < 900)
                        {
                            n7 = n5B1 + 1; a7 = a5B1 - 750;
                            na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                        }
                        else if (600 <= a5B1 && a5B1 < 750)
                        {
                            n7 = n5B1 + 1; a7 = a5B1 - 600;
                            na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                        }
                        else if (450 <= a5B1 && a5B1 < 600)
                        {
                            n7 = n5B1 + 1; a7 = a5B1 - 450;
                            na5B1 = n7; aa5B1 = a6; ma5B1 = 2;

                        }
                        else if (a5B1 < 450)
                        {
                            na5B1 = n5B1; aa5B1 = a5B1; ma5B1 = 1;

                        }
                        #endregion
                        #region  计算过程
                        N3 = nL15L1 * nBb + na5b * na5B1; M3 = mL15L1 * mBb + ma5B1 * ma5b; A3 = aBb * PMCC + aa5b * (PMCC - aBb);
                        fm.A1 = N3;
                        fm.A2 = M3;
                        fm.A3= A3;
                        #endregion

                    }
                    #endregion
                    else if (a7 < 100)
                    {
                        nL15L1 = n7; aL15L1 = a7; mL15L1 = 2;
                        #region  宽度方向
                        MBCCK = 300;
                        n5 = (int)(PMCK / MBCCK);
                        a5 = PMCK - n5 * MBCCK;

                        if (a5 < 100)
                        {
                            nBb = n5; aBb = a5; mBb = 1;
                        }
                        else if (100 <= a5 && a5 < 150)
                        {
                            nBb = n5 + 1; aBb = a5 - 100; mBb = 2;
                        }
                        else if (150 <= a5 && a5 < 200)
                        {
                            nBb = n5 + 1; aBb = a5 - 150; mBb = 2;
                        }
                        else if (200 <= a5 && a5 < 250)
                        {
                            nBb = n5 + 1; aBb = a5 - 200; mBb = 2;
                        }
                        else if (250 <= a5 && a5 < 300)
                        {
                            nBb = n5 + 1; aBb = a5 - 250; mBb = 2;
                        }
                        #endregion
                        #region 计算过程
                        N1 = nL15L1 * nBb; M1 = mL15L1 * mBb; A1 = aL15L1 * PMCK + aBb * (PMCC - aL15L1);
                        fm.A1 = N1;
                        fm.A2 = M1;
                        fm.A3 = A1;
                        #endregion
                    }
                }
                else if (a5L1 >= 750 && a5L1 < 900)
                {
                    n7 = n5L1 + 1;
                    a7 = a5L1 - 750;
                    #region 此情况按横竖混合计算
                    if (a7 >= 100 && a7 < 150)
                    {
                        n7 = 2; a7 = a7 - 100;
                        na5b = n7;
                        aa5b = a7;
                        ma5b = 1;
                        #region 宽度方向
                        nBb = (int)(PMCK / 300);
                        aBb = PMCK - nBb * 300;
                        mBb = 1;
                        n5B1 = (int)(PMCK / 1200);
                        a5B1 = PMCK - n5B1 * 1200;

                        if (1050 <= a5B1 && a5B1 < 1200)
                        {
                            n7 = n5B1 + 1; a7 = a5B1 - 1050;
                            na5B1 = n6; aa5B1 = a6; ma5B1 = 3;

                        }
                        else if (900 <= a5B1 && a5B1 < 1050)
                        {
                            n7 = n5B1 + 1; a7 = a5B1 - 900;
                            na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                        }
                        else if (750 <= a5B1 && a5B1 < 900)
                        {
                            n7 = n5B1 + 1; a7 = a5B1 - 750;
                            na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                        }
                        else if (600 <= a5B1 && a5B1 < 750)
                        {
                            n7 = n5B1 + 1; a7 = a5B1 - 600;
                            na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                        }
                        else if (450 <= a5B1 && a5B1 < 600)
                        {
                            n7 = n5B1 + 1; a7 = a5B1 - 450;
                            na5B1 = n7; aa5B1 = a6; ma5B1 = 2;

                        }
                        else if (a5B1 < 450)
                        {
                            na5B1 = n5B1; aa5B1 = a5B1; ma5B1 = 1;

                        }
                        #endregion
                        #region  计算过程

                        N3 = nL15L1 * nBb + na5b * na5B1; M3 = mL15L1 * mBb + ma5B1 * ma5b; A3 = aBb * PMCC + aa5b * (PMCC - aBb);
                        fm.A1 = N3;
                        fm.A2 = M3;
                        fm.A3 = A3;
                        #endregion

                    }
                    #endregion
                    else if (a7 < 100)
                    {
                        nL15L1 = n7; aL15L1 = a7; mL15L1 = 2;
                        #region  宽度方向
                        MBCCK = 300;
                        n5 = (int)(PMCK / MBCCK);
                        a5 = PMCK - n5 * MBCCK;

                        if (a5 < 100)
                        {
                            nBb = n5; aBb = a5; mBb = 1;
                        }
                        else if (100 <= a5 && a5 < 150)
                        {
                            nBb = n5 + 1; aBb = a5 - 100; mBb = 2;
                        }
                        else if (150 <= a5 && a5 < 200)
                        {
                            nBb = n5 + 1; aBb = a5 - 150; mBb = 2;
                        }
                        else if (200 <= a5 && a5 < 250)
                        {
                            nBb = n5 + 1; aBb = a5 - 200; mBb = 2;
                        }
                        else if (250 <= a5 && a5 < 300)
                        {
                            nBb = n5 + 1; aBb = a5 - 250; mBb = 2;
                        }
                        #endregion
                        #region 计算过程
                        N1 = nL15L1 * nBb; M1 = mL15L1 * mBb; A1 = aL15L1 * PMCK + aBb * (PMCC - aL15L1);
                        fm.A1 = N1;
                        fm.A2 = M1;
                        fm.A3 = A1;
                        #endregion
                    }
                }
                else if (a5L1 >= 600 && a5L1 < 750)
                {
                    n7 = n5L1 + 1;
                    a7 = a5L1 - 600;
                    #region 此情况按横竖混合计算
                    if (a7 >= 100 && a7 < 150)
                    {
                        n7 = 2; a7 = a7 - 100;
                        na5b = n7;
                        aa5b = a7;
                        ma5b = 1;
                        #region 宽度方向
                        nBb = (int)(PMCK / 300);
                        aBb = PMCK - nBb * 300;
                        mBb = 1;
                        n5B1 = (int)(PMCK / 1200);
                        a5B1 = PMCK - n5B1 * 1200;

                        if (1050 <= a5B1 && a5B1 < 1200)
                        {
                            n7 = n5B1 + 1; a7 = a5B1 - 1050;
                            na5B1 = n6; aa5B1 = a6; ma5B1 = 3;

                        }
                        else if (900 <= a5B1 && a5B1 < 1050)
                        {
                            n7 = n5B1 + 1; a7 = a5B1 - 900;
                            na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                        }
                        else if (750 <= a5B1 && a5B1 < 900)
                        {
                            n7 = n5B1 + 1; a7 = a5B1 - 750;
                            na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                        }
                        else if (600 <= a5B1 && a5B1 < 750)
                        {
                            n7 = n5B1 + 1; a7 = a5B1 - 600;
                            na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                        }
                        else if (450 <= a5B1 && a5B1 < 600)
                        {
                            n7 = n5B1 + 1; a7 = a5B1 - 450;
                            na5B1 = n7; aa5B1 = a6; ma5B1 = 2;

                        }
                        else if (a5B1 < 450)
                        {
                            na5B1 = n5B1; aa5B1 = a5B1; ma5B1 = 1;

                        }
                        #endregion
                        #region  计算过程
                        N3 = nL15L1 * nBb + na5b * na5B1; M3 = mL15L1 * mBb + ma5B1 * ma5b; A3 = aBb * PMCC + aa5b * (PMCC - aBb);
                        fm.A1= N3;
                        fm.A2 = M3;
                        fm.A3 = A3;
                        #endregion

                    }
                    #endregion
                    else if (a7 < 100)
                    {
                        nL15L1 = n7; aL15L1 = a7; mL15L1 = 2;
                        #region  宽度方向
                        MBCCK = 300;
                        n5 = (int)(PMCK / MBCCK);
                        a5 = PMCK - n5 * MBCCK;

                        if (a5 < 100)
                        {
                            nBb = n5; aBb = a5; mBb = 1;
                        }
                        else if (100 <= a5 && a5 < 150)
                        {
                            nBb = n5 + 1; aBb = a5 - 100; mBb = 2;
                        }
                        else if (150 <= a5 && a5 < 200)
                        {
                            nBb = n5 + 1; aBb = a5 - 150; mBb = 2;
                        }
                        else if (200 <= a5 && a5 < 250)
                        {
                            nBb = n5 + 1; aBb = a5 - 200; mBb = 2;
                        }
                        else if (250 <= a5 && a5 < 300)
                        {
                            nBb = n5 + 1; aBb = a5 - 250; mBb = 2;
                        }
                        #endregion
                        #region 计算过程
                        N1 = nL15L1 * nBb; M1 = mL15L1 * mBb; A1 = aL15L1 * PMCK + aBb * (PMCC - aL15L1);
                        fm.A1 = N1;
                        fm.A2 = M1;
                        fm.A3 = A1;
                        #endregion
                  
                    }
                }
                else if (a5L1 >= 450 && a5L1 < 600)
                {
                    n7 = n5L1 + 1;
                    a7 = a5L1 - 450;
                    #region 此情况按横竖混合计算
                    if (a7 >= 100 && a7 < 150)
                    {
                        n7 = 2; a7 = a7 - 100;
                        na5b = n7;
                        aa5b = a7;
                        ma5b = 1;
                        #region 宽度方向
                        nBb = (int)(PMCK / 300);
                        aBb = PMCK - nBb * 300;
                        mBb = 1;
                        n5B1 = (int)(PMCK / 1200);
                        a5B1 = PMCK - n5B1 * 1200;

                        if (1050 <= a5B1 && a5B1 < 1200)
                        {
                            n7 = n5B1 + 1; a7 = a5B1 - 1050;
                            na5B1 = n6; aa5B1 = a6; ma5B1 = 3;

                        }
                        else if (900 <= a5B1 && a5B1 < 1050)
                        {
                            n7 = n5B1 + 1; a7 = a5B1 - 900;
                            na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                        }
                        else if (750 <= a5B1 && a5B1 < 900)
                        {
                            n7 = n5B1 + 1; a7 = a5B1 - 750;
                            na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                        }
                        else if (600 <= a5B1 && a5B1 < 750)
                        {
                            n7 = n5B1 + 1; a7 = a5B1 - 600;
                            na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                        }
                        else if (450 <= a5B1 && a5B1 < 600)
                        {
                            n7 = n5B1 + 1; a7 = a5B1 - 450;
                            na5B1 = n7; aa5B1 = a6; ma5B1 = 2;

                        }
                        else if (a5B1 < 450)
                        {
                            na5B1 = n5B1; aa5B1 = a5B1; ma5B1 = 1;

                        }
                        #endregion
                        #region  计算过程

                        N3 = nL15L1 * nBb + na5b * na5B1; M3 = mL15L1 * mBb + ma5B1 * ma5b; A3 = aBb * PMCC + aa5b * (PMCC - aBb);
                        fm.A1 = N3;
                        fm.A2= M3;
                        fm.A3 = A3;
                        #endregion

                    }
                    #endregion
                    else if (a7 < 100)
                    {
                        nL15L1 = n7; aL15L1 = a7; mL15L1 = 2;
                        #region  宽度方向
                        MBCCK = 300;
                        n5 = (int)(PMCK / MBCCK);
                        a5 = PMCK - n5 * MBCCK;

                        if (a5 < 100)
                        {
                            nBb = n5; aBb = a5; mBb = 1;
                        }
                        else if (100 <= a5 && a5 < 150)
                        {
                            nBb = n5 + 1; aBb = a5 - 100; mBb = 2;
                        }
                        else if (150 <= a5 && a5 < 200)
                        {
                            nBb = n5 + 1; aBb = a5 - 150; mBb = 2;
                        }
                        else if (200 <= a5 && a5 < 250)
                        {
                            nBb = n5 + 1; aBb = a5 - 200; mBb = 2;
                        }
                        else if (250 <= a5 && a5 < 300)
                        {
                            nBb = n5 + 1; aBb = a5 - 250; mBb = 2;
                        }
                        #endregion
                        #region 计算过程
                        N1 = nL15L1 * nBb; M1 = mL15L1 * mBb; A1 = aL15L1 * PMCK + aBb * (PMCC - aL15L1);
                        fm.A1 = N1;
                        fm.A2 = M1;
                        fm.A3 = A1;
                        #endregion
                    }
                }
                else if (a5L1 >= 100 && a5L1 < 450)
                {
                    #region 此过程按横竖混合计算
                    #region 长度方向
                    if (400 <= a5L1 && a5L1 < 450)
                    {
                        n7 = 2; a7 = a5L1 - n7 * 200;
                        na5b = n7;
                        aa5b = a7;
                        ma5b = 1;
                    }
                    else if (350 <= a5L1 && a5L1 < 400)
                    {
                        n7 = 2; a7 = a5L1 - 350;
                        na5b = n7;
                        aa5b = a7;
                        ma5b = 2;
                    }
                    else if (300 <= a5L1 && a5L1 < 350)
                    {
                        n7 = 2; a7 = a5L1 - 300;
                        na5b = n7;
                        aa5b = a7;
                        ma5b = 1;
                    }

                    else if (250 <= a5L1 && a5L1 < 300)
                    {
                        n7 = 2; a7 = a6L1 - 250;
                        na5b = n7;
                        aa5b = a7;
                        ma5b = 1;
                    }
                    else if (200 <= a5L1 && a5L1 < 250)
                    {
                        n7 = 2; a7 = a5L1 - 200;
                        na5b = n7;
                        aa5b = a7;
                        ma5b = 1;
                    }
                    else if (150 <= a5L1 && a5L1 < 200)
                    {
                        n7 = 2; a7 = a5L1 - 150;
                        na5b = n7;
                        aa5b = a7;
                        ma5b = 1;
                    }
                    else if (100 <= a5L1 && a5L1 < 150)
                    {
                        n7 = 2; a7 = a5L1 - 100;
                        na5b = n7;
                        aa5b = a7;
                        ma5b = 1;
                    }
                    #endregion 
                    #region 宽度方向
                    nBb = (int)(PMCK / 300);
                    aBb = PMCK - nBb * 300;
                    mBb = 1;
                    n5B1 = (int)(PMCK / 1200);
                    a5B1 = PMCK - n5B1 * 1200;

                    if (1050 <= a5B1 && a5B1 < 1200)
                    {
                        n7 = n5B1 + 1; a7 = a5B1 - 1050;
                        na5B1 = n6; aa5B1 = a6; ma5B1 = 3;

                    }
                    else if (900 <= a5B1 && a5B1 < 1050)
                    {
                        n7 = n5B1 + 1; a7 = a5B1 - 900;
                        na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                    }
                    else if (750 <= a5B1 && a5B1 < 900)
                    {
                        n7 = n5B1 + 1; a7 = a5B1 - 750;
                        na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                    }
                    else if (600 <= a5B1 && a5B1 < 750)
                    {
                        n7 = n5B1 + 1; a7 = a5B1 - 600;
                        na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                    }
                    else if (450 <= a5B1 && a5B1 < 600)
                    {
                        n7 = n5B1 + 1; a7 = a5B1 - 450;
                        na5B1 = n7; aa5B1 = a6; ma5B1 = 2;

                    }
                    else if (a5B1 < 450)
                    {
                        na5B1 = n5B1; aa5B1 = a5B1; ma5B1 = 1;

                    }
                    #endregion
                    #region  计算过程

                    N3 = nL15L1 * nBb + na5b * na5B1; M3 = mL15L1 * mBb + ma5B1 * ma5b; A3 = aBb * PMCC + aa5b * (PMCC - aBb);
                    fm.A1 = N3;
                    fm.A2 = M3;
                    fm.A3 = A3;
                    #endregion
                    #endregion
                }
                else if (a5L1<100)
                {
                    nL15L1 = n5L1; aL15L1 = a5L1; mL15L1 = 2;
                    #region  宽度方向
                    MBCCK = 300;
                    n5 = (int)(PMCK / MBCCK);
                    a5 = PMCK - n5 * MBCCK;

                    if (a5 < 100)
                    {
                        nBb = n5; aBb = a5; mBb = 1;
                    }
                    else if (100 <= a5 && a5 < 150)
                    {
                        nBb = n5 + 1; aBb = a5 - 100; mBb = 2;
                    }
                    else if (150 <= a5 && a5 < 200)
                    {
                        nBb = n5 + 1; aBb = a5 - 150; mBb = 2;
                    }
                    else if (200 <= a5 && a5 < 250)
                    {
                        nBb = n5 + 1; aBb = a5 - 200; mBb = 2;
                    }
                    else if (250 <= a5 && a5 < 300)
                    {
                        nBb = n5 + 1; aBb = a5 - 250; mBb = 2;
                    }
                    #endregion
                    #region 计算过程
                    N1 = nL15L1 * nBb; M1 = mL15L1 * mBb; A1 = aL15L1 * PMCK + aBb * (PMCC - aL15L1);
                    fm.A1 = N1;
                    fm.A2 = M1;
                    fm.A3 = A1;
                    #endregion
                }
                #endregion
                   fm.PailieMode = 0;
                }
                if(this.comboBoxEx9.SelectedIndex==1)
                {
                   #region 全部竖向排列 
                n5B1 =(int)(PMCK / 1200);
                a5B1 = PMCK - n5B1 * 1200;
                nB15B1 = n5B1; aB15B1 = a5B1; mB15B1 = 1;
                if(a5B1>=1050&&a5B1<1200)
                {
                    n7 = n5B1 + 1;
                    a7 = a5B1 - 600 - 450;
                    #region 此过程按竖横混合排列计算
                    if (a7>=100&&a7<150)
                    {
                        n7 = 2;
                        a7 = a7- 100;
                        na5b = n7; aa5b = a7; ma5b = 1;
                        #region 长度方向
                        nLb = (int)(PMCK / 300);
                        aLb = PMCK - nLb * 300;
                        mLb = 1;
                        n5L1 = (int)(PMCK / 1200);
                        a5L1 = PMCK - n5L1 * 1200;
                        if (1050 <= a5L1 && a5L1 < 1200)
                        {
                            n7 = n5L1 + 1; a7 = a5L1 - 1050;
                            na5L1 = n7; aa5L1 = a7; ma5L1 = 3;
                        }
                        else if (900 <= a5L1 && a5L1 < 1050)
                        {
                            n7 = n5L1 + 1; a7 = a5L1 - 900;
                            na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                        }
                        else if (750 <= a5L1 && a5L1 < 900)
                        {
                            n7 = n5L1 + 1; a7 = a5L1 - 750;
                            na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                        }
                        else if (600 <= a5L1 && a5L1 < 750)
                        {
                            n7 = n5L1 + 1; a7 = a5L1 - 600;
                            na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                        }
                        else if (450 <= a5L1 && a5L1 < 600)
                        {
                            n7 = n5L1 + 1; a7 = a5L1 - 450;
                            na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                        }
                        else if (a5L1 < 450)
                        {
                            na5L1 = n5L1; aa5L1 = a5L1; ma5L1 = 1;
                        }
                        #endregion
                        #region 计算过程                    
                        N4 = nB15B1 * nLb + na5b * na5L1;
                        M4 = mB15B1 * mLb + ma5L1 * ma5b;
                        A4 = aa5b * PMCC + aLb * (PMCK - aB15B1);
                        fm.B1 = N4;
                        fm.B2 = M4;
                        fm.B3 = A4;
                        #endregion

                    }
                    #endregion
                    else if(a7<100)
                    {
                        nB15B1 = n7; aB15B1 = a7; mB15B1 = 3;
                        #region  长度方向
                        n5 = (int)(PMCC / 300);
                        a5 = PMCC - n5 * 300;
                        if (a5 < 100)
                        {
                            nLb = n5; aLb = a5; mLb = 1;
                        }
                        else if (100 <= a5 && a5 < 150)
                        {
                            nLb = n5 + 1; aLb = a5 - 100; mLb = 2;
                        }
                        else if (150 <= a5 && a5 < 200)
                        {
                            nLb = n5 + 1; aLb = a5 - 150; mLb = 2;
                        }
                        else if (200 <= a5 && a5 < 250)
                        {
                            nLb = n5 + 1; aLb = a5 - 200; mLb = 2;
                        }
                        else if (250 <= a5 && a5 < 300)
                        {
                            nLb = n5 + 1; aLb = a5 - 250; mLb = 2;
                        }
                        #endregion
                        #region 计算过程
                        N2 = nB15B1 * nLb; M2 = mB15B1 * mLb; A2 = aB15B1 * PMCK + aLb * (PMCC - aB15B1);
                        fm.B1 = N2;
                        fm.B2 = M2;
                        fm.B3 = A2;
                        #endregion 
                    }
                }
                else if (a5B1 >= 900 && a5B1 < 1050)
                {
                    n7 = n5B1 + 1;
                    a7 = a5B1 - 900;
                    if (a7 >= 100 && a7 < 150)
                    {
                        #region 此过程按竖横混合排列计算
                        if (a7 >= 100 && a7 < 150)
                        {
                            n7 = 2;
                            a7 = a7 - 100;
                            na5b = n7; aa5b = a7; ma5b = 1;
                            #region 长度方向
                            nLb = (int)(PMCK / 300);
                            aLb = PMCK - nLb * 300;
                            mLb = 1;
                            n5L1 = (int)(PMCK / 1200);
                            a5L1 = PMCK - n5L1 * 1200;
                            if (1050 <= a5L1 && a5L1 < 1200)
                            {
                                n7 = n5L1 + 1; a7 = a5L1 - 1050;
                                na5L1 = n7; aa5L1 = a7; ma5L1 = 3;
                            }
                            else if (900 <= a5L1 && a5L1 < 1050)
                            {
                                n7 = n5L1 + 1; a7 = a5L1 - 900;
                                na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                            }
                            else if (750 <= a5L1 && a5L1 < 900)
                            {
                                n7 = n5L1 + 1; a7 = a5L1 - 750;
                                na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                            }
                            else if (600 <= a5L1 && a5L1 < 750)
                            {
                                n7 = n5L1 + 1; a7 = a5L1 - 600;
                                na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                            }
                            else if (450 <= a5L1 && a5L1 < 600)
                            {
                                n7 = n5L1 + 1; a7 = a5L1 - 450;
                                na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                            }
                            else if (a5L1 < 450)
                            {
                                na5L1 = n5L1; aa5L1 = a5L1; ma5L1 = 1;
                            }
                            #endregion
                            #region 计算过程
                            N4 = nB15B1 * nLb + na5b * na5L1;
                            M4 = mB15B1 * mLb + ma5L1 * ma5b;
                            A4 = aa5b * PMCC + aLb * (PMCK - aB15B1);
                            fm.B1 = N4;
                            fm.B2 = M4;
                            fm.B3 = A4;
                            #endregion

                        }
                        #endregion
                    }
                    else if (a7 < 100)
                    {
                        nB15B1 = n7; aB15B1 = a7; mB15B1 = 2;
                        #region  长度方向
                        n5 = (int)(PMCC / 300);
                        a5 = PMCC - n5 * 300;
                        if (a5 < 100)
                        {
                            nLb = n5; aLb = a5; mLb = 1;
                        }
                        else if (100 <= a5 && a5 < 150)
                        {
                            nLb = n5 + 1; aLb = a5 - 100; mLb = 2;
                        }
                        else if (150 <= a5 && a5 < 200)
                        {
                            nLb = n5 + 1; aLb = a5 - 150; mLb = 2;
                        }
                        else if (200 <= a5 && a5 < 250)
                        {
                            nLb = n5 + 1; aLb = a5 - 200; mLb = 2;
                        }
                        else if (250 <= a5 && a5 < 300)
                        {
                            nLb = n5 + 1; aLb = a5 - 250; mLb = 2;
                        }
                        #endregion
                        #region 计算过程
                        N2 = nB15B1 * nLb; M2 = mB15B1 * mLb; A2 = aB15B1 * PMCK + aLb * (PMCC - aB15B1);
                        fm.B1 = N2;
                        fm.B2 = M2;
                        fm.B3 = A2;
                        #endregion 
                    }
                }
                else if (a5B1 >= 750 && a5B1 < 900)
                {
                    n7 = n5B1 + 1;
                    a7 = a5B1 - 750;
                    if (a7 >= 100 && a7 < 150)
                    {
                        #region 此过程按竖横混合排列计算
                        if (a7 >= 100 && a7 < 150)
                        {
                            n7 = 2;
                            a7 = a7 - 100;
                            na5b = n7; aa5b = a7; ma5b = 1;
                            #region 长度方向
                            nLb = (int)(PMCK / 300);
                            aLb = PMCK - nLb * 300;
                            mLb = 1;
                            n5L1 = (int)(PMCK / 1200);
                            a5L1 = PMCK - n5L1 * 1200;
                            if (1050 <= a5L1 && a5L1 < 1200)
                            {
                                n7 = n5L1 + 1; a7 = a5L1 - 1050;
                                na5L1 = n7; aa5L1 = a7; ma5L1 = 3;
                            }
                            else if (900 <= a5L1 && a5L1 < 1050)
                            {
                                n7 = n5L1 + 1; a7 = a5L1 - 900;
                                na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                            }
                            else if (750 <= a5L1 && a5L1 < 900)
                            {
                                n7 = n5L1 + 1; a7 = a5L1 - 750;
                                na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                            }
                            else if (600 <= a5L1 && a5L1 < 750)
                            {
                                n7 = n5L1 + 1; a7 = a5L1 - 600;
                                na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                            }
                            else if (450 <= a5L1 && a5L1 < 600)
                            {
                                n7 = n5L1 + 1; a7 = a5L1 - 450;
                                na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                            }
                            else if (a5L1 < 450)
                            {
                                na5L1 = n5L1; aa5L1 = a5L1; ma5L1 = 1;
                            }
                            #endregion
                            #region 计算过程
                            N4 = nB15B1 * nLb + na5b * na5L1;
                            M4 = mB15B1 * mLb + ma5L1 * ma5b;
                            A4 = aa5b * PMCC + aLb * (PMCK - aB15B1);
                            fm.B1 = N4;
                            fm.B2 = M4;
                            fm.B3= A4;
                            #endregion

                        }
                        #endregion
                    }
                    else if (a7 < 100)
                    {
                        nB15B1 = n7; aB15B1 = a7; mB15B1 = 2;
                        #region  长度方向
                        n5 = (int)(PMCC / 300);
                        a5 = PMCC - n5 * 300;
                        if (a5 < 100)
                        {
                            nLb = n5; aLb = a5; mLb = 1;
                        }
                        else if (100 <= a5 && a5 < 150)
                        {
                            nLb = n5 + 1; aLb = a5 - 100; mLb = 2;
                        }
                        else if (150 <= a5 && a5 < 200)
                        {
                            nLb = n5 + 1; aLb = a5 - 150; mLb = 2;
                        }
                        else if (200 <= a5 && a5 < 250)
                        {
                            nLb = n5 + 1; aLb = a5 - 200; mLb = 2;
                        }
                        else if (250 <= a5 && a5 < 300)
                        {
                            nLb = n5 + 1; aLb = a5 - 250; mLb = 2;
                        }
                        #endregion
                        #region 计算过程
                        N2 = nB15B1 * nLb; M2 = mB15B1 * mLb; A2 = aB15B1 * PMCK + aLb * (PMCC - aB15B1);
                        fm.B1 = N2;
                        fm.B2 = M2;
                        fm.B3 = A2;
                        #endregion 
                    }
                }
                else if (a5B1 >= 600 && a5B1 < 750)
                {
                    n7 = n5B1 + 1;
                    a7 = a5B1 - 600;
                    if (a7 >= 100 && a7 < 150)
                    {
                        #region 此过程按竖横混合排列计算
                        if (a7 >= 100 && a7 < 150)
                        {
                            n7 = 2;
                            a7 = a7 - 100;
                            na5b = n7; aa5b = a7; ma5b = 1;
                            #region 长度方向
                            nLb = (int)(PMCK / 300);
                            aLb = PMCK - nLb * 300;
                            mLb = 1;
                            n5L1 = (int)(PMCK / 1200);
                            a5L1 = PMCK - n5L1 * 1200;
                            if (1050 <= a5L1 && a5L1 < 1200)
                            {
                                n7 = n5L1 + 1; a7 = a5L1 - 1050;
                                na5L1 = n7; aa5L1 = a7; ma5L1 = 3;
                            }
                            else if (900 <= a5L1 && a5L1 < 1050)
                            {
                                n7 = n5L1 + 1; a7 = a5L1 - 900;
                                na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                            }
                            else if (750 <= a5L1 && a5L1 < 900)
                            {
                                n7 = n5L1 + 1; a7 = a5L1 - 750;
                                na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                            }
                            else if (600 <= a5L1 && a5L1 < 750)
                            {
                                n7 = n5L1 + 1; a7 = a5L1 - 600;
                                na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                            }
                            else if (450 <= a5L1 && a5L1 < 600)
                            {
                                n7 = n5L1 + 1; a7 = a5L1 - 450;
                                na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                            }
                            else if (a5L1 < 450)
                            {
                                na5L1 = n5L1; aa5L1 = a5L1; ma5L1 = 1;
                            }
                            #endregion
                            #region 计算过程
                            N4 = nB15B1 * nLb + na5b * na5L1;
                            M4 = mB15B1 * mLb + ma5L1 * ma5b;
                            A4 = aa5b * PMCC + aLb * (PMCK - aB15B1);
                            fm.B1 = N4;
                            fm.B2 = M4;
                            fm.B3 = A4;
                            #endregion

                        }
                        #endregion
                    }
                    else if (a7 < 100)
                    {
                        nB15B1 = n7; aB15B1 = a7; mB15B1 = 2;
                        #region  长度方向
                        n5 = (int)(PMCC / 300);
                        a5 = PMCC - n5 * 300;
                        if (a5 < 100)
                        {
                            nLb = n5; aLb = a5; mLb = 1;
                        }
                        else if (100 <= a5 && a5 < 150)
                        {
                            nLb = n5 + 1; aLb = a5 - 100; mLb = 2;
                        }
                        else if (150 <= a5 && a5 < 200)
                        {
                            nLb = n5 + 1; aLb = a5 - 150; mLb = 2;
                        }
                        else if (200 <= a5 && a5 < 250)
                        {
                            nLb = n5 + 1; aLb = a5 - 200; mLb = 2;
                        }
                        else if (250 <= a5 && a5 < 300)
                        {
                            nLb = n5 + 1; aLb = a5 - 250; mLb = 2;
                        }
                        #endregion
                        #region 计算过程
                        N2 = nB15B1 * nLb; M2 = mB15B1 * mLb; A2 = aB15B1 * PMCK + aLb * (PMCC - aB15B1);
                        fm.B1 = N2;
                        fm.B2 = M2;
                        fm.B3 = A2;
                        #endregion 
                    }
                }
                else if (a5B1 >= 450 && a5B1 < 600)
                {
                    n7 = n5B1 + 1;
                    a7 = a5B1 - 450;
                    if (a7 >= 100 && a7 < 150)
                    {
                        #region 此过程按竖横混合排列计算
                        if (a7 >= 100 && a7 < 150)
                        {
                            n7 = 2;
                            a7 = a7 - 100;
                            na5b = n7; aa5b = a7; ma5b = 1;
                            #region 长度方向
                            nLb = (int)(PMCK / 300);
                            aLb = PMCK - nLb * 300;
                            mLb = 1;
                            n5L1 = (int)(PMCK / 1200);
                            a5L1 = PMCK - n5L1 * 1200;
                            if (1050 <= a5L1 && a5L1 < 1200)
                            {
                                n7 = n5L1 + 1; a7 = a5L1 - 1050;
                                na5L1 = n7; aa5L1 = a7; ma5L1 = 3;
                            }
                            else if (900 <= a5L1 && a5L1 < 1050)
                            {
                                n7 = n5L1 + 1; a7 = a5L1 - 900;
                                na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                            }
                            else if (750 <= a5L1 && a5L1 < 900)
                            {
                                n7 = n5L1 + 1; a7 = a5L1 - 750;
                                na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                            }
                            else if (600 <= a5L1 && a5L1 < 750)
                            {
                                n7 = n5L1 + 1; a7 = a5L1 - 600;
                                na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                            }
                            else if (450 <= a5L1 && a5L1 < 600)
                            {
                                n7 = n5L1 + 1; a7 = a5L1 - 450;
                                na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                            }
                            else if (a5L1 < 450)
                            {
                                na5L1 = n5L1; aa5L1 = a5L1; ma5L1 = 1;
                            }
                            #endregion
                            #region 计算过程
                            N4 = nB15B1 * nLb + na5b * na5L1;
                            M4 = mB15B1 * mLb + ma5L1 * ma5b;
                            A4 = aa5b * PMCC + aLb * (PMCK - aB15B1);
                            fm.B1 = N4;
                            fm.B2 = M4;
                            fm.B3 = A4;
                            #endregion

                        }
                        #endregion
                    }
                    else if (a7 < 100)
                    {
                        nB15B1 = n7; aB15B1 = a7; mB15B1 = 2;
                        #region  长度方向
                        n5 = (int)(PMCC / 300);
                        a5 = PMCC - n5 * 300;
                        if (a5 < 100)
                        {
                            nLb = n5; aLb = a5; mLb = 1;
                        }
                        else if (100 <= a5 && a5 < 150)
                        {
                            nLb = n5 + 1; aLb = a5 - 100; mLb = 2;
                        }
                        else if (150 <= a5 && a5 < 200)
                        {
                            nLb = n5 + 1; aLb = a5 - 150; mLb = 2;
                        }
                        else if (200 <= a5 && a5 < 250)
                        {
                            nLb = n5 + 1; aLb = a5 - 200; mLb = 2;
                        }
                        else if (250 <= a5 && a5 < 300)
                        {
                            nLb = n5 + 1; aLb = a5 - 250; mLb = 2;
                        }
                        #endregion
                        #region 计算过程
                        N2 = nB15B1 * nLb; M2 = mB15B1 * mLb; A2 = aB15B1 * PMCK + aLb * (PMCC - aB15B1);
                        fm.B1 = N2;
                        fm.B2 = M2;
                        fm.B3 = A2;
                        #endregion 
                    }
                }
                else if (a5B1 >= 100 && a5B1 < 450)
                {
                    #region 此过程按竖横混合计算
                    #region 宽度方向
                    if (400 <= a5B1 && a5B1 < 450)
                    {
                        n7 = 2; a7 = a5B1 - n7 * 200;
                        na5b = n7; aa5b = a7; ma5b = 1;
                    }

                    else if (350 <= a5B1 && a5B1 < 400)
                    {
                        n7 = 2; a7 = a5B1 - 350;
                        na5b = n7; aa5b = a7; ma5b = 2;
                    }
                    else if (300 <= a5B1 && a5B1 < 350)
                    {
                        n7 = 2; a7 = a5B1 - 300;
                        na5b = n7; aa5b = a7; ma5b = 1;
                    }

                    else if (250 <= a5B1 && a5B1 < 300)
                    {
                        n7 = 2; a7 = a5B1 - 250;
                        na5b = n7; aa5b = a7; ma5b = 1;
                    }

                    else if (200 <= a5B1 && a5B1 < 250)
                    {
                        n7 = 2; a7 = a5B1 - 200;
                        na5b = n7; aa5b = a7; ma5b = 1;
                    }

                    else if (150 <= a5B1 && a5B1 < 200)
                    {
                        n7 = 2; a7 = a5B1 - 150;
                        na5b = n7; aa5b = a7; ma5b = 1;
                    }

                    else if (100 <= a5B1 && a5B1 < 150)
                    {
                        n7 = 2; a7 = a5B1 - 100;
                        na5b = n7; aa5b = a7; ma5b = 1;
                    }
                    #endregion
                    #region 长度方向
                    nLb = (int)(PMCK / 300);
                    aLb = PMCK - nLb * 300;
                    mLb = 1;
                    n5L1 = (int)(PMCK / 1200);
                    a5L1 = PMCK - n5L1 * 1200;
                    if (1050 <= a5L1 && a5L1 < 1200)
                    {
                        n7 = n5L1 + 1; a7 = a5L1 - 1050;
                        na5L1 = n7; aa5L1 = a7; ma5L1 = 3;
                    }
                    else if (900 <= a5L1 && a5L1 < 1050)
                    {
                        n7 = n5L1 + 1; a7 = a5L1 - 900;
                        na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                    }
                    else if (750 <= a5L1 && a5L1 < 900)
                    {
                        n7 = n5L1 + 1; a7 = a5L1 - 750;
                        na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                    }
                    else if (600 <= a5L1 && a5L1 < 750)
                    {
                        n7 = n5L1 + 1; a7 = a5L1 - 600;
                        na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                    }
                    else if (450 <= a5L1 && a5L1 < 600)
                    {
                        n7 = n5L1 + 1; a7 = a5L1 - 450;
                        na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                    }
                    else if (a5L1 < 450)
                    {
                        na5L1 = n5L1; aa5L1 = a5L1; ma5L1 = 1;
                    }
                    #endregion
                    #region 计算过
                    N4 = nB15B1 * nLb + na5b * na5L1;
                    M4 = mB15B1 * mLb + ma5L1 * ma5b;
                    A4 = aa5b * PMCC + aLb * (PMCK - aB15B1);
                    fm.B1 = N4;
                    fm.B2 = M4;
                    fm.B3 = A4;
                    #endregion
                    #endregion
                }
                else if (a5B1<100)
                {
                    nB15B1 = n5B1; aB15B1 = a5B1; mB15B1 = 1;
                    #region  长度方向
                    n5 = (int)(PMCC / 300);
                    a5 = PMCC - n5 * 300;
                    if (a5 < 100)
                    {
                        nLb = n5; aLb = a5; mLb = 1;
                    }
                    else if (100 <= a5 && a5 < 150)
                    {
                        nLb = n5 + 1; aLb = a5 - 100; mLb = 2;
                    }
                    else if (150 <= a5 && a5 < 200)
                    {
                        nLb = n5 + 1; aLb = a5 - 150; mLb = 2;
                    }
                    else if (200 <= a5 && a5 < 250)
                    {
                        nLb = n5 + 1; aLb = a5 - 200; mLb = 2;
                    }
                    else if (250 <= a5 && a5 < 300)
                    {
                        nLb = n5 + 1; aLb = a5 - 250; mLb = 2;
                    }
                    #endregion
                    #region 计算过程
                    N2 = nB15B1 * nLb; M2 = mB15B1 * mLb; A2 = aB15B1 * PMCK + aLb * (PMCC - aB15B1);
                    fm.B1 = N2;
                    fm.B2 = M2;
                    fm.B3 = A2;
                    #endregion 
                }
                #endregion
                  fm.PailieMode = 1;
                }
                if(this.comboBoxEx9.SelectedIndex==2)
                {
                   #region 横竖混合排列 先横后竖 长度方向
                 MBCCC = 1200;
                 n5L1 = (int)(PMCC / MBCCC);
                 a5L1 = PMCC - n5L1 * MBCCC; na5b = 0; ma5b = 0;
                 nL15L1 = n5L1; aL15L1 = a5L1; mL15L1 = 1;
                 if (400 <= a5L1 && a5L1 < 450)
                 {
                     n7 = 2; a7 = a5L1 - n7 * 200;
                     na5b = n7;
                     aa5b = a7;
                     ma5b = 1;
                 }
                 else if (350 <= a5L1 && a5L1 < 400)
                 {
                     n7 = 2; a7 = a5L1 - 350;
                     na5b = n7;
                     aa5b = a7;
                     ma5b = 2;
                 }
                 else if (300 <= a5L1 && a5L1 < 350)
                 {
                     n7 = 2; a7 = a5L1 - 300;
                     na5b = n7;
                     aa5b = a7;
                     ma5b = 1;
                 }

                 else if (250 <= a5L1 && a5L1 < 300)
                 {
                     n7 = 2; a7= a6L1 - 250;
                     na5b = n7;
                     aa5b = a7;
                     ma5b = 1;
                 }
                 else if (200 <= a5L1 && a5L1 < 250)
                 {
                     n7 = 2; a7 = a5L1 - 200;
                     na5b = n7;
                     aa5b = a7;
                     ma5b = 1;
                 }
                 else if (150 <= a5L1 && a5L1 < 200)
                 {
                     n7 = 2; a7 = a5L1 - 150;
                     na5b = n7;
                     aa5b = a7;
                     ma5b = 1;
                 }
                 else if (100 <= a5L1 && a5L1 < 150)
                 {
                     n7 = 2; a7 = a5L1 - 100;
                     na5b = n7;
                     aa5b = a7;
                     ma5b = 1;
                 }
                #endregion
                   #region 宽度方向
                 nBb = (int)(PMCK / 300);
                 aBb = PMCK - nBb * 300;
                 mBb = 1;
                 n5B1 = (int)(PMCK / 1200);
                 a5B1 = PMCK - n5B1 * 1200;
                 
                 if (1050 <= a5B1 && a5B1 < 1200)
                 {
                     n7 = n5B1 + 1; a7 = a5B1 - 1050;
                     na5B1 = n6; aa5B1 = a6; ma5B1 = 3;

                 }
                 else if (900 <= a5B1 && a5B1 < 1050)
                 {
                     n7 = n5B1 + 1; a7= a5B1 - 900;
                     na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                 }
                 else if (750 <= a5B1 && a5B1 < 900)
                 {
                     n7 = n5B1 + 1; a7 = a5B1 - 750;
                     na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                 }
                 else if (600 <= a5B1 && a5B1 < 750)
                 {
                     n7 = n5B1 + 1; a7 = a5B1 - 600;
                     na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                 }
                 else if (450 <= a5B1 && a5B1 < 600)
                 {
                     n7= n5B1 + 1; a7 = a5B1 - 450;
                     na5B1 = n7; aa5B1 = a6; ma5B1 = 2;

                 }
                 else if (a5B1 < 450)
                 {
                     na5B1 = n5B1; aa5B1 = a5B1; ma5B1 = 1;

                 }
                #endregion
                   #region  计算过程
               
                 N3 = nL15L1 * nBb+na5b*na5B1; M3 = mL15L1 * mBb+ma5B1*ma5b; A3 = aBb * PMCC + aa5b * (PMCC - aBb);
                 fm.C1 = N3;
                 fm.C2 = M3;
                 fm.C3 = A3;
                #endregion
                  fm.PailieMode = 2;
                }
                if(this.comboBoxEx9.SelectedIndex==3)
                {
                    #region 全部横向排列
                    MBCCC = 1200;
                    n5L1 = (int)(PMCC / MBCCC);
                    a5L1 = PMCC - n5L1 * MBCCC;
                    nL15L1 = n5L1; aL15L1 = a5L1;
                    if (a5L1 >= 1050 && a5L1 < 1200)
                    {
                        n7 = n5L1 + 1;
                        a7 = a5L1 - 600 - 450;
                        #region 此情况按横竖混合计算
                        if (a7 >= 100 && a7 < 150)
                        {
                            n7 = 2; a7 = a7 - 100;
                            na5b = n7;
                            aa5b = a7;
                            ma5b = 1;
                            #region 宽度方向
                            nBb = (int)(PMCK / 300);
                            aBb = PMCK - nBb * 300;
                            mBb = 1;
                            n5B1 = (int)(PMCK / 1200);
                            a5B1 = PMCK - n5B1 * 1200;

                            if (1050 <= a5B1 && a5B1 < 1200)
                            {
                                n7 = n5B1 + 1; a7 = a5B1 - 1050;
                                na5B1 = n6; aa5B1 = a6; ma5B1 = 3;

                            }
                            else if (900 <= a5B1 && a5B1 < 1050)
                            {
                                n7 = n5B1 + 1; a7 = a5B1 - 900;
                                na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                            }
                            else if (750 <= a5B1 && a5B1 < 900)
                            {
                                n7 = n5B1 + 1; a7 = a5B1 - 750;
                                na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                            }
                            else if (600 <= a5B1 && a5B1 < 750)
                            {
                                n7 = n5B1 + 1; a7 = a5B1 - 600;
                                na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                            }
                            else if (450 <= a5B1 && a5B1 < 600)
                            {
                                n7 = n5B1 + 1; a7 = a5B1 - 450;
                                na5B1 = n7; aa5B1 = a6; ma5B1 = 2;

                            }
                            else if (a5B1 < 450)
                            {
                                na5B1 = n5B1; aa5B1 = a5B1; ma5B1 = 1;

                            }
                            #endregion
                            #region  计算过程

                            N3 = nL15L1 * nBb + na5b * na5B1; M3 = mL15L1 * mBb + ma5B1 * ma5b; A3 = aBb * PMCC + aa5b * (PMCC - aBb);
                            fm.A1 = N3;
                            fm.A2 = M3;
                            fm.A3 = A3;
                            #endregion

                        }
                        #endregion
                        else if (a7 < 100)
                        {
                            nL15L1 = n7; aL15L1 = a7; mL15L1 = 3;
                            #region  宽度方向
                            MBCCK = 300;
                            n5 = (int)(PMCK / MBCCK);
                            a5 = PMCK - n5 * MBCCK;

                            if (a5 < 100)
                            {
                                nBb = n5; aBb = a5; mBb = 1;
                            }
                            else if (100 <= a5 && a5 < 150)
                            {
                                nBb = n5 + 1; aBb = a5 - 100; mBb = 2;
                            }
                            else if (150 <= a5 && a5 < 200)
                            {
                                nBb = n5 + 1; aBb = a5 - 150; mBb = 2;
                            }
                            else if (200 <= a5 && a5 < 250)
                            {
                                nBb = n5 + 1; aBb = a5 - 200; mBb = 2;
                            }
                            else if (250 <= a5 && a5 < 300)
                            {
                                nBb = n5 + 1; aBb = a5 - 250; mBb = 2;
                            }
                            #endregion
                            #region 计算过程
                            N1 = nL15L1 * nBb; M1 = mL15L1 * mBb; A1 = aL15L1 * PMCK + aBb * (PMCC - aL15L1);
                            fm.A1 = N1;
                            fm.A2 = M1;
                            fm.A3 = A1;
                            #endregion
                        }
                    }
                    else if (a5L1 >= 900 && a5L1 < 1050)
                    {
                        n7 = n5L1 + 1;
                        a7 = a5L1 - 900;

                        #region 此情况按横竖混合计算
                        if (a7 >= 100 && a7 < 150)
                        {
                            n7 = 2; a7 = a7 - 100;
                            na5b = n7;
                            aa5b = a7;
                            ma5b = 1;
                            #region 宽度方向
                            nBb = (int)(PMCK / 300);
                            aBb = PMCK - nBb * 300;
                            mBb = 1;
                            n5B1 = (int)(PMCK / 1200);
                            a5B1 = PMCK - n5B1 * 1200;

                            if (1050 <= a5B1 && a5B1 < 1200)
                            {
                                n7 = n5B1 + 1; a7 = a5B1 - 1050;
                                na5B1 = n6; aa5B1 = a6; ma5B1 = 3;

                            }
                            else if (900 <= a5B1 && a5B1 < 1050)
                            {
                                n7 = n5B1 + 1; a7 = a5B1 - 900;
                                na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                            }
                            else if (750 <= a5B1 && a5B1 < 900)
                            {
                                n7 = n5B1 + 1; a7 = a5B1 - 750;
                                na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                            }
                            else if (600 <= a5B1 && a5B1 < 750)
                            {
                                n7 = n5B1 + 1; a7 = a5B1 - 600;
                                na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                            }
                            else if (450 <= a5B1 && a5B1 < 600)
                            {
                                n7 = n5B1 + 1; a7 = a5B1 - 450;
                                na5B1 = n7; aa5B1 = a6; ma5B1 = 2;

                            }
                            else if (a5B1 < 450)
                            {
                                na5B1 = n5B1; aa5B1 = a5B1; ma5B1 = 1;

                            }
                            #endregion
                            #region  计算过程
                            N3 = nL15L1 * nBb + na5b * na5B1; M3 = mL15L1 * mBb + ma5B1 * ma5b; A3 = aBb * PMCC + aa5b * (PMCC - aBb);
                            fm.A1 = N3;
                            fm.A2 = M3;
                            fm.A3 = A3;
                            #endregion

                        }
                        #endregion
                        else if (a7 < 100)
                        {
                            nL15L1 = n7; aL15L1 = a7; mL15L1 = 2;
                            #region  宽度方向
                            MBCCK = 300;
                            n5 = (int)(PMCK / MBCCK);
                            a5 = PMCK - n5 * MBCCK;

                            if (a5 < 100)
                            {
                                nBb = n5; aBb = a5; mBb = 1;
                            }
                            else if (100 <= a5 && a5 < 150)
                            {
                                nBb = n5 + 1; aBb = a5 - 100; mBb = 2;
                            }
                            else if (150 <= a5 && a5 < 200)
                            {
                                nBb = n5 + 1; aBb = a5 - 150; mBb = 2;
                            }
                            else if (200 <= a5 && a5 < 250)
                            {
                                nBb = n5 + 1; aBb = a5 - 200; mBb = 2;
                            }
                            else if (250 <= a5 && a5 < 300)
                            {
                                nBb = n5 + 1; aBb = a5 - 250; mBb = 2;
                            }
                            #endregion
                            #region 计算过程
                            N1 = nL15L1 * nBb; M1 = mL15L1 * mBb; A1 = aL15L1 * PMCK + aBb * (PMCC - aL15L1);
                            fm.A1 = N1;
                            fm.A2 = M1;
                            fm.A3 = A1;
                            #endregion
                        }
                    }
                    else if (a5L1 >= 750 && a5L1 < 900)
                    {
                        n7 = n5L1 + 1;
                        a7 = a5L1 - 750;
                        #region 此情况按横竖混合计算
                        if (a7 >= 100 && a7 < 150)
                        {
                            n7 = 2; a7 = a7 - 100;
                            na5b = n7;
                            aa5b = a7;
                            ma5b = 1;
                            #region 宽度方向
                            nBb = (int)(PMCK / 300);
                            aBb = PMCK - nBb * 300;
                            mBb = 1;
                            n5B1 = (int)(PMCK / 1200);
                            a5B1 = PMCK - n5B1 * 1200;

                            if (1050 <= a5B1 && a5B1 < 1200)
                            {
                                n7 = n5B1 + 1; a7 = a5B1 - 1050;
                                na5B1 = n6; aa5B1 = a6; ma5B1 = 3;

                            }
                            else if (900 <= a5B1 && a5B1 < 1050)
                            {
                                n7 = n5B1 + 1; a7 = a5B1 - 900;
                                na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                            }
                            else if (750 <= a5B1 && a5B1 < 900)
                            {
                                n7 = n5B1 + 1; a7 = a5B1 - 750;
                                na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                            }
                            else if (600 <= a5B1 && a5B1 < 750)
                            {
                                n7 = n5B1 + 1; a7 = a5B1 - 600;
                                na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                            }
                            else if (450 <= a5B1 && a5B1 < 600)
                            {
                                n7 = n5B1 + 1; a7 = a5B1 - 450;
                                na5B1 = n7; aa5B1 = a6; ma5B1 = 2;

                            }
                            else if (a5B1 < 450)
                            {
                                na5B1 = n5B1; aa5B1 = a5B1; ma5B1 = 1;

                            }
                            #endregion
                            #region  计算过程

                            N3 = nL15L1 * nBb + na5b * na5B1; M3 = mL15L1 * mBb + ma5B1 * ma5b; A3 = aBb * PMCC + aa5b * (PMCC - aBb);
                            fm.A1 = N3;
                            fm.A2 = M3;
                            fm.A3 = A3;
                            #endregion

                        }
                        #endregion
                        else if (a7 < 100)
                        {
                            nL15L1 = n7; aL15L1 = a7; mL15L1 = 2;
                            #region  宽度方向
                            MBCCK = 300;
                            n5 = (int)(PMCK / MBCCK);
                            a5 = PMCK - n5 * MBCCK;

                            if (a5 < 100)
                            {
                                nBb = n5; aBb = a5; mBb = 1;
                            }
                            else if (100 <= a5 && a5 < 150)
                            {
                                nBb = n5 + 1; aBb = a5 - 100; mBb = 2;
                            }
                            else if (150 <= a5 && a5 < 200)
                            {
                                nBb = n5 + 1; aBb = a5 - 150; mBb = 2;
                            }
                            else if (200 <= a5 && a5 < 250)
                            {
                                nBb = n5 + 1; aBb = a5 - 200; mBb = 2;
                            }
                            else if (250 <= a5 && a5 < 300)
                            {
                                nBb = n5 + 1; aBb = a5 - 250; mBb = 2;
                            }
                            #endregion
                            #region 计算过程
                            N1 = nL15L1 * nBb; M1 = mL15L1 * mBb; A1 = aL15L1 * PMCK + aBb * (PMCC - aL15L1);
                            fm.A1 = N1;
                            fm.A2 = M1;
                            fm.A3 = A1;
                            #endregion
                        }
                    }
                    else if (a5L1 >= 600 && a5L1 < 750)
                    {
                        n7 = n5L1 + 1;
                        a7 = a5L1 - 600;
                        #region 此情况按横竖混合计算
                        if (a7 >= 100 && a7 < 150)
                        {
                            n7 = 2; a7 = a7 - 100;
                            na5b = n7;
                            aa5b = a7;
                            ma5b = 1;
                            #region 宽度方向
                            nBb = (int)(PMCK / 300);
                            aBb = PMCK - nBb * 300;
                            mBb = 1;
                            n5B1 = (int)(PMCK / 1200);
                            a5B1 = PMCK - n5B1 * 1200;

                            if (1050 <= a5B1 && a5B1 < 1200)
                            {
                                n7 = n5B1 + 1; a7 = a5B1 - 1050;
                                na5B1 = n6; aa5B1 = a6; ma5B1 = 3;

                            }
                            else if (900 <= a5B1 && a5B1 < 1050)
                            {
                                n7 = n5B1 + 1; a7 = a5B1 - 900;
                                na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                            }
                            else if (750 <= a5B1 && a5B1 < 900)
                            {
                                n7 = n5B1 + 1; a7 = a5B1 - 750;
                                na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                            }
                            else if (600 <= a5B1 && a5B1 < 750)
                            {
                                n7 = n5B1 + 1; a7 = a5B1 - 600;
                                na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                            }
                            else if (450 <= a5B1 && a5B1 < 600)
                            {
                                n7 = n5B1 + 1; a7 = a5B1 - 450;
                                na5B1 = n7; aa5B1 = a6; ma5B1 = 2;

                            }
                            else if (a5B1 < 450)
                            {
                                na5B1 = n5B1; aa5B1 = a5B1; ma5B1 = 1;

                            }
                            #endregion
                            #region  计算过程
                            N3 = nL15L1 * nBb + na5b * na5B1; M3 = mL15L1 * mBb + ma5B1 * ma5b; A3 = aBb * PMCC + aa5b * (PMCC - aBb);
                            fm.A1 = N3;
                            fm.A2 = M3;
                            fm.A3 = A3;
                            #endregion

                        }
                        #endregion
                        else if (a7 < 100)
                        {
                            nL15L1 = n7; aL15L1 = a7; mL15L1 = 2;
                            #region  宽度方向
                            MBCCK = 300;
                            n5 = (int)(PMCK / MBCCK);
                            a5 = PMCK - n5 * MBCCK;

                            if (a5 < 100)
                            {
                                nBb = n5; aBb = a5; mBb = 1;
                            }
                            else if (100 <= a5 && a5 < 150)
                            {
                                nBb = n5 + 1; aBb = a5 - 100; mBb = 2;
                            }
                            else if (150 <= a5 && a5 < 200)
                            {
                                nBb = n5 + 1; aBb = a5 - 150; mBb = 2;
                            }
                            else if (200 <= a5 && a5 < 250)
                            {
                                nBb = n5 + 1; aBb = a5 - 200; mBb = 2;
                            }
                            else if (250 <= a5 && a5 < 300)
                            {
                                nBb = n5 + 1; aBb = a5 - 250; mBb = 2;
                            }
                            #endregion
                            #region 计算过程
                            N1 = nL15L1 * nBb; M1 = mL15L1 * mBb; A1 = aL15L1 * PMCK + aBb * (PMCC - aL15L1);
                            fm.A1 = N1;
                            fm.A2 = M1;
                            fm.A3 = A1;
                            #endregion

                        }
                    }
                    else if (a5L1 >= 450 && a5L1 < 600)
                    {
                        n7 = n5L1 + 1;
                        a7 = a5L1 - 450;
                        #region 此情况按横竖混合计算
                        if (a7 >= 100 && a7 < 150)
                        {
                            n7 = 2; a7 = a7 - 100;
                            na5b = n7;
                            aa5b = a7;
                            ma5b = 1;
                            #region 宽度方向
                            nBb = (int)(PMCK / 300);
                            aBb = PMCK - nBb * 300;
                            mBb = 1;
                            n5B1 = (int)(PMCK / 1200);
                            a5B1 = PMCK - n5B1 * 1200;

                            if (1050 <= a5B1 && a5B1 < 1200)
                            {
                                n7 = n5B1 + 1; a7 = a5B1 - 1050;
                                na5B1 = n6; aa5B1 = a6; ma5B1 = 3;

                            }
                            else if (900 <= a5B1 && a5B1 < 1050)
                            {
                                n7 = n5B1 + 1; a7 = a5B1 - 900;
                                na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                            }
                            else if (750 <= a5B1 && a5B1 < 900)
                            {
                                n7 = n5B1 + 1; a7 = a5B1 - 750;
                                na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                            }
                            else if (600 <= a5B1 && a5B1 < 750)
                            {
                                n7 = n5B1 + 1; a7 = a5B1 - 600;
                                na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                            }
                            else if (450 <= a5B1 && a5B1 < 600)
                            {
                                n7 = n5B1 + 1; a7 = a5B1 - 450;
                                na5B1 = n7; aa5B1 = a6; ma5B1 = 2;

                            }
                            else if (a5B1 < 450)
                            {
                                na5B1 = n5B1; aa5B1 = a5B1; ma5B1 = 1;

                            }
                            #endregion
                            #region  计算过程

                            N3 = nL15L1 * nBb + na5b * na5B1; M3 = mL15L1 * mBb + ma5B1 * ma5b; A3 = aBb * PMCC + aa5b * (PMCC - aBb);
                            fm.A1 = N3;
                            fm.A2 = M3;
                            fm.A3 = A3;
                            #endregion

                        }
                        #endregion
                        else if (a7 < 100)
                        {
                            nL15L1 = n7; aL15L1 = a7; mL15L1 = 2;
                            #region  宽度方向
                            MBCCK = 300;
                            n5 = (int)(PMCK / MBCCK);
                            a5 = PMCK - n5 * MBCCK;

                            if (a5 < 100)
                            {
                                nBb = n5; aBb = a5; mBb = 1;
                            }
                            else if (100 <= a5 && a5 < 150)
                            {
                                nBb = n5 + 1; aBb = a5 - 100; mBb = 2;
                            }
                            else if (150 <= a5 && a5 < 200)
                            {
                                nBb = n5 + 1; aBb = a5 - 150; mBb = 2;
                            }
                            else if (200 <= a5 && a5 < 250)
                            {
                                nBb = n5 + 1; aBb = a5 - 200; mBb = 2;
                            }
                            else if (250 <= a5 && a5 < 300)
                            {
                                nBb = n5 + 1; aBb = a5 - 250; mBb = 2;
                            }
                            #endregion
                            #region 计算过程
                            N1 = nL15L1 * nBb; M1 = mL15L1 * mBb; A1 = aL15L1 * PMCK + aBb * (PMCC - aL15L1);
                            fm.A1 = N1;
                            fm.A2 = M1;
                            fm.A3 = A1;
                            #endregion
                        }
                    }
                    else if (a5L1 >= 100 && a5L1 < 450)
                    {
                        #region 此过程按横竖混合计算
                        #region 长度方向
                        if (400 <= a5L1 && a5L1 < 450)
                        {
                            n7 = 2; a7 = a5L1 - n7 * 200;
                            na5b = n7;
                            aa5b = a7;
                            ma5b = 1;
                        }
                        else if (350 <= a5L1 && a5L1 < 400)
                        {
                            n7 = 2; a7 = a5L1 - 350;
                            na5b = n7;
                            aa5b = a7;
                            ma5b = 2;
                        }
                        else if (300 <= a5L1 && a5L1 < 350)
                        {
                            n7 = 2; a7 = a5L1 - 300;
                            na5b = n7;
                            aa5b = a7;
                            ma5b = 1;
                        }

                        else if (250 <= a5L1 && a5L1 < 300)
                        {
                            n7 = 2; a7 = a6L1 - 250;
                            na5b = n7;
                            aa5b = a7;
                            ma5b = 1;
                        }
                        else if (200 <= a5L1 && a5L1 < 250)
                        {
                            n7 = 2; a7 = a5L1 - 200;
                            na5b = n7;
                            aa5b = a7;
                            ma5b = 1;
                        }
                        else if (150 <= a5L1 && a5L1 < 200)
                        {
                            n7 = 2; a7 = a5L1 - 150;
                            na5b = n7;
                            aa5b = a7;
                            ma5b = 1;
                        }
                        else if (100 <= a5L1 && a5L1 < 150)
                        {
                            n7 = 2; a7 = a5L1 - 100;
                            na5b = n7;
                            aa5b = a7;
                            ma5b = 1;
                        }
                        #endregion
                        #region 宽度方向
                        nBb = (int)(PMCK / 300);
                        aBb = PMCK - nBb * 300;
                        mBb = 1;
                        n5B1 = (int)(PMCK / 1200);
                        a5B1 = PMCK - n5B1 * 1200;

                        if (1050 <= a5B1 && a5B1 < 1200)
                        {
                            n7 = n5B1 + 1; a7 = a5B1 - 1050;
                            na5B1 = n6; aa5B1 = a6; ma5B1 = 3;

                        }
                        else if (900 <= a5B1 && a5B1 < 1050)
                        {
                            n7 = n5B1 + 1; a7 = a5B1 - 900;
                            na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                        }
                        else if (750 <= a5B1 && a5B1 < 900)
                        {
                            n7 = n5B1 + 1; a7 = a5B1 - 750;
                            na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                        }
                        else if (600 <= a5B1 && a5B1 < 750)
                        {
                            n7 = n5B1 + 1; a7 = a5B1 - 600;
                            na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                        }
                        else if (450 <= a5B1 && a5B1 < 600)
                        {
                            n7 = n5B1 + 1; a7 = a5B1 - 450;
                            na5B1 = n7; aa5B1 = a6; ma5B1 = 2;

                        }
                        else if (a5B1 < 450)
                        {
                            na5B1 = n5B1; aa5B1 = a5B1; ma5B1 = 1;

                        }
                        #endregion
                        #region  计算过程

                        N3 = nL15L1 * nBb + na5b * na5B1; M3 = mL15L1 * mBb + ma5B1 * ma5b; A3 = aBb * PMCC + aa5b * (PMCC - aBb);
                        fm.A1 = N3;
                        fm.A2 = M3;
                        fm.A3 = A3;
                        #endregion
                        #endregion
                    }
                    else if (a5L1 < 100)
                    {
                        nL15L1 = n5L1; aL15L1 = a5L1; mL15L1 = 2;
                        #region  宽度方向
                        MBCCK = 300;
                        n5 = (int)(PMCK / MBCCK);
                        a5 = PMCK - n5 * MBCCK;

                        if (a5 < 100)
                        {
                            nBb = n5; aBb = a5; mBb = 1;
                        }
                        else if (100 <= a5 && a5 < 150)
                        {
                            nBb = n5 + 1; aBb = a5 - 100; mBb = 2;
                        }
                        else if (150 <= a5 && a5 < 200)
                        {
                            nBb = n5 + 1; aBb = a5 - 150; mBb = 2;
                        }
                        else if (200 <= a5 && a5 < 250)
                        {
                            nBb = n5 + 1; aBb = a5 - 200; mBb = 2;
                        }
                        else if (250 <= a5 && a5 < 300)
                        {
                            nBb = n5 + 1; aBb = a5 - 250; mBb = 2;
                        }
                        #endregion
                        #region 计算过程
                        N1 = nL15L1 * nBb; M1 = mL15L1 * mBb; A1 = aL15L1 * PMCK + aBb * (PMCC - aL15L1);
                        fm.A1 = N1;
                        fm.A2 = M1;
                        fm.A3 = A1;
                        #endregion
                    }
                    #endregion
                    #region 全部竖向排列
                    n5B1 = (int)(PMCK / 1200);
                    a5B1 = PMCK - n5B1 * 1200;
                    nB15B1 = n5B1; aB15B1 = a5B1; mB15B1 = 1;
                    if (a5B1 >= 1050 && a5B1 < 1200)
                    {
                        n7 = n5B1 + 1;
                        a7 = a5B1 - 600 - 450;
                        #region 此过程按竖横混合排列计算
                        if (a7 >= 100 && a7 < 150)
                        {
                            n7 = 2;
                            a7 = a7 - 100;
                            na5b = n7; aa5b = a7; ma5b = 1;
                            #region 长度方向
                            nLb = (int)(PMCK / 300);
                            aLb = PMCK - nLb * 300;
                            mLb = 1;
                            n5L1 = (int)(PMCK / 1200);
                            a5L1 = PMCK - n5L1 * 1200;
                            if (1050 <= a5L1 && a5L1 < 1200)
                            {
                                n7 = n5L1 + 1; a7 = a5L1 - 1050;
                                na5L1 = n7; aa5L1 = a7; ma5L1 = 3;
                            }
                            else if (900 <= a5L1 && a5L1 < 1050)
                            {
                                n7 = n5L1 + 1; a7 = a5L1 - 900;
                                na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                            }
                            else if (750 <= a5L1 && a5L1 < 900)
                            {
                                n7 = n5L1 + 1; a7 = a5L1 - 750;
                                na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                            }
                            else if (600 <= a5L1 && a5L1 < 750)
                            {
                                n7 = n5L1 + 1; a7 = a5L1 - 600;
                                na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                            }
                            else if (450 <= a5L1 && a5L1 < 600)
                            {
                                n7 = n5L1 + 1; a7 = a5L1 - 450;
                                na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                            }
                            else if (a5L1 < 450)
                            {
                                na5L1 = n5L1; aa5L1 = a5L1; ma5L1 = 1;
                            }
                            #endregion
                            #region 计算过程
                            N4 = nB15B1 * nLb + na5b * na5L1;
                            M4 = mB15B1 * mLb + ma5L1 * ma5b;
                            A4 = aa5b * PMCC + aLb * (PMCK - aB15B1);
                            fm.B1 = N4;
                            fm.B2 = M4;
                            fm.B3 = A4;
                            #endregion

                        }
                        #endregion
                        else if (a7 < 100)
                        {
                            nB15B1 = n7; aB15B1 = a7; mB15B1 = 3;
                            #region  长度方向
                            n5 = (int)(PMCC / 300);
                            a5 = PMCC - n5 * 300;
                            if (a5 < 100)
                            {
                                nLb = n5; aLb = a5; mLb = 1;
                            }
                            else if (100 <= a5 && a5 < 150)
                            {
                                nLb = n5 + 1; aLb = a5 - 100; mLb = 2;
                            }
                            else if (150 <= a5 && a5 < 200)
                            {
                                nLb = n5 + 1; aLb = a5 - 150; mLb = 2;
                            }
                            else if (200 <= a5 && a5 < 250)
                            {
                                nLb = n5 + 1; aLb = a5 - 200; mLb = 2;
                            }
                            else if (250 <= a5 && a5 < 300)
                            {
                                nLb = n5 + 1; aLb = a5 - 250; mLb = 2;
                            }
                            #endregion
                            #region 计算过程
                            N2 = nB15B1 * nLb; M2 = mB15B1 * mLb; A2 = aB15B1 * PMCK + aLb * (PMCC - aB15B1);
                            fm.B1 = N2;
                            fm.B2 = M2;
                            fm.B3 = A2;
                            #endregion
                        }
                    }
                    else if (a5B1 >= 900 && a5B1 < 1050)
                    {
                        n7 = n5B1 + 1;
                        a7 = a5B1 - 900;
                        if (a7 >= 100 && a7 < 150)
                        {
                            #region 此过程按竖横混合排列计算
                            if (a7 >= 100 && a7 < 150)
                            {
                                n7 = 2;
                                a7 = a7 - 100;
                                na5b = n7; aa5b = a7; ma5b = 1;
                                #region 长度方向
                                nLb = (int)(PMCK / 300);
                                aLb = PMCK - nLb * 300;
                                mLb = 1;
                                n5L1 = (int)(PMCK / 1200);
                                a5L1 = PMCK - n5L1 * 1200;
                                if (1050 <= a5L1 && a5L1 < 1200)
                                {
                                    n7 = n5L1 + 1; a7 = a5L1 - 1050;
                                    na5L1 = n7; aa5L1 = a7; ma5L1 = 3;
                                }
                                else if (900 <= a5L1 && a5L1 < 1050)
                                {
                                    n7 = n5L1 + 1; a7 = a5L1 - 900;
                                    na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                                }
                                else if (750 <= a5L1 && a5L1 < 900)
                                {
                                    n7 = n5L1 + 1; a7 = a5L1 - 750;
                                    na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                                }
                                else if (600 <= a5L1 && a5L1 < 750)
                                {
                                    n7 = n5L1 + 1; a7 = a5L1 - 600;
                                    na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                                }
                                else if (450 <= a5L1 && a5L1 < 600)
                                {
                                    n7 = n5L1 + 1; a7 = a5L1 - 450;
                                    na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                                }
                                else if (a5L1 < 450)
                                {
                                    na5L1 = n5L1; aa5L1 = a5L1; ma5L1 = 1;
                                }
                                #endregion
                                #region 计算过程
                                N4 = nB15B1 * nLb + na5b * na5L1;
                                M4 = mB15B1 * mLb + ma5L1 * ma5b;
                                A4 = aa5b * PMCC + aLb * (PMCK - aB15B1);
                                fm.B1 = N4;
                                fm.B2 = M4;
                                fm.B3 = A4;
                                #endregion

                            }
                            #endregion
                        }
                        else if (a7 < 100)
                        {
                            nB15B1 = n7; aB15B1 = a7; mB15B1 = 2;
                            #region  长度方向
                            n5 = (int)(PMCC / 300);
                            a5 = PMCC - n5 * 300;
                            if (a5 < 100)
                            {
                                nLb = n5; aLb = a5; mLb = 1;
                            }
                            else if (100 <= a5 && a5 < 150)
                            {
                                nLb = n5 + 1; aLb = a5 - 100; mLb = 2;
                            }
                            else if (150 <= a5 && a5 < 200)
                            {
                                nLb = n5 + 1; aLb = a5 - 150; mLb = 2;
                            }
                            else if (200 <= a5 && a5 < 250)
                            {
                                nLb = n5 + 1; aLb = a5 - 200; mLb = 2;
                            }
                            else if (250 <= a5 && a5 < 300)
                            {
                                nLb = n5 + 1; aLb = a5 - 250; mLb = 2;
                            }
                            #endregion
                            #region 计算过程
                            N2 = nB15B1 * nLb; M2 = mB15B1 * mLb; A2 = aB15B1 * PMCK + aLb * (PMCC - aB15B1);
                            fm.B1 = N2;
                            fm.B2 = M2;
                            fm.B3 = A2;
                            #endregion
                        }
                    }
                    else if (a5B1 >= 750 && a5B1 < 900)
                    {
                        n7 = n5B1 + 1;
                        a7 = a5B1 - 750;
                        if (a7 >= 100 && a7 < 150)
                        {
                            #region 此过程按竖横混合排列计算
                            if (a7 >= 100 && a7 < 150)
                            {
                                n7 = 2;
                                a7 = a7 - 100;
                                na5b = n7; aa5b = a7; ma5b = 1;
                                #region 长度方向
                                nLb = (int)(PMCK / 300);
                                aLb = PMCK - nLb * 300;
                                mLb = 1;
                                n5L1 = (int)(PMCK / 1200);
                                a5L1 = PMCK - n5L1 * 1200;
                                if (1050 <= a5L1 && a5L1 < 1200)
                                {
                                    n7 = n5L1 + 1; a7 = a5L1 - 1050;
                                    na5L1 = n7; aa5L1 = a7; ma5L1 = 3;
                                }
                                else if (900 <= a5L1 && a5L1 < 1050)
                                {
                                    n7 = n5L1 + 1; a7 = a5L1 - 900;
                                    na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                                }
                                else if (750 <= a5L1 && a5L1 < 900)
                                {
                                    n7 = n5L1 + 1; a7 = a5L1 - 750;
                                    na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                                }
                                else if (600 <= a5L1 && a5L1 < 750)
                                {
                                    n7 = n5L1 + 1; a7 = a5L1 - 600;
                                    na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                                }
                                else if (450 <= a5L1 && a5L1 < 600)
                                {
                                    n7 = n5L1 + 1; a7 = a5L1 - 450;
                                    na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                                }
                                else if (a5L1 < 450)
                                {
                                    na5L1 = n5L1; aa5L1 = a5L1; ma5L1 = 1;
                                }
                                #endregion
                                #region 计算过程
                                N4 = nB15B1 * nLb + na5b * na5L1;
                                M4 = mB15B1 * mLb + ma5L1 * ma5b;
                                A4 = aa5b * PMCC + aLb * (PMCK - aB15B1);
                                fm.B1 = N4;
                                fm.B2 = M4;
                                fm.B3 = A4;
                                #endregion

                            }
                            #endregion
                        }
                        else if (a7 < 100)
                        {
                            nB15B1 = n7; aB15B1 = a7; mB15B1 = 2;
                            #region  长度方向
                            n5 = (int)(PMCC / 300);
                            a5 = PMCC - n5 * 300;
                            if (a5 < 100)
                            {
                                nLb = n5; aLb = a5; mLb = 1;
                            }
                            else if (100 <= a5 && a5 < 150)
                            {
                                nLb = n5 + 1; aLb = a5 - 100; mLb = 2;
                            }
                            else if (150 <= a5 && a5 < 200)
                            {
                                nLb = n5 + 1; aLb = a5 - 150; mLb = 2;
                            }
                            else if (200 <= a5 && a5 < 250)
                            {
                                nLb = n5 + 1; aLb = a5 - 200; mLb = 2;
                            }
                            else if (250 <= a5 && a5 < 300)
                            {
                                nLb = n5 + 1; aLb = a5 - 250; mLb = 2;
                            }
                            #endregion
                            #region 计算过程
                            N2 = nB15B1 * nLb; M2 = mB15B1 * mLb; A2 = aB15B1 * PMCK + aLb * (PMCC - aB15B1);
                            fm.B1 = N2;
                            fm.B2 = M2;
                            fm.B3 = A2;
                            #endregion
                        }
                    }
                    else if (a5B1 >= 600 && a5B1 < 750)
                    {
                        n7 = n5B1 + 1;
                        a7 = a5B1 - 600;
                        if (a7 >= 100 && a7 < 150)
                        {
                            #region 此过程按竖横混合排列计算
                            if (a7 >= 100 && a7 < 150)
                            {
                                n7 = 2;
                                a7 = a7 - 100;
                                na5b = n7; aa5b = a7; ma5b = 1;
                                #region 长度方向
                                nLb = (int)(PMCK / 300);
                                aLb = PMCK - nLb * 300;
                                mLb = 1;
                                n5L1 = (int)(PMCK / 1200);
                                a5L1 = PMCK - n5L1 * 1200;
                                if (1050 <= a5L1 && a5L1 < 1200)
                                {
                                    n7 = n5L1 + 1; a7 = a5L1 - 1050;
                                    na5L1 = n7; aa5L1 = a7; ma5L1 = 3;
                                }
                                else if (900 <= a5L1 && a5L1 < 1050)
                                {
                                    n7 = n5L1 + 1; a7 = a5L1 - 900;
                                    na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                                }
                                else if (750 <= a5L1 && a5L1 < 900)
                                {
                                    n7 = n5L1 + 1; a7 = a5L1 - 750;
                                    na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                                }
                                else if (600 <= a5L1 && a5L1 < 750)
                                {
                                    n7 = n5L1 + 1; a7 = a5L1 - 600;
                                    na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                                }
                                else if (450 <= a5L1 && a5L1 < 600)
                                {
                                    n7 = n5L1 + 1; a7 = a5L1 - 450;
                                    na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                                }
                                else if (a5L1 < 450)
                                {
                                    na5L1 = n5L1; aa5L1 = a5L1; ma5L1 = 1;
                                }
                                #endregion
                                #region 计算过程
                                N4 = nB15B1 * nLb + na5b * na5L1;
                                M4 = mB15B1 * mLb + ma5L1 * ma5b;
                                A4 = aa5b * PMCC + aLb * (PMCK - aB15B1);
                                fm.B1 = N4;
                                fm.B2 = M4;
                                fm.B3 = A4;
                                #endregion

                            }
                            #endregion
                        }
                        else if (a7 < 100)
                        {
                            nB15B1 = n7; aB15B1 = a7; mB15B1 = 2;
                            #region  长度方向
                            n5 = (int)(PMCC / 300);
                            a5 = PMCC - n5 * 300;
                            if (a5 < 100)
                            {
                                nLb = n5; aLb = a5; mLb = 1;
                            }
                            else if (100 <= a5 && a5 < 150)
                            {
                                nLb = n5 + 1; aLb = a5 - 100; mLb = 2;
                            }
                            else if (150 <= a5 && a5 < 200)
                            {
                                nLb = n5 + 1; aLb = a5 - 150; mLb = 2;
                            }
                            else if (200 <= a5 && a5 < 250)
                            {
                                nLb = n5 + 1; aLb = a5 - 200; mLb = 2;
                            }
                            else if (250 <= a5 && a5 < 300)
                            {
                                nLb = n5 + 1; aLb = a5 - 250; mLb = 2;
                            }
                            #endregion
                            #region 计算过程
                            N2 = nB15B1 * nLb; M2 = mB15B1 * mLb; A2 = aB15B1 * PMCK + aLb * (PMCC - aB15B1);
                            fm.B1 = N2;
                            fm.B2 = M2;
                            fm.B3 = A2;
                            #endregion
                        }
                    }
                    else if (a5B1 >= 450 && a5B1 < 600)
                    {
                        n7 = n5B1 + 1;
                        a7 = a5B1 - 450;
                        if (a7 >= 100 && a7 < 150)
                        {
                            #region 此过程按竖横混合排列计算
                            if (a7 >= 100 && a7 < 150)
                            {
                                n7 = 2;
                                a7 = a7 - 100;
                                na5b = n7; aa5b = a7; ma5b = 1;
                                #region 长度方向
                                nLb = (int)(PMCK / 300);
                                aLb = PMCK - nLb * 300;
                                mLb = 1;
                                n5L1 = (int)(PMCK / 1200);
                                a5L1 = PMCK - n5L1 * 1200;
                                if (1050 <= a5L1 && a5L1 < 1200)
                                {
                                    n7 = n5L1 + 1; a7 = a5L1 - 1050;
                                    na5L1 = n7; aa5L1 = a7; ma5L1 = 3;
                                }
                                else if (900 <= a5L1 && a5L1 < 1050)
                                {
                                    n7 = n5L1 + 1; a7 = a5L1 - 900;
                                    na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                                }
                                else if (750 <= a5L1 && a5L1 < 900)
                                {
                                    n7 = n5L1 + 1; a7 = a5L1 - 750;
                                    na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                                }
                                else if (600 <= a5L1 && a5L1 < 750)
                                {
                                    n7 = n5L1 + 1; a7 = a5L1 - 600;
                                    na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                                }
                                else if (450 <= a5L1 && a5L1 < 600)
                                {
                                    n7 = n5L1 + 1; a7 = a5L1 - 450;
                                    na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                                }
                                else if (a5L1 < 450)
                                {
                                    na5L1 = n5L1; aa5L1 = a5L1; ma5L1 = 1;
                                }
                                #endregion
                                #region 计算过程
                                N4 = nB15B1 * nLb + na5b * na5L1;
                                M4 = mB15B1 * mLb + ma5L1 * ma5b;
                                A4 = aa5b * PMCC + aLb * (PMCK - aB15B1);
                                fm.B1 = N4;
                                fm.B2 = M4;
                                fm.B3 = A4;
                                #endregion

                            }
                            #endregion
                        }
                        else if (a7 < 100)
                        {
                            nB15B1 = n7; aB15B1 = a7; mB15B1 = 2;
                            #region  长度方向
                            n5 = (int)(PMCC / 300);
                            a5 = PMCC - n5 * 300;
                            if (a5 < 100)
                            {
                                nLb = n5; aLb = a5; mLb = 1;
                            }
                            else if (100 <= a5 && a5 < 150)
                            {
                                nLb = n5 + 1; aLb = a5 - 100; mLb = 2;
                            }
                            else if (150 <= a5 && a5 < 200)
                            {
                                nLb = n5 + 1; aLb = a5 - 150; mLb = 2;
                            }
                            else if (200 <= a5 && a5 < 250)
                            {
                                nLb = n5 + 1; aLb = a5 - 200; mLb = 2;
                            }
                            else if (250 <= a5 && a5 < 300)
                            {
                                nLb = n5 + 1; aLb = a5 - 250; mLb = 2;
                            }
                            #endregion
                            #region 计算过程
                            N2 = nB15B1 * nLb; M2 = mB15B1 * mLb; A2 = aB15B1 * PMCK + aLb * (PMCC - aB15B1);
                            fm.B1 = N2;
                            fm.B2 = M2;
                            fm.B3 = A2;
                            #endregion
                        }
                    }
                    else if (a5B1 >= 100 && a5B1 < 450)
                    {
                        #region 此过程按竖横混合计算
                        #region 宽度方向
                        if (400 <= a5B1 && a5B1 < 450)
                        {
                            n7 = 2; a7 = a5B1 - n7 * 200;
                            na5b = n7; aa5b = a7; ma5b = 1;
                        }

                        else if (350 <= a5B1 && a5B1 < 400)
                        {
                            n7 = 2; a7 = a5B1 - 350;
                            na5b = n7; aa5b = a7; ma5b = 2;
                        }
                        else if (300 <= a5B1 && a5B1 < 350)
                        {
                            n7 = 2; a7 = a5B1 - 300;
                            na5b = n7; aa5b = a7; ma5b = 1;
                        }

                        else if (250 <= a5B1 && a5B1 < 300)
                        {
                            n7 = 2; a7 = a5B1 - 250;
                            na5b = n7; aa5b = a7; ma5b = 1;
                        }

                        else if (200 <= a5B1 && a5B1 < 250)
                        {
                            n7 = 2; a7 = a5B1 - 200;
                            na5b = n7; aa5b = a7; ma5b = 1;
                        }

                        else if (150 <= a5B1 && a5B1 < 200)
                        {
                            n7 = 2; a7 = a5B1 - 150;
                            na5b = n7; aa5b = a7; ma5b = 1;
                        }

                        else if (100 <= a5B1 && a5B1 < 150)
                        {
                            n7 = 2; a7 = a5B1 - 100;
                            na5b = n7; aa5b = a7; ma5b = 1;
                        }
                        #endregion
                        #region 长度方向
                        nLb = (int)(PMCK / 300);
                        aLb = PMCK - nLb * 300;
                        mLb = 1;
                        n5L1 = (int)(PMCK / 1200);
                        a5L1 = PMCK - n5L1 * 1200;
                        if (1050 <= a5L1 && a5L1 < 1200)
                        {
                            n7 = n5L1 + 1; a7 = a5L1 - 1050;
                            na5L1 = n7; aa5L1 = a7; ma5L1 = 3;
                        }
                        else if (900 <= a5L1 && a5L1 < 1050)
                        {
                            n7 = n5L1 + 1; a7 = a5L1 - 900;
                            na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                        }
                        else if (750 <= a5L1 && a5L1 < 900)
                        {
                            n7 = n5L1 + 1; a7 = a5L1 - 750;
                            na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                        }
                        else if (600 <= a5L1 && a5L1 < 750)
                        {
                            n7 = n5L1 + 1; a7 = a5L1 - 600;
                            na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                        }
                        else if (450 <= a5L1 && a5L1 < 600)
                        {
                            n7 = n5L1 + 1; a7 = a5L1 - 450;
                            na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                        }
                        else if (a5L1 < 450)
                        {
                            na5L1 = n5L1; aa5L1 = a5L1; ma5L1 = 1;
                        }
                        #endregion
                        #region 计算过
                        N4 = nB15B1 * nLb + na5b * na5L1;
                        M4 = mB15B1 * mLb + ma5L1 * ma5b;
                        A4 = aa5b * PMCC + aLb * (PMCK - aB15B1);
                        fm.B1 = N4;
                        fm.B2 = M4;
                        fm.B3 = A4;
                        #endregion
                        #endregion
                    }
                    else if (a5B1 < 100)
                    {
                        nB15B1 = n5B1; aB15B1 = a5B1; mB15B1 = 1;
                        #region  长度方向
                        n5 = (int)(PMCC / 300);
                        a5 = PMCC - n5 * 300;
                        if (a5 < 100)
                        {
                            nLb = n5; aLb = a5; mLb = 1;
                        }
                        else if (100 <= a5 && a5 < 150)
                        {
                            nLb = n5 + 1; aLb = a5 - 100; mLb = 2;
                        }
                        else if (150 <= a5 && a5 < 200)
                        {
                            nLb = n5 + 1; aLb = a5 - 150; mLb = 2;
                        }
                        else if (200 <= a5 && a5 < 250)
                        {
                            nLb = n5 + 1; aLb = a5 - 200; mLb = 2;
                        }
                        else if (250 <= a5 && a5 < 300)
                        {
                            nLb = n5 + 1; aLb = a5 - 250; mLb = 2;
                        }
                        #endregion
                        #region 计算过程
                        N2 = nB15B1 * nLb; M2 = mB15B1 * mLb; A2 = aB15B1 * PMCK + aLb * (PMCC - aB15B1);
                        fm.B1 = N2;
                        fm.B2 = M2;
                        fm.B3 = A2;
                        #endregion
                    }
                    #endregion
                    #region 横竖混合排列 先横后竖 长度方向
                    MBCCC = 1200;
                    n5L1 = (int)(PMCC / MBCCC);
                    a5L1 = PMCC - n5L1 * MBCCC; na5b = 0; ma5b = 0;
                    nL15L1 = n5L1; aL15L1 = a5L1; mL15L1 = 1;
                    if (1350 <= a5L1 && a5L1 < 1500)
                    {
                        n7 = n5L1 + 2; a7 = a5L1 - 900 - 450;
                        if (100 <= a7 && a6 < 150)
                        {

                            n7 = 2; a7 = a7 - 100;
                            na5b = n7;
                            aa5b = a7;
                            ma5b = 1;
                        }
                    }
                    else if (1200 <= a5L1 && a5L1 < 1350)
                    {
                        n7 = n5L1 + 1; a7= a5L1 - 1200;
                        if (100 <= a7 && a7< 150)
                        {

                            n7 = 2; a7 = a7 - 100;
                            na5b = n7;
                            aa5b = a7;
                            ma5b = 1;
                        }
                    }
                    else if (1050 <= a5L1 && a5L1 < 1200)
                    {
                        n7= 2; a7 = a5L1 - 100;
                        na5b = n7;
                        aa5b = a7;
                        ma5b = 1;
                    }
                    else if (900 <= a5L1 && a5L1 < 1050)
                    {
                        n7 = 2; a7 = a5L1 - 100;
                        na5b = n7;
                        aa5b = a7;
                        ma5b = 1;
                    }
                    else if (750 <= a5L1 && a5L1 < 900)
                    {
                        n7 = 2; a7 = a5L1 - 100;
                        na5b = n7;
                        aa5b = a7;
                        ma5b = 1;
                    }
                    else if (600 <= a5L1 && a5L1 < 750)
                    {
                        n7 = 2; a7 = a5L1 - 100;
                        na5b = n7;
                        aa5b = a7;
                        ma5b = 1;
                    }
                    else if (450 <= a5L1 && a5L1 < 600)
                    {
                        n7 = 2; a7 = a5L1 - 100;
                        na5b = n7;
                        aa5b = a7;
                        ma5b = 1;
                    }
                    else if (400 <= a5L1 && a5L1 < 450)
                    {
                        n7 = 2; a7 = a5L1 - n7 * 200;
                        na5b = n7;
                        aa5b = a7;
                        ma5b = 1;
                    }
                    else if (350 <= a5L1 && a5L1 < 400)
                    {
                        n7 = 2; a7 = a5L1 - 350;
                        na5b = n7;
                        aa5b = a7;
                        ma5b = 2;
                    }
                    else if (300 <= a5L1 && a5L1 < 350)
                    {
                        n7 = 2; a7 = a5L1 - 300;
                        na5b = n7;
                        aa5b = a7;
                        ma5b = 1;
                    }

                    else if (250 <= a5L1 && a5L1 < 300)
                    {
                        n7 = 2; a7 = a6L1 - 250;
                        na5b = n7;
                        aa5b = a7;
                        ma5b = 1;
                    }
                    else if (200 <= a5L1 && a5L1 < 250)
                    {
                        n7 = 2; a7 = a5L1 - 200;
                        na5b = n7;
                        aa5b = a7;
                        ma5b = 1;
                    }
                    else if (150 <= a5L1 && a5L1 < 200)
                    {
                        n7 = 2; a7 = a5L1 - 150;
                        na5b = n7;
                        aa5b = a7;
                        ma5b = 1;
                    }
                    else if (100 <= a5L1 && a5L1 < 150)
                    {
                        n7 = 2; a7 = a5L1 - 100;
                        na5b = n7;
                        aa5b = a7;
                        ma5b = 1;
                    }
                    #endregion
                    #region 宽度方向
                    nBb = (int)(PMCK / 300);
                    aBb = PMCK - nBb * 300;
                    mBb = 1;
                    n5B1 = (int)(PMCK / 1200);
                    a5B1 = PMCK - n5B1 * 1200;

                    if (1050 <= a5B1 && a5B1 < 1200)
                    {
                        n7 = n5B1 + 1; a7 = a5B1 - 1050;
                        na5B1 = n6; aa5B1 = a6; ma5B1 = 3;

                    }
                    else if (900 <= a5B1 && a5B1 < 1050)
                    {
                        n7 = n5B1 + 1; a7 = a5B1 - 900;
                        na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                    }
                    else if (750 <= a5B1 && a5B1 < 900)
                    {
                        n7 = n5B1 + 1; a7 = a5B1 - 750;
                        na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                    }
                    else if (600 <= a5B1 && a5B1 < 750)
                    {
                        n7 = n5B1 + 1; a7 = a5B1 - 600;
                        na5B1 = n7; aa5B1 = a7; ma5B1 = 2;

                    }
                    else if (450 <= a5B1 && a5B1 < 600)
                    {
                        n7 = n5B1 + 1; a7 = a5B1 - 450;
                        na5B1 = n7; aa5B1 = a6; ma5B1 = 2;

                    }
                    else if (a5B1 < 450)
                    {
                        na5B1 = n5B1; aa5B1 = a5B1; ma5B1 = 1;

                    }
                    #endregion
                    #region  计算过程

                    N3 = nL15L1 * nBb + na5b * na5B1; M3 = mL15L1 * mBb + ma5B1 * ma5b; A3 = aBb * PMCC + aa5b * (PMCC - aBb);
                    fm.C1 = N3;
                    fm.C2 = M3;
                    fm.C3 = A3;
                    #endregion
                #region 竖横排列 宽度方向
                 MBCCC = 1200;
                 n5B1 = (int)(PMCC / MBCCC);
                 a5B1 = PMCC - n5B1 * MBCCC;
                 nB15B1 = n5B1; aB15B1 = a5B1; mB15B1 = 1;
                 if (400 <= a5B1 && a5B1 < 450)
                 {
                     n7 = 2; a7 = a5B1 - n7 * 200;
                     na5b = n7; aa5b = a7; ma5b = 1;
                 }

                 else if (350 <= a5B1 && a5B1 < 400)
                 {
                     n7 = 2; a7 = a5B1 - 350;
                     na5b = n7; aa5b = a7; ma5b = 2;
                 }
                 else if (300 <= a5B1 && a5B1 < 350)
                 {
                     n7= 2; a7 = a5B1 - 300;
                     na5b = n7; aa5b = a7; ma5b = 1;
                 }

                 else if (250 <= a5B1 && a5B1 < 300)
                 {
                     n7 = 2; a7 = a5B1 - 250;
                     na5b = n7; aa5b = a7; ma5b = 1;
                 }

                 else if (200 <= a5B1 && a5B1 < 250)
                 {
                     n7 = 2; a7 = a5B1 - 200;
                     na5b = n7; aa5b = a7; ma5b = 1;
                 }

                 else if (150 <= a5B1 && a5B1 < 200)
                 {
                     n7 = 2; a7 = a5B1 - 150;
                     na5b = n7; aa5b = a7; ma5b = 1;
                 }

                 else if (100 <= a5B1 && a5B1 < 150)
                 {
                     n7 = 2; a7= a5B1 - 100;
                     na5b = n7; aa5b = a7; ma5b = 1;
                 }
                #endregion
                #region 长度方向
                 nLb = (int)(PMCK / 300);
                 aLb = PMCK - nLb * 300;
                 mLb = 1;
                 n5L1 = (int)(PMCK / 1200);
                 a5L1 = PMCK - n5L1 * 1200;
                 if (1050 <= a5L1 && a5L1 < 1200)
                 {
                     n7 = n5L1 + 1; a7 = a5L1 - 1050;
                     na5L1 = n7; aa5L1 = a7; ma5L1 = 3;
                 }
                 else if (900 <= a5L1 && a5L1 < 1050)
                 {
                     n7 = n5L1 + 1; a7 = a5L1 - 900;
                     na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                 }
                 else if (750 <= a5L1 && a5L1 < 900)
                 {
                     n7 = n5L1 + 1; a7 = a5L1 - 750;
                     na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                 }
                 else if (600 <= a5L1 && a5L1 < 750)
                 {
                     n7 = n5L1 + 1; a7 = a5L1 - 600;
                     na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                 }
                 else if (450 <= a5L1 && a5L1 < 600)
                 {
                     n7 = n5L1 + 1; a7 = a5L1 - 450;
                     na5L1 = n7; aa5L1 = a7; ma5L1 = 2;
                 }
                 else if (a5L1 < 450)
                 {
                     na5L1 = n5L1; aa5L1 = a5L1; ma5L1 = 1;
                 }
                #endregion
                #region 计算过
                 N4 = nB15B1 * nLb + na5b * na5L1;
                 M4 = mB15B1 * mLb + ma5L1 * ma5b;
                 A4 = aa5b * PMCC + aLb * (PMCK - aB15B1);
                 fm.D1 = N4;
                 fm.D2 = M4;
                 fm.D3 = A4;
                #endregion
                fm.PailieMode = 3;
                }
                fm.IsOneOrTwo =1;
                fm.ShowDialog();
             }
            #endregion

        }

        private void Frmpeiban_Load(object sender, EventArgs e)
        {
            checkBoxX3.Enabled = false; checkBoxX4.Enabled = false; checkBoxX5.Enabled = false; checkBoxX6.Enabled = false;
            checkBoxX7.Enabled = false; checkBoxX8.Enabled = false; checkBoxX9.Enabled = false; checkBoxX10.Enabled = false;
            checkBoxX11.Enabled = false; labelX6.Enabled = false; comboBoxEx1.Enabled = false; labelX7.Enabled = false; comboBoxEx2.Enabled = false;
            labelX8.Enabled = false; comboBoxEx3.Enabled = false; labelX9.Enabled = false; comboBoxEx4.Enabled = false;
            labelX10.Enabled = false; comboBoxEx5.Enabled = false; labelX11.Enabled = false; comboBoxEx6.Enabled = false;
            labelX13.Enabled = false; comboBoxEx8.Enabled = false; labelX12.Enabled = false; comboBoxEx7.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                checkBoxX3.Enabled = true; checkBoxX4.Enabled = true; checkBoxX5.Enabled = true; checkBoxX6.Enabled = true;
                checkBoxX7.Enabled = true; checkBoxX8.Enabled =true; checkBoxX9.Enabled = true; checkBoxX10.Enabled = true;
                checkBoxX11.Enabled = true; labelX6.Enabled = true; comboBoxEx1.Enabled = true; labelX7.Enabled = true; comboBoxEx2.Enabled = true;
                labelX8.Enabled = true; comboBoxEx3.Enabled = true; labelX9.Enabled = true; comboBoxEx4.Enabled = true;
                labelX10.Enabled = true; comboBoxEx5.Enabled = true; labelX11.Enabled = true; comboBoxEx6.Enabled = true;
                labelX13.Enabled = true; comboBoxEx8.Enabled = true; labelX12.Enabled = true; comboBoxEx7.Enabled = true;

            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked==true)
            {
                checkBoxX3.Enabled = false; checkBoxX4.Enabled = false; checkBoxX5.Enabled = false; checkBoxX6.Enabled = false;
                checkBoxX7.Enabled = false; checkBoxX8.Enabled = false; checkBoxX9.Enabled = false; checkBoxX10.Enabled = false;
                checkBoxX11.Enabled = false; labelX6.Enabled = false; comboBoxEx1.Enabled = false; labelX7.Enabled = false; comboBoxEx2.Enabled = false;
                labelX8.Enabled = false; comboBoxEx3.Enabled = false; labelX9.Enabled = false; comboBoxEx4.Enabled = false;
                labelX10.Enabled = false; comboBoxEx5.Enabled = false; labelX11.Enabled = false; comboBoxEx6.Enabled = false;
                labelX13.Enabled = false; comboBoxEx8.Enabled = false; labelX12.Enabled = false; comboBoxEx7.Enabled = false;
            }
        }

       
    }
}