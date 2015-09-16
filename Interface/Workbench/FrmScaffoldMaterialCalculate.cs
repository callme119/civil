using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Framework.Interface.Workbench
{
    public partial class FrmScaffoldMaterialCalculate : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data);
        public CreateModuleHandle CreateModuleIntance;
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private object @class;
        private System.Collections.ArrayList templateList;

        public FrmScaffoldMaterialCalculate(Framework.Entity.Chapter chapter, object type)
        {
            InitializeComponent();
            @class = type;
            templateList = contentService.GetContentTemplateByTitle(chapter.Title);
            //CbxType.SelectedIndex = 0;
            CbxScaffoldType.SelectedIndex = 0;
            Cb_MaterialJDCSZ.SelectedIndex = 0;
            //Cbx_Item3JDCSZ.SelectedIndex = 0;
        }

        private void CbxScaffoldType_SelectedIndexChanged(object sender, EventArgs e)//选择脚手架类型后显示的窗体
        {
            if (CbxScaffoldType.SelectedIndex == 0 | CbxScaffoldType.SelectedIndex == 1)
            {
                YLtabItem1.Visible = true;
                YLtabItem2.Visible = false;
                YLtabItem3.Visible = false;
                YLtabItem4.Visible = false;
                Cb_MaterialWCDHGJJ.SelectedIndex = 0;
                if (CbxScaffoldType.SelectedIndex == 0)
                {
                    YLtabItem1.Text = "双排脚手架用料计算";
                }
                else
                    YLtabItem1.Text = "单排脚手架用料计算";
            }
            else if (CbxScaffoldType.SelectedIndex == 2)
            {
                YLtabItem1.Visible = false;
                YLtabItem2.Visible = true;
                YLtabItem3.Visible = false;
                YLtabItem4.Visible = false;
                Tb_Item2BS.Text = System.Convert.ToString(System.Convert.ToInt32((DbInput_Item2GD.Value / DbInput_Item2BJ.Value) + 1));//计算脚手架搭设步数
                Cbx_Item2ZJ.SelectedIndex = 3;
                Cbx_Item2HJ.SelectedIndex = 3;
                Cbx_Item2LGG.SelectedIndex = Cbx_Item2WXG.SelectedIndex = Cbx_Item2SPX.SelectedIndex = Cbx_Item2LDX.SelectedIndex = Cbx_Item2LGD.SelectedIndex = Cbx_Item2JHG.SelectedIndex = 0;
            }
            else if (CbxScaffoldType.SelectedIndex == 3)
            {
                YLtabItem1.Visible = false;
                YLtabItem2.Visible = false;
                YLtabItem3.Visible = true;
                YLtabItem4.Visible = false;
            }
            else if (CbxScaffoldType.SelectedIndex == 4)
            {
                YLtabItem1.Visible = false;
                YLtabItem2.Visible = false;
                YLtabItem3.Visible = false;
                YLtabItem4.Visible = true;
            }
        }

        private void Cb_MaterialJDCSZ_SelectedIndexChanged(object sender, EventArgs e)//YLtabItem1“剪刀撑设置”，决定“剪刀撑间隔立杆纵距数”的显隐性
        {
            if (Cb_MaterialJDCSZ.SelectedIndex == 1)
            {
                Lb_MaterialJDCJGLGZJ.Enabled = true;
                IntInput_MaterialJDCJGLGZJ.Enabled = true;
            }
            else 
            {
                Lb_MaterialJDCJGLGZJ.Enabled = false ;
                IntInput_MaterialJDCJGLGZJ.Enabled = false ;
            }
        }

        private void Cb_MaterialWCDHGJJ_SelectedIndexChanged_1(object sender, EventArgs e)//YLtabItem1外侧大横杆间距
        {
            switch (Cb_MaterialWCDHGJJ.SelectedIndex)
            {
                case 0: Tb_MaterialWCDHGQZ.Text = Convert.ToString(1); break;
                case 1: Tb_MaterialWCDHGQZ.Text = Convert.ToString(2); break;
            }
        }

        private void DbInput_Item2GD_ValueChanged(object sender, EventArgs e)
        {
            Tb_Item2BS.Text = System.Convert.ToString(System.Convert.ToInt32((DbInput_Item2GD.Value / DbInput_Item2BJ.Value) + 1));//计算脚手架搭设步数
        }

        private void DbInput_Item2BJ_ValueChanged(object sender, EventArgs e)
        {
            Tb_Item2BS.Text = System.Convert.ToString(System.Convert.ToInt32((DbInput_Item2GD.Value / DbInput_Item2BJ.Value) + 1));//计算脚手架搭设步数
        }

        private void Cbx_Item3JDCSZ_SelectedIndexChanged(object sender, EventArgs e)//YLtabItem3“剪刀撑设置”，决定“剪刀撑间隔门架跨度数”的显隐性
        {
            if (Cbx_Item3JDCSZ.SelectedIndex == 1)
            {
                Lb_Item3_ZDCJGMJKDS.Enabled = true;
                IntInput_Item3JDCJGMJKDS.Enabled = true;
            }
            else
            {
                Lb_Item3_ZDCJGMJKDS.Enabled = false;
                IntInput_Item3JDCJGMJKDS.Enabled = false;
            }
        }

        private void TB_Item4ZZBZZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断按键是不是要输入的类型。
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;

            //小数点的处理。
            if ((int)e.KeyChar == 46)                           //小数点
            {
                if (TB_Item4ZZBZZ.Text.Length <= 0)
                    e.Handled = true;   //小数点不能在第一位
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(TB_Item4ZZBZZ.Text, out oldf);
                    b2 = float.TryParse(TB_Item4ZZBZZ.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }

        private void Btn_YLSubmit_Click(object sender, EventArgs e)
        {
            Framework.Entity.Template item = new Framework.Entity.Template();
            string itemtext = "";
            object[] obj = new object[] { };
            #region 单双排脚手架用料计算
            if (CbxScaffoldType.SelectedIndex == 0 | CbxScaffoldType.SelectedIndex == 1)
            {
                #region 单双排脚手架用料计算涉及的参数定义
                double Ly1_1, Ly1_2, Ly1_3, Ly1_4, Ly1_5, Ly1_6, Ly1_7, Ly1_9, Ly1_10, Ly1_11, Ly1_12;
                double LySum1 = 0, LySum2 = 0, LySum3 = 0, LySum4 = 0, LySum5 = 0, LySum6 = 0, LySum7 = 0, LySum8 = 0, LySum9 = 0;
                string Ly1_8;
                Ly1_1 = DbInput_MaterialDSGD.Value; //脚手架搭设高度
                Ly1_2 = DbInput_MaterialDSCD.Value;  //脚手架搭设长度
                Ly1_3 = DbInput_MaterialLGZJ.Value; //立杆纵距la
                Ly1_4 = DbInput_MaterialLGHJ.Value; //立杆横距lb
                Ly1_5 = DbInput_MaterialBJ.Value; //步距h
                Ly1_6 = DbInput_MaterialLQJL.Value; //脚手架内排的离墙距离
                Ly1_7 = System.Convert.ToInt16(Tb_MaterialWCDHGQZ.Text); //外侧大横杆间距取值
                Ly1_8 = Cb_MaterialJDCSZ.Text; //剪刀撑设置
                Ly1_9 = System.Convert.ToDouble(IntInput_MaterialJDCKYBJ.Value); //剪刀撑跨越步距数
                Ly1_10 = System.Convert.ToDouble(IntInput_MaterialJDCKYLGZJ.Value); //剪刀撑跨越立杆纵距数
                Ly1_11 = System.Convert.ToDouble(IntInput_MaterialJDCJGLGZJ.Value); //剪刀撑间隔立杆纵距数
                Ly1_12 = DBIput_MaterialCLYLXS.Value; //材料用量系数
                #endregion
                if (CbxScaffoldType.SelectedIndex == 0) //选择双排脚手架用料计算
                {
                    itemtext = "双排脚手架用料计算";
                    #region // 双排脚手架用料计算过程：
                    LySum1 = Ly1_12 * Ly1_2 / Ly1_3 * 2 * Ly1_1;//不同于单排脚手架
                    LySum2 = Ly1_12 * Ly1_1 / Ly1_5 * 2 * Ly1_7 * Ly1_2;//不同于单排脚手架
                    LySum3 = Ly1_12 * Ly1_1 / Ly1_5 * Ly1_2 / Ly1_3 * (Ly1_4 + Ly1_6);
                    LySum4 = Ly1_12 * (Math.Pow((Ly1_10 * Ly1_10 + Ly1_9 * Ly1_9), 0.5) + 1) * Ly1_1 / Ly1_9 * Ly1_2 / Ly1_10;
                    LySum5 = Ly1_12 * (Ly1_1 / Ly1_5 * Ly1_2 / Ly1_3 * 2 + LySum2 / Ly1_3);//不同于单排脚手架
                    LySum6 = Ly1_12 * Ly1_1 / Ly1_9 * Ly1_2 / Ly1_10 * 14;
                    LySum7 = Ly1_12 * (LySum1 + LySum2) / 5;
                    LySum8 = LySum1 + LySum2 + LySum3 + LySum4;
                    LySum9 = LySum8 * 3.97 / 1000;
                    #endregion
                }
                else if (CbxScaffoldType.SelectedIndex == 1) //选择单排脚手架用料计算
                {
                    itemtext = "单排脚手架用料计算";
                    #region // 单排脚手架用料计算过程：
                    LySum1 = Ly1_12 * Ly1_2 / Ly1_3 * Ly1_1;//不同于双排脚手架
                    LySum2 = Ly1_12 * Ly1_1 / Ly1_5 * Ly1_7 * Ly1_2;//不同于双排脚手架
                    LySum3 = Ly1_12 * Ly1_1 / Ly1_5 * Ly1_2 / Ly1_3 * (Ly1_4 + Ly1_6);
                    LySum4 = Ly1_12 * (Math.Pow((Ly1_10 * Ly1_10 + Ly1_9 * Ly1_9), 0.5) + 1) * Ly1_1 / Ly1_9 * Ly1_2 / Ly1_10;
                    LySum5 = Ly1_12 * (Ly1_1 / Ly1_5 * Ly1_2 / Ly1_3 + LySum2 / Ly1_3);//不同于双排脚手架
                    LySum6 = Ly1_12 * Ly1_1 / Ly1_9 * Ly1_2 / Ly1_10 * 14;
                    LySum7 = Ly1_12 * (LySum1 + LySum2) / 5;
                    LySum8 = LySum1 + LySum2 + LySum3 + LySum4;
                    LySum9 = LySum8 * 3.97 / 1000;
                    #endregion
                }
                LySum1 = Math.Round(LySum1, 0);
                LySum2 = Math.Round(LySum2, 0);
                LySum3 = Math.Round(LySum3, 0);
                LySum4 = Math.Round(LySum4, 0);
                LySum5 = Math.Round(LySum5, 0);
                LySum6 = Math.Round(LySum6, 0);
                LySum7 = Math.Round(LySum7, 0);
                LySum8 = Math.Round(LySum8, 0);
                LySum9 = Math.Round(LySum9, 0);
                obj = new object[] { Ly1_1 , Ly1_2 , Ly1_3 , Ly1_4 , Ly1_5 , Ly1_6 , Ly1_7 , Ly1_8 , IntInput_MaterialJDCKYBJ.Value , IntInput_MaterialJDCKYLGZJ.Value ,IntInput_MaterialJDCJGLGZJ.Value, Ly1_12 ,
                                                        LySum1 , LySum2 ,  LySum3 ,  LySum4 ,  LySum5 ,  LySum6 ,  LySum7 ,  LySum8 ,  LySum9};
            }
            #endregion
            else if (CbxScaffoldType.SelectedIndex == 2) //选择碗扣式脚手架用料计算
            {
                itemtext = "碗扣式脚手架用料计算";
                #region 碗扣式脚手架用料计算设计的参数定义
                double Ly2_1, Ly2_2, Ly2_3, Ly2_4, Ly2_5, Ly2_6;
                string Ly2_7, Ly2_8, Ly2_9, Ly2_10, Ly2_11;
                double Ly2Sum1 = 0, Ly2Sum2 = 0, Ly2Sum3 = 0, Ly2Sum4 = 0, Ly2Sum5 = 0, Ly2Sum6 = 0, Ly2Sum7 = 0, Ly2Sum8 = 0, Ly2Sum9 = 0, Ly2Sum10 = 0, Ly2Sum11 = 0, Ly2Sum12 = 0;
                Ly2_1 = DbInput_Item2GD.Value;//脚手架搭设高度
                Ly2_2 = DbInput_Item2CD.Value;//脚手架搭设长度
                Ly2_3 = DbInput_Item2BJ.Value;//步距
                Ly2_4 = System.Convert.ToDouble(Tb_Item2BS.Text);//脚手架搭设步数
                Ly2_5 = System.Convert.ToDouble(Cbx_Item2ZJ.Text);//立杆纵距
                double[] Gkzg1 = new double[] { 0.0132, 0.0247, 0.0363, 0.0478, 0.0593, 0.0708 };
                double Gkzg = Gkzg1[Cbx_Item2ZJ.SelectedIndex];
                Ly2_6 = System.Convert.ToDouble(Cbx_Item2HJ.Text);//立杆横距
                double[] Gkhg1 = new double[] { 0.0132, 0.0247, 0.0363, 0.0478, 0.0593, 0.0708 };//立杆横距
                double Gkhg = Gkhg1[Cbx_Item2HJ.SelectedIndex];

                double[] Gkjhg1 = new double[] { 0.0437, 0.0552, 0.0685, 0.0816 };//间横杆钢管类型
                double Gkjhg = Gkjhg1[Cbx_Item2JHG.SelectedIndex];

                Ly2_7 = Cbx_Item2LGG.Text;//立杆钢管类型
                double[] Gkl1 = new double[] { 0.0705, 0.1019, 0.1334, 0.1648 };
                double Gkl = Gkl1[Cbx_Item2LGG.SelectedIndex ];
                double[] Gkl2 = new double[] { 1.2, 1.8, 2.4, 3.0 };
                double Gkl3 = Gkl1[Cbx_Item2LGG.SelectedIndex];
                Ly2_8 = Cbx_Item2WXG.Text;//外斜杆钢管类型
                double[] Gkwg1 = new double[] {0.0633, 0.0703, 0.0866, 0.0930, 0.1004};
                double Gkwg = Gkwg1[Cbx_Item2WXG.SelectedIndex];
                Ly2_9 = Cbx_Item2SPX.Text;//水平斜杆钢管类型
                double[] Gksg1 = new double[] {0.0589, 0.0676, 0.0873};
                double Gksg = Gksg1[Cbx_Item2SPX.SelectedIndex];
                Ly2_10 = Cbx_Item2LDX.Text;//廊道斜杆钢管类型
                double[] Gklg1 = new double[] {0.0633, 0.0703, 0.0866, 0.0930, 0.1004};
                double Gklg = Gklg1[Cbx_Item2LDX.SelectedIndex];
                Ly2_11 = Cbx_Item2LGD.Text;//立杆底座类型
                double[] Gkdz1 = new double[] { 0.0582, 0.0712, 0.085};
                double Gkdz = Gkdz1[Cbx_Item2LDX.SelectedIndex];
                double Ly2_12, Ly2_13, Ly2_14, Ly2_15, Ly2_16, Ly2_17, Ly2_18, Ly2_19, Ly2_20;
                Ly2_12 = System.Convert.ToDouble(Cbx_Item2DKJ.Text);
                Ly2_13 = System.Convert.ToDouble(Cbx_Item2WXGBZ.Text);
                Ly2_14 = IntInput_Item2SPX.Value;
                Ly2_15 = IntInput_Item2LDX.Value;
                Ly2_16 = DbInput_Item2H1.Value;
                Ly2_17 = DbInput_Item2L1.Value;
                Ly2_18 = DbInput_Item2L0.Value;
                Ly2_19 = IntInput_Item2CS.Value;
                Ly2_20 = DbInput_Item2XS.Value;
                #endregion
                Ly2Sum1 = Ly2_20 * (Ly2_2 / Ly2_5 + 1) * 2 * Ly2_1 / Gkl3 * Gkl / 10;
                Ly2Sum2 = Ly2_20 * 2 * (Ly2_4 + Ly2_20) * Ly2_2 / Ly2_5 * Gkzg / 10;
                Ly2Sum3 = Ly2_20 * (Ly2_2 / Ly2_5 + 1) * Ly2_4 * Gkhg / 10;
                Ly2Sum4 = Ly2_20 * Ly2_2 / Ly2_5 * Ly2_12 * Ly2_4 * Gkjhg / 10;
                Ly2Sum5 = Ly2_20 * Ly2_2 / Ly2_5 / Ly2_13 * Ly2_4 * Gkwg / 10;
                Ly2Sum6 = Ly2_20 * Ly2_2 / Ly2_5 / Ly2_14 * Ly2_4 * Gksg / 10;
                Ly2Sum7 = Ly2_20 * Ly2_2 / Ly2_5 / Ly2_15 * Ly2_4 * Gklg / 10;
                Ly2Sum8 = Ly2_20 * (Ly2_2 / Ly2_5 + 1) * 2 * Gkdz / 10;
                Ly2Sum9 = Ly2_20 * Ly2_2 * Ly2_1 / Ly2_16 / Ly2_17 * Ly2_18 * 3.97 / 1000;
                Ly2Sum10 = Ly2_20 * Ly2_2 * Ly2_5 * Ly2_19;
                Ly2Sum11 = Ly2_20 * 2 * 0.18 * Ly2_2 * Ly2_19;
                Ly2Sum12 = Ly2_20 * Ly2_2 * Ly2_1;
      
                obj = new object[] { Ly2_1, Ly2_2, Ly2_3, Ly2_4, Ly2_5, Gkzg, Ly2_6, Gkhg, Gkjhg, Ly2_7, Gkl, Gkl3, Ly2_8, Gkwg, Ly2_9, Gksg, Ly2_10, Gklg, Ly2_11, Gkdz ,
                                                Ly2_12, Ly2_13, Ly2_14, Ly2_15, Ly2_16, Ly2_17, Ly2_18, Ly2_19, Ly2_20,
                                                 Ly2Sum1, Ly2Sum2, Ly2Sum3,Ly2Sum4, Ly2Sum5, Ly2Sum6, Ly2Sum7, Ly2Sum8, Ly2Sum9, Ly2Sum10, Ly2Sum11, Ly2Sum12, Cbx_Item2JHG.Text };
            }
            /*
             * 功能：门式脚手架用量计算
             * 作者：林凯
             * 日期：2013-9-16
             */
            else if (CbxScaffoldType.SelectedIndex == 3)//选择门式脚手架用量计算
            {
                itemtext = "门式脚手架用料计算";
                #region 门式脚手架用量计算涉及的参数定义
                double Ly3_1, Ly3_2, Ly3_3, Ly3_4, Ly3_5, Ly3_7, Ly3_8, Ly3_9, Ly3_10;
                string Ly3_6;
                double Ly3Sum1 = 0, Ly3Sum2 = 0, Ly3Sum3 = 0, Ly3Sum4 = 0, Ly3Sum5 = 0, Ly3Sum6 = 0, Ly3Sum7 = 0;
                Ly3_1 = DbInput_Item3GD.Value;//脚手架搭设高度               
                Ly3_2 = DbInput_Item3CD.Value;//脚手架搭设长度
                Ly3_3 = DbInput_Item3MJBJ.Value;//门架步距
                Ly3_4 = DbInput_Item3MJKD.Value;//门架跨度
                Ly3_5 = System.Convert.ToDouble(DbInput_Item3CS.Value);//脚手板搭设层数
                Ly3_6 = Cbx_Item3JDCSZ.Text;//剪刀撑设置
                Ly3_7 = System.Convert.ToDouble(IntInput_Item3JDCKMJBJ.Value);//剪刀撑跨门架步距
                Ly3_8 = System.Convert.ToDouble(IntInput_Item3JDCKYMJKDS.Value);//剪刀撑跨越立杆纵距数
                Ly3_9 = System.Convert.ToDouble(IntInput_Item3JDCJGMJKDS.Value);//剪刀撑间隔立杆纵距数
                Ly3_10 = DbInput_Item3XS.Value;//材料用量系数
                #endregion
                #region 门式脚手架用量计算过程
                Ly3Sum1 = Ly3_10 * (Ly3_2 / Ly3_4 + 1) * Ly3_1 / Ly3_3;
                Ly3Sum2 = Ly3_10 * Ly3_2 / Ly3_4 * Ly3_1 / Ly3_3 * 2;
                Ly3Sum3 = Ly3_10 * Ly3_2 / Ly3_4 * Ly3_5;
                Ly3Sum4 = Ly3_10 * (Ly3_2 / Ly3_4 + 1) * Ly3_1 / Ly3_3 * 2;
                Ly3Sum5 = Ly3_10 * (Math.Pow((Ly3_8 * Ly3_8 + Ly3_7 * Ly3_7), 0.5) + 1) * Ly3_1 / Ly3_7 * Ly3_2 / Ly3_8;
                Ly3Sum6 = Ly3Sum5 * 3.97 / 1000;
                Ly3Sum7 = Ly3_10 * Ly3_1 / Ly3_7 * Ly3_2 / Ly3_8 * 14;
                #endregion
                Ly3Sum1 = Math.Round(Ly3Sum1, 0);
                Ly3Sum2 = Math.Round(Ly3Sum2, 0);
                Ly3Sum3 = Math.Round(Ly3Sum3, 0);
                Ly3Sum4 = Math.Round(Ly3Sum4, 0);
                Ly3Sum5 = Math.Round(Ly3Sum5, 0);
                Ly3Sum6 = Math.Round(Ly3Sum6, 0);
                Ly3Sum7 = Math.Round(Ly3Sum7, 0);
                obj = new object[] {Ly3_1, Ly3_2, Ly3_3, Ly3_4, Ly3_5, Ly3_7, Ly3_8, Ly3_9, Ly3_10,Ly3_6, Ly3Sum1, Ly3Sum2, Ly3Sum3, Ly3Sum4, Ly3Sum5, Ly3Sum6, Ly3Sum7,
                                            DbInput_Item3CS.Value,IntInput_MaterialJDCKYBJ.Value,IntInput_Item3JDCKYMJKDS.Value,IntInput_Item3JDCJGMJKDS.Value};

            }
            else if (CbxScaffoldType.SelectedIndex == 4)//选择吊篮脚手架用量计算
            {
                itemtext = "吊篮脚手架用料计算";
                #region 吊篮脚手架用量计算涉及的参数定义
                double Ly4_1, Ly4_2, Ly4_3=1, Ly4_4, Ly4_5, Ly4_6, Ly4_7, Ly4_8, Ly4_9, Ly4_10, Ly4_11, Ly4_12, Ly4_13, Ly4_14, Ly4_15,
                    Ly4_16, Ly4_17, Ly4_18, Ly4_19, Ly4_20, Ly4_21, Ly4_22, Ly4_23, Ly4_24, Ly4_25;
                double Ly4Sum1 = 0, Ly4Sum2 = 0, Ly4Sum3 = 0, Ly4Sum4 = 0, Ly4Sum5 = 0, Ly4Sum6 = 0, Ly4Sum7 = 0, Ly4Sum8 = 0, Ly4Sum9 = 0, Ly4Sum10 = 0, Ly4Sum11 = 0, Ly4Sum12 = 0, Ly4Sum13 = 0, Ly4Sum14 = 0, Ly4Sum15 = 0, Ly4Sum16 = 0;
                string compare1 = "", compare2 = "", compare3 = "", compare4 = "", compare5 = "";
                Ly4_1 = Db_Item4CD.Value;//吊篮长度
                Ly4_2 = Db_Item4KD.Value;//吊篮宽度
                Ly4_3 = Db_Item4GD.Value;//吊篮高度
                Ly4_4 = Db_Item4PZZL.Value;//配重质量
                Ly4_5 = Db_Item4XTLFBHD.Value;//悬挑梁腹板厚度
                Ly4_6 = Db_Item4XTLMJJ.Value;//悬挑梁面积矩
                Ly4_7 = Db_Item4JMGXJ.Value;//悬挑梁截面惯性矩
                Ly4_8 = Db_Item4JMDKJ.Value;//悬挑梁截面抵抗矩
                Ly4_9 = Db_Item4DLDDJL.Value;//悬挑梁前部支点至吊篮吊点距离
                Ly4_10 = Db_Item4HBZDJL.Value;// 悬挑梁前部支点至后部支点距离
                Ly4_11 = Db_Item4WDXS.Value;//悬挑梁整体稳定系数
                Ly4_12 = Db_Item4KWQD.Value;//悬挑梁抗弯强度设计值
                Ly4_13 = Db_Item4KJQD.Value;//悬挑梁抗剪强度设计值
                Ly4_14 = Db_Item4GSSZJ.Value;//钢丝绳直径
                Ly4_15 = Db_Item4LJZH.Value;//钢丝破断拉力总和
                Ly4_16 = Db_Item4SLGSSS.Value;//每榀架体受力钢丝绳数
                Ly4_17 = Db_Item4AQXS.Value;//安全系数
                Ly4_18 = Db_Item4BJYXS.Value;//不均匀系数
                Ly4_19 = Db_Item4GSSDLZZ.Value;// 钢丝绳及吊篮自重标准值
                Ly4_20 = System.Convert.ToDouble(TB_Item4ZZBZZ.Text);//悬挑梁自重标准值
                Ly4_21 = Db_Item4HZBZZ.Value;//施工活荷载标准值
                Ly4_22 = Db_Item4JBFY.Value;//基本风压
                Ly4_23 = Db_Item4FHZTXXS.Value;//风荷载体型系数
                Ly4_24 = Db_Item4FYGDBHXS.Value;//风压高度变化系数
                Ly4_25 = Db_Item4FZXS.Value;//风振系数
                #endregion
                #region 吊篮脚手架用量计算过程
                Ly4Sum1 = Ly4_1 * Ly4_3;//吊篮受风面积F
                Ly4Sum2 = Ly4_22 * Ly4_23 * Ly4_24 * Ly4_25 * Ly4Sum1;//吊篮的风荷载标准值Qwk
                Ly4Sum3 = Ly4_1 * Ly4_2;//吊篮底部最大面积A
                Ly4Sum4 = Ly4_21 * Ly4Sum3;//施工活荷载标准值Qk
                Ly4Sum5 = (Ly4_19 + Ly4Sum4) / 2;//吊篮动力钢丝绳竖向荷载标准值Q1
                Ly4Sum6 = Ly4Sum2 / 2;//吊篮动力钢丝绳水平荷载标准值Q2
                Ly4Sum7 = Ly4_17 * (Math.Pow((Ly4Sum5 * Ly4Sum5 + Ly4Sum6 * Ly4Sum6), 0.5));//动力钢丝绳所受拉力的施工核算值QD
                Ly4Sum8 = Ly4Sum7 * (1 + Ly4_9 / Ly4_10) + Ly4_20 * (Ly4_9 + Ly4_10);//支撑悬挂机构前支架的结构所承受的集中荷载ND
                Ly4Sum9 = Ly4_18 * Ly4_16 * Ly4_15 / Ly4_17;//钢丝绳计算[Fg]
                Ly4Sum10 = 2 * (Ly4Sum7 * Ly4_9 / Ly4_10);//支承悬挂机构后支架的结构所承受的集中荷载T
                Ly4Sum11 = Ly4Sum10 * 100;//允许最小配重重量m0
                Ly4Sum12 = Ly4Sum7 * Ly4_9;//悬挑梁抗弯强度验算Mmax
                Ly4Sum13 = Ly4Sum12 * 1000 / Ly4_8;//悬挑梁抗弯强度验算σ
                Ly4Sum14 = Ly4Sum7 + Ly4_20 * Ly4_9;//悬挑梁抗剪验算Vmax
                Ly4Sum15 = Ly4Sum14 * Ly4_6 / Ly4_5 / Ly4_7 * 10;//悬挑梁抗剪验算τmax
                Ly4Sum16 = Ly4Sum12 * 1000 / (Ly4_11 * Ly4_8);//悬挑梁整体稳定性验算σ

                Ly4Sum1 = Math.Round(Ly4Sum1, 0);
                Ly4Sum2 = Math.Round(Ly4Sum2, 0);
                Ly4Sum3 = Math.Round(Ly4Sum3, 0);
                Ly4Sum4 = Math.Round(Ly4Sum4, 0);
                Ly4Sum5 = Math.Round(Ly4Sum5, 0);
                Ly4Sum6 = Math.Round(Ly4Sum6, 0);
                Ly4Sum7 = Math.Round(Ly4Sum7, 0);
                Ly4Sum8 = Math.Round(Ly4Sum8, 0);
                Ly4Sum9 = Math.Round(Ly4Sum9, 0);
                Ly4Sum10 = Math.Round(Ly4Sum10, 0);
                Ly4Sum11 = Math.Round(Ly4Sum11, 0);
                Ly4Sum12 = Math.Round(Ly4Sum12, 0);
                Ly4Sum13 = Math.Round(Ly4Sum13, 0);
                Ly4Sum14 = Math.Round(Ly4Sum14, 0);
                Ly4Sum15 = Math.Round(Ly4Sum15, 0);
                Ly4Sum16 = Math.Round(Ly4Sum16, 0);

                if (Ly4Sum9 >= Ly4Sum7)
                {
                    compare1 = "[Fg]= " + Ly4Sum9 + " kN ≥QD= " + Ly4Sum7 + " kN，满足要求!";
                }
                else
                    compare1 = "[Fg]= " + Ly4Sum9 + " kN<QD= " + Ly4Sum7 + " kN，不满足要求!";
               
                if (Ly4_4 >= Ly4Sum11)
                {
                    compare2 = "实际配重：m=" + Ly4_4 + " kg≥m0= " + Ly4Sum11 + " kg，满足要求!";
                }
                else
                    compare2 = "实际配重：m=" + Ly4_4 + " kg<m0= " + Ly4Sum11 + " kg，不满足要求!";
               
                if (Ly4Sum13 <= Ly4_12)
                {
                    compare3 = "σ=" + Ly4Sum13 + "N/mm2≤f= "+Ly4_12+" N/mm2，满足要求!";
                }
                else
                    compare3 = "σ=" + Ly4Sum13 + "N/mm2>f= " + Ly4_12 + " N/mm2，不满足要求!";
               
                if (Ly4Sum15 <= Ly4_13)
                {
                    compare4 = "τmax=" + Ly4Sum15 + " N/mm2≤τ="+Ly4_13+" N/mm2，满足要求!";
                }
                else
                    compare4 = "τmax=" + Ly4Sum15 + " N/mm2>τ=" + Ly4_13 + " N/mm2，不满足要求!";
               
                if (Ly4Sum16 <= Ly4_12)
                {
                    compare5 = "σ=" + Ly4Sum16 + "N/mm2≤[f]= " + Ly4_12 + "N/mm2，满足要求!";
                }
                else
                    compare5 = "σ=" + Ly4Sum16 + "N/mm2>[f]= " + Ly4_12 + "N/mm2，不满足要求!";
                #endregion


                obj = new object[] {Ly4_1, Ly4_2, Ly4_3, Ly4_4, Ly4_5, Ly4_6, Ly4_7, Ly4_8, Ly4_9, Ly4_10, Ly4_11, Ly4_12, Ly4_13, Ly4_14, Ly4_15,
                    Ly4_16, Ly4_17, Ly4_18, Ly4_19, Ly4_20, Ly4_21, Ly4_22, Ly4_23, Ly4_24, Ly4_25, Ly4Sum1, Ly4Sum2, Ly4Sum3, Ly4Sum4, Ly4Sum5, 
                    Ly4Sum6, Ly4Sum7, Ly4Sum8, Ly4Sum9, Ly4Sum10, Ly4Sum11, Ly4Sum12, Ly4Sum13, Ly4Sum14, Ly4Sum15, Ly4Sum16,compare1,compare2,compare3,compare4,compare5};
            }

            foreach (Framework.Entity.Template template in templateList)
            {
                if (itemtext == template.Title)
                {
                    item = template;
                    break;
                }
            }
            CreateModuleIntance(item, null, @class, obj);
            this.Close();
        }


    }
}

